using freelancerBD.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.Infrastructure
{
    public class FreelancerContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AdminAction> AdminActions { get; set; }
        public DbSet<Bidder> Bidders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientAccount> ClientAccounts{ get; set; }
        public DbSet<Freelancer> Freelancers{ get; set; }
        public DbSet<FreelancerAccount> FreelancerAccounts{ get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<SystemTransactionHistory> SystemTransactionHistories { get; set; }


    }
}
