using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medicamento.Model;
using Microsoft.EntityFrameworkCore;

namespace Medicamento.Data
{
    public class MedicamentoContext : DbContext
    {
        public MedicamentoContext(DbContextOptions<MedicamentoContext> opt) : base(opt)
        { }

        public DbSet<MedicamentoModel> Medicamentos { get; set; }
    }
}
