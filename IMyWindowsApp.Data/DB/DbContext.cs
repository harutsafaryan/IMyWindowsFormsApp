using IMyWindowsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsApp.Data.DB
{
    internal class DbContext : IDbContext
    {
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
        public List<Address> Addresses { get; set; }

        public DbContext()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
            Addresses = new List<Address>();
        }
    }
}
