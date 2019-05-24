using System.Collections.Generic;
using System.Linq;
using DAL.EF;

namespace DAL
{
    public class IdentityRepository : IIdentityRepository
    {
        private ApplicationDbContext ctx;

        public IdentityRepository(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public Organisation readOrganisation(string userId)
        {
            IEnumerable<Organisation> orgList = ctx.Organisations.Where(o => o.ApplicationUser.Id == userId).AsEnumerable();
            if (orgList.Any())
            {
                return orgList.First();
            }
            return null;
        }

        public void updateOrganisation(Organisation organisation)
        {
            ctx.Organisations.Update(organisation);
            ctx.SaveChanges();
        }

        public void deleteOrganisation(string organisationId)
        {
            ctx.Organisations.Remove(ctx.Organisations.Find(organisationId));
            ctx.SaveChanges();
        }
    }
}