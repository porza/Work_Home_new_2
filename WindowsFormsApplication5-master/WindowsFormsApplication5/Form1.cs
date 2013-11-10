using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string opt1;
            string opt2;
            string opt3;
            string opt4;
             
            if (apt1.Checked == true)
            {
                opt1 = "ชาย" ;


            }
            else  
            {
                opt1= "หญิง" ;

            }

            
            if (bpt1.Checked == true)
            {
                opt2="20-30 ปี";
            }
            else  if (bpt2.Checked == true)
            {
                opt2 = "31-40 ปี" ;
            }
            else if (radioButton1.Checked == true)
            {
                opt2 = "41-50 ปี" ;

            }
            else  
            {
                opt2 = "51 ปีขึ้นไป" ;

            }
         
            if (cpt1.Checked == true)
            {
                opt3 = "ต่ำกว่าปริญญาตรี" ;
            }
            else  if (cpt2.Checked == true)
            {
                  opt3 = "ปริญญาตรี";
            }
            else  if (cpt3.Checked == true)
            {
                opt3 = "ปริญญาโท" ;
            }
           else   
            {
                opt3= "ปริญญาเอก";


            }
            
            if (dpt1.Checked == true)
            {
                opt4 = "ผู้บริหาร" ;
            }
            else  if (dpt2.Checked == true)
            {
                opt4= "อาจารย์" ;
            }
            else  if (dpt3.Checked == true)
            {
                opt4= "เจ้าหน้าที่" ;
            }
            else  if (radioButton5.Checked == true)
            {
               opt4 = "นักศักษาปัจจุบัน" ;
            }
            else if (radioButton6.Checked == true)
            {
              opt4="ศิษย์เก่า" ;
            }
            else  
            {
                opt4 = "ประชาชนทั่วไป";
            }
            Form2 frm = new Form2(opt1, opt2, opt3, opt4);
            frm.Show();
            }
        

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

