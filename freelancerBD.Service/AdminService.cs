using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using freelancerBD.Entities;
using freelancerBD.IService;

namespace freelancerBD.Service
{
    public class AdminService : AdminCommon<Admin>, IAdminService
    {
        public AdminService(DbContext context) : base(context)
        {

        }

        public bool ChangePassword(Admin admin)
        {

            try
            {
                Context.Entry<Admin>(admin).State = EntityState.Modified;
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
