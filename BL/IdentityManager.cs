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
//        public IdentityManager()
//        {
//            repo = new IdentityRepository();
//        }

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