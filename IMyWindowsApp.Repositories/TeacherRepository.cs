using IMyWindowsApp.Data.DB;
using IMyWindowsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Repositories
{
    internal class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        private readonly IDbContext _dbContext;
        public TeacherRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public override void Add(Teacher model)
        {
            _dbContext.Teachers.Add(model);
        }
        public override Teacher Get(Guid id)
        {
            return _dbContext.Teachers.FirstOrDefault(x => x.Id == id);
        }
        public override List<Teacher> GetAll()
        {
            return _dbContext.Teachers;
        }
        public override int IndexOf(Teacher model)
        {
            return _dbContext.Teachers.IndexOf(model);
        }
        public override void Remove(Teacher model)
        {
            _dbContext.Teachers.Remove(model);
        }
        public override void Update(Teacher model, int index)
        {
            _dbContext.Teachers[index] = model;
        }
    }
}
