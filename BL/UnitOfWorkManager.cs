using DAL;
using DAL.EF;

namespace BL
{
    public class UnitOfWorkManager
    {
        internal UnitOfWork UnitOfWork { get; } //Readonly-property!
        public UnitOfWorkManager()
        {
            this.UnitOfWork = new UnitOfWork();
        }
        
       

        //Deze methode zorgt ervoor dat alle tot hier toe aangebrachte wijzigingen binnen een 'unit of work'
        // kunnen worden gepersisteert naar de databank
        public void Save()
        {
            UnitOfWork.CommitChanges();
        }
        
        
    }
        
    
}