using DAL;
using DAL.EF;

namespace BL
{
    public class IdentityManager : IIdentityManager
    {
        private IdentityRepository repo;
        
        public IdentityManager(ApplicationDbContext ctx)
        {
            repo = new IdentityRepository(ctx);
        }

        public Organisation getOrganisation(string UserId)
        {
            return repo.readOrganisation(UserId);
        }

        public void changeOrganisation(Organisation organisation)
        {
            repo.updateOrganisation(organisation);
        }

        public void removeOrganisation(string organisationId)
        {
            repo.deleteOrganisation(organisationId);
        }
    }
}