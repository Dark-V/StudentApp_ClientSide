using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScottPlot;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using System.Windows.Forms;
using OfficeOpenXml;

namespace StudentApp_Client.forms
{
    public partial class outputs : Form
    {
        private mainform form1;
        private ReportResponse lastReportData;
        private int lastType = 0;
        public outputs(mainform form1)
        {
            InitializeComponent();
            this.form1 = form1;

            LoadMethodsInComboBox();
            LoadGroups();

        }

        private void LoadMethodsInComboBox()
        {
            // Create a list of anonymous objects with Text and Value properties
            var items = new[]
            {
                new { Text = "семестр", Value = "s" },
                new { Text = "учебный", Value = "t" },
                new { Text = "студент", Value = "student" }
            };

            // Set the DataSource, DisplayMember, and ValueMember properties
            formatBox.DataSource = items;
            formatBox.DisplayMember = "Text";
            formatBox.ValueMember = "Value";
        }

        private void LoadDataIntoGraph(List<ReportData> reportDataList, string type)
        {
            formsPlot1.Plot.Clear();

            switch (type)
            {
                case "Среднее значение":
                    double[] average_scores = reportDataList.Select(data => data.average_score).ToArray();
                    var signalPlot1 = formsPlot1.Plot.Add.Signal(average_scores.Select(x => (double)x).ToArray()); // Преобразование int[] в double[]
                    signalPlot1.Label = type;
                    break;
                case "Медиана":
                    double[] medians = reportDataList.Select(data => data.Median).ToArray();
                    var signalPlot2 = formsPlot1.Plot.Add.Signal(medians.Select(x => (double)x).ToArray()); // Преобразование int[] в double[]
                    signalPlot2.Label = type;
                    break;
                case "Мода":
                    int[] modes = reportDataList.Select(data => data.Mode).ToArray();
                    var signalPlot3 = formsPlot1.Plot.Add.Signal(modes.Select(x => (double)x).ToArray()); // Преобразование int[] в double[]
                    signalPlot3.Label = type;
                    break;
                case "Дисперсия":
                    double[] variances = reportDataList.Select(data => data.Variance).ToArray();
                    var signalPlot4 = formsPlot1.Plot.Add.Signal(variances);
                    signalPlot4.Label = type;
                    break;
            }

            formsPlot1.Plot.Title("Наглядное представление данных (в совокупности):");
            formsPlot1.Plot.ShowLegend(Alignment.LowerRight);
            formsPlot1.Plot.Axes.Margins(bottom: 0);
            formsPlot1.Plot.Legend.Orientation = ScottPlot.Orientation.Horizontal;

            formsPlot1.Plot.ShowLegend();
            formsPlot1.Refresh();

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

        public class Group
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void outputs_Load(object sender, EventArgs e)
        {

        }

        private void formatBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (formatBox.Text == "студент")
            {
                button2.Enabled = false;
                button1.Enabled = false;

                var selectedGroup = groupBox.SelectedItem;
                int groupId = ((dynamic)selectedGroup).Value;
                try
                {
                    outputStudentHelper form = new outputStudentHelper(groupId, this);

                    // Set the new form's StartPosition property to CenterParent
                    form.StartPosition = FormStartPosition.CenterParent;

                    // Get the location of the new form
                    Point location = form.Location;

                    // Move the new form up by a certain amount (e.g., 50 pixels)
                    location.Y -= 50;

                    // Set the new location of the form
                    form.Location = location;

                    form.Show();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public async void GetSummaryDataForReport(string? studentId)
        {
            string from_date = dateTimePickerFROM.Value.ToString("dd.MM.yyyy");
            string to_date = dateTimePickerTO.Value.ToString("dd.MM.yyyy");
            string? format = formatBox.SelectedValue.ToString();

            var selectedItem = groupBox.SelectedItem;
            var valueType = selectedItem.GetType().GetProperty("Value");
            var group_id = valueType.GetValue(selectedItem, null);


            if (studentId is null) studentId = "0";

            string url = $"http://{Session.ip}:{Session.port}/report?type={format}&from={from_date}&to={to_date}&studentId={studentId}&group_id={group_id}";

            try
            {
                var response = await Session.Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var summaryData = JsonConvert.DeserializeObject<ReportResponse>(json);

                    // Create a BindingList from the report data and set it as the data source
                    var bindingList = new SortableBindingList<ReportData>(summaryData.Report);
                    reportGrid.DataSource = bindingList;

                    // Enable sorting for each column
                    foreach (DataGridViewColumn column in reportGrid.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }

                    reportGrid.Columns["Name"].HeaderText = "Имя";
                    reportGrid.Columns["average_score"].HeaderText = "Среднее число";
                    reportGrid.Columns["Discipline"].HeaderText = "Дисциплина";
                    reportGrid.Columns["Median"].HeaderText = "Медиана";
                    reportGrid.Columns["Mode"].HeaderText = "Мода";
                    reportGrid.Columns["Variance"].HeaderText = "Дисперсия";

                    reportGrid.Columns["Name"].DisplayIndex = 0;
                    reportGrid.Columns["Discipline"].DisplayIndex = 1;
                    reportGrid.Columns["average_score"].DisplayIndex = 2;
                    reportGrid.Columns["Median"].DisplayIndex = 3;
                    reportGrid.Columns["Mode"].DisplayIndex = 4;
                    reportGrid.Columns["Variance"].DisplayIndex = 5;

                    reportGrid.ClearSelection();
                    reportGrid.BackgroundColor = System.Drawing.SystemColors.Control;
                    reportGrid.BorderStyle = BorderStyle.None;

                    foreach (DataGridViewColumn column in reportGrid.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }

                    reportGrid.Refresh();

                    if (summaryData.Report.Count > 0)
                    {
                        lastReportData = summaryData;
                        LoadDataIntoGraph(summaryData.Report, "Среднее значение");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        public class ReportResponse
        {
            public List<ReportData> Report { get; set; }
        }

        public class ReportData
        {
            public double average_score { get; set; }
            public string Discipline { get; set; }
            public double Median { get; set; }
            public int Mode { get; set; }
            public string Name { get; set; }
            public double Variance { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetSummaryDataForReport(null);
        }

        public class SortableBindingList<T> : BindingList<T>
        {
            private bool isSortedValue;
            ListSortDirection sortDirectionValue;
            PropertyDescriptor sortPropertyValue;

            public SortableBindingList()
            {
            }

            public SortableBindingList(IList<T> list)
            {
                foreach (object o in list)
                {
                    this.Add((T)o);
                }
            }

            protected override void ApplySortCore(PropertyDescriptor prop,
                ListSortDirection direction)
            {
                Type interfaceType = prop.PropertyType.GetInterface("IComparable");

                if (interfaceType == null && prop.PropertyType.IsValueType)
                {
                    Type underlyingType = Nullable.GetUnderlyingType(prop.PropertyType);

                    if (underlyingType != null)
                    {
                        interfaceType = underlyingType.GetInterface("IComparable");
                    }
                }

                if (interfaceType != null)
                {
                    sortPropertyValue = prop;
                    sortDirectionValue = direction;

                    IEnumerable<T> query = base.Items;

                    if (direction == ListSortDirection.Ascending)
                    {
                        query = query.OrderBy(i => prop.GetValue(i));
                    }
                    else
                    {
                        query = query.OrderByDescending(i => prop.GetValue(i));
                    }

                    int newIndex = 0;
                    foreach (object item in query)
                    {
                        this.Items[newIndex] = (T)item;
                        newIndex++;
                    }

                    isSortedValue = true;
                    this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
                }
                else
                {
                    throw new NotSupportedException("Cannot sort by " + prop.Name +
                        ". This" + prop.PropertyType.ToString() +
                        " does not implement IComparable");
                }
            }

            protected override PropertyDescriptor SortPropertyCore
            {
                get { return sortPropertyValue; }
            }

            protected override ListSortDirection SortDirectionCore
            {
                get { return sortDirectionValue; }
            }

            protected override bool SupportsSortingCore
            {
                get { return true; }
            }

            protected override bool IsSortedCore
            {
                get { return isSortedValue; }
            }
        }
        private void reportGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void reportGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void formsPlot1_MClick(object sender, MouseEventArgs e)
        {
            string[] types = { "Мода", "Медиана", "Среднее значение", "Дисперсия" };

            lastType %= types.Length;
            LoadDataIntoGraph(lastReportData.Report, types[lastType]);

            lastType++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView is empty
            if (reportGrid.Rows.Count == 0)
            {
                MessageBox.Show("Данных недостаточно!");
                return;
            }

            using (ExcelPackage pck = new ExcelPackage())
            {
                // Create a new worksheet in the Excel package
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");

                // Load the DataGridView data into the Excel worksheet starting from cell A1
                var data = reportGrid.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => !row.IsNewRow)
                    .Select(row => row.Cells.Cast<DataGridViewCell>()
                    .Select(cell => cell.Value)
                    .ToArray())
                    .ToArray();

                // Add the column headers to the data
                var headers = reportGrid.Columns.Cast<DataGridViewColumn>()
                    .Select(column => column.HeaderText)
                    .ToArray();
                data = new[] { headers }.Concat(data).ToArray();

                ws.Cells["A1"].LoadFromArrays(data);

                byte[] imageBytes = formsPlot1.Plot.GetImageBytes(800, 500);

                // Add the image to the worksheet
                var picture = ws.Drawings.AddPicture("Plot", new MemoryStream(imageBytes));
                picture.SetPosition(reportGrid.Rows.Count + 5, 0, 0, 0);

                // Save the package to a file
                var dialog = new SaveFileDialog();
                dialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Stream stream = dialog.OpenFile();
                    pck.SaveAs(stream);
                    stream.Close();
                }
            }
        }
    }
}
