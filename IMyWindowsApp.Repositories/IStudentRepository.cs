using IMyWindowsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Repositories
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        List<Student> GetAllByTeacher(Guid id);
    }
}
