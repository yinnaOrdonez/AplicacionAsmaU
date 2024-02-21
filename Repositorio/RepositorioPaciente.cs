using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        public void IngresarPaciente(Paciente paciente)
        {

        }

        public void ActualizarPaciente(Paciente paciente)
        {

        }

        public Paciente ObtenerPaciente(string numeroDocumento)
        {
            return new Paciente();
        }

    }
}
