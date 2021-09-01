using ProjectSAD3.Data;
using ProjectSAD3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSAD3.Repstory
{
    public class RepstoryUser : IRepstory<User>
    {
        private DContext _db;
        public RepstoryUser(DContext db)
        {
            _db = db;
        }
        public bool Add(User item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, User item)
        {
            throw new NotImplementedException();
        }

        public bool Check(String email,String pass)
        {
            // var user = _db.users.AsEnumerable().Where(_db.users)
            return true;
        }
    }
}
