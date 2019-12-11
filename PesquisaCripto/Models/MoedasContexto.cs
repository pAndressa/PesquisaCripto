using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PesquisaCripto.Models;

namespace PesquisaCripto.Models
{
    public class MoedasContexto : DbContext
    {
        public DbSet<Moedas> Moedas { get; set; }
        public MoedasContexto(DbContextOptions<MoedasContexto> opcoes): base (opcoes)
        {

        }
       
    }
}
