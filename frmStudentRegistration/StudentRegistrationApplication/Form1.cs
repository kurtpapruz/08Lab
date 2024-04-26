using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                DayBox.Items.Add(i);
            }
            ArrayList month = new ArrayList();
            month.Add("January");
            month.Add("February");
            month.Add("March");
            month.Add("April");
            month.Add("May");
            month.Add("June");
            month.Add("July");
            month.Add("August");
            month.Add("September");
            month.Add("October");
            month.Add("November");
            month.Add("December");

            for (int i = 0; i < 12; i++)
            {
                MonthBox.Items.Add(month[i]);
            }
            int crYear = DateTime.Now.Year;
            for (int i = 1900; i <= crYear; i++)
            {
                YearBox.Items.Add(i);
            }

            ArrayList programs = new ArrayList();
            programs.Add("Bachelor of Scince in Information Technology");
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information System");
            programs.Add("Bachelor of Science in Computer Engineering");

            foreach (String program in programs)
            {
                ProgramBox.Items.Add(program);
            }


        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string Lname = LastNameBox.Text;
            string Fname = FirstNameBox.Text;
            string Mname = MiddleNameBox.Text;
            string gender;
            string Program = ProgramBox.Text;
            string Month = MonthBox.Text;
            string Year = YearBox.Text;
            string Day = DayBox.Text;

            if (Male.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            MessageBox.Show("Student Name: " + Lname + ", " + Fname + " " + Mname + "." +
            "\nDate of Birth: " + DayBox.Text + "/" + MonthBox.Text + "/" + YearBox.Text + "\nGender: " + gender + "\nProgram: " + ProgramBox.Text);
        }
       

    
         public void info1(string name, string Program, string Gender)
         {
            string Lname = LastNameBox.Text;
            string Fname = FirstNameBox.Text;
            string gender;
           
            if (Male.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            MessageBox.Show("Student Name: " + Lname + ", " + Fname + " "  +
            "\nGender: " + gender + "\nProgram: " + ProgramBox.Text);
         }

        public void info2(string name, string Program)
        {
            string Lname = LastNameBox.Text;
            string Fname = FirstNameBox.Text;
            

            MessageBox.Show("Student Name: " + Lname + ", " + Fname + " " +
            "\nProgram: " + ProgramBox.Text);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();    
            OpenFileDialog openPogi = new OpenFileDialog();
            openPogi.ShowDialog(this);
          
            if (openPogi.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(openPogi.FileName); 
            }
        }
    }
}
