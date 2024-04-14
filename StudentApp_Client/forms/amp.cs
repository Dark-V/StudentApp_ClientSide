using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp_Client.forms
{
    public partial class amp : Form
    {
        public amp(mainform form)
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            string url = $"http://{Session.ip}:{Session.port}/get_dates";

            try
            {
                HttpResponseMessage response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Parse the JSON response
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<dynamic>(jsonString);

                    List<AttendanceRecord> marks = JsonConvert.DeserializeObject<List<AttendanceRecord>>(jsonString);

                    foreach (var record in marks)
                    {
                        switch (record.status)
                        {
                            case "Б":
                                record.status = "Болел";
                                break;
                            case "П":
                                record.status = "Присутствовал";
                                break;
                            case "УВ":
                                record.status = "Уважительная причина";
                                break;
                            case "О":
                                record.status = "Отсутствовал";
                                break;
                        }
                    }

                    dataGridView1.DataSource = marks;

                    dataGridView1.Columns["date"].HeaderText = "Дата выставления";
                    dataGridView1.Columns["status"].HeaderText = "Статус";

                    dataGridView1.ClearSelection();
                    dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
                    dataGridView1.BorderStyle = BorderStyle.None;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public class AttendanceRecord
        {
            public string date { get; set; }
            public string status { get; set; }
        }
    }
}
