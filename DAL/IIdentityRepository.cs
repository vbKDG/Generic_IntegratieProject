using DAL.EF;

namespace DAL
{
    public interface IIdentityRepository
    {
        void updateOrganisation(Organisation organisation);
        void deleteOrganisation(string organisationId);
        
        Organisation readOrganisation(string userId);
    }
}