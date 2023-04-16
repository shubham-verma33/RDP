using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSTSCLib;

namespace RDP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rdp.Server = txtServerName.Text;    
                rdp.UserName = txtUserName.Text;    

                IMsTscNonScriptable secured = (IMsTscNonScriptable)rdp.GetOcx();
                secured.ClearTextPassword = txtPassword.Text;
                rdp.Connect();

            }

            catch(Exception Ex)
                {
                MessageBox.Show("Error", "error1" + txtServerName.Text + "error:" + Ex.Message,MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
        }


        private void axMsTscAxNotSafeForScripting1_OnConnecting(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(rdp.Connected.ToString() =="1")
                    rdp.Disconnect();

              
            }

            catch(Exception Ex )
            {

                MessageBox.Show("Error", "error1" + txtServerName.Text + "error:" + Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
