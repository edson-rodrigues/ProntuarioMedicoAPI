using Microsoft.EntityFrameworkCore;

namespace ProntuarioMedicoAPI.Models
{

    [PrimaryKey(nameof(PacienteId), nameof(MedicoId))]
    public class MedicoPaciente
    {
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
    }
}
