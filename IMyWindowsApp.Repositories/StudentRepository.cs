using IMyWindowsApp.Data.DB;
using IMyWindowsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Repositories
{
    internal class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        private readonly IDbContext _dbContext;
        public StudentRepository(IDbContext dbContext)  : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override void Add(Student model)
        {
            _dbContext.Students.Add(model);
        }

        public override Student Get(Guid id)
        {
            return _dbContext.Students.FirstOrDefault(x => x.Id == id);
        }

        public override List<Student> GetAll()
        {
            return _dbContext.Students;
        }

        public List<Student> GetAllByTeacher(Guid id)
        {           
            return _dbContext.Students.Where(x => x.teacherId == id).ToList();
        }
        public override int IndexOf(Student model)
        {
            return _dbContext.Students.IndexOf(model);
        }

        public override void Remove(Student model)
        {
            _dbContext.Students.Remove(model);
        }

        public override void Update(Student model, int index)
        {
            _dbContext.Students[index] = model;
        }
    }
}
