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
    public partial class InsertStudent : Form
    {
        StudentDetails s;
        public InsertStudent(StudentDetails sd)
        {
            InitializeComponent();
            s = sd;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtdob.Text == "" || txtgpa.Text == "" || txtname.Text == "")
            {


                MessageBox.Show("Fields can not be null");
                return;

            }


             DateTime result;
            try
            {

                Double.Parse(txtgpa.Text);

            }
            catch
            {

                MessageBox.Show("GPA value is not valid");
                    return;

            }
            var success = DateTime.TryParse(txtdob.Text, out result);


            if (success.ToString() == "False")
            {

                MessageBox.Show("Date(date of birth) is not in valid format");
                return;
            }
            
            
            String active="flase";
            if(cboxactive.Checked)
            {

                active="true";
            }


            s.change(txtname.Text, txtdob.Text.Trim(), Convert.ToDouble(txtgpa.Text.Trim()), active);
            txtname.Text = "";
            txtdob.Text = "";
            txtgpa.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
