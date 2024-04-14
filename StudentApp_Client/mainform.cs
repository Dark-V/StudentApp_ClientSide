using Newtonsoft.Json;
using StudentApp_Client.forms;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentApp_Client
{
    public partial class mainform : Form
    {
        private Form activeForm;
        public mainform()
        {
            InitializeComponent();
            Session.LoadSession();

            status_bar_part2_load();
        }

        private void status_bar_part2_load()
        {
            // Get the current date
            string currentDate = DateTime.Now.ToString("dd.MM.yyyy");
            // Get the version of the application
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // Set the text in the status bar
            status_bar_part2.Text = $"Äàòà: {currentDate} Âåðñèÿ: {version}";
        }

        public void EnableButton(string role) // by client-side disable tabs where user can be by his role
        {
            this.auth.Enabled = false;
            this.logout.Enabled = true;

            switch (role)
            {
                case "student":
                    this.about.Enabled = true;
                    this.grades.Enabled = true;
                    this.amp.Enabled = true;
                    this.gradesForm.Enabled = true;
                    break;
                case "teacher":
                    this.about.Enabled = true;
                    this.grades.Enabled = true;
                    this.amp.Enabled = true;
                    this.gradesForm.Enabled = true;
                    this.inputGrades.Enabled = true;
                    this.inputAmp.Enabled = true;
                    break;
                case "admin":
                    this.about.Enabled = true;
                    this.grades.Enabled = true;
                    this.amp.Enabled = true;
                    this.gradesForm.Enabled = true;
                    this.inputGrades.Enabled = true;
                    this.inputAmp.Enabled = true;
                    this.reg.Enabled = true;
                    this.perm.Enabled = true;
                    this.outputs.Enabled = true;
                    break;
            }
        }

        public void DisableButton()
        {
            this.auth.Enabled = true; // Àâòîðèçàöèÿ

            this.about.Enabled = false;
            this.grades.Enabled = false;
            this.amp.Enabled = false;
            this.gradesForm.Enabled = false;

            // Teacher
            this.inputGrades.Enabled = false;
            this.inputAmp.Enabled = false;

            // Admin
            this.reg.Enabled = false;
            this.perm.Enabled = false;
            this.outputs.Enabled = false;

            this.logout.Enabled = false;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.Login(this), e);
        }

        private void about_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.aboutme(this), e);
        }

        private void grades_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.ViewGrades(this), e);
        }

        private void amp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.amp(this), e);
        }

        private void gradesForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.gradesForm(this), e);
        }

        private void reg_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.reg(this), e);
        }

        private void perm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.perm(), e);
        }

        private void sql_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.outputs(this), e);
        }

        private void help_icon_click(object sender, EventArgs e)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\HelpFile.chm";
            if (!File.Exists(filePath))
            {
                var data = Properties.Resources.help11;
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    stream.Write(data, 0, data.Length);
                    stream.Flush();
                }
            }
            Help.ShowHelp(this, filePath);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DisableButton();
            Session.Key = "";
            status_bar_part1.Text = "Âõîä: ÍÅÈÇÂÅÑÒÍÎ. Ïîëüçîâàòåëü: ÍÅ ÎÁÍÀÐÓÆÅÍ";
        }

        private void inputGrades_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.inputGrades(), e);
        }

        private void inputAmp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.InputAmp(), e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // TODO LIST:

            // input amp and input grades: add remove feature
            // reg (registarion of student): add feature to server-side of deleting, editing or adding data
            // add to server-side a photos feature of students on reg sub-form
            // edit db in students, add photos

        }
    }

    public static class Session
    {
        public static string ip = "127.0.0.1";
        public static string port = "5555";
        public static string? Key { get; set; }
        public static HttpClient Client { get; set; } = new HttpClient();

        public static void LoadSession()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string configPath = Path.Combine(docPath, "config.json");

            if (!File.Exists(configPath))
            {
                var config = new { ip = Session.ip, port = Session.port };
                File.WriteAllText(configPath, JsonConvert.SerializeObject(config));
            }
            else
            {
                var config = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(configPath));
                Session.ip = config.ip;
                Session.port = config.port;
            }
        }
    }
}
