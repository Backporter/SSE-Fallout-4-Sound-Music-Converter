using System;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SSE_Fallout_4_Sound_Music_Converter
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/twpSyYp");
        }
    }
}
