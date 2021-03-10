using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffParser
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;

            foreach (string line in txtInput.Text.Split('\n'))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    if (line[0] != '-')
                    {
                        string newLine = line;
                        if (line[0] == '+')
                        {
                            newLine = line.Substring(1).Insert(0, " ");
                        }

                        txtOutput.Text += newLine + "\n";
                    }
                }
            }
        }
    }
}
