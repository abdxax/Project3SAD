using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSAD3.Repstory
{
    interface IRepstory<T>
    {
        IEnumerable<T> GetAll();
        bool Add(T item);
        bool Delete(int id);
        T Get(int id);
        bool Update(int id, T item);
    }
}
