using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        public int MyProperty { get; set; }
    }
}
