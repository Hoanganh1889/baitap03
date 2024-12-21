using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap3
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }
        private void NhanVien_Load(object sender, EventArgs e)
        {
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text) || string.IsNullOrEmpty(txtEmployeeName.Text) || string.IsNullOrEmpty(txtSalary.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                MessageBox.Show("Lương cơ bản phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EmployeeID = txtEmployeeID.Text;
            EmployeeName = txtEmployeeName.Text;
            Salary = salary;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }       
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
