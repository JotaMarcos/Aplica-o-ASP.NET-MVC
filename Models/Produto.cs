using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMV.Models
{
    public class Produto
    {
        
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório!")]
        public string Descricao { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "O campo quantidade é obrigatório!")]
        [Range(1, 100, ErrorMessage = "Valor fora da faixa permitida!")]
        public int Quatidade { get; set; }
        


        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
