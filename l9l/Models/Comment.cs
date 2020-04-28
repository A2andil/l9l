using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        public string CommentBody { get; set; }

        public DateTime date { get; set; }
    }
}
