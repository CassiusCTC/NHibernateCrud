using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Models
{
    public class Usuarios
    {
        public virtual int id { get; set; }

        public virtual string email { get; set; }
        public virtual string username { get; set; }
        public virtual string password{ get; set; }
        public virtual string nome { get; set; }
        public virtual string estado { get; set; }


    }
}
