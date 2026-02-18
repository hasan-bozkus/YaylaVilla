using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Domain.Entites.Common;

namespace YaylaVilla.Domain.Entites
{
    public class Comment : BaseEntity
    {
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string CommentDetail { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsToxic { get; set; }
        public bool Sttaus { get; set; }
    }
}
