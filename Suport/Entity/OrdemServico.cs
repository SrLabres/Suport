using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Suport.Entity
{
    public class OrdemServico
    {
        public int Id { get; set; }

        [ForeignKey("Usuario")]
        public Usuario Usuario { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public Prioridade Prioridade { get; set; }
        public string Descricao { get; set; }
    }
}
