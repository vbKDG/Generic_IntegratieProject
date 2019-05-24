using DAL.EF;

namespace DAL
{
    public interface IIdentityRepository
    {
        Organisation readOrganisation(string userId);
        void updateOrganisation(Organisation organisation);
        void deleteOrganisation(string organisationId);
    }
}