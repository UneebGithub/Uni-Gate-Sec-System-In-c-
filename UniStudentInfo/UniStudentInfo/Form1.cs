using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniStudentInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        unistdDataContext db;
        private void button1_Click(object sender, EventArgs e)
        {
            db=new unistdDataContext();
            try
            {
                var user=textBox1.Text;
                var pass=textBox2.Text;

                var check_vali = db.Logins.FirstOrDefault(l => l.username == user && l.pass == pass);
                if (check_vali != null)
                {
                    DisplayUser du=new DisplayUser();
                    du.ShowDialog();




                }
                else
                {
                    MessageBox.Show("Your Pass or Username is wrong");
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

        }
    }
}
