using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    public static class CurrentUser
    {
        public static string Login { get; set; }
        public static string RoleName { get; set; }
        public static int RoleId { get; set; }
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string email { get; set; }
        public static string phone { get; set; }
        
        public static string userId { get; set; }

        public static void Clear()
        {
            Login = null;
            RoleName = null;
        }

        public static void GetUserInfo(string login)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.bd_connect))
            {
                using (SqlCommand cmd = new SqlCommand("GetUserInfo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@login", login);

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    // Используем ExecuteReader вместо ExecuteScalar
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {
                            CurrentUser.Login = login;
                            // Заполняем данные пользователя
                            CurrentUser.RoleId = Convert.ToInt32(reader["roleId"]);
                            CurrentUser.RoleName = reader["role_name"].ToString();
                            CurrentUser.firstName = reader["firstName"].ToString();
                            CurrentUser.lastName = reader["lastName"].ToString();
                            CurrentUser.email = reader["email"].ToString();
                            CurrentUser.phone = reader["phone"].ToString();
                            CurrentUser.userId = reader["userId"].ToString();

                        }
                        else
                        {
                            Console.WriteLine("ошибка");
                        }
                    }
                    }
                }
            }


        public static bool UpdateUserInfo(string login, string firstName, string lastName, string email, string phone)
        {
            // Валидация обязательных параметров
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentException("Логин не может быть пустым", nameof(login));

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.bd_connect))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("UpdateUserInfo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone",phone);
                        cmd.Parameters.AddWithValue("@login", login);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Возвращаем true, если обновление прошло успешно
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

    }
        




    }
   
