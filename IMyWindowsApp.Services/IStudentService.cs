using IMyWindowsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Services
{
    public interface IStudentService
    {
        void Add(Student model);
        void Remove(Student model);
        void Update(Student model);
        Student Get(Guid id);
        List<Student> GetAll();
        List<Student> GetAllByTeacher(Guid id);
        int IndexOf(Student model);

    }
}
