namespace baitap3
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhân Viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lương Cơ Bản :";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(140, 24);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(200, 22);
            this.txtEmployeeID.TabIndex = 3;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(140, 69);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(200, 22);
            this.txtEmployeeName.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(140, 117);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(200, 22);
            this.txtSalary.TabIndex = 5;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(102, 165);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(85, 34);
            this.btnDongY.TabIndex = 6;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(223, 165);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 34);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Bỏ Qua";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 225);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnNext;
    }
}