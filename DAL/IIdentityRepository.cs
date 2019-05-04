using DAL.EF;

namespace DAL
{
    public interface IIdentityRepository
    {
        Organisation readOrganisation(string UserId);
        void updateOrganisation(Organisation organisation);
        void deleteOrganisation(string organisationId);
    }
}