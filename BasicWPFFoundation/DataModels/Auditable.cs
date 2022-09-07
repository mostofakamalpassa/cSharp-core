using BasicWPFFoundation.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWPFFoundation.DataModels
{
    public interface Auditable
    {
        DateTime CreatedOn { get; set; }
        User CreatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
        User UpdatedBy { get; set; }
    }
}
