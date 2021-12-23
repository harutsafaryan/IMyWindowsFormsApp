using IMyWindowsApp.Data.DB;
using IMyWindowsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Repositories
{
    internal class AddressRepository : BaseRepository<Address>,  IAddressRepository
    {
        private readonly IDbContext _dbContext;
        public AddressRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public override void Add(Address model)
        {
            _dbContext.Addresses.Add(model);
        }

        public override Address Get(Guid id)
        {
           return _dbContext.Addresses.FirstOrDefault(x => x.Id == id);
        }

        public List<Address> GetAllByStudent(Guid id)
        {
            return _dbContext.Addresses.Where(x => x.StudentId == id).ToList();
        }

        public  override int IndexOf(Address model)
        {
            return _dbContext.Addresses.IndexOf(model);
        }

        public override void Remove(Address model)
        {
            _dbContext.Addresses.Remove(model);
        }

        public override void Update(Address model, int index)
        {
            _dbContext.Addresses[index] = model;
        }
    }
}
