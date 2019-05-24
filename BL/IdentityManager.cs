using DAL;
using DAL.EF;

namespace BL
{
    public class IdentityManager : IIdentityManager
    {
        private IIdentityRepository repo;
        
        public IdentityManager(ApplicationDbContext ctx)
        {
            repo = new IdentityRepository(ctx);
        }

        public IdentityManager(IIdentityRepository identityRepo)
        {
            repo = identityRepo;
        }

        public Organisation getOrganisation(string userId)
        {
            return repo.readOrganisation(userId);
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