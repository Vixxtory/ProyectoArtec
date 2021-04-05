using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
namespace artec.Models
{
    public class Usuario: IdentityUser
    {
        public List<Categoria> Categorias {get;set;}
    }
}