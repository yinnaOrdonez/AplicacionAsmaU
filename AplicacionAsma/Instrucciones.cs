using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAsma
{
    public partial class Instrucciones : Form
    {
        public Instrucciones()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            var Cuestionario1 = new Cuestionario1();
            Cuestionario1.Show();
            this.Hide();
        }
    }
}
