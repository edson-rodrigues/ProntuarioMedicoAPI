using Microsoft.EntityFrameworkCore;

namespace ProntuarioMedicoAPI.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Prontuario> Prontuarios { get; set; }
        public DbSet<ResultadosExames> ResultadosExames { get; set; }
        public DbSet<MedicoPaciente> MedicoPacientes { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {    
        }
    }
}
