using ProntuarioMedicoAPI.Models;

namespace ProntuarioMedicoAPI.DTO
{
    public class PacienteEditarDTO
    {
        public string Name { get; set; }
        public DateTime? Birthday { get; set; } = null;
        public char? BiologicGender { get; set; } //M = Masculine F = Feminine
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<MedicoPaciente> Medicos { get; set; }
    }
}
