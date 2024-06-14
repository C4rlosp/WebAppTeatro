using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppTeatro.Shared
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Cedula {  get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
    }
}