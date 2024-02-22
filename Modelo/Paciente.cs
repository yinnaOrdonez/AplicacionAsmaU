using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Entidades;

namespace Modelo
{
  
        [Table("Pacientes")]
        public class Paciente
        {
            [Key]
            public int Id { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public int IdTipoDocumento { get; set; }
            public virtual TipoDocumento TipoDocumento { get; set; }
            public string NumeroIdentificacion { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Telefono { get; set; }
            public string ContactoEmergencia { get; set; }
            public string Direccion { get; set; }
            public int IdCiudad { get; set; }
            public virtual Ciudad Ciudad { get; set; }
            public int IdGenero { get; set; }
            public virtual Genero Genero { get; set; }
            public int IdRegimen { get; set; }
            public virtual Regimen Regimen { get; set; }
            public int IdEstadoCivil { get; set; }
            public virtual EstadoCivil EstadoCivil { get; set; }
            public int IdNivelEscolaridad { get; set; }
            public virtual NivelEscolaridad NivelEscolaridad { get; set; }
            public string Email { get; set; }
            public int IdEPS { get; set; }
            public virtual EPS EPS { get; set; }
            public int IdOcupacion { get; set; }
            public virtual Ocupacion Ocupacion { get; set;  }

        }

    
}