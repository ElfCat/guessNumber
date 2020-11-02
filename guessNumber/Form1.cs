using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace guessNumber
{
    public partial class Form1 : Form
    {
        public int hostNumber;
       

        public Form1()
        {
             Regex myReg = new Regex("[0-9]");
            InitializeComponent();
            btnEnter.Text = "Enter";
            tbUser.Text = "";
            lblComp.Text = "";
            var rand = new Random();
            hostNumber = rand.Next(1, 100);
           
           
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Regex myReg = new Regex("[0-9]");

            if (tbUser.Text == "" || !myReg.IsMatch(tbUser.Text))
                {
                    lblComp.Text = "Enter your number, please~";
            } else 
                {
                if (int.Parse(tbUser.Text) == hostNumber)
                {
                    btnEnter.Enabled = false;
                    lblComp.Text = "You win 🥇🌸🌸🌸!";
                }
                else
                    {
                    if (int.Parse(tbUser.Text) > hostNumber)
                    {
                        lblComp.Text = "Your number is bigger then given";
                    }
                    else
                        {
                        if (int.Parse(tbUser.Text) < hostNumber)
                        {
                            lblComp.Text = "Your number is smaller then given";
                        }

                        }
                    }
             }
        }
    }
}
