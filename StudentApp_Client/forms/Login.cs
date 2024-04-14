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

namespace StudentApp_Client.forms
{
    public partial class Login : Form
    {
        private mainform form1;
        public Login(mainform form1)
        {
            InitializeComponent();
            this.form1 = form1;

            button1.PerformClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            form1.status_bar_part1.Text = $"Вход: АВТОРИЗЦИЯ. Пользователь: ...";

            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            string url = $"http://{Session.ip}:{Session.port}/auth/login?username={username}&password={password}";

            try
            {
                HttpResponseMessage response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Get the Set-Cookie header value
                    if (response.Headers.TryGetValues("Set-Cookie", out var cookies))
                    {
                        // Extract the session cookie
                        string sessionCookie = cookies.FirstOrDefault(c => c.StartsWith("session="));
                        if (sessionCookie != null)
                        {
                            // Store the session cookie
                            Session.Key = sessionCookie;
                            Session.Client.DefaultRequestHeaders.Add("Cookie", Session.Key);

                            var content = await response.Content.ReadAsStringAsync();

                            // Parse the JSON content
                            var json = JObject.Parse(content);

                            // Extract the role from the JSON
                            var role = json["role"].ToString();
                            form1.EnableButton(role);

                            MessageBox.Show($"Logged in successfully as {role}");
                            form1.status_bar_part1.Text = $"Вход: УСПЕШНО. Пользователь: {username}";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
