using ProntuarioMedicoAPI.Models;

namespace ProntuarioMedicoAPI.DTO
{
    public class PacienteCadastroDTO
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public char BiologicGender { get; set; } //M = Masculine F = Feminine
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<MedicoPaciente> Medicos { get; set; }
    }
}
