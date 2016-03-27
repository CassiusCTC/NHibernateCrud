using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Repositorio.Models;

namespace Repositorio.Mapping
{
    public class UsuariosMap:ClassMap<Usuarios>
    {
        public UsuariosMap() {

            Id(c => c.id);
            Map(c => c.email);
            Map(c => c.password);
            Map(c => c.username);
            Map(c => c.nome);
            Map(c => c.estado);
            Table("usuarios");        

        }
    }
}
