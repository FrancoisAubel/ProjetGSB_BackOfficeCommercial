using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeCommercial
{
    public partial class GestionProduit : Form
    {
        public GestionProduit()
        {
            InitializeComponent();
        }

        private void btn_Del_BackHomeProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Edit_BackHomeProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_New_BackHomeProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
