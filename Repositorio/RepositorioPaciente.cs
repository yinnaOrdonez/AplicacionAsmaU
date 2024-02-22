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
        private Modelo.Contexto contexto;
        public RepositorioPaciente()
        {
            contexto = new Modelo.Contexto();
        }

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
                IdEPS = paciente.Eps.Id,
                IdRegimen = paciente.Regimen.Id,
                
            };

            contexto.Pacientes.Add(pacienteIngresar);
            contexto.SaveChanges();

        }

        public void ActualizarPaciente(Paciente paciente)
        {
            var pacienteActual = contexto.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            pacienteActual.Nombres = paciente.Nombres;
            pacienteActual.Apellidos = paciente.Apellidos;
            pacienteActual.NumeroIdentificacion = paciente.NumeroIdentificacion;
            pacienteActual.IdTipoDocumento = paciente.TipoDocumento.Id;
            pacienteActual.Direccion = paciente.Direccion;
            pacienteActual.IdCiudad = paciente.Ciudad.Id;
            pacienteActual.FechaNacimiento = paciente.FechaNacimiento;
            pacienteActual.ContactoEmergencia = paciente.ContactoEmergencia;
            pacienteActual.Telefono = paciente.Telefono;
            pacienteActual.IdNivelEscolaridad = paciente.NivelEscolaridad.Id;
            pacienteActual.IdRegimen = paciente.Regimen;
            pacienteActual.IdGenero = paciente.Genero.Id;
            pacienteActual.IdEPS = paciente.Eps.Id;
            pacienteActual.IdOcupacion = paciente.Ocupacion.Id;
            pacienteActual.IdEstadoCivil = paciente.EstadoCivil.Id;
            pacienteActual.Email = paciente.Email;

            contexto.SaveChanges();

        }

        public Paciente ObtenerPaciente(string numeroDocumento)
        {
            var pacienteActual = contexto.Pacientes.FirstOrDefault(p => p.NumeroIdentificacion == numeroDocumento);
            if (pacienteActual != null)
                return new Entidades.Paciente()
                {
                    Nombres = pacienteActual.Nombres,
                    Apellidos = pacienteActual.Apellidos,
                    NumeroIdentificacion = pacienteActual.NumeroIdentificacion,
                    TipoDocumento = new TipoDocumento() { Id = pacienteActual.TipoDocumento.Id },
                    Direccion = pacienteActual.Direccion,
                    Ciudad = new Ciudad() { Id = pacienteActual.Ciudad.Id },
                    FechaNacimiento = pacienteActual.FechaNacimiento,
                    NivelEscolaridad = new NivelEscolaridad() { Id = pacienteActual.NivelEscolaridad.Id },
                    Telefono = pacienteActual.Telefono,
                    ContactoEmergencia = pacienteActual.ContactoEmergencia,
                    Eps = new EPS() { Id = pacienteActual.EPS.Id },
                    Genero = new Genero() { Id = pacienteActual.Genero.Id },
                    Ocupacion = new Ocupacion() { Id = pacienteActual.Ocupacion.Id },
                    Regimen = new Regimen() { Id = pacienteActual.Regimen.Id },
                    EstadoCivil = new EstadoCivil() { Id = pacienteActual.EstadoCivil.Id },
                    Email = pacienteActual.Email,
                };

            return null;

        }

    }
}
