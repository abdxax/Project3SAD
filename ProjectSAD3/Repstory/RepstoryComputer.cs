using ProjectSAD3.Data;
using ProjectSAD3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSAD3.Repstory
{
    public class RepstoryComputer : IRepstory<Computer>
    {
        private DContext _db;

        public RepstoryComputer(DContext db)
        {
            _db = db;
        }
        public bool Add(Computer item)
        {
            try
            {
                Computer c = item;
            //    c.Id = _db.computers.Max(item => item.Id) + 1;
                _db.computers.Add(c);
                _db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Computer Get(int id)
        {
            return _db.computers.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Computer> GetAll()
        {
            return _db.computers.ToList();
        }

        public bool Update(int id, Computer item)
        {
            throw new NotImplementedException();
        }
    }
}
