using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;
using BillingSystem.Utils;
using Org.BouncyCastle.Tls;

namespace BillingSystem
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            // Step 1: Validate input fields
            string currentPassword = tbCurrentPassword.Text;
            string newPassword = tbNewPassword.Text;
            string retypePassword = tbRetypePassword.Text;

            // Step 2: Verify current password
            if (!VerifyCurrentPassword(currentPassword))
            {
                MessageBox.Show(
                    "The current password you entered is incorrect. Please try again.",
                    "Invalid Current Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tbCurrentPassword.Clear();
                tbCurrentPassword.Focus();
                return;
            }

            // Step 3: Check if new passwords match
            if (newPassword != retypePassword)
            {
                MessageBox.Show(
                    "The new password and retype password do not match. Please try again.",
                    "Password Mismatch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tbNewPassword.Clear();
                tbRetypePassword.Clear();
                tbNewPassword.Focus();
                return;
            }

            // Step 4: Validate password complexity
            string complexityError = ValidatePasswordComplexity(newPassword);
            if (!string.IsNullOrEmpty(complexityError))
            {
                MessageBox.Show(
                    complexityError,
                    "Weak Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tbNewPassword.Clear();
                tbRetypePassword.Clear();
                tbNewPassword.Focus();
                return;
            }

            // Step 5: All validations passed, update the database
            if (UpdatePasswordInDatabase(newPassword))
            {
                MessageBox.Show(
                    "Your password has been changed successfully.",
                    "Password Changed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "An error occurred while changing your password. Please try again later.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool VerifyCurrentPassword(string enteredPassword)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT Password
                           FROM Users 
                           WHERE UserID = @UserID;"; 

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", AppSession.CurrentUserID);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader.GetString("Password");
                                return storedPassword == enteredPassword;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verifying current password:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private string ValidatePasswordComplexity(string password)
        {
            List<string> unmetRequirements = new List<string>();

            // Check minimum length (at least 8 characters)
            if (password.Length < 8)
            {
                unmetRequirements.Add("• Must be at least 8 characters long");
            }

            // Check for at least one uppercase letter
            if (!password.Any(c => char.IsUpper(c)))
            {
                unmetRequirements.Add("• Must contain at least one uppercase letter (A-Z)");
            }

            // Check for at least one lowercase letter
            if (!password.Any(c => char.IsLower(c)))
            {
                unmetRequirements.Add("• Must contain at least one lowercase letter (a-z)");
            }

            // Check for at least one numeric digit
            if (!password.Any(c => char.IsDigit(c)))
            {
                unmetRequirements.Add("• Must contain at least one numeric digit (0-9)");
            }

            // Check for at least one special character
            string specialCharacters = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~";
            if (!password.Any(c => specialCharacters.Contains(c)))
            {
                unmetRequirements.Add("• Must contain at least one special character (e.g., !, @, #, $, etc.)");
            }

            if (unmetRequirements.Count > 0)
            {
                string message = "The new password does not meet the following requirements:\n\n" 
                     + string.Join("\n", unmetRequirements);
                return message;
            }

            return string.Empty; // All requirements met
        }

        private bool UpdatePasswordInDatabase(string newPassword)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Parameterized UPDATE query, never concatenate user input directly
                    string sql = @"UPDATE Users
                           SET    Password = @NewPassword 
                           WHERE  UserID = @UserID;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        cmd.Parameters.AddWithValue("@UserID", AppSession.CurrentUserID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Log the password change for audit trail
                            AuditLogger.Log("CHANGE_PASSWORD",
                                $"{AppSession.CurrentFullName} ({AppSession.CurrentRole}) changed their password.");
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

    }
}
