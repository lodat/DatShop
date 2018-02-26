using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        public string ID { get; set; }
        public string Content { get; set; }
    }
}
