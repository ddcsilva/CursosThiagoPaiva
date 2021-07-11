﻿using System;

namespace GerenciadorCondominio.BLL.Models
{
    public class ServicoPredio
    {
        public int ServicoPredioId { get; set; }
        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }

        public DateTime DataExecucao { get; set; }
    }
}
