using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaylaVilla.Dto.Dtos.WorkFlowDtos
{
    public class CreateWorkFlowDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}
