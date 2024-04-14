using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace StudentApp_Client.forms
{
    public partial class reg : Form
    {
        public reg(mainform form1)
        {
            InitializeComponent();

            LoadGrid(); // load all students into grid
        }

        private async void LoadAddEditRemForm(string type, Dictionary<string, string> rowData)
        {
            try
            {
                regAddEditRemove form = new regAddEditRemove(type, rowData);
                form.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private async void LoadGrid()
        {
            string url = $"http://{Session.ip}:{Session.port}/student/getAll";

            try
            {
                HttpResponseMessage response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response to a list of Student objects
                    var students = JsonConvert.DeserializeObject<List<Student>>(content);

                    all_studentsGrid.DataSource = students;

                    all_studentsGrid.Columns["id"].HeaderText = "ID";
                    all_studentsGrid.Columns["family"].HeaderText = "Фамилия";
                    all_studentsGrid.Columns["name"].HeaderText = "Имя";
                    all_studentsGrid.Columns["second_name"].HeaderText = "Отечество";
                    all_studentsGrid.Columns["gender"].HeaderText = "Пол";
                    all_studentsGrid.Columns["Groups_number"].HeaderText = "Группа";
                    all_studentsGrid.Columns["specialty"].HeaderText = "Специальность";
                    all_studentsGrid.Columns["department"].HeaderText = "Отделение";

                    all_studentsGrid.ClearSelection();
                    all_studentsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
                    all_studentsGrid.BorderStyle = BorderStyle.None;

                    foreach (DataGridViewColumn column in all_studentsGrid.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
                else
                {
                    MessageBox.Show("Failed to load student data");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public class Student
        {
            public int id { get; set; }
            public string family { get; set; }
            public string name { get; set; }
            public string second_name { get; set; }
            public string gender { get; set; }
            public int Groups_number { get; set; }
            public string specialty { get; set; }
            public string department { get; set; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> rowData = new Dictionary<string, string>();
            LoadAddEditRemForm("add", rowData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (all_studentsGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = all_studentsGrid.SelectedRows[0];
                Dictionary<string, string> rowData = new Dictionary<string, string>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowData.Add(cell.OwningColumn.Name, cell.Value.ToString());
                }
                LoadAddEditRemForm("edit", rowData);
            }
            else MessageBox.Show("Сначала нужно выбрать нужного студента!", "Ошибка");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (all_studentsGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = all_studentsGrid.SelectedRows[0];
                Dictionary<string, string> rowData = new Dictionary<string, string>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowData.Add(cell.OwningColumn.Name, cell.Value.ToString());
                }
                LoadAddEditRemForm("remove", rowData);
            }
            else MessageBox.Show("Сначала нужно выбрать нужного студента!", "Ошибка");
        }

        private void all_studentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
