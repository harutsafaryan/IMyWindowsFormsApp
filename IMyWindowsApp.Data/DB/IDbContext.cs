using IMyWindowsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Data.DB
{
    public interface IDbContext
    {
        List<Teacher>  Teachers { get; set; }
        List<Student> Students { get; set; }
        List<Address> Addresses { get; set; }
    }
}
