using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class StubCheckoutService : ICheckoutService
    {
        public object GetSummary(string session)
        {
            throw new NotImplementedException();
        }
    }
}
