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
        void Insert(T t, int id);
        void Update(T t, int id);
        void Delete(T t, int id);
    }
}
