using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System.Linq.Expressions;

namespace NWCProject.Repositories
{
    public class GeneralRepository<T> where T : class
    {
        protected NwcDbContext nwcDbContext;
        protected DbSet<T> Sets;

        public GeneralRepository(NwcDbContext nwcDbContext)
        {
            this.nwcDbContext = nwcDbContext;
            Sets = nwcDbContext.Set<T>();
        }

        public void Add(T Entity)
        {

            Sets.Add(Entity);


            nwcDbContext.SaveChanges();

        }

        public virtual async ValueTask<EntityEntry<T>> AddAsync(T Entity)
        {



            return await Sets.AddAsync(Entity);

        }



        public async Task<List<T>> GetList()
        {

            var result = await Sets.AsQueryable().AsNoTracking().ToListAsync();


            return result;

        }

        public virtual IQueryable<T> GetOne(Expression<Func<T, bool>> expression)
        {

            var query = Sets.AsQueryable<T>();
            if (expression != null)
            {
                var result = query.Where(expression);
                return result;


            }

            return null;

        }


        public IQueryable<T> GetWithRelatedEntity(Expression<Func<T, bool>> expression = null, params string[] navigationProperty)
        {
            IQueryable<T> result = Sets.AsNoTracking();
            if (navigationProperty != null && navigationProperty.Count()!=0)
            {
                foreach (string Name in navigationProperty)
                {
                    result = result.Include(Name);
                }
            }
            if (expression != null)
            {


                result = result.Where(expression);


            }
            if (result != null)
                return result;
            return null;



        }






    }
    public class GenericRepository<TEntity> where TEntity : class, new()
    {
        protected readonly NwcDbContext nwcDbContext;

        private DbSet<TEntity> DbSet
        {
            get
            {
                return nwcDbContext.Set<TEntity>();
            }
        }
        public GenericRepository(NwcDbContext DbContext)
        {
            nwcDbContext = DbContext;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            return (await DbSet.AddAsync(entity)).Entity;
        }
        public async Task<TEntity?> FindAsync(params object[] predicate)
        {
            return await DbSet.FindAsync(predicate);
        }
        public async Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.FirstAsync(predicate);
        }
        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }
        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.CountAsync(predicate);
        }
        public async Task<int> CountAsync()
        {
            return await DbSet.CountAsync();
        }
        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }
        public void RemoveRange(List<TEntity> list)
        {
            foreach (var item in list)
                Remove(item);
        }
        public void Remove(TEntity enity)
        {
            DbSet.Remove(enity);
        }
        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AnyAsync(predicate);
        }
        public async Task<TEntity?> FirstOrDefaultAsync()
        {
            return await DbSet.FirstOrDefaultAsync();
        }
        public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.FirstOrDefaultAsync(predicate);
        }
        public async Task<int> CommitAsync()
        {
            return await nwcDbContext.SaveChangesAsync();
        }
    }
}