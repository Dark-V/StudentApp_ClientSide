using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentApp_Client.forms.ViewGrades;

namespace StudentApp_Client.forms
{
    public partial class inputGrades : Form
    {
        public inputGrades()
        {
            InitializeComponent();

            // set today
            DateTime selectedDate = monthCalendar1.SelectionStart;
            string formattedDate = selectedDate.ToString("dd.MM.yyyy");
            dateBox.Text = formattedDate;
            scoreBox.SelectedIndex = 0;

            // load data in combox'es
            LoadGroups();
            GetDisciplines();

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
        public class DisciplineData
        {
            public List<Item> disciplines { get; set; }
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

        public async void GetDisciplines()
        {
            string url = $"http://{Session.ip}:{Session.port}/discipline/get";
            try
            {
                var response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var disciplineData = JsonConvert.DeserializeObject<DisciplineData>(json);
                    foreach (var discipline in disciplineData.disciplines)
                    {
                        dicp.Items.Add(discipline);
                    }
                    dicp.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                var scoreDict = new Dictionary<string, int> { { "5 (отлично)", 5 }, { "4 (хорошо)", 4 }, { "3 (удовлетворительно)", 3 }, { "2 (не удовлетворительно)", 2 }, { "1 (плохо)", 1 }, { "0 (очень плохо)", 0 } };
                var score = scoreDict[scoreBox.Text].ToString();

                var date = dateBox.Text;
                var studentId = ((Item)studentsBox.SelectedItem).Id.ToString();
                var disciplineId = ((Item)dicp.SelectedItem).Id.ToString();

                // Prepare the data to be sent
                var gradeData = new Dictionary<string, string>
                {
                    { "date", date },
                    { "score", score },
                    { "student_id", studentId },
                    { "discipline_id", disciplineId }
                };

                // Convert the data to JSON
                var json = JsonConvert.SerializeObject(gradeData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request
                var response = await Session.Client.PostAsync($"http://{Session.ip}:{Session.port}/grade/add", content);

                // Check the response
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Оценка успешна добавлена");
                    UpdateGrid();
                }
                else
                {
                    MessageBox.Show("Ошибка добавления");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        public class Grade
        {
            public int Id { get; set; } // Add this line
            public long date { get; set; } // Assuming the timestamp is a long
            public string discipline_id { get; set; }
            public int mark { get; set; }

            public string FormattedDate
            {
                get
                {
                    // Create a DateTime object from the Unix timestamp
                    DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                    dateTime = dateTime.AddSeconds(this.date).ToLocalTime();

                    // Format the DateTime object to a string in the format "dd.MM.yyyy"
                    return dateTime.ToString("dd.MM.yyyy");
                }
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
        public async void UpdateGrid()
        {
            try
            {
                // Get the selected item
                var selectedItem = (Item)studentsBox.SelectedItem;

                // Get the id of the selected student
                int studentId = selectedItem.Id;

                // Send a request to the server to get the grades of the student
                string url = $"http://{Session.ip}:{Session.port}/get_grades?id={studentId}";
                var response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var grades = JsonConvert.DeserializeObject<List<Grade>>(json);

                    // Convert to display format
                    var displayMarks = grades.Select(m => new DisplayStudentMark
                    {
                        Id = m.Id,
                        FormattedDate = m.FormattedDate,
                        discipline_id = m.discipline_id,
                        mark = m.mark
                    }).ToList();

                    dataGridView1.DataSource = displayMarks;

                    // Set the Id column visibility to false after setting the DataSource
                    dataGridView1.Columns["Id"].Visible = false;

                    dataGridView1.Columns["FormattedDate"].HeaderText = "Дата выставление";
                    dataGridView1.Columns["discipline_id"].HeaderText = "Предмет";
                    dataGridView1.Columns["mark"].HeaderText = "Оценка";

                    dataGridView1.ClearSelection();
                    dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
                    dataGridView1.BorderStyle = BorderStyle.None;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                // Show a message box with the error message
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        public async void studentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGroup = groupBox.SelectedItem;

            // Get the group ID
            int groupId = ((dynamic)selectedGroup).Value;
            GetStudents(groupId);
        }

        private void inputGrades_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedMark = (DisplayStudentMark)selectedRow.DataBoundItem;

                string url = $"http://{Session.ip}:{Session.port}/grade/delete?id={selectedMark.Id}";
                var response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Оценка была успешна удалена!");
                    UpdateGrid(); // Refresh the grid
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                }
            }
        }
    }
}
