using freelancerBD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.IService
{
    public interface IAdminService : AdminCommonInterface<Admin>
    {
        bool ChangePassword(Admin admin);
    }
    
}
