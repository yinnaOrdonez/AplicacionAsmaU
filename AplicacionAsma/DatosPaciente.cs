using Entidades;
using Negocio;
using Repositorio;
using System.ComponentModel;

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

            Paciente paciente = new Paciente();

            var Nombres = txtNombres.Text;
            var Apellidos = txtApellidos.Text;
            var tipoDocumento = cboTidentificacion.SelectedItem as TipoDocumento;
            var numeroIdentificacion = txtNIdentificacion.Text;
            DateTime fechaNacimiento = dtpNacimiento.Value;
            var estadoCivil = cboEstadoCivil.SelectedItem as EstadoCivil;
            var genero = rdbMasculino.Checked ? 1 :
                        rdbFemenino.Checked ? 2 :
                        rdbNoBinario.Checked ? 3: 1;
            var ciudad = cboCiudadResidencia.SelectedItem as Ciudad;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string contactoEmergencia = txtCEmergencia.Text;
            var ocupacion = cboOcupacion.SelectedItem as Ocupacion;
            var nivelEscolaridad = cboNEscolaridad.SelectedItem as NivelEscolaridad;  
            string email = txtEmail.Text;
            var eps = cboEps.SelectedItem as EPS;
            var regimen = rdbContributivo.Checked ? 1 :
                           rdbSubsidiado.Checked ? 2: 1;
                                
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
            
            paciente.Nombres = Nombres;
            paciente.Apellidos = Apellidos;
            paciente.TipoDocumento = tipoDocumento;
            paciente.NumeroIdentificacion = numeroIdentificacion;
            paciente.FechaNacimiento = fechaNacimiento;
            paciente.EstadoCivil = estadoCivil;
            paciente.Genero = genero;
            paciente.Ciudad = ciudad;
            paciente.Direccion = direccion;
            paciente.Telefono = telefono;
            paciente.ContactoEmergencia = contactoEmergencia;
            paciente.Ocupacion = ocupacion;
            paciente.NivelEscolaridad = nivelEscolaridad;
            paciente.Email = email;
            paciente.Eps = eps;
            paciente.Regimen = regimen;

            IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
            INegocioPaciente negocioPaciente = new NegocioPaciente(repositorioPaciente);
            if (paciente.Id == 0)
                negocioPaciente.IngresarPaciente(paciente);
            else
                negocioPaciente.ActualizarPaciente(paciente);

            var datos = @"Nombres : " + Nombres + "\n" +
                       "Apellidos : " + Apellidos + "\n" +
                       "Tipo identificación  : " + tipoDocumento + "\n" +
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
