using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int TotalBill = 0;
        int TotalProducts = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int ee =0;            
        int  fd = 0;

        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if(checkBox1.Checked==true)
            {
                numericUpDown1.Enabled = true;
                comboBox1.Enabled = true;
                numericUpDown1.Visible= true;
                comboBox1.Visible = true;
                TotalProducts++;
               
            }
            else
            {
                numericUpDown1.Enabled = false; 
                    comboBox1.Enabled = false;
                TotalProducts--;
            }

            label3.Text = "Apple";
            
           

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked==true)
            {
                numericUpDown2.Enabled = true;
                comboBox2.Enabled = true;
                numericUpDown2.Visible = true;
                comboBox2.Visible= true;
                TotalProducts ++; ;
            }
            else
            {
                numericUpDown2.Enabled= false;
                comboBox2.Enabled = false;
                TotalProducts--;
            }
            label4.Text = "Orange";
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked==true)
            {
                numericUpDown3.Enabled= true;
                comboBox3.Enabled = true;
                numericUpDown3.Visible = true;
                comboBox3.Visible= true;
                         TotalProducts ++ ;
                
            }
            else
            {
                numericUpDown3.Enabled = false;
                comboBox3.Enabled = false;
                TotalProducts--;
            }
            label5.Text = "Mango";
       
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked==true)
            {
                numericUpDown4.Enabled = true;
                comboBox4.Enabled = true;
                numericUpDown4.Visible = true;
                comboBox4.Visible = true;
                TotalProducts ++;
            }
            else
            {
                numericUpDown4.Enabled= false;
                comboBox4.Enabled = false;
                TotalProducts--;
            }
            label6.Text = "Peach";
    
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox5.Checked==true)
            {
                numericUpDown5.Enabled = true;
                comboBox5.Enabled = true;
                numericUpDown5.Visible = true;
                comboBox5.Visible = true;
                TotalProducts ++;
            }
            else
            {
                numericUpDown5.Enabled= false;
                comboBox5.Enabled = false;
                TotalProducts--;
            }
            label8.Text = "PineApple";
       
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked==true)
            {
                numericUpDown6.Enabled= true;
                comboBox6.Enabled = true;
          
                TotalProducts ++;
            }
            else
            {
                numericUpDown6.Enabled= false;
                comboBox6.Enabled = false;
               
                TotalProducts--;
            }
            label9.Text = "Strawbery";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TotalBill = 0;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            ee = 0;
            fd = 0;
            if(checkBox1.Checked==true)
                {
                checkBox1.Checked=false;
            }
            if(checkBox2.Checked==true)
            {
                checkBox2.Checked = false;
            }
            if(checkBox3.Checked=true)
            {
                 checkBox3.Checked=false;
            }
            if(checkBox4.Checked=true)
            {
                checkBox4.Checked=false;
            }
            if(checkBox5.Checked=true)
            {
                checkBox5.Checked=false;
            }
            if(checkBox6.Checked=true)
            {
                checkBox6.Checked=false;
            }
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label24.Text = "";
            label25.Text = "";
            label30.Text = "Time";
            numericUpDown1.ResetText();
            numericUpDown2.ResetText();
            numericUpDown3.ResetText();
            numericUpDown4.ResetText();
            numericUpDown5.ResetText();
            numericUpDown6.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox5.ResetText();
            comboBox6.ResetText();
      
                                }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
    
       
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            int AplQuant = Convert.ToInt32(numericUpDown1.Value);
            label10.Text = AplQuant.ToString();
            if (comboBox1.SelectedIndex==0)
            {

                a = +200*AplQuant;
                label16.Text=a.ToString();
            
            }
          if(comboBox1.SelectedIndex==1)
            {

                a =+ 150*AplQuant;
                label16.Text = a.ToString();
            }

            TotalBill += a;
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String AplQual = Convert.ToString(comboBox2.Text);
            label17.Text = AplQual.ToString();
            int OrangQuant = Convert.ToInt32(numericUpDown2.Value);
            label11.Text = OrangQuant.ToString();
            if (comboBox2.SelectedIndex==0)
            {
                b += 300*OrangQuant;
                label17.Text=b.ToString();
                
            }
          if (comboBox2.SelectedIndex==1)
            {
                b = +200*OrangQuant;
                label17.Text = b.ToString();
            }
            TotalBill += b;
        }

     

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String AplQual = Convert.ToString(comboBox3.Text);
            label18.Text = AplQual.ToString();
            int mango = Convert.ToInt32(numericUpDown3.Value);
            label12.Text = mango.ToString();
            if (comboBox3.SelectedIndex == 0)
            {
                c += 150*mango;
                label18.Text = c.ToString();

                
            }
           if(comboBox3.SelectedIndex == 1)
            {
       
                c = +120*mango;
                label18.Text = c.ToString();

            }
         TotalBill += c;
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String AplQual = Convert.ToString(comboBox4.Text);
            label19.Text = AplQual.ToString();
            int peach = Convert.ToInt32(numericUpDown4.Value);
            label13.Text = peach.ToString();
            if (comboBox4.SelectedIndex == 0)
            {
                d += 250*peach;
                label19.Text=d.ToString();

            }
            if (comboBox4.SelectedIndex == 1)
            {

                d =+ 200*peach;
                label19.Text = d.ToString();

            }
          
            TotalBill += d;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            String AplQual = Convert.ToString(comboBox5.Text);
            label20.Text = AplQual.ToString();
            int pineApple = Convert.ToInt32(numericUpDown5.Value);
            label14.Text = pineApple.ToString();
            if (comboBox5.SelectedIndex == 0)
            {
                ee += 1000*pineApple;
                label20.Text = ee.ToString();

            }
            if (comboBox5.SelectedIndex == 1)
            {

                ee =+ 800*pineApple;
                label20.Text = ee.ToString();

            }
     TotalBill += ee;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            String AplQual = Convert.ToString(comboBox6.Text);
            label21.Text = AplQual.ToString();
            int straw = Convert.ToInt32(numericUpDown6.Value);
            label15.Text = straw.ToString();
            if (comboBox6.SelectedIndex == 0)
            {
                fd += 90*straw;
                label21.Text = fd.ToString();

            }
            if (comboBox6.SelectedIndex == 1)
            {

                fd =+ 60*straw;
                label21.Text = fd.ToString();

            }
          
            TotalBill += fd;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {  if(radioButton1.Checked==true)
            {
                TotalBill += 20;
                
            }
   
            
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label25.Text = TotalBill.ToString();
            label30.Text = DateTime.Now.ToString("hh:mm:ss tt");
            label24.Text = TotalProducts.ToString();
            groupBox1.Visible = true;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}