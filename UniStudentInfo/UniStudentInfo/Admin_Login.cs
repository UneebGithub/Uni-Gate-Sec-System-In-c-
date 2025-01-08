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
    public partial class Admin_Login : Form
    {
        public static int user_test = 0;
        public Admin_Login()
        {
            
            InitializeComponent();
        }
        public int check_log()
        {
            int login_checker;
            return login_checker=4;
        }
        unistdDataContext db;
        private void button1_Click(object sender, EventArgs e)
        {
            db = new unistdDataContext();
            try
            {
                var user=" ";
                 var   pass=" ";
                
               // MessageBox.Show(" " + user_test);
                
                int checker_lg=check_log();
                if (user_test < checker_lg)
                {
                     user = textBox1.Text;
                     pass = textBox2.Text;
                    user_test += 1;
                }
                else if (user_test == checker_lg)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                }
                

                
                
                var check_vali = db.ADMINLogins.FirstOrDefault(l => l.username == user && l.pass == pass);
                if (check_vali != null)
                {
                    UserADD du= new UserADD();  
                //    DisplayUser du = new DisplayUser();
                    du.ShowDialog();




                }
                else
                {
                    MessageBox.Show("Your Pass or Username is wrong");
                }
            }
            catch (Exception ex) { 
            
            }
    }
    }
}
