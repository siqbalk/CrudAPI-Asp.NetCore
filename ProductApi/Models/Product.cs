using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Models
{
    [Table("Product")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string  ProductName { get; set; }
        public int  Price { get; set; }
        public string  Description { get; set; }
        public int Qnty { get; set; }
    }
}
