using IMyWindowsApp.Data.Models;
using IMyWindowsApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Services
{
    internal class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public void Add(Address model)
        {
            _addressRepository.Add(model);
        }

        public Address Get(Guid id)
        {
           return _addressRepository.Get(id);
        }

        public List<Address> GetAllByStudent(Guid id)
        {
            return _addressRepository.GetAllByStudent(id);
        }

        public int IndexOf(Address model)
        {
            return _addressRepository.IndexOf(model);
        }

        public void Remove(Address model)
        {
            _addressRepository.Remove(model);
        }

        public void Update(Address model)
        {
            var oldAddress = _addressRepository.Get(model.Id);
            int index = _addressRepository.IndexOf(oldAddress);
            _addressRepository.Update(model, index);
        }
    }
}
