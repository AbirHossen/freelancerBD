using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.IService
{
    public interface AdminCommonInterface<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        bool Insert(T t);
        bool Update(T t);
        bool Delete(T t, int id);
    }
}
