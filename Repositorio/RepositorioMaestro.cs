using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Repositorio
{
    public class RepositorioMaestro : IRepositorioMaestro

    {
        public List<EPS> ObtenerEPS(int idRegimen)
        {
            var regimen= ObtenerRegimen();
            var eps = regimen.FirstOrDefault(d => d.Id == idRegimen).EPSS
                .OrderBy(c => c.Nombre)
                .ToList();

            return EPSS;
        }

        public List<Regimen> ObtenerRegimen()
        {
            var regimen = new List<Regimen>();

            regimen.Add(new Regimen() { Id = 1, Nombre = "Antioquia", Eps = new List<EPS>() });
            regimen[0].EPSS.Add(new EPS() { Id = 1, Nombre = "Medellín" });
            departamentos[0].Ciudades.Add(new Ciudad() { Id = 2, Nombre = "Bello" });
            departamentos[0].Ciudades.Add(new Ciudad() { Id = 3, Nombre = "Sabaneta" });

            departamentos.Add(new Departamento() { Id = 2, Nombre = "Córdoba", Ciudades = new List<Ciudad>() });
            departamentos[1].Ciudades.Add(new Ciudad() { Id = 4, Nombre = "Sahagún" });
            departamentos[1].Ciudades.Add(new Ciudad() { Id = 5, Nombre = "Montería" });
            departamentos[1].Ciudades.Add(new Ciudad() { Id = 6, Nombre = "Tierralta" });

            departamentos.Add(new Departamento() { Id = 3, Nombre = "Atlántico", Ciudades = new List<Ciudad>() });
            departamentos[2].Ciudades.Add(new Ciudad() { Id = 7, Nombre = "Barranquilla" });
            departamentos[2].Ciudades.Add(new Ciudad() { Id = 8, Nombre = "Sabanalarga" });
            departamentos[2].Ciudades.Add(new Ciudad() { Id = 9, Nombre = "Malambo" });

            return departamentos;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = new List<TipoDocumento>();

            tiposDocumento.Add(new TipoDocumento() { Id = 1, Nombre = "Cédula de Ciudadanía" });
            tiposDocumento.Add(new TipoDocumento() { Id = 2, Nombre = "Cédula de Extranjería" });
            tiposDocumento.Add(new TipoDocumento() { Id = 3, Nombre = "Pasaporte" });
            tiposDocumento.Add(new TipoDocumento() { Id = 4, Nombre = "Registro Civil" });
            tiposDocumento.Add(new TipoDocumento() { Id = 5, Nombre = "Tarjeta de Identidad" });

            return tiposDocumento;
        }

        public List<EstadoCivil> ObtenerEstadoCivil()
        {
            var estadoCivil = new List<EstadoCivil>();

            estadoCivil.Add(new EstadoCivil() { Id = 1, Nombre = "Soltero" });
            estadoCivil.Add(new EstadoCivil() { Id = 2, Nombre = "Casado" });
            estadoCivil.Add(new EstadoCivil() { Id = 3, Nombre = "Unión libre" });
            estadoCivil.Add(new EstadoCivil() { Id = 4, Nombre = "Divorciado" });
            estadoCivil.Add(new EstadoCivil() { Id = 5, Nombre = "Viudo" });

            return estadoCivil;
        }

        public List<Ciudad> ObtenerCiudad()
        {
            var ciudad = new List<Ciudad>();

            ciudad.Add(new Ciudad() { Id = 1, Nombre = "Soltero" });
            ciudad.Add(new Ciudad() { Id = 2, Nombre = "Casado" });
            ciudad.Add(new Ciudad() { Id = 3, Nombre = "Unión libre" });
            ciudad.Add(new Ciudad() { Id = 4, Nombre = "Divorciado" });
            ciudad.Add(new Ciudad() { Id = 5, Nombre = "Viudo" });

            return ciudad;
        }

        public List<Entidades.Ciudad> ObtenerCiudades()
        {
            throw new NotImplementedException();
        }

        List<Entidades.TipoDocumento> IRepositorioMaestro.ObtenerTiposDocumento()
        {
            throw new NotImplementedException();
        }

        public List<Entidades.Genero> ObtenerGenero()
        {
            throw new NotImplementedException();
        }

        public List<Entidades.NivelEscolaridad> ObtenerNivelEscolaridad()
        {
            throw new NotImplementedException();
        }

        public List<Entidades.Ocupacion> ObtenerOcupacion()
        {
            throw new NotImplementedException();
        }

        public List<Entidades.EPS> ObtenerEPS()
        {
            throw new NotImplementedException();
        }

        List<Entidades.EstadoCivil> IRepositorioMaestro.ObtenerEstadoCivil()
        {
            throw new NotImplementedException();
        }
    }
}
