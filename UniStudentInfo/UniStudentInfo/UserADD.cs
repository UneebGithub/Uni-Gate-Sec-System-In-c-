using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniStudentInfo
{
    public partial class UserADD : Form
    {
        public UserADD()
        {
            InitializeComponent();
        }

        unistdDataContext db;
        private void button1_Click(object sender, EventArgs e)
        {
            db=new unistdDataContext();
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
                    Title = "Select a Picture"
                };

                byte[] pictureData = null;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader binaryReader = new BinaryReader(fileStream))
                        {
                            pictureData = binaryReader.ReadBytes((int)fileStream.Length);
                        }
                    }
                }
                stddata stddata = new stddata();
                stddata.username=textBox2.Text;
                stddata.reg_no= textBox3.Text;
                stddata.batch=Convert.ToInt32(textBox4.Text);
                stddata.dep= textBox5.Text;
                stddata.CNIC=Convert.ToInt64(textBox6.Text);
                stddata.adr=textBox7.Text;
                stddata.picture=pictureData;
                db.stddatas.InsertOnSubmit(stddata);
                db.SubmitChanges();
                MessageBox.Show("DATA ADDED SUCCESSFULLY");
                // stddata.reg_no = reg;
                Clear();

            }
            catch (Exception ex) { 
            
            
            }
        }
        private void Clear()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
                
        }
        private void button2_Click(object sender, EventArgs e)
        {
            db=new unistdDataContext();
            try
            {
                var sb=textBox1.Text;

                var check = db.stddatas.FirstOrDefault(d => d.reg_no == sb);
                if (check != null) { 
                        
                    db.stddatas.DeleteOnSubmit(check);
                    db.SubmitChanges();
                    MessageBox.Show("Delete Successfully");
                    Clear();

                
                }
            }
            catch (Exception ex) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db = new unistdDataContext();
            var check_Rn = textBox1.Text;
            var check_bar = db.stddatas.FirstOrDefault(s => s.reg_no == check_Rn);
            if (check_bar != null) {
                textBox2.Text = check_bar.username;
            textBox3.Text= check_bar.reg_no;
            textBox4.Text=  check_bar.batch.ToString();
            textBox5.Text=  check_bar.dep;
            textBox6.Text= check_bar.CNIC.ToString();
             textBox7.Text=  check_bar.adr;
                byte[] std_data_picture = (byte[])check_bar.picture.ToArray();
                MemoryStream memory = new MemoryStream(std_data_picture);
                pictureBox1.Image = Image.FromStream(memory);
            } }

        private void button3_Click(object sender, EventArgs e)
        {
            var check_Rn = textBox1.Text;
            var check_bar = db.stddatas.FirstOrDefault(s => s.reg_no == check_Rn);
            if (check_bar != null)
            {
                check_bar.username=textBox2.Text  ;
                check_bar.reg_no= textBox3.Text;
                 check_bar.batch = Convert.ToInt32(textBox4.Text);
                check_bar.dep= textBox5.Text;
                check_bar.CNIC= Convert.ToInt64(textBox6.Text);
                check_bar.adr= textBox7.Text; 
                db.SubmitChanges();
                MessageBox.Show("Data Save Successfully");
                Clear();
            }
            }
    }
}
