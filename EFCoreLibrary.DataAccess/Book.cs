using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLibrary.DataAccess
{
    public class Book
    {
        [Key]
        public int BookId { get; set; } = 0;
        public string Title { get; set; } = "";
    }
}
