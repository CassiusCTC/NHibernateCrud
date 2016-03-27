using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Repositorio.Models;

namespace Repositorio.Mapping
{
    public class ProdutosMap:ClassMap<Produtos>
    {
        public ProdutosMap() {
             
            Id(c=>c.id);
            Map(c => c.descricao);
            Map(c => c.nomeprod);
            Map(c => c.qnt);
            Map(c => c.data);
            Map(c => c.usuarios_id);
            Map(c => c.tipo_id);
            Table("produtos");
       }

    }
}
