using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Repositorio;

namespace Negocio
{
    public class NegocioMaestro : INegocioMaestro
    {
        IRepositorioMaestro repositorioMaestro = new RepositorioMaestroEF();
        public NegocioMaestro(IRepositorioMaestro repositorioMaestro)
        {
            this.repositorioMaestro = repositorioMaestro;
        }

        public List<Ciudad> ObtenerCiudades()
        => repositorioMaestro.ObtenerCiudades();

        public List<TipoDocumento> ObtenerTiposDocumento()
        => repositorioMaestro.ObtenerTiposDocumento();

    }
}
