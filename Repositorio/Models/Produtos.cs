using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Models
{
    public class Produtos
    {
        public virtual int id { get; set; }

        public virtual string descricao { get; set; }
        public virtual string nomeprod { get; set; }
        public virtual int qnt { get; set; }
        public virtual DateTime data { get; set; }
        public virtual int usuarios_id { get; set; }
        public virtual int tipo_id { get; set; }
    }
}
