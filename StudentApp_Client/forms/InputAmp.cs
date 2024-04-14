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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentApp_Client.forms
{
    public partial class InputAmp : Form
    {
        public InputAmp()
        {
            InitializeComponent();

            // set today
            DateTime selectedDate = monthCalendar1.SelectionStart;
            string formattedDate = selectedDate.ToString("dd.MM.yyyy");
            dateBox.Text = formattedDate;
            statusBox.SelectedIndex = 0;

            LoadGroups();

            MakeGridStyles();
        }
        private void MakeGridStyles()
        {
            dataGridView1.ClearSelection();
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
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

        public class Group
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        private async void LoadGroups()
        {
            string url = $"http://{Session.ip}:{Session.port}/groups/get";

            try
            {
                HttpResponseMessage response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Parse the JSON response
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<dynamic>(jsonString);

                    // Access the 'groups' property of the JSON response
                    List<Group> groups = JsonConvert.DeserializeObject<List<Group>>(data["groups"].ToString());

                    // Clear the comboBox1 items
                    groupBox.Items.Clear();

                    // Add the group names to comboBox1
                    foreach (var group in groups)
                    {
                        groupBox.Items.Add(new { Text = group.name, Value = group.id });
                    }

                    // Set the DisplayMember and ValueMember properties
                    groupBox.DisplayMember = "Text";
                    groupBox.ValueMember = "Value";

                    groupBox.SelectedIndex = 0;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
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

                    foreach (var student in students)
                    {
                        studentsBox.Items.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            string formattedDate = selectedDate.ToString("dd.MM.yyyy");
            dateBox.Text = formattedDate;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var date = dateBox.Text;
                var studentId = ((Item)studentsBox.SelectedItem).Id.ToString();
                var status = statusBox.SelectedItem.ToString();

                switch (status)
                {
                    case "Болел":
                        status = "Б";
                        break;
                    case "Присутствовал":
                        status = "П";
                        break;
                    case "Уважительная причина":
                        status = "УВ";
                        break;
                    case "Отсутствовал":
                        status = "О";
                        break;
                    default:
                        status = "Неизвестный статус";
                        break;
                }

                // Prepare the data to be sent
                var dateData = new Dictionary<string, string>
                {
                    { "date", date },
                    { "status", status },
                    { "student_id", studentId }
                };

                // Convert the data to JSON
                var json = JsonConvert.SerializeObject(dateData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request
                var response = await Session.Client.PostAsync($"http://{Session.ip}:{Session.port}/date/add", content);

                // Check the response
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Дата успешно добавлена");
                    UpdateGrid();
                }
                else
                {
                    MessageBox.Show("Ошибка добавления даты");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        public class AttendanceRecord
        {
            public string date { get; set; }
            public string status { get; set; }
        }
        public async void UpdateGrid()
        {
            try
            {
                // Get the selected item
                var selectedItem = (Item)studentsBox.SelectedItem;

                // Get the id of the selected student
                int studentId = selectedItem.Id;

                // Send a request to the server to get the grades of the student
                string url = $"http://{Session.ip}:{Session.port}/get_dates?id={studentId}";
                var response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var Attendance = JsonConvert.DeserializeObject<List<AttendanceRecord>>(json);

                    foreach (var record in Attendance)
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

                    // Set the data into dataGridView1
                    dataGridView1.DataSource = Attendance;

                    dataGridView1.Columns["date"].HeaderText = "Дата выставления";
                    dataGridView1.Columns["status"].HeaderText = "Статус";
                }
            }
            catch (Exception ex)
            {
                // Show a message box with the error message
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void studentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void InputAmp_Load(object sender, EventArgs e)
        {

        }

        private void groupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGroup = groupBox.SelectedItem;

            // Get the group ID
            int groupId = ((dynamic)selectedGroup).Value;
            GetStudents(groupId);
        }

        private void dateBox_Validating(object sender, CancelEventArgs e)
        {
           DateTime parsedDate;
           var isValidDate = DateTime.TryParse(dateBox.Text, out parsedDate);

           if (!isValidDate)
           {
               MessageBox.Show("Пожалуйста, введите корректную дату!");
               e.Cancel = true;
           }
         
        }
    }
}
