using Entidades;

namespace Repositorio
{
    public class RepositorioSeguridad : IRepositorioSeguridad
    {
        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            return new Usuario { NombreUsuario = nombreUsuario, Clave = "123" };
        }

    }
}