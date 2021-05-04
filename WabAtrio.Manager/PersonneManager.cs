using System;
using WebAtrio.Dao.Entity;
using WebAtrio.Manager.Interfaces;
using WebAtrio.Repository.Interfaces;

namespace WebAtrio.Manager
{
    public class PersonneManager : IPersonneManager
    {
        private readonly IPersonneRepository personneRepository;

        public PersonneManager(IPersonneRepository personneRepository)
        {
            this.personneRepository = personneRepository;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Personne Get(long id)
        {
            throw new NotImplementedException();
        }

        public long SaveOrUpdate(Personne item)
        {
            throw new NotImplementedException();
        }
    }
}
