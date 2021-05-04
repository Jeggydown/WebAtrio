using WebAtrio.Dao.Entity;
using WebAtrio.Repository.Interfaces;

namespace WebAtrio.Repository
{
    public class PersonneRepository : EFRepository<Personne>, IPersonneRepository
    {
        public PersonneRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}
