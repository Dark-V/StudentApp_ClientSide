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
    public partial class perm : Form
    {
        public perm()
        {
            InitializeComponent();
            roleBox.SelectedIndex = 0;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            string role = roleBox.SelectedItem.ToString();
            string url = $"http://{Session.ip}:{Session.port}/auth/permission?role={role}&id={id}";

            try
            {
                HttpResponseMessage response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Полномочия были изменены!");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
