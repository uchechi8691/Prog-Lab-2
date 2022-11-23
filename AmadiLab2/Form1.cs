using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmadiLab2
{               //Name:Uchechi Amadi
                //Date:06/10/2022
                //This lab is our first program designed to test our knowledge.
                
    public partial class amadiLab2 : Form
    {
        public amadiLab2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPicture_Click_Click(object sender, EventArgs e)
        {
            //Show picture box
            picUche.Show();
            lblText.Hide();
        }

        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void btnHide_Click_Click(object sender, EventArgs e)
        {
            //hide label and picture box
            lblText.Visible = false;
            picUche.Hide();

            //reset label to blank
            lblText.ResetText();

        }

        private void btnData_Click_Click(object sender, EventArgs e)
        {
            //put answer in label and display
            lblText.Text = "My Name is Uche. I was born in Lagos, Nigeria where I\n" +
                "had lived for the past 35yrs before coming to New Brunswick for school.\n\n" +
                "I am currently a student of NBCC studying in the ITPA program. It is an exciting\n" +
                "program and the first few weeks have so far, been challenging.\n" +
                "Learning to code and design websites for the first time has not been an easy feat\n" +
                "and I must admit that it has been a bit overwhelming. Nevertheless, we keep pushing.\n\n" +
                "I hope to enjoy the rest of the program because I have a great Teacher like Cathy";
            lblText.Visible = true;
            picUche.Hide();
        }

        private void btnCalculate_Click_Click(object sender, EventArgs e)
        {
            //declare two local variables-integers
            int Operand1, Operand2;

            //declare answer as double
            double answer;

            //read from text boxes, put in two integers - conversion required
            Operand1 = Convert.ToInt32(textBox1.Text);
            Operand2 = Convert.ToInt32(textBox2.Text);

            //put operator in the label
            lblAnswer.Text = btnCalculate_Click.Text;

            //do the math - must cast one of the operands
            answer = Operand1 * (double)Operand2;

            //display the answers - conversion required - formatting
            //format string: 1st character letter, 2nd number
            lblAnswer.Text = answer.ToString("f2");

        }

        private void btnReset_Click_Click(object sender, EventArgs e)
        {
            //Reset label to blank
             lblAnswer.ResetText();
            textBox1.ResetText();
            textBox2.ResetText();
            textBox1.Focus();



        }

        private void picUche_Click(object sender, EventArgs e)
        {
            //comment
            MessageBox.Show("This is my humble and blessed self");
        }
    }
}
