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
    public partial class DatosPaciente : Form
    {
        public DatosPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //TODO 1. Recuperar datos del formulario

            var Nombres = txtNombres.Text;
            var Apellidos = txtApellidos.Text;
            var tipoIdentificacion = cboTidentificacion.SelectedItem as string;
            var numeroIdentificacion = txtNIdentificacion.Text;
            DateTime fechaNacimiento = dtpNacimiento.Value;
            var estadoCivil = cboEstadoCivil.SelectedItem as string;
            var genero = rdbMasculino.Checked ? "Maculino" :
                        rdbFemenino.Checked ? "Femenino" :
                        rdbNoBinario.Checked ? "No binario" : "";
            var ciudad = cboCiudadResidencia.SelectedItem as string;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string contactoEmergencia = txtCEmergencia.Text;
            var ocupacion = cboOcupacion.SelectedItem as string;
            var nivelEscolaridad = cboNEscolaridad.SelectedItem as string;  
            string email = txtEmail.Text;
            var eps = cboEps.SelectedItem as string;
            var regimen = rdbContributivo.Checked ? "Contributivo" :
                           rdbSubsidiado.Checked ? "Subsidiado" : "";
                                
            //TODO 2. Validar datos del formulario
            erpDatos.SetError(txtNombres,null);
            erpDatos.SetError(txtApellidos, null);
            erpDatos.SetError(cboTidentificacion, null);
            erpDatos.SetError(txtNIdentificacion, null);
            erpDatos.SetError(dtpNacimiento, null);
            erpDatos.SetError(cboEstadoCivil, null);
            erpDatos.SetError(rdbMasculino, null);
            erpDatos.SetError(rdbFemenino, null);
            erpDatos.SetError(rdbNoBinario, null);
            erpDatos.SetError(cboCiudadResidencia, null);
            erpDatos.SetError(txtDireccion, null);
            erpDatos.SetError(txtTelefono, null);
            erpDatos.SetError(txtCEmergencia, null);
            erpDatos.SetError(cboOcupacion, null);
            erpDatos.SetError(cboNEscolaridad, null);
            erpDatos.SetError(txtEmail, null);
            erpDatos.SetError(cboEps, null);
            erpDatos.SetError(rdbContributivo, null);
            erpDatos.SetError(rdbSubsidiado, null);

            if (Nombres.Trim() == "")
            {
                MessageBox.Show("El nombre no debe estar vacío", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(txtNombres, "Por favor complete el campo nombre");
                return;
            }
            if (Apellidos.Trim() == "")
            {
                MessageBox.Show("El apellido no debe estar vacío", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(txtApellidos, "Por favor complete el campo apellidos");
                return;
            }
            if (string.IsNullOrEmpty(tipoIdentificacion))
            {
                MessageBox.Show("Debe seleccionar un tipo de identificación", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(cboTidentificacion, "Por favor seleccione un tipo de identificación");
                return;
            }
            if (numeroIdentificacion.Trim() == string.Empty)
            {
                MessageBox.Show("El número de identificación no debe estar vacío", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(txtNIdentificacion, "Por favor complete el campo de número de identificación");
                return;
            }
            if (fechaNacimiento > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no debe ser mayor a la fecha actual", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(dtpNacimiento, "Por favor seleccione una fecha");
                return;
            }
            if (string.IsNullOrEmpty(estadoCivil))
            {
                MessageBox.Show("Debe seleccionar un estado cívil", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(cboEstadoCivil, "Por favor seleccione un estado cívil");
                return;
            }
            if (!rdbMasculino.Checked && !rdbFemenino.Checked && !rdbNoBinario.Checked)
            {
                MessageBox.Show("Debe seleccionar un género", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(rdbMasculino, "Por favor seleccione un género");
                erpDatos.SetError(rdbFemenino, "Por favor seleccione un género");
                erpDatos.SetError(rdbNoBinario, "Por favor seleccione un género");
                return;
            }
            if (string.IsNullOrEmpty(ciudad))
            {
                MessageBox.Show("Debe seleccionar una ciudad", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(cboCiudadResidencia, "Por favor seleccione una ciudad");
                return;
            }
            if (direccion.Trim() == string.Empty)
            {
                MessageBox.Show("La dirección no debe estar vacia", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(txtDireccion, "Por favor complete el campo de dirección");
                return;
            }
            if (telefono.Trim() == string.Empty)
            {
                MessageBox.Show("El teléfono no debe estar vacío", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(txtTelefono, "Por favor complete el campo de teléfono");
                return;
            }
            if (contactoEmergencia.Trim() == string.Empty)
            {
                MessageBox.Show("El contacto de emergencia no debe estar vacío", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(txtCEmergencia, "Por favor complete el campo de contacto de emergencia");
                return;
            }
            if (string.IsNullOrEmpty(ocupacion))
            {
                MessageBox.Show("Debe seleccionar una ocupación", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(cboOcupacion, "Por favor seleccione una ocupación");
                return;
            }
            if (string.IsNullOrEmpty(nivelEscolaridad))
            {
                MessageBox.Show("Debe seleccionar un nivel de escolaridad", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(cboNEscolaridad, "Por favor seleccione un nivel de escolaridad");
                return;
            }
            if (email.Trim() == string.Empty)
            {
                MessageBox.Show("El email no debe estar vacío", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(txtEmail, "Por favor complete el campo de email");
                return;
            }
            if (string.IsNullOrEmpty(eps))
            {
                MessageBox.Show("Debe seleccionar una EPS", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(cboEps, "Por favor seleccione una EPS");
                return;
            }
            if (!rdbContributivo.Checked && !rdbSubsidiado.Checked)
            {
                MessageBox.Show("Debe seleccionar un régimen", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpDatos.SetError(rdbContributivo, "Por favor seleccione una régimen");
                erpDatos.SetError(rdbSubsidiado, "Por favor seleccione una régimen");
                return;
            }

            //TODO 4. Mostrar mensaje de confirmación de la operación
            var datos = @"Nombres : " + Nombres + "\n" +
                       "Apellidos : " + Apellidos + "\n" +
                       "Tipo identificación  : " + tipoIdentificacion + "\n" +
                       "Número identificación : " + numeroIdentificacion + "\n" +
                       "Fecha Nacimiento : " + fechaNacimiento + "\n" +
                       "Estado civil : " + estadoCivil + "\n" +
                       "Género : " + genero + "\n" +
                       "Ciudad : " + ciudad + "\n" +
                       "Dirección : " + direccion + "\n" +
                       "Teléfono : " + telefono + "\n" +
                       "Contacto Emergencia : " + contactoEmergencia + "\n" +
                       "Ocupación : " + ocupacion + "\n" +
                       "Nivel Escolaridad : " + nivelEscolaridad + "\n" +
                       "Email : " + email + "\n" +
                       "Eps : " + eps + "\n" +
                       "Régimen : " + regimen + "\n";

            MessageBox.Show(datos, "Datos Paciente", MessageBoxButtons.OK);

            var Instrucciones = new Instrucciones();
            Instrucciones.Show();
            this.Hide();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper()[0];
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper()[0];
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            var caracter = e.KeyChar;
            if (caracter != '0' && caracter != '1' && caracter != '2' && caracter != '3' &&
                caracter != '4' && caracter != '5' && caracter != '6' && caracter != '7' && caracter != '8' &&
                caracter != '9' && (int)caracter != 8)
            {

                e.Handled = true;
            }
                
        }

        private void txtCEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            var caracter = e.KeyChar;
            if (caracter != '0' && caracter != '1' && caracter != '2' && caracter != '3' &&
                caracter != '4' && caracter != '5' && caracter != '6' && caracter != '7' && caracter != '8' &&
                caracter != '9' && (int)caracter != 8)
            {

                e.Handled = true;
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            erpDatos.SetError(txtTelefono, null);
            if (txtTelefono.Text.Length == 0 || txtTelefono.Text[0] != '3')
            {
                erpDatos.SetError(txtTelefono, "El número de celular debe empezar por 3");
            }
            
        }

        private void txtCEmergencia_Validating(object sender, CancelEventArgs e)
        {
            erpDatos.SetError(txtCEmergencia, null);
            if (txtCEmergencia.Text.Length == 0 || txtCEmergencia.Text[0] != '3')
            {
                erpDatos.SetError(txtCEmergencia, "El número de contacto de emergencia debe empezar por 3");
            }
        }
    }
}
