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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvEmployees.Columns.Add("EmployeeID", "Mã NV");
            dgvEmployees.Columns.Add("EmployeeName", "Tên NV");
            dgvEmployees.Columns.Add("Salary", "Lương CB");
        }

        private void InitializeComponent()
        {
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtEmployeeID,
            this.txtEmployeeName,
            this.txtSalary});
            this.dgvEmployees.Location = new System.Drawing.Point(12, 55);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(491, 150);
            this.dgvEmployees.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(557, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(557, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.HeaderText = "MSNV";
            this.txtEmployeeID.MinimumWidth = 6;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Width = 125;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.HeaderText = "Tên NV";
            this.txtEmployeeName.MinimumWidth = 6;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Width = 125;
            // 
            // txtSalary
            // 
            this.txtSalary.HeaderText = "Lương CB";
            this.txtSalary.MinimumWidth = 6;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Width = 125;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(701, 332);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
                string msnv = employeeForm.EmployeeID;
                string name = employeeForm.EmployeeName;
                decimal salary = employeeForm.Salary;
                dgvEmployees.Rows.Add(msnv, name, salary);
            }
        }
    }
}
