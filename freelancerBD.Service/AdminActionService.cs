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
    public class AdminActionService : AdminCommon<AdminAction> , IAdminAction
    {
        public AdminActionService(DbContext context) : base(context)
        {

        }
    }
}
