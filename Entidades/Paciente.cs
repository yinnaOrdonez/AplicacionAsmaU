namespace Entidades
{
    public class Paciente
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set;  }
        public TipoDocumento TipoDocumento { get; set; }
        public int NumeroIdentificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Genero Genero { get; set; }  
        public EstadoCivil EstadoCivil { get; set; }
        public Ciudad Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string ContactoEmergencia { get; set; }
        public Ocupacion Ocupacion { get; set; }
        public NivelEscolaridad NivelEscolaridad { get; set; }
        public string Email { get; set; }
        public EPS Eps { get; set; }
        public Regimen Regimen { get; set; }
        
    }
}