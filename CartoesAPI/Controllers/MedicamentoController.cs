using Medicamento.Data;
using Medicamento.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medicamento.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicamentoController : Controller
    {
        private MedicamentoContext _context;

        public MedicamentoController(MedicamentoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<MedicamentoModel> GetMedicamentos()
        {
            return _context.Medicamentos;
        }
        [HttpPost]
        public IActionResult AddMedicamento([FromBody] MedicamentoModel medicamentos)
        {
            _context.Medicamentos.Add(medicamentos);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMedicamentoById), new { Id =  medicamentos.IdMedicamento}, medicamentos);
        }
        /* Exemplo JSON
          {
            "Id":2,
            "Number":"1111222233335555",
            "ExpiredDate":"2025-10-21",
            "Cvv":"123"
          }
        */

        [HttpGet("{id}")]
        public IActionResult GetMedicamentoById(int id)
        {
            MedicamentoModel medicamentos = _context.Medicamentos.FirstOrDefault( medicamentos => medicamentos.IdMedicamento == id);
            if(medicamentos != null)
            {
                return Ok(medicamentos);
            }
            return NotFound();
        }

    }
}
