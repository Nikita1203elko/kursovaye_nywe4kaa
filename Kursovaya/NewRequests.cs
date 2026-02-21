using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Kursovaya
{
    public partial class NewRequests : Form
    {
        public NewRequests()
        {
            InitializeComponent();
        }

        private Dictionary<string, int> equipmentIdMap; 
        private void NewRequests_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.bd_connect))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetEquipment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CurrentUserId", CurrentUser.userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            equipmentIdMap = new Dictionary<string, int>();
                            equipmentList.Items.Clear();

                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);

                                equipmentIdMap[name] = id;
                                equipmentList.Items.Add(name);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            string description = description_tb.Text.Trim();
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Опишите, что случилось.");
                return;
            }

            if (equipmentList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одно оборудование.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.bd_connect))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            int requestId;
                            using (SqlCommand cmdRequest = new SqlCommand("AddRequest", conn, transaction))
                            {
                                cmdRequest.CommandType = CommandType.StoredProcedure;
                                cmdRequest.Parameters.AddWithValue("@user_id", CurrentUser.userId);
                                cmdRequest.Parameters.AddWithValue("@description", description);

                                SqlParameter outputIdParam = new SqlParameter("@new_id", SqlDbType.Int)
                                {
                                    Direction = ParameterDirection.Output
                                };
                                cmdRequest.Parameters.Add(outputIdParam);

                                cmdRequest.ExecuteNonQuery();
                                requestId = (int)outputIdParam.Value;
                            }
                            foreach (var checkedItem in equipmentList.CheckedItems)
                            {
                                string equipmentName = checkedItem.ToString();
                                if (equipmentIdMap.ContainsKey(equipmentName))
                                {
                                    int equipmentId = equipmentIdMap[equipmentName];

                                    using (SqlCommand cmdEquipment = new SqlCommand("AddEquipmentForRequest", conn, transaction))
                                    {
                                        cmdEquipment.CommandType = CommandType.StoredProcedure;
                                        cmdEquipment.Parameters.AddWithValue("@request_id", requestId);
                                        cmdEquipment.Parameters.AddWithValue("@equipment_id", equipmentId);

                                        cmdEquipment.ExecuteNonQuery();
                                    }
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show($"Заявка успешно создана!");
                            this.Close();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
