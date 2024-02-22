namespace Negocio
{
    public interface INegocioUsuario
    {
        bool ValidarUsuario(string nombreUsuario, string contraseña);
    }
}