using Newtonsoft.Json.Linq;
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
using static StudentApp_Client.forms.reg;

namespace StudentApp_Client.forms
{
    public partial class outputStudentHelper : Form

    {
        public outputs form1;
        public outputStudentHelper(int groupId, outputs outputForm)
        {
            InitializeComponent();

            form1 = outputForm;

            GetStudents(groupId);
        }

        public async void GetStudents(int groupId)
        {
            string url = $"http://{Session.ip}:{Session.port}/student/get?groupId={groupId}";
            try
            {
                var response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    // Parse the JSON data into a JObject
                    var jsonData = JObject.Parse(json);

                    // Get the 'students' property which is an array
                    var studentsJson = jsonData["students"].ToString();

                    // Deserialize the students JSON data into a list of Item
                    var students = JsonConvert.DeserializeObject<List<Item>>(studentsJson);

                    studentsBox.DisplayMember = "Name";
                    studentsBox.ValueMember = "Id";

                    foreach (var student in students)
                    {
                        studentsBox.Items.Add(new Item() { Name = student.Name, Id = student.Id });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        public class Item
        {
            public string Name { get; set; }
            public int Id { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (studentsBox.SelectedItem != null)
            {
                var selectedId = ((Item)studentsBox.SelectedItem).Id.ToString();
                form1.GetSummaryDataForReport(selectedId);
                form1.button2.Enabled = true;
                form1.button1.Enabled = true;
                this.Close();

                form1.formatBox.SelectedIndex = 0;
            }
            else MessageBox.Show("Вам нужно выбрать имя студента!");
        }

        private void outputStudentHelper_Load(object sender, EventArgs e)
        {

        }

        private void outputStudentHelper_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.button2.Enabled = true;
            form1.button1.Enabled = true;
            form1.formatBox.SelectedIndex = 0;
        }
    }
}
