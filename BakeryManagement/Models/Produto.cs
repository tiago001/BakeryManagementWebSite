using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBakery.Models
{
    [Table("Produtos")]
    class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public string Unidade { get; set; }
        public DateTime PrazoValidade { get; set; }
    }
}
