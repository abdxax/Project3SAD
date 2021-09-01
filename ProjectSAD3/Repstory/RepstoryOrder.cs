using ProjectSAD3.Data;
using ProjectSAD3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSAD3.Repstory
{
    public class RepstoryOrder : IRepstory<Order>
    {
        private readonly DContext _db;
        public RepstoryOrder(DContext db)
        {
            _db = db;
        }
        public bool Add(Order item)
        {
            _db.orders.Add(item);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            return _db.orders.ToList();
        }

        public bool Update(int id, Order item)
        {
            throw new NotImplementedException();
        }
    }
}
