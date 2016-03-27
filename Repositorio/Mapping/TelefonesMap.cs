using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Repositorio.Models;

namespace Repositorio.Mapping
{
    public class TelefonesMap: ClassMap<Telefones>
    {
        public TelefonesMap() {
            Id(c=>c.id);
            Map(c=>c.numero);
            Map(c => c.usuarios_id);
            Table("telefones");

        }
    }
}
