namespace WebAtrio.Manager.Interfaces
{
    public interface IManager<TEntity> where TEntity : class
    {
        TEntity Get(long id);

        void Delete(long id);

        long SaveOrUpdate(TEntity item);
    }
}
