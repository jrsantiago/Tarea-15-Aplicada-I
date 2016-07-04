using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
 
        public partial class Usuario
        {
           [Key]
            public string contrasena { get; set; }
            public string userName { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string sexo { get; set; }
        }
    
}
