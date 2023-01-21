using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Testes_Invor_Dados_Web.EF;

namespace Testes_Invor_Dados_Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Testes_Invor_Dados_Web.EF.Cliente> Cliente { get; set; }
        public DbSet<Testes_Invor_Dados_Web.EF.Funcionario> Funcionario { get; set; }
        public DbSet<Testes_Invor_Dados_Web.EF.Produto> Produto { get; set; }
        public DbSet<Testes_Invor_Dados_Web.EF.Fornecedor> Fornecedor { get; set; }
    }
}
