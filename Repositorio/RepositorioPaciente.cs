using Entidades;
using Modelo;
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
            Modelo.Paciente pacienteIngresar = new Modelo.Paciente()
            {
                Nombres = paciente.Nombres,
                Apellidos = paciente.Apellidos,
                NumeroIdentificacion = paciente.NumeroIdentificacion,
                IdTipoDocumento = paciente.TipoDocumento.Id,
                FechaNacimiento = paciente.FechaNacimiento,
                IdGenero = paciente.Genero.Id,
                IdEstadoCivil = paciente.EstadoCivil.Id,
                Direccion = paciente.Direccion,
                IdCiudad = paciente.Ciudad.Id,
                Telefono = paciente.Telefono,
                ContactoEmergencia = paciente.ContactoEmergencia,
                IdNivelEscolaridad = paciente.NivelEscolaridad.Id,
                IdOcupacion = paciente.Ocupacion.Id,
                Email = paciente.Email,
                IdEPS = paciente.EPS.Id,
                IdRegimen = paciente.Regimen.Id,
                
            };

            contexto.Pacientes.Add(pacienteIngresar);
            contexto.SaveChanges();

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
