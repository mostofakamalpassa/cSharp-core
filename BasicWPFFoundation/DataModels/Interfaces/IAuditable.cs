using BasicWPFFoundation.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BasicWPFFoundation.DataModels.Interfaces
{
    internal interface IAuditable
    {
        DateTime CreatedOn { get; set; }
        User CreatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
        User UpdatedBy { get; set; }

        Auditable Auditable { get; set; }
    }
}
