using IMyWindowsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Repositories
{
    public interface IAddressRepository  : IBaseRepository<Address>
    {
        List<Address> GetAllByStudent(Guid id);
    }
}
