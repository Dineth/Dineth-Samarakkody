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
    public partial class StudentDetails : Form
    {
        private DataTable Dt = new DataTable();
       
         
        public StudentDetails()
        {
            InitializeComponent();
            Dt.Columns.Add("name",typeof(String));
            Dt.Columns.Add("dob", typeof(String));
            Dt.Columns.Add("gpa", typeof(String));
            Dt.Columns.Add("active", typeof(String));

            dgwresult.DataSource = DbFunctions.getStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            InsertStudent ls=new InsertStudent(this);
            ls.Show();
            
            
           

        }
        public void change(String name,String Dob,Double gpa,String active)
        {

            Dt.Rows.Add(name, Dob,gpa,active);
            dgwlist.DataSource = Dt;

        }

        private void btnsave_Click(object sender, EventArgs e)

           {
               if (dgwlist.Rows.Count == 0)
               {

                   MessageBox.Show("Please Add Students");

               }

            for (int i = 0; i < dgwlist.Rows.Count; i++)
            {



                String name = dgwlist.Rows[i].Cells["Names"].Value.ToString();

                String dob = dgwlist.Rows[i].Cells["Dob"].Value.ToString();
                Double gpa = Convert.ToDouble(dgwlist.Rows[i].Cells["GPAvg"].Value);
                String active = dgwlist.Rows[i].Cells["Active"].Value.ToString();
                if (!DbFunctions.insertStudent(name, dob, gpa, active)) 
                {

                    MessageBox.Show("Database problem occured while trying to insert record " + i + ".");
                    dgwresult.DataSource = DbFunctions.getStudents();
                    return;
                }
              

                    

                    dgwresult.DataSource = DbFunctions.getStudents();
            }
                  MessageBox.Show("Records have been successfuly saved");
                  Dt.Clear();
                  dgwlist.DataSource = Dt;
        }
     
        private void StudentDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
