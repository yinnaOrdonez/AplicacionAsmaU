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
    public partial class Ingreso : Form
    {
        private string CONTRASENA = "123456";
        private string USUARIO = "yinna.lu";

        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        
        {
            erpIngreso.SetError(txtUsuario, null);
            erpIngreso.SetError(txtContraseña, null);
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
               erpIngreso.SetError(txtUsuario, "Por favor Ingrese el usuario");
               return;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                erpIngreso.SetError(txtContraseña, "Por favor Ingrese la contraseña");
                return;
            }
            if (txtUsuario.Text == USUARIO && txtContraseña.Text == CONTRASENA)
            {
                var Principal = new MDIPrincipal();
                Principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Las credenciales de ingreso no son válidas. Por favor verifique.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
