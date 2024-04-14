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

namespace StudentApp_Client.forms
{
    public partial class sql : Form
    {
        public sql()
        {
            InitializeComponent();
        }

        private async void send_Click(object sender, EventArgs e)
        {
            string raw_sql = this.textBox1.Text;
            string url = $"http://{Session.ip}:{Session.port}/auth/raw_sql?sql={raw_sql}";

            try
            {
                HttpResponseMessage response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("SQL был выполнен");
                }
                else
                {
                    MessageBox.Show("Invalid SQL or smth else");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
