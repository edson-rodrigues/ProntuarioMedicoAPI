namespace ProntuarioMedicoAPI.Models
{
    public class Prontuario
    {
        public int ProntuarioId { get; set; }
        public List<ResultadosExames> ResultadosExames { get; set; } 
    }
}
