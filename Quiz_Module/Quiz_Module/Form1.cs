using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Module
{
    public partial class Form1 : Form
    {
        public static string[] ques;
        public static string[] ans;
        public static int co=0;
        public static int score = 0;
        public static string temp;
        public Form1()
        {
            InitializeComponent();
            label7.Visible = false;
            int c = 0;
            label1.Location = new Point(80, 85);
            label1.Font = new Font("Arial", 40, FontStyle.Bold);
            AutoScroll = true;
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Public\\questions.txt");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                c++;
            }
            file.Close();
            ques = new string[c];
            ans = new string[5 * c];
            
            c = 0;
            System.IO.StreamReader file1 = new System.IO.StreamReader("C:\\Users\\Public\\questions.txt");
            while ((line = file1.ReadLine()) != null)
            {
                ques[c] = line;
                c++;
            }
            file1.Close();
            string[] temp;
            List<string> ans2 = new List<string>();
            System.IO.StreamReader file2 = new System.IO.StreamReader("C:\\Users\\Public\\options.txt");
            while ((line = file2.ReadLine()) != null)
            {
                temp=line.Split(';');
                for (int i = 0; i < 5; i++)
                {
                    ans2.Add(temp[i]);
                }
                
            }
            ans = ans2.ToArray();

            textBox1.Text = "0";
            Construct();
        }
        public void Construct()
        {
            if(co<ques.Length)
            { 
            label1.Text = ques[co];
            label2.Text = ans[((co + 1) * 5) - 5];
            label3.Text = ans[((co + 1) * 5) - 4];
            label4.Text = ans[((co + 1) * 5) - 3];
            label5.Text = ans[((co + 1) * 5) - 2];
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
               button6.Visible=false;
               textBox1.Visible = false;
               label7.Text = label7.Text + score;
               label7.Visible = true;

                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            co++; Construct();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            temp = button1.Text;
            button1.Enabled = false;

            if (ans[((co + 1) * 5) - 1].Equals(temp))
            {

                score++; textBox1.Text = score.ToString();
                label2.BackColor = Color.Green;
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                label5.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            { score--; textBox1.Text = score.ToString();
            label2.BackColor = Color.Red;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = button2.Text;
            button2.Enabled = false;
            if (ans[((co + 1) * 5) - 1].Equals(temp))
            {

                score++; textBox1.Text = score.ToString();
                label3.BackColor = Color.Green;
                label2.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                label5.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            { score--; textBox1.Text = score.ToString();
            label3.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = button3.Text;
            button3.Enabled = false;
            if (ans[((co + 1) * 5) - 1].Equals(temp))
            {

                score++; textBox1.Text = score.ToString();
                label4.BackColor = Color.Green;
                label3.BackColor = Color.Red;
                label2.BackColor = Color.Red;
                label5.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            { score--; textBox1.Text = score.ToString();
            label4.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temp = button4.Text;
            button4.Enabled = false;
            if (ans[((co + 1) * 5) - 1].Equals(temp))
            {

                score++; textBox1.Text = score.ToString();
                label5.BackColor = Color.Green;
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                label2.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else
            { score--; textBox1.Text = score.ToString();
            label5.BackColor = Color.Red;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
