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

namespace UniStudentInfo
{
    public partial class DisplayUser : Form
    {
        public DisplayUser()
        {
            InitializeComponent();
        }

        private void DisplayUser_Load(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            textBox1.Text = " ";
            textBox1.Focus();
        }
        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.ShowDialog();
            //this.Close();
            this.Dispose();
        }
        unistdDataContext db;
        private void button1_Click(object sender, EventArgs e)
        {
            db=new unistdDataContext();
            try
            {
                var search_bar = textBox1.Text;

                var check_bar = db.stddatas.FirstOrDefault(l => l.reg_no == search_bar);
                if (check_bar != null) {

                    label8.Text = " " + check_bar.username;
                    label9.Text=" "+check_bar.reg_no;
                    label10.Text=" "+check_bar.batch;
                    label11.Text=" "+check_bar.dep;
                    label12.Text=" "+check_bar.CNIC;
                    label13.Text=" "+check_bar.adr;
                    byte[] std_data_picture=(byte[])check_bar.picture.ToArray();
                    MemoryStream memory = new MemoryStream(std_data_picture);
                    pictureBox1.Image=Image.FromStream(memory);
                    clear();

                
                }
                else
                {
                    label8.Text = "Data Not Found " ;
                    label9.Text = "Data Not Found ";
                    label10.Text = " Data Not Found";
                    label11.Text = " Data Not Found";
                    label12.Text = " Data Not Found";
                    label13.Text = " Data Not Found";
                    clear();
                }


            }
            catch (Exception ex) {
                MessageBox.Show("Error");
            }

        }

        private void aDMINLOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Login admin_Login = new Admin_Login();
            admin_Login.ShowDialog();
        }
    }
}
