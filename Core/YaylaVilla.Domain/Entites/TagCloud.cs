using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Domain.Entites.Common;

namespace YaylaVilla.Domain.Entites
{
    public class TagCloud : BaseEntity
    {
        public int TagCloudID { get; set; }
        public string TagName { get; set; }
    }
}
