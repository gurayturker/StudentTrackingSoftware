using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTrackinSoftware.Common.Enums
{
   public enum CardType:byte
   {
        [Description("School Card")]
        School=1,
        [Description("City Card")]
        City =2,
        [Description("District Card")]
        District =3
   }
}
