using System;
using WebAtrio.Dao.Entity;
using WebAtrio.Manager;
using WebAtrio.Repository;
using WebAtrio.Service.Contract;

namespace WebAtrio.Service.Impl
{
    public class PersonneService : IPersonneService
    {
        public void SaveOrUpdate(Personne personne)
        {
            try
            {
                PersonneManager manager = new PersonneManager(new PersonneRepository(new EFUnitOfWork()));
                manager.SaveOrUpdate(personne);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
