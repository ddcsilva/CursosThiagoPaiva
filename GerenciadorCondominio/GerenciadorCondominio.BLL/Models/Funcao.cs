using Microsoft.AspNetCore.Identity;

namespace GerenciadorCondominio.BLL.Models
{
    public class Funcao : IdentityRole<string>
    {
        public string Descricao { get; set; }
    }
}
