using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api_net_9.Models;

[Table("Categorias")]

public class Categoria
{

public Categoria()
    {
        Produtos = new HashSet<Produto>();
    }

   [Key]
    public int CategoriaId { get; set; }


    [Required]
    [StringLength(100)]
    public string? Nome { get; set; }


    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    public ICollection<Produto>? Produtos { get; set; }

}