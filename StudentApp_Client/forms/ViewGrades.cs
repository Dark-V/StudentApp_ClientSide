using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentApp_Client.forms
{
    public partial class ViewGrades : Form
    {

        public ViewGrades(mainform form1)
        {
            InitializeComponent();
            LoadData();
        }

        public class DisplayStudentMark
        {
            public string FormattedDate { get; set; }
            public string discipline_id { get; set; }
            public int mark { get; set; }
        }

        private async void LoadData()
        {
            string url = $"http://{Session.ip}:{Session.port}/get_grades";

            try
            {
                HttpResponseMessage response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Parse the JSON response
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<dynamic>(jsonString);

                    List<StudentMark> marks = JsonConvert.DeserializeObject<List<StudentMark>>(jsonString);

                    // Convert to display format
                    var displayMarks = marks.Select(m => new DisplayStudentMark
                    {
                        FormattedDate = m.FormattedDate,
                        discipline_id = m.discipline_id,
                        mark = m.mark
                    }).ToList();

                    dataGridView1.DataSource = displayMarks;

                    dataGridView1.Columns["FormattedDate"].HeaderText = "Дата выставление";
                    dataGridView1.Columns["discipline_id"].HeaderText = "Предмет";
                    dataGridView1.Columns["mark"].HeaderText = "Оценка";

                    // dataGridView1.Sort(dataGridView1.Columns["FormattedDate"], ListSortDirection.Ascending);
                    dataGridView1.ClearSelection();
                    dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
                    dataGridView1.BorderStyle = BorderStyle.None;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
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


        public class StudentMark
        {
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

    }
}
