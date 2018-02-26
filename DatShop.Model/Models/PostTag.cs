using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Model.Models
{
    [Table("PostTags")]
   public class PostTag
    {
        [Key]
        public string TagID { get; set; }

        [Key]
        public int PostID { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
