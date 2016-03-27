using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Repositorio.Models;

namespace Repositorio.Mapping
{
    public class TiposMap:ClassMap<Tipos>
    {
        public TiposMap() {
            Id(c=>c.id);
            Map(c=>c.tipo);
            Table("tipos");
        }
    }
}
