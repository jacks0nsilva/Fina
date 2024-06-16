using System.ComponentModel.DataAnnotations;

namespace Fina.Shared.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    [Required(ErrorMessage = "É obrigatório informar o Id da categoria.")]
    public long Id { get; set; }
    [Required(ErrorMessage = "Título inválido.")]
    [MaxLength(80, ErrorMessage = "O título devo conter no máximo 80 caracteres.")]
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
