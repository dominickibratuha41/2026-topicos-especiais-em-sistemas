using System;

namespace API.Models;

public class Produto
{
    // C# usa PascalCase para propriedades
    public string Id { get; set; }
    public string Nome { get; set; } = string.Empty; // Inicializa para evitar null warning
    public double Preco { get; set; }
    public DateTime CriadoEm { get; set; }

    // Construtor
    public Produto()
    {
        // CORREÇÃO: Faltava o () no final do ToString
        Id = Guid.NewGuid().ToString(); 
        
        // Inicializamos a data aqui para garantir que o valor seja do momento da criação
        CriadoEm = DateTime.Now;
    }

    // O seu comentário sobre Java está certíssimo! 
    // No C#, o { get; set; } já faz o papel do Getter e Setter automaticamente.
}