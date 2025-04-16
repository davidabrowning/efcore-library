using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Member? Member { get; set; }
    }
}
