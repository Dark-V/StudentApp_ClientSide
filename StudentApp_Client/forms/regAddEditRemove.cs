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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentApp_Client.forms
{
    public partial class regAddEditRemove : Form
    {
        public regAddEditRemove(string type, Dictionary<string, string> rowData)
        {
            InitializeComponent();

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

            if (type != "add")
            {
                // Assuming that keys in the dictionary match the names of your form elements
                FamilyBox.Text = rowData["family"];
                nameBox.Text = rowData["name"];
                secondNameBox.Text = rowData["second_name"];
                genderBox.SelectedItem = rowData["gender"];
                groupBox.SelectedItem = rowData["Groups_number"];
                specialityBox.SelectedItem = rowData["specialty"];
                departmentBox.SelectedItem = rowData["department"];
            }

            switch (type)
            {
                case "add":
                    AddNewDataToTable();
                    break;
                case "edit":
                    EditDataToTable();
                    break;
                case "remove":
                    RemoveDataToTable();
                    break;
            }

        }

        private void AddNewDataToTable()
        {

        }

        private void EditDataToTable()
        {

        }
        private void RemoveDataToTable()
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
