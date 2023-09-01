using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProntuarioMedicoAPI.Models
{
    public class ResultadosExames
    {
        [Key]
        public int ResultadoExamesId { get; set; }
        public string Resultado { get; set; }
        public bool Pronto { get; set; }
    }
}
