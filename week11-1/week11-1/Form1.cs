using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("save");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("save");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("open");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is a simple of menus in c#","About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormatColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem.Checked)
            {
                redToolStripMenuItem.Checked = false;
                blueToolStripMenuItem.Checked = false;
                greenToolStripMenuItem.Checked = false;

                menuItem.Checked = true;
                label1.ForeColor = menuItem.ForeColor;
            }
            else
            {
                label1.ForeColor = Color.Black;
            }
        }
        private void FormatFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem.Checked)
            {
                tahomaToolStripMenuItem.Checked = false;
                timesNewRomanToolStripMenuItem.Checked = false;
                courierNewToolStripMenuItem.Checked = false;

                menuItem.Checked = true;
                label1.Font = new Font(menuItem.Tag.ToString(), label1.Font.Size);
            }
            else
            {
                label1.Font = new Font("Microsoft Sans Serif", label1.Font.Size);
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, label1.Font.Style ^ FontStyle.Bold);
        }

        private void ıtalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, label1.Font.Style ^ FontStyle.Italic);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(239, 105);
            label.Text = txtContent.Text;
            label.ContextMenuStrip = contextMenuStrip1;

            TabPage tab = new TabPage(txtHeader.Text);
            tab.BackColor = Color.AntiqueWhite;
            tab.Controls.Add(label);

            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Loading... ";
            toolStripProgressBar1.Visible = true;
            for (int i = 0; i < toolStripProgressBar1.Maximum; i++)
            {
                toolStripProgressBar1.Value = i;
                toolStripStatusLabel1.Text = $"Loading... ({100 * i / toolStripProgressBar1.Maximum}%)";
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }

            toolStripStatusLabel1.Text = "Ready";
            toolStripProgressBar1.Visible = false;
        }

        private void uploadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Loading... ";
            toolStripProgressBar1.Visible = true;
            for (int i = 0; i < toolStripProgressBar1.Maximum; i++)
            {
                toolStripProgressBar1.Value = i;
                toolStripStatusLabel1.Text = $"Loading... ({100 * i / toolStripProgressBar1.Maximum}%)";
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }

            toolStripStatusLabel1.Text = "Ready";
            toolStripProgressBar1.Visible = false;
        }

        private void changeTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;

            Label label = contextMenuStrip1.SourceControl as Label;

            label.Text = "You clicked on this label.";
        }
    }
}
