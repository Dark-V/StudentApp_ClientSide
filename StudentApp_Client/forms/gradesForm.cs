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
using static StudentApp_Client.forms.amp;
using ScottPlot;
using ScottPlot.WinForms;
using ScottPlot.Plottables;

namespace StudentApp_Client.forms
{
    public partial class gradesForm : Form
    {
        public gradesForm(Form form1)
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            string url = $"http://{Session.ip}:{Session.port}/get_dates";

            try
            {
                HttpResponseMessage response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    // Parse the JSON response
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<dynamic>(jsonString);

                    List<AttendanceRecord> records = JsonConvert.DeserializeObject<List<AttendanceRecord>>(jsonString);

                    int total_B = 0;
                    int total_O = 0;
                    int total_UV = 0;
                    int total_p = 0;

                    int total_items = records.Count;

                    foreach (var record in records)
                    {
                        switch (record.status)
                        {
                            case "Б":
                                total_B++;
                                break;
                            case "О":
                                total_O++;
                                break;
                            case "УВ":
                                total_UV++;
                                break;
                            case "П":
                                total_p++;
                                break;
                        }
                    }

                    pristv.Text = $"Присутствовал: {total_p}";
                    prop.Text = $"Количество пропусков: {total_O}";
                    ill.Text = $"Болел: {total_B}";
                    megaill.Text = $"Уважительная причина: {total_UV}";
                    total.Text = $"Всего: {total_items}";

                    double positive = total_p + total_UV;
                    if (total_items > 0)
                    {
                        rating.Text = $"Рейтинг: {Math.Round(positive / total_items * 100, 1)}%";
                    }

                    // after all, load a graphic
                    LoadGraph(total_B, total_O, total_UV, total_p);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadGraph(double total_B, double total_O, double total_UV, double total_p)
        {
            double[] values = { total_B, total_O, total_UV, total_p };
            string[] labels = { "Болел", "Пропуски", "Уважительная причина", "Присутствовал" };

            // Create a list of colors for the bars
            ScottPlot.Color[] colors =
            {
                ScottPlot.Color.FromHex("#FF0000"),  // Red
                ScottPlot.Color.FromHex("#0000FF"),  // Blue
                ScottPlot.Color.FromHex("#00FF00"),  // Green
                ScottPlot.Color.FromHex("#FFFF00")   // Yellow
            };

            // Iterate over the values and labels to create the bars
            for (int i = 0; i < values.Length; i++)
            {
                double[] xs = { i + 0.1 };  // X values
                double[] ys = { values[i] };  // Y values
                var barPlot = formsPlot1.Plot.Add.Bars(xs, ys);
                barPlot.Label = labels[i];
                barPlot.Color = colors[i];  // Set the color of the bar
            }

            formsPlot1.Plot.Title("График посещений");
            formsPlot1.Plot.ShowLegend(Alignment.LowerRight);
            formsPlot1.Plot.Axes.Margins(bottom: 0);

            formsPlot1.Plot.ShowLegend();
            formsPlot1.Refresh();
        }

        private void rating_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }
    }
}
