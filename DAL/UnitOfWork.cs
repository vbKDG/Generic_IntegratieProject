using DAL.EF;

namespace DAL
{
    public class UnitOfWork
    {
        /*public UnitOfWork()
        {
            Context = new DemoDbContext(isUnitOfWorkPresent:true);
        }

        internal DemoDbContext Context { get; } 

        public void CommitChanges()
        {
            Context.CommitChanges();
        }*/
        
        public UnitOfWork()
        {
            //De parameter 'isUnitOfWorkPresent' geeft aan dat er gewerkt wordt binnen een 'unit of work', en zo het gedrag van de DbContext hierop af te stemmen.
            Context = new ApplicationDbContext(isUnitOfWorkPresent:true);
        }

        internal ApplicationDbContext Context { get; } //Readonly-property!!

        //Deze methode zorgt ervoor dat alle aangebrachte wijzigingen binnen een 'unit of work'
        // gepersisteert worden naar de databank.
        public void CommitChanges()
        {
            Context.CommitChanges();
        }
    }
}