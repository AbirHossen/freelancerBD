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
        public bool Delete(T t, int id)
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

        public T GetById(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public bool  Insert(T t)
        {
            try
            {
                Context.Entry<T>(t).State = EntityState.Added;
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

         public bool  Update(T t)
        {
            try
            {
                Context.Entry<T>(t).State = EntityState.Modified;
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
