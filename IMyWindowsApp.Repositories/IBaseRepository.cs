using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Repositories
{
    public interface IBaseRepository<T>
    {
        void Add(T model);
        void Remove(T model);
        T Get(Guid id);
        void Update(T model, int index);
        List<T> GetAll();
        int IndexOf(T model);
    }
}
