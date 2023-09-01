namespace ProntuarioMedicoAPI.Models
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public int CRM { get; set; }
        public string CRMState { get; set; }
        public List<MedicoPaciente> Pacientes { get; set;}
    }
}
