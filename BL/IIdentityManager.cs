using DAL.EF;

namespace BL
{
    public interface IIdentityManager
    {
        Organisation getOrganisation(string userId);
        void changeOrganisation(Organisation organisation);
        void removeOrganisation(string organisationId);
    }
}