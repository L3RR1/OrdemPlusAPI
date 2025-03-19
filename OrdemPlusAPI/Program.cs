using Microsoft.EntityFrameworkCore;
using OrdemPlus.Data;
using OrdemPlus.Repositories;
using OrdemPlus.Services;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os controllers
builder.Services.AddControllers();

// Configura o DbContext com SQL Server
builder.Services.AddDbContext<OrdemPlusDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registra o repositório genérico
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Registra os serviços
builder.Services.AddScoped<IServicoService, ServicoService>();
builder.Services.AddScoped<IEquipeService, EquipeService>();
builder.Services.AddScoped<IFuncionarioService, FuncionarioService>();
builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IEmpresaService, EmpresaService>();

// Configura o Swagger/OpenAPI para desenvolvimento
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
