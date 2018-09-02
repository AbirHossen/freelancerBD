using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using freelancerBD.Infrastructure;
using freelancerBD.IService;
using System.Data.Entity;


namespace freelancerBD.Service
{
    public class AdminCommon<T> : AdminCommonInterface<T> where T : class

    {
        protected readonly DbContext Context;
        public AdminCommon(DbContext context)
        {
            Context = context;
        }
        public void Delete(T t, int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            
                return Context.Set<T>().ToList();
            
        }

        public void Insert(T t, int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T t, int id)
        {
            throw new NotImplementedException();
        }
    }
}
