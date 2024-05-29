using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace EmployeeAttendanceSystem
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();

        public int Empcount = 0;

        public Form1()
        {
            InitializeComponent();
            Search_dataGridView.RowHeadersVisible = false;
            Searchbtn.Enabled = false;
        }

        //читаем з файла xml 
        public void LoadEmployees()
        {
            DataTable employeeTable = new DataTable();

            employeeTable.Columns.Add("PIB", typeof(string));
            employeeTable.Columns.Add("Posada", typeof(string));
            employeeTable.Columns.Add("Date", typeof(DateTime));
            employeeTable.Columns.Add("Arrival", typeof(TimeSpan));
            employeeTable.Columns.Add("Leave", typeof(TimeSpan));
            employeeTable.Columns.Add("Count", typeof(int));
            employeeTable.Columns.Add("WorkDuration", typeof(TimeSpan));

            XmlDocument Data_Document = new XmlDocument();
            string path = "C:\\Users\\stand\\source\\repos\\EmployeeAttendanceSystem\\EmployeeAttendanceSystem\\XML_Data.xml";
            Data_Document.Load(path);
            employees.Clear();

            foreach (XmlNode node in Data_Document.DocumentElement)
            {
                string PIB = node.Attributes[0].Value;
                string Posada = node.SelectSingleNode("Posada").InnerText;
                string date = node.SelectSingleNode("Date").InnerText;
                string arrival = node.SelectSingleNode("Arrival").InnerText;
                string leave = node.SelectSingleNode("Leave").InnerText;

                DateTime Date = DateTime.ParseExact(date, "dd.MM.yyyy", null);

                string[] arrivalParts = arrival.Split(':');
                TimeSpan Arrival = new TimeSpan(int.Parse(arrivalParts[0]), int.Parse(arrivalParts[1]), 0);

                string[] leaveParts = leave.Split(':');
                TimeSpan Leave = new TimeSpan(int.Parse(leaveParts[0]), int.Parse(leaveParts[1]), 0);

                TimeSpan workDuration = Leave - Arrival;

                employees.Add(new Employee(PIB, Posada, Date, Arrival, Leave, workDuration));

                //Кількість робітників
                Empcount++;
            }
            //сортуємо по часу прибуття
            employees.Sort((x, y) => TimeSpan.Compare(x.Arrival, y.Arrival));
            foreach (var emp in employees)
            {
                employeeTable.Rows.Add(emp.PIB, emp.Posada, emp.Date, emp.Arrival.ToString(), emp.Leave.ToString(), employeeTable.Rows.Count + 1, emp.WorkDuration);
            }
            Search_dataGridView.AutoGenerateColumns = true;
            Search_dataGridView.DataSource = employeeTable;
        }
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            sortThem();
            Search_resultlbl.Text = Search_dataGridView.Rows.Count.ToString();
        }
        private void sortThem()
        {
            if (!Search_byDatechb.Checked && !Search_byTimechb.Checked)
            {
                LoadEmployees();
                return;
            }
            DateTime fromDate = Search_FromdateTimePicker.Value.Date;
            DateTime toDate = Search_TodateTimePicker.Value.Date.AddDays(1).AddSeconds(-1);
            TimeSpan fromTime = Search_FromTimePicker.Value.TimeOfDay;
            TimeSpan toTime = Search_ToTimePicker.Value.TimeOfDay;

            List<Employee> filteredEmployees = new List<Employee>();

            if (Search_byDatechb.Checked && Search_byTimechb.Checked)
            {
                filteredEmployees = employees.Where(emp =>
                    emp.Date >= fromDate && emp.Date <= toDate &&
                    emp.Arrival.TotalSeconds >= fromTime.TotalSeconds && emp.Leave.TotalSeconds <= toTime.TotalSeconds).ToList();
            }
            else if (Search_byDatechb.Checked)
            {
                filteredEmployees = employees.Where(emp => emp.Date >= fromDate && emp.Date <= toDate).ToList();
            }
            else if (Search_byTimechb.Checked)
            {
                filteredEmployees = employees.Where(emp =>
                    emp.Arrival.TotalSeconds >= fromTime.TotalSeconds && emp.Leave.TotalSeconds <= toTime.TotalSeconds).ToList();
            }
            QuickSort(filteredEmployees, 0, filteredEmployees.Count - 1);
            DataTable employeeTable = new DataTable();
            employeeTable.Columns.Add("PIB", typeof(string));
            employeeTable.Columns.Add("Posada", typeof(string));
            employeeTable.Columns.Add("Date", typeof(DateTime));
            employeeTable.Columns.Add("Arrival", typeof(TimeSpan));
            employeeTable.Columns.Add("Leave", typeof(TimeSpan));
            employeeTable.Columns.Add("Count", typeof(int));
            employeeTable.Columns.Add("WorkDuration", typeof(TimeSpan));

            foreach (var emp in filteredEmployees)
            {
                employeeTable.Rows.Add(emp.PIB, emp.Posada, emp.Date, emp.Arrival.ToString(), emp.Leave.ToString(), employeeTable.Rows.Count + 1, emp.WorkDuration);
            }
            Search_dataGridView.DataSource = employeeTable;
        }
        private void QuickSort(List<Employee> employees, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(employees, low, high);

                QuickSort(employees, low, pivotIndex - 1);
                QuickSort(employees, pivotIndex + 1, high);
            }
        }
        private int Partition(List<Employee> employees, int low, int high)
        {
            TimeSpan pivot = employees[high].Arrival;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (employees[j].Arrival < pivot)
                {
                    i++;
                    Swap(employees, i, j);
                }
            }
            Swap(employees, i + 1, high);
            return i + 1;
        }
        private void Swap(List<Employee> employees, int i, int j)
        {
            Employee temp = employees[i];
            employees[i] = employees[j];
            employees[j] = temp;
        }
        public void WriteindgvEmployees()
        {
            int n = Write_dataGridView.Rows.Add();
            Write_dataGridView.Rows[n].Cells[0].Value = Write_Nametxb.Text;
            Write_dataGridView.Rows[n].Cells[1].Value = Write_Posadatxb.Text;
            Write_dataGridView.Rows[n].Cells[2].Value = Write_dateTimePicker.Text;
            Write_dataGridView.Rows[n].Cells[3].Value = Write_ArriveTimePicker.Text;
            Write_dataGridView.Rows[n].Cells[4].Value = Write_LeaveTimePicker.Text;
        }
        public void WriteinxxmlEmployees()
        {
            XDocument doc;
            if (File.Exists("C:\\Users\\stand\\source\\repos\\EmployeeAttendanceSystem\\EmployeeAttendanceSystem\\XML_Data.xml"))
            {
                doc = XDocument.Load("C:\\Users\\stand\\source\\repos\\EmployeeAttendanceSystem\\EmployeeAttendanceSystem\\XML_Data.xml");
            }
            else
            {
                doc = new XDocument(new XElement("Employees"));
            }

            XElement root = doc.Root;

            foreach (DataGridViewRow r in Write_dataGridView.Rows)
            {
                bool isEmptyRow = true;
                foreach (DataGridViewCell cell in r.Cells)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(cell.Value)))
                    {
                        isEmptyRow = false;
                        break;
                    }
                }
                if (isEmptyRow)
                {
                    continue;
                }
                string pibValue = Convert.ToString(r.Cells[0].Value);
                string posadaValue = Convert.ToString(r.Cells[1].Value);
                string dateValue = Convert.ToString(r.Cells[2].Value);
                string arrivalValue = Convert.ToString(r.Cells[3].Value);
                string leaveValue = Convert.ToString(r.Cells[4].Value);

                XElement employee = new XElement("Employee",
                    new XAttribute("PIB", pibValue),
                    new XElement("Posada", posadaValue),
                    new XElement("Date", dateValue),
                    new XElement("Arrival", arrivalValue),
                    new XElement("Leave", leaveValue)
                );
                root.Add(employee);
            }
            doc.Save("C:\\Users\\stand\\source\\repos\\EmployeeAttendanceSystem\\EmployeeAttendanceSystem\\XML_Data.xml");
        }
        private void Write_LoadDatabtn_Click(object sender, EventArgs e)
        {
            WriteindgvEmployees();
            Write_dataGridView.AutoGenerateColumns = true;
        }
        private void Search_Sortchb_CheckStateChanged(object sender, EventArgs e)
        {
            if (Search_Sortchb.Checked)
            {
                Searchbtn.Enabled = true;
            }
            else
            {
                Searchbtn.Enabled = false;
            }
        }
        private void Write_DeleteLastbtn_Click(object sender, EventArgs e)
        {
            Write_dataGridView.Rows.RemoveAt(Write_dataGridView.Rows.Count - 2);
        }
        private void Write_ClearAllbtn_Click(object sender, EventArgs e)
        {
            Write_dataGridView.Rows.Clear();
        }
        private void Search_byDatechb_CheckedChanged(object sender, EventArgs e)
        {
            if (Search_byDatechb.Checked)
            {
                Search_FromdateTimePicker.Enabled = true;
                Search_TodateTimePicker.Enabled = true;
            }
            else
            {
                Search_FromdateTimePicker.Enabled = false;
                Search_TodateTimePicker.Enabled = false;
            }
        }
        private void Search_byTimechb_CheckedChanged(object sender, EventArgs e)
        {
            if (Search_byTimechb.Checked)
            {
                Search_FromTimePicker.Enabled = true;
                Search_ToTimePicker.Enabled = true;
            }
            else
            {
                Search_FromTimePicker.Enabled = false;
                Search_ToTimePicker.Enabled = false;
            }
        }
        private void Write_Savebtn_Click(object sender, EventArgs e)
        {
            WriteinxxmlEmployees();
           // LoadEmployees();
        }
        private void Search_Exportbtn_Click(object sender, EventArgs e)
        {
            WriteToAFile();
        }
        private void WriteToAFile()
        {
            if (Search_dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Нічого запмувати.");
                return;
            }
            string filePath = "C:\\Users\\stand\\Desktop\\Search_Results.txt";

            // находим ширину columns
            int[] columnWidths = new int[Search_dataGridView.Columns.Count];
            foreach (DataGridViewRow row in Search_dataGridView.Rows)
            {
                for (int i = 0; i < Search_dataGridView.Columns.Count; i++)
                {
                    int cellLength = (row.Cells[i].Value ?? "").ToString().Length;
                    if (cellLength > columnWidths[i])
                    {
                        columnWidths[i] = cellLength;
                    }
                }
            }

            // stringbuilder с данними от dgv
            StringBuilder sb = new StringBuilder();

            // Добваляем пробели
            for (int i = 0; i < Search_dataGridView.Columns.Count; i++)
            {
                string header = Search_dataGridView.Columns[i].HeaderText;
                sb.Append(header.PadRight(columnWidths[i] + 2));
            }
            sb.AppendLine();

            // добавляем ряди с пробелами
            foreach (DataGridViewRow row in Search_dataGridView.Rows)
            {
                for (int i = 0; i < Search_dataGridView.Columns.Count; i++)
                {
                    string cellValue = (row.Cells[i].Value ?? "").ToString();
                    sb.Append(cellValue.PadRight(columnWidths[i] + 2));
                }
                sb.AppendLine();
            }
            //записуем в файл
            File.WriteAllText(filePath, sb.ToString());
            MessageBox.Show("Файл був записаний в " + filePath);
        }
        private void Search_Savebtn_Click(object sender, EventArgs e)
        {
            Search_dataGridView.DataSource = null;
            Search_dataGridView.Rows.Clear();
            Search_resultlbl.Text = "_";
        }
        struct Employee
        {
            public string PIB { get; set; }
            public string Posada { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan Arrival { get; set; }
            public TimeSpan Leave { get; set; }
            public TimeSpan WorkDuration { get; set; }

            public Employee(string pib, string posada, DateTime date, TimeSpan arrival, TimeSpan leave, TimeSpan workDuration)
            {
                PIB = pib;
                Posada = posada;
                Date = date;
                Arrival = arrival;
                Leave = leave;
                WorkDuration = workDuration;
            }
        }
    }
}
