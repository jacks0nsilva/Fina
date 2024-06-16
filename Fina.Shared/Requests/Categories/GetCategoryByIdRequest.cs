using System.ComponentModel.DataAnnotations;

namespace Fina.Shared.Requests.Categories;

public class GetCategoryByIdRequest : Request
{
    [Required(ErrorMessage = "É obrigatório informar o Id da categoria.")]
    public long Id { get; set; }
}
