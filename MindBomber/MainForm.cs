using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRage
{
    public partial class MainForm : Form
    {
        string[] currentMsgs = { };
        int currentLine = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void fireBtn_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled && hateBox.Text != "")
            {
                currentMsgs = hateBox.Text.Split('\n');
                currentLine = 0;
                timer1.Interval = 2000;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentLine >= currentMsgs.Length)
            {
                timer1.Stop();
                return;
            }

            try
            {
                string msg = currentMsgs[currentLine];

                timer1.Interval = int.Parse(intervBox.Text) + msg.Length * 3;
                Clipboard.SetText(msg);
                SendKeys.Send("^{v}");
                SendKeys.Send("{ENTER}");
            }
            catch (ArgumentNullException) { }

            currentLine++;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When \"Fire artillery!\" is clicked, focus your mouse pointer on the text input so that it can paste the text and send it out to any chat you'd like. This has been tested on Discord and works as it should in a simple way.");
        }
    }
}
