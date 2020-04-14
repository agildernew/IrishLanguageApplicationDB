using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrishLanguageApplicationDB
{
    public partial class AmhranNabfFiannForm : Form
    {
        public AmhranNabfFiannForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Hide();
        }
    }
}
