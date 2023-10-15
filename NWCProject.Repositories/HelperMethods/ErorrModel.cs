using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Repositories
{
    public class ErorrModel
    {
        public string ErrorMessage { get; set; }
        public bool Status { get; set; }

        public static implicit operator Task<object>(ErorrModel v)
        {
            throw new NotImplementedException();
        }
    }
}
