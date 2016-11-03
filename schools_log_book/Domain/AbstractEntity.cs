using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLB.Domain
{
    class AbstractEntity
    {
        public AbstractId Id { get; private set; }

        public AbstractEntity(AbstractId id)
        {
            this.Id = id;
        }
    }
}
