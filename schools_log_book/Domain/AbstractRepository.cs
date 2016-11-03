using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLB.Domain
{
    abstract class AbstractRepository<EntityType, IdType, DataSetType>
    {
        public AbstractRepository()
        {
        }

        public abstract EntityType create(DataSetType dataset);
        public abstract void findById(IdType id);
        public abstract void delete(EntityType entity);
    }
}
