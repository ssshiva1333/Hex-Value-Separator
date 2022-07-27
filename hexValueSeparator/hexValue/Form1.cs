using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hexValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_separate_Click(object sender, EventArgs e)
        {
            try
            {
                txtb_newhexvalue.Clear();
                string hexValue = txtb_hexvalue.Text;
                string newHexValue = "";
                for (int i = 0; i < hexValue.Length; i++)
                {
                    if (i % 2 != 0 && i > 0)
                    {
                        newHexValue = newHexValue + hexValue[i - 1] + hexValue[i] + " ";
                    }
                }
                txtb_newhexvalue.Text = newHexValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
