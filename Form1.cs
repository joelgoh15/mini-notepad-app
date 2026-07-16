using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reloadFromDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void beginEndToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notepadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //add button
            // Create a new TabPage
            TabPage newTab = new TabPage("Tab " + (tabControl1.TabCount + 1));

           newTab.Name = "tabPageNote" + (tabControl1.TabCount + 1).ToString();

            // Add the new TabPage to the TabControl
            tabControl1.TabPages.Add(newTab);

            // Select the newly added tab
            tabControl1.SelectedTab = newTab;

        }

        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            //delete button

            // Check if there is a selected tab
            if (tabControl1.SelectedTab != null)
            {
                // Remove the selected tab
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                Font newFont = new Font(currentFont, currentFont.Style ^ FontStyle.Underline);
                richTextBox1.SelectionFont = newFont;
            }
        }
    }
}
