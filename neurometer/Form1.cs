using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neurometer
{
    public partial class Form1 : Form
    {
        bool isStart = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isStart = true;
            times.Text = "0";
            timer1.Enabled = true;
            
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (isStart == true)
            {
                isStart = false;
                Console.Beep(1500, 600);
                MessageBox.Show("Game Over! Your Times"+" "+times.Text + "\n" + "Your Score Is: " + score.Text);
                score.Text = "0";
                timer1.Enabled = false;
            }

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (isStart == true)
            {
                MessageBox.Show("You Win Your Times: "+" "+times.Text + "\n" + "Your Score Is: " + score.Text);
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            times.Text = (int.Parse(times.Text)+1).ToString();
            score.Text = (int.Parse(score.Text) + 1).ToString();
        }
    }
}
