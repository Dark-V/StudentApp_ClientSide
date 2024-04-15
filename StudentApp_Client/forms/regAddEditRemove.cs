using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentApp_Client.forms.inputGrades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentApp_Client.forms
{
    public partial class regAddEditRemove : Form
    {
        private reg form1;
        public regAddEditRemove(reg form1_this, string type, Dictionary<string, string> rowData)
        {
            InitializeComponent();

            form1 = form1_this;

            LoadGroupData(type, rowData);
        }

        private async void LoadGroupData(string type, Dictionary<string, string> rowData)
        {
            // Send the GET request
            var response = await Session.Client.GetAsync($"http://{Session.ip}:{Session.port}/discipline/getAll");

            // Check the response
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Disciplines>(json);

                foreach (var item in data.disciplines)
                {
                    groupBox.Items.Add(item.id.ToString());
                    specialityBox.Items.Add(item.specialty);
                    departmentBox.Items.Add(item.department);
                }

                LoadDataToForm(type, rowData);
            }
            else
            {
                throw new Exception("Error fetching data from server");
            }
        }

        public class Discipline
        {
            public string department { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string specialty { get; set; }
        }

        public class Disciplines
        {
            public List<Discipline> disciplines { get; set; }
        }

        private void LoadDataToForm(string type, Dictionary<string, string> rowData)
        {
            switch (type)
            {
                case "add":
                    button1.Text = "Добавить студента";
                    break;
                case "edit":
                    button1.Text = "Подтвердить изменения";
                    break;
                case "remove":
                    button1.Text = "Удалить студента";
                    break;

            }

            if (type == "edit")
            {
                // Assuming that keys in the dictionary match the names of your form elements
                label10.Text = $"ID: {rowData["id"]}";
                FamilyBox.Text = rowData["family"];
                nameBox.Text = rowData["name"];
                secondNameBox.Text = rowData["second_name"];
                genderBox.SelectedItem = rowData["gender"];
                groupBox.SelectedItem = rowData["Groups_number"];
                specialityBox.SelectedItem = rowData["specialty"];
                departmentBox.SelectedItem = rowData["department"];
            }
            if (type == "remove")
            {
                // Assuming that keys in the dictionary match the names of your form elements
                label10.Text = $"ID: {rowData["id"]}";
                FamilyBox.Text = rowData["family"];
                nameBox.Text = rowData["name"];
                secondNameBox.Text = rowData["second_name"];
                genderBox.SelectedItem = rowData["gender"];
                groupBox.SelectedItem = rowData["Groups_number"];
                specialityBox.SelectedItem = rowData["specialty"];
                departmentBox.SelectedItem = rowData["department"];

                label10.Enabled = false;
                FamilyBox.Enabled = false;
                nameBox.Enabled = false;
                secondNameBox.Enabled = false;
                genderBox.Enabled = false;
                groupBox.Enabled = false;
                specialityBox.Enabled = false;
                departmentBox.Enabled = false;
                loginBox.Enabled = false;
                passBox.Enabled = false;    
                pictureBox1.Enabled = false;   
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
        public class DisciplineData
        {
            public List<Item> disciplines { get; set; }
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
                        specialityBox.Items.Add(discipline);
                    }
                    specialityBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to only allow PNG files
            openFileDialog.Filter = "PNG Files|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected PNG file into an Image
                Image originalImage = Image.FromFile(openFileDialog.FileName);

                // Create a new Bitmap with the desired size
                Bitmap resizedImage = new Bitmap(250, 250);

                // Draw the original image onto the new Bitmap
                using (Graphics g = Graphics.FromImage(resizedImage))
                {
                    g.DrawImage(originalImage, 0, 0, 250, 250);
                }

                // Set the PictureBox's Image property to the new Bitmap
                pictureBox1.Image = resizedImage;
            }
        }

        private void regAddEditRemove_Load(object sender, EventArgs e)
        {

        }

        private async void StudentAdd()
        {
            // Create a new student object
            var student = new
            {
                id = label10.Text.Replace("ID: ", ""),
                Family = FamilyBox.Text,
                Name = nameBox.Text,
                SecondName = secondNameBox.Text,
                Gender = genderBox.SelectedItem.ToString(),
                GroupNumber = groupBox.SelectedItem.ToString(),
                Specialty = specialityBox.SelectedItem.ToString(),
                Department = departmentBox.SelectedItem.ToString(),
                login = loginBox.Text.ToString(),
                password = passBox.Text.ToString(),

                // Convert the image in pictureBox1 to a base64 string
                Img = Convert.ToBase64String((byte[])new ImageConverter().ConvertTo(pictureBox1.Image, typeof(byte[])))
            };

            // Convert the student object to JSON
            string json = JsonConvert.SerializeObject(student);

            // Create a new StringContent instance
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send a POST request to the server
            var response = await Session.Client.PostAsync($"http://{Session.ip}:{Session.port}/student/add", content);

            // Check the response
            if (response.IsSuccessStatusCode)
            {
                // Success
                Console.WriteLine("Данные студента успешно изменены.");

                form1.LoadGrid();
                this.Close();
            }
            else
            {
                // Error
                Console.WriteLine("Error editing student: " + response.StatusCode);
            }
        }

        private async void StudentEdit()
        {
            // Create a new student object
            var student = new
            {
                id = label10.Text.Replace("ID: ", ""),
                Family = FamilyBox.Text,
                Name = nameBox.Text,
                SecondName = secondNameBox.Text,
                Gender = genderBox.SelectedItem.ToString(),
                GroupNumber = groupBox.SelectedItem.ToString(),
                Specialty = specialityBox.SelectedItem.ToString(),
                Department = departmentBox.SelectedItem.ToString(),
                login = loginBox.Text.ToString(),
                password = passBox.Text.ToString(),

                // Convert the image in pictureBox1 to a base64 string
                Img = Convert.ToBase64String((byte[])new ImageConverter().ConvertTo(pictureBox1.Image, typeof(byte[])))
            };

            // Convert the student object to JSON
            string json = JsonConvert.SerializeObject(student);

            // Create a new StringContent instance
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send a POST request to the server
            var response = await Session.Client.PostAsync($"http://{Session.ip}:{Session.port}/student/edit", content);

            // Check the response
            if (response.IsSuccessStatusCode)
            {
                // Success
                Console.WriteLine("Данные студента успешно изменены.");

                form1.LoadGrid();
                this.Close();
            }
            else
            {
                // Error
                Console.WriteLine("Error editing student: " + response.StatusCode);
            }
        }


        private async void StudentRemove()
        {
            var id = label10.Text.Replace("ID: ", "");
            var response = await Session.Client.DeleteAsync($"http://{Session.ip}:{Session.port}/student/remove/{id}");

            // Check the response
            if (response.IsSuccessStatusCode)
            {
                // Success
                Console.WriteLine("Студент успешно удалён из системы.");

                form1.LoadGrid();
                this.Close();
            }
            else
            {
                // Error
                Console.WriteLine("Error editing student: " + response.StatusCode);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (button1.Text)
            {
                case "Добавить студента":
                    StudentAdd();
                    break;
                case "Подтвердить изменения":
                    StudentEdit();
                    break;
                case "Удалить студента":
                    StudentRemove();
                    break;

            }

        }
    }
}
