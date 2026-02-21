using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.bd_connect);

        public LoginForm()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tb_login.Text) || string.IsNullOrWhiteSpace(tb_password.Text))
                {
                    MessageBox.Show("Заполните все поля для входа", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string login = tb_login.Text.Trim();
                string password = tb_password.Text;

                string storedHash = GetPasswordHashFromDatabase(login);

                if (string.IsNullOrEmpty(storedHash))
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_password.Clear();
                    tb_password.Focus();
                    return;
                }

                bool isPasswordValid = PasswordHelper.VerifyPassword(password, storedHash);

                if (isPasswordValid)
                {

                    CurrentUser.GetUserInfo(login);
                    Form mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_password.Clear();
                    tb_password.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка базы данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        private string GetPasswordHashFromDatabase(string login)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT password FROM users WHERE login = @login", conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }





        private void VisiblePassword(object sender, EventArgs e)
        {
            if (tb_password.UseSystemPasswordChar)
            {
                tb_password.UseSystemPasswordChar = false;
                tb_password.PasswordChar = '\0';

            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
            }

            
            tb_password.Focus();
            tb_password.SelectionStart = tb_password.Text.Length;
        }
    }
}