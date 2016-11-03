using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLB.Domain.Student
{
    class StudentRepository : AbstractRepository<StudentEntity, StudentId, StudentDataSet>
    {
        public StudentRepository()
        {

        }

        public override StudentEntity create(StudentDataSet dataset)
        {
            throw new NotImplementedException();
        }

        public override void delete(StudentEntity entity)
        {
            throw new NotImplementedException();
        }

        public override void findById(StudentId id)
        {
            throw new NotImplementedException();
        }
    }
}
