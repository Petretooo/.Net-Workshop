using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnShowDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("My first dialog", "My dialog title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            MessageBox.Show(result.ToString());
        }

        private void BtnShowCustomDialog_Click(object sender, EventArgs e)
        {
            string text = tbText.Text;
            MyCustonDialog dialog = new MyCustonDialog(text);
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                MessageBox.Show("Done!");
            }
        }
    }
}
