using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDevkitPlusPlus;
using XRPCLib;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using MetroFramework.Animation;

namespace NFS_MW_RTE_Tool
{
    public partial class Form1 : MetroForm
    {

        XRPC Jtag = new XRPC();

        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectConsole_Click(object sender, EventArgs e)
        {
            try
            {
                Jtag.Connect();
                if (Jtag.activeConnection == true)
                {
                    MessageBox.Show("Connected To Console", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setMoney.Enabled = true;
                    setBounty.Enabled = true;
                    moneyValue.Enabled = true;
                    bountyValue.Enabled = true;
                }
                else
                {
                    MessageBox.Show("XRPC Connection Failed", "Connected Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("XBDM Connection Failed", "Connected Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetMoney_Click(object sender, EventArgs e)
        {
            try
            {
                Jtag.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xCD63F09C), Convert.ToInt32(moneyValue.Text));
            }
            catch(Exception ec)
            {
                MessageBox.Show("Please Enter A Number Value", "Connected Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetBounty_Click(object sender, EventArgs e)
        {
            try
            {
                Jtag.xbCon.DebugTarget.WriteInt32(Convert.ToUInt32(0xCCB24414), Convert.ToInt32(bountyValue.Text));
            }
            catch(Exception ec)
            {
                MessageBox.Show("Please Enter A Number Value", "Connected Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
