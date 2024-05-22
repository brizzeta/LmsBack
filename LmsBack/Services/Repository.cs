using Microsoft.EntityFrameworkCore;

namespace LmsBack.Repositories {
    public interface IRepository<T> where T : class {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T item);
        void Update(T item);
        Task Delete(int id);
        Task Save();
    }
    public class Repository<T> : IRepository<T> where T : class {
        private readonly Context db;
        private readonly DbSet<T> dbSet;
        public Repository(Context context) {
            db = context;
            dbSet = db.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll() => await dbSet.ToListAsync();
        public async Task<T> GetById(int id) => await dbSet.FindAsync(id);
        public async Task Insert(T item) => await dbSet.AddAsync(item);
        public void Update(T item) => db.Entry(item).State = EntityState.Modified;
        public async Task Delete(int id) => dbSet.Remove(await GetById(id));
        public async Task Save() => await db.SaveChangesAsync();
    }
}