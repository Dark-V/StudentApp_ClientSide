using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Newtonsoft.Json;

namespace StudentApp_Client.forms
{
    public partial class aboutme : Form
    {
        public aboutme(mainform form1)
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            string url = $"http://{Session.ip}:{Session.port}/get_info";

            try
            {
                HttpResponseMessage response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Parse the JSON response
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<dynamic>(jsonString);

                    name.Text = $"Инициалы: {data.name}";

                    speciality.Text = $"Группа: {data.specialty}";
                    group.Text = $"Специальность: {data.groups_number}";
                    dep.Text = $"Направление: {data.department}";

                    role.Text = $"Статус: {data.role}";

                    string role2 = data.role;
                    switch (role2)
                    {
                        case "admin":
                            this.pictureBox2.Image = global::StudentApp_Client.Properties.Resources.admin;
                            break;
                        case "teacher":
                            this.pictureBox2.Image = global::StudentApp_Client.Properties.Resources.teacher;
                            break;
                        case "student":
                            this.pictureBox2.Image = global::StudentApp_Client.Properties.Resources.student;
                            break;
                    }
                    pictureBox1.Refresh();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
