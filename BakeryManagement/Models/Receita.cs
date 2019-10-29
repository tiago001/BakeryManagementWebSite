using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBakery.Models
{
    [Table("Receitas")]
    class Receita
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rendimento { get; set; }
        public List<Produto> Ingredientes { get; set; }
        public int TempoDePreparo { get; set; }
    }
}
