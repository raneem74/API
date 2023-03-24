namespace DTO.DBServiceRepo
{
    public interface IDBRepo<TEntity>
    {
        public TEntity GetById(int id);
        public TEntity GetByName(string name);
        public List<TEntity> GetAll();
        public void Add(TEntity entity);
        public void Update(int id, TEntity entity);
        public void Delete(int id);
    }
}
