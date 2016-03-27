using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Models
{
    public class Telefones
    {
        public virtual int id { get; set; }
        public virtual string numero { get; set; }
        public virtual int usuarios_id { get; set; }


    }
}
