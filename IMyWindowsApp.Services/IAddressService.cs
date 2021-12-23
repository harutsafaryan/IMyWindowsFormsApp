using IMyWindowsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Services
{
    public interface IAddressService
    {
        void Add(Address model);
        void Remove(Address model);
        void Update(Address model);
        Address Get(Guid id);
        List<Address> GetAllByStudent(Guid id);
        int IndexOf(Address model);
    }
}
