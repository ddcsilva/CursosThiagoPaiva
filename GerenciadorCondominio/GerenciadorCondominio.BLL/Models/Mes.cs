using System.Collections.Generic;

namespace GerenciadorCondominio.BLL.Models
{
    public class Mes
    {
        public int MesId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Aluguel> Alugueis { get; set; }
        public virtual ICollection<HistoricoRecursos> HistoricosRecursos { get; set; }
    }
}
