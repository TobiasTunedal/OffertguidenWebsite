using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OffertguidenWebsite.Model
{
    
    public class BlogModel
    {
        [Key]

        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Text is required.")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public string Date { get; set; }

        public string Picture { get; set; }
    }
}
