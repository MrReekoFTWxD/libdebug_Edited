using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using libdebug;

namespace libDebugEdited_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public PS4DBG ps4 = new PS4DBG();

        private void button1_Click(object sender, EventArgs e)
        {
            if (ps4.IsConnected)
                return;

            ps4.Connect();
            ps4.Notify(222, "Connected!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ps4.Reboot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ps4.Disconnect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ps4.Notify(222, textBox1.Text);
        }
    }
}
