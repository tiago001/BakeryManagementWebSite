using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBakery.Models
{
    [Table("ProdutosFinais")]
    class ProdutoFinal
    {
        [Key]
        public int Id { get; set; }
        public Receita Receita { get; set; }
        public double Preco { get; set; }
        public double Custo { get; set; }
        public DateTime PrazoValidade { get; set; }
    }
}
