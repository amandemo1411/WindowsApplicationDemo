using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplicationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string employeeName = txtName.Text.Trim();
            int salary = Convert.ToInt32(txtSalary.Text.Trim());
            bool response = ProcessEmployee.ProcessEmployeeData(employeeName, salary);
            if (response)
                MessageBox.Show("Data has been added");
            else
                MessageBox.Show("Issue while saving data");
        }
    }
}
