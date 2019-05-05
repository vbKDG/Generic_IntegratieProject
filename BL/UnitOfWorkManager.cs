using DAL;
using DAL.EF;

namespace BL
{
    public class UnitOfWorkManager
    {
        public UnitOfWorkManager()
        {
            this.UnitOfWork = new UnitOfWork();
        }
        
        internal UnitOfWork UnitOfWork { get; } //Readonly-property!

        //Deze methode zorgt ervoor dat alle tot hier toe aangebrachte wijzigingen binnen een 'unit of work'
        // kunnen worden gepersisteert naar de databank
        public void Save()
        {
            UnitOfWork.CommitChanges();
        }
        
        
    }
        
    
}