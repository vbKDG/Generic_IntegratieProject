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
        
        public void Save()
        {
            UnitOfWork.CommitChanges();
        }
    }
}