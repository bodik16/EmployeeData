using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            for (int i = 0; i < Data.Employees.Count; i++)
            {
                treeView1.Nodes.Add(Data.Employees[i].ToString());
            }
            CountOfEmployeesValueLabel.Text = Data.Employees.Count.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            int counter = 0;
            if (SearchTextBox.Text != "")
            {
                string txt = SearchTextBox.Text.ToLower();
                for (int i = 0; i < Data.Employees.Count; i++)
                {
                    if (Data.Employees[i].EmployeeFirstName.ToLower().Contains(txt) || Data.Employees[i].EmployeeLastName.ToLower().Contains(txt) ||
                        Data.Employees[i].EmployeeFathersName.ToLower().Contains(txt) || Data.Employees[i].EmployeeID.ToString().ToLower().Contains(txt))
                    {
                        treeView1.Nodes.Add(Data.Employees[i].ToString());
                        counter = counter + 1;
                    }
                }
                CountOfEmployeesValueLabel.Text = Convert.ToString(counter);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (_editcheckBox.Checked == true)
            {
                _fathersNametextBox.ReadOnly = false;
                _firstNametextBox.ReadOnly = false;
                _lastNametextBox.ReadOnly = false;
                _salarynumericUpDown.ReadOnly = false;
                _editButton.Visible = true;
            }
            else if (_editcheckBox.Checked == false)
            {
                _fathersNametextBox.ReadOnly = true;
                _firstNametextBox.ReadOnly = true;
                _lastNametextBox.ReadOnly = true;
                _salarynumericUpDown.ReadOnly = true;
                _editButton.Visible = false;
            }
        }

        private void _editButton_Click(object sender, EventArgs e)
        {
            string txt = "";
            for (int i = 0; i < Data.Employees.Count; i++)
            {
                if (Data.Employees[i].EmployeeID.ToString() == _idtextBox.Text)
                {
                    Data.Employees[i].EmployeeFirstName = _firstNametextBox.Text;
                    Data.Employees[i].EmployeeLastName = _lastNametextBox.Text;
                    Data.Employees[i].EmployeeFathersName = _fathersNametextBox.Text;
                    Data.Employees[i].SalaryPerHour = _salarynumericUpDown.Value;
                }
            }
            MessageBox.Show("You have successfully edited employee info");


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string txt = treeView1.SelectedNode.Text;

            for (int i = 0; i < Data.Employees.Count; i++)
            {
                if (txt == Data.Employees[i].ToString())
                {
                    _fathersNametextBox.Text = Data.Employees[i].EmployeeFathersName;
                    _firstNametextBox.Text = Data.Employees[i].EmployeeFirstName;
                    _lastNametextBox.Text = Data.Employees[i].EmployeeLastName;
                    _idtextBox.Text = Data.Employees[i].EmployeeID.ToString();
                    _salarynumericUpDown.Value = Data.Employees[i].SalaryPerHour;
                }
            }

            if (treeView1.Nodes.Count >= 1)
            {
                SackAnEmployeeButton.Enabled = true;
            }

        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeegroupBox.Visible = true;
            Hirebutton.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool exist = false;
            for (int i = 0; i < Data.Employees.Count; i++)
            {
                if (Data.Employees[i].EmployeeID.ToString() != _idtextBoxAdd.Value.ToString())
                {
                    exist = false;
                }
                else if (Data.Employees[i].EmployeeID.ToString() == _idtextBoxAdd.Value.ToString())
                {
                    exist = true;
                    break;
                }
            }
            if (exist == true)
            {
                MessageBox.Show("Inputed ID has already taken!");
            }
            else if (exist == false)
            {
                long id = (long)_idtextBoxAdd.Value;
                Employee employee = new Employee(id, _firstNametextBoxAdd.Text, _lastNametextBoxAdd.Text, _fathersNametextBoxAdd.Text, _salarynumericUpDownAdd.Value);
                Data.Employees.Add(employee);
                MessageBox.Show($"New employee has already successfully added to our friendly team!\n{employee.ToString()}");
            }
            _firstNametextBoxAdd.Text = "";
            _fathersNametextBoxAdd.Text = "";
            _lastNametextBoxAdd.Text = "";
            _salarynumericUpDownAdd.Value = _salarynumericUpDownAdd.Minimum;
            _idtextBoxAdd.Value = _idtextBoxAdd.Minimum;
            AddEmployeegroupBox.Visible = false;
        }

        private void _firstNametextBoxAdd_TextChanged(object sender, EventArgs e)
        {
            if (_firstNametextBoxAdd.Text == "")
            {
                Hirebutton.Enabled = false;
            }
            else if (_fathersNametextBoxAdd.Text != "" && _lastNametextBoxAdd.Text != "" && _firstNametextBoxAdd.Text != "")
            {
                Hirebutton.Enabled = true;
            }
        }

        private void _lastNametextBoxAdd_TextChanged(object sender, EventArgs e)
        {

            if (_lastNametextBoxAdd.Text == "")
            {
                Hirebutton.Enabled = false;
            }
            else if (_fathersNametextBoxAdd.Text != "" && _lastNametextBoxAdd.Text != "" && _firstNametextBoxAdd.Text != "")
            {
                Hirebutton.Enabled = true;
            }
        }

        private void _fathersNametextBoxAdd_TextChanged(object sender, EventArgs e)
        {

            if (_fathersNametextBoxAdd.Text == "")
            {
                Hirebutton.Enabled = false;
            }
            else if (_fathersNametextBoxAdd.Text != "" && _lastNametextBoxAdd.Text != "" && _firstNametextBoxAdd.Text != "")
            {
                Hirebutton.Enabled = true;
            }
        }

        private void _idtextBoxAdd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployeegroupBox.Visible = false;
            _firstNametextBoxAdd.Text = "";
            _fathersNametextBoxAdd.Text = "";
            _lastNametextBoxAdd.Text = "";
            _salarynumericUpDownAdd.Value = _salarynumericUpDownAdd.Minimum;
            _idtextBoxAdd.Value = _idtextBoxAdd.Minimum;
            AddEmployeegroupBox.Visible = false;
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (treeView1.Nodes.Count == 0)
            {
                SackAnEmployeeButton.Enabled = false;

            }
        }

        private void SackAnEmployeeButton_Click(object sender, EventArgs e)
        {
            string txt = treeView1.SelectedNode.Text;

            for (int i = 0; i < Data.Employees.Count; i++)
            {
                if (txt == Data.Employees[i].ToString())
                {
                    DialogResult dialogResult = MessageBox.Show("Are you shure that you want to sack an employee", "Sack an employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show($"An employee was successfully sacked from our company!\n{Data.Employees[i].ToString()}");
                        Data.Employees.Remove(Data.Employees[i]);
                        break;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing
                    }
                    //MessageBox.Show("Are you shure that you want to sack an employee", "Sack an employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                }
            }
            treeView1.Nodes.Clear();
            SearchTextBox.Text = "";
            _firstNametextBox.Text = "";
            _lastNametextBox.Text = "";
            _fathersNametextBox.Text = "";
            _idtextBox.Text = "";
            _salarynumericUpDown.Value = _salarynumericUpDown.Minimum;
        }
        private decimal CalcAverageSalary()
        {
            decimal sum = 0;
            decimal aver = 0;
            for (int i = 0; i < Data.Employees.Count; i++)
            {
                sum = sum + Data.Employees[i].SalaryPerHour;
            }
            aver = sum / Data.Employees.Count;
            return aver;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            AverageSalaryValueLabel.Text = String.Format("{0:0.00}", CalcAverageSalary()).ToString();

        }

        private void AverageSalaryValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddEmployeegroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AverageSalaryLabel_Click(object sender, EventArgs e)
        {

        }

        private void CountOfEmployeesValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void CountOfEmployeesLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            AverageSalaryValueLabel.Text = String.Format("{0:0.00}", CalcAverageSalary()).ToString();
        }
        string FileName = "XmlFileName.xml";
        private void SerializeButton_Click(object sender, EventArgs e)
        {
            if ((File.Exists(FileName)))
            {
                File.Delete(FileName);
            }
            SerializeerClass.SerializeObject(Data.Employees, FileName);
        }

        private void DeserializeButton_Click(object sender, EventArgs e)
        {
            SerializeerClass.Deserialize(Data.Employees, FileName);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string FileName = "WriteFile.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(FileName))
                {
                    for (int i = 0; i < Data.Employees.Count; i++)
                    {
                        sw.Write($"{Data.Employees[i].ToString()}\n");
                    }

                }
                MessageBox.Show("Successfully done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
