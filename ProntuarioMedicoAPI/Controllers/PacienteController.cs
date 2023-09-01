using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProntuarioMedicoAPI.DTO;
using ProntuarioMedicoAPI.Models;

namespace ProntuarioMedicoAPI.Controllers
{
    [ApiController]
    [Route("/paciente")]
    public class PacienteController : ControllerBase
    {
        private readonly Contexto contexto;
        public PacienteController(Contexto context)
        {
            contexto = context;
        }


        [HttpGet("/{id:int}")]
        public async Task<IActionResult> GetById ([FromRoute]int id)
        {
            var paciente = await contexto.Pacientes.FirstOrDefaultAsync(c => c.PacienteId == id);
            if (paciente == null)
            {
                return NotFound();
            }
            return Ok(paciente);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PacienteCadastroDTO pacienteCadastroDTO)
        {
            var paciente = new Paciente
            {
                Name = pacienteCadastroDTO.Name,
                Birthday = pacienteCadastroDTO.Birthday,
                BiologicGender = pacienteCadastroDTO.BiologicGender,
                Email = pacienteCadastroDTO.Email,
                Phone = pacienteCadastroDTO.Phone,
                Medicos = pacienteCadastroDTO.Medicos
            };
            var retorno = await contexto.Pacientes.AddAsync(paciente);
            await contexto.SaveChangesAsync();
            return Created($"/{paciente.PacienteId}", paciente);
        }

        [HttpPut("/{id:int}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] PacienteEditarDTO pacienteEditarDTO)
        {
            var paciente = await contexto.Pacientes.FirstOrDefaultAsync(paciente => paciente.PacienteId == id);
            if (paciente == null)
            {
                return NotFound($"Paciente com o id {id} não encontrado");
            }
            paciente.Name = pacienteEditarDTO.Name ?? paciente.Name;
            paciente.Birthday = pacienteEditarDTO.Birthday ?? paciente.Birthday;
            paciente.BiologicGender = pacienteEditarDTO.BiologicGender ?? paciente.BiologicGender;
            paciente.Email = pacienteEditarDTO.Email ?? paciente.Email;
            paciente.Phone = pacienteEditarDTO.Phone ?? paciente.Phone;

            contexto.Pacientes.Update(paciente);
            await contexto.SaveChangesAsync();
            return Ok($"{paciente}");
        }
        [HttpDelete("/{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var paciente = await contexto.Pacientes.FirstOrDefaultAsync(paciente => paciente.PacienteId == id);
            if (paciente == null)
            {
                return NotFound();
            }
            contexto.Pacientes.Remove(paciente);
            await contexto.SaveChangesAsync();
            return Ok(paciente);
        }
    }
}
