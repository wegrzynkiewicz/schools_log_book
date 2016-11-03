using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SLB.Domain.Exceptions;

namespace SLB.Domain
{
    abstract class AbstractId
    {
        public int Value { get; private set; }

        public AbstractId(int id)
        {
            if (id <= 0)
            {
                throw new InvalidIdException();
            }
            this.Value = id;
        }
    }
}
