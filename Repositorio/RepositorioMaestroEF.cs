using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    
    
        public class RepositorioMaestroEF : IRepositorioMaestro
        {
            private Modelo.Contexto contexto;
            public RepositorioMaestroEF()
            {
                contexto = new Modelo.Contexto();
            }

            public List<Ciudad> ObtenerCiudades(int idDepartamento)
            {
                return contexto.Ciudad
                  .Select(c => new Ciudad() { Id = c.Id, Nombre = c.Nombre })
                  .OrderBy(c => c.Nombre)
                  .ToList();
            }

            public List<EstadoCivil> ObtenerEstadoCivil()
            {
                return contexto.EstadoCivil
                    .Select(c => new EstadoCivil() { Id = c.Id, Nombre = c.Nombre })
                    .OrderBy(c => c.Nombre)
                    .ToList();
            }

            public List<TipoDocumento> ObtenerTiposDocumento()
            {
                return contexto.TiposDocumentos
                    .Select(c => new TipoDocumento() { Id = c.Id, Nombre = c.Nombre })
                    .OrderBy(c => c.Nombre)
                    .ToList();
            }
        public List<Ocupacion> ObtenerOcupacion()
        {
            return contexto.Ocupacion
                .Select(c => new Ocupacion() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();
        }
        public List<NivelEscolaridad> ObtenerNivelEscolaridad()
        {
            return contexto.NivelEscolaridad
                .Select(c => new NivelEscolaridad() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();
        }

        public List<EPS> ObtenerEPS(int idRegimen)
        {
            var EPS = contexto.EPS.Where(d => d.Id == idRegimen)
                .Select(c => new EPS() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

         
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

        List<Entidades.NivelEscolaridad> IRepositorioMaestro.ObtenerNivelEscolaridad()
        {
            throw new NotImplementedException();
        }

        List<Entidades.Ocupacion> IRepositorioMaestro.ObtenerOcupacion()
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
