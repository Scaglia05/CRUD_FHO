using Bogus;
using Bogus.Extensions.Brazil;
using ImoveisApi2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

public class Context : DbContext {
    public Context(DbContextOptions<Context> options) : base(options) {
    }

    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Vendedor> Vendedor { get; set; }
    public DbSet<Imovel> Imovel { get; set; }
    public object Imoveis { get; internal set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);

        // Suprimir o aviso de mudanças pendentes no modelo
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning)
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);

        // Criando um gerador de dados fictícios
        var faker = new Faker("pt_BR"); // Definindo o local para português do Brasil

        // Seeding de dados estruturado para a entidade Cliente
        modelBuilder.Entity<Cliente>().HasData(
            new Cliente {
                Id = 1,
                Nome = "Guilherme",
                CPF = "123.456.789.10",
                Endereco = "Av.12a, Araras-SP",
                DataNascimento = new DateOnly(2002, 10, 10),
                Email_Cliente = "cliente@gmail.com"
            },
            new Cliente {
                Id = 2,
                Nome = faker.Name.FullName(), // Nome aleatório
                CPF = faker.Person.Cpf(), // CPF aleatório
                Endereco = faker.Address.FullAddress(), // Endereço aleatório
                DataNascimento = DateOnly.FromDateTime(faker.Date.Past(20)), // Converte DateTime para DateOnly
                Email_Cliente = faker.Internet.Email() // Email aleatório
            }
        );
    }
}
