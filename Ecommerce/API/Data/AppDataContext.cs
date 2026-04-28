using System;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

//Representa o Banco de Dados da sua aplicação
// 1 Criar a herança da classe DbContext
// 2 Criar os atributos para representar as tabelas no Banco de Dados
public class AppDataContext : DbContext
{
    //classes de modelo que vão representar tabelas no banco
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Banco.db");
    }
}