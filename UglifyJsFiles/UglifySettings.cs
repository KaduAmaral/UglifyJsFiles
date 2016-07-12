using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UglifyJsFiles
{
    public partial class UglifySettings : Form
    {
        public UglifySettings()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();
        }

        private void chkSupportIE8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSupportIE8.Checked)
                chkScrewIE8.Checked = false;
            
        }

        private void chkScrewIE8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkScrewIE8.Checked)
                chkSupportIE8.Checked = false;
        }
    }
}
