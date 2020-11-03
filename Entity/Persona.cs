using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Persona
    {
        [Key]
        public string Identificacion { get; set; } 
        
        [Column(TypeName = "nvarchar(30)")]
        public string Nombre { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string Apellido { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Sexo { get; set; }
        public int Edad { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Departamento{ get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Ciudad { get; set; }  

        [Column(TypeName = "nvarchar(30)")]  
        public string Tipo { get; set; }    
        public int Valor { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string Fecha { get; set; }
    }
}
