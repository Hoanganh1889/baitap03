using System;
using System.Windows.Forms;

namespace baitap3
{
    internal class EmployeeForm : NhanVien
    {
        public string EmployeeID { get; internal set; }
        public string EmployeeName { get; internal set; }
        public decimal Salary { get; internal set; }
    }
}