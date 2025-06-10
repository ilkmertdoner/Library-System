using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms_Projects.Button_Classes;

namespace Windows_Forms_Projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        } 

        // Maximize locationları ayarla

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
            if(Form1.ActiveForm.WindowState == FormWindowState.Maximized)
            {
                buttonLogin.Width = 250;
                buttonLogin.Height = 80;
                buttonLogin.Location = new Point(630,550);
                buttonLogin.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            minimize.Minimize(this);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            carry.Carry(this, panelCarry);
            carry.Carry(this, panelCarry2);
            carry.Carry(this, panelCarry3);
            carry.Carry(this, panelCarry4);
            panelCarry.BringToFront();
            passwordTxtBox.Text = "Password";
            this.UseWaitCursor = false;
            panelLogin.UseWaitCursor = false;
            panelCarry.UseWaitCursor = false;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Indigo;
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

        private void labelSignup_MouseHover(object sender, EventArgs e)
        {
            labelSignup.Font = new Font(labelSignup.Font, FontStyle.Underline);
        }
        private void labelSignup_MouseLeave(object sender, EventArgs e)
        {
            labelSignup.Font = new Font(labelSignup.Font, FontStyle.Regular);
        }

        private void labelReset_MouseHover(object sender, EventArgs e)
        {
            labelReset.Font = new Font(labelReset.Font, FontStyle.Underline);
        }

        private void labelReset_MouseLeave(object sender, EventArgs e)
        {
            labelReset.Font = new Font(labelReset.Font, FontStyle.Regular);
        }

        private void labelSignup_Click(object sender, EventArgs e)
        {
            SignPanel.Parent = this;
            SignPanel.BringToFront();
            SignPanel.Visible = true;
            panelLogin.Visible = false;
            PanelResetPassword.Visible = false;
        }

        private void labelReset_Click(object sender, EventArgs e)
        {
            PanelResetPassword.Parent = this;
            PanelResetPassword.BringToFront();
            PanelResetPassword.Visible = true;
            panelLogin.Visible = false;
            SignPanel.Visible = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelLogin.Parent = this;
            panelLogin.BringToFront();
            panelLogin.Visible = true;
            SignPanel.Visible = false;
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            panelLogin.Parent = this;
            panelLogin.BringToFront();
            panelLogin.Visible = true;
            PanelResetPassword.Visible = false;
        }
    }
}
