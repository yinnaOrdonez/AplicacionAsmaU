using Entidades;

namespace Negocio
{
    public interface INegocioMaestro
    {
        List<Ciudad> ObtenerCiudades();
        List<TipoDocumento> ObtenerTiposDocumento();

    }
}