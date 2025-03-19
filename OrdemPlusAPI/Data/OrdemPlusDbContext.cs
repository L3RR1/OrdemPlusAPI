using Microsoft.EntityFrameworkCore;
using OrdemPlus.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace OrdemPlus.Data
{
    public class OrdemPlusDbContext : DbContext
    {
        public OrdemPlusDbContext(DbContextOptions<OrdemPlusDbContext> options)
            : base(options)
        {
        }

        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Servico)
                .WithMany()
                .HasForeignKey(p => p.ServicoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Equipe)
                .WithMany()
                .HasForeignKey(p => p.EquipeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Empresa)
                .WithMany()
                .HasForeignKey(u => u.EmpresaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
