using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Domain.Entites.Common;

namespace YaylaVilla.Domain.Entites
{
    public class WorkFlow : BaseEntity
    {
        public int WorkFlowID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}
