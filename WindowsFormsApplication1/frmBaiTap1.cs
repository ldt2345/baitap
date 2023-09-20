using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmBaiTap1 : Form
    {
        public frmBaiTap1()
        {
            InitializeComponent();
        }


        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must Enter Your Name");
            else
                this.errorProvider1.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;
            age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
            MessageBox.Show("My name is:" + txtYourName.Text + "\n" + "Age: " + age.ToString() + "\n");
        }

        private void frmBaiTap1_Load(object sender, EventArgs e)
        {

        }

        private void frmBaiTap1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn đóng form không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "This is not avalid number");
            else
                this.errorProvider1.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }

      
    }
}
