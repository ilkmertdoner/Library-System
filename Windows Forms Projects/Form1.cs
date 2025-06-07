using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms_Projects.Button_Classes;
using System.Runtime.InteropServices;

namespace Windows_Forms_Projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        } 

        buttonClose close = new buttonClose();
        buttonMaximize maximize = new buttonMaximize();
        buttonMinimize minimize = new buttonMinimize();
        AppCarry carry = new AppCarry();
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            close.Close(this);
            
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            maximize.Maximize(this);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            minimize.Minimize(this);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            carry.Carry(this, panelCarry);
            carry.Carry(this, panelCarry2);
            panelCarry.BringToFront();
            passwordTxtBox.Text = "Password";
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.DarkSlateBlue;
        }

        private void nameTxtBox_Click(object sender, EventArgs e)
        {
            if (nameTxtBox.Text == "Username") 
            { 
                nameTxtBox.Text = "";
            }
        }

        private void nameTxtBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nameTxtBox.Text))
            {
                nameTxtBox.Text = "Username";
            }
        }

        private void passwordTxtBox_Click(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "Password")
            {
                passwordTxtBox.Text = "";
            }
        }

        private void passwordTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTxtBox.Text))
            {
                passwordTxtBox.Text = "Password";
            }
        }
    }
}
