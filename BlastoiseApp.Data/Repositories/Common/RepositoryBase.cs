namespace BlastoiseApp.Data.Repositories.Common
{
	public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
	{
		protected BlastoiseAppDbContext _context { get; }

		protected RepositoryBase(BlastoiseAppDbContext context)
		{
			_context = context;
		}

		public virtual async Task<TEntity?> GetByIdAsync(int id) =>
				 await _context.Set<TEntity>().FindAsync(id);

		public virtual async Task<List<TEntity>> GetAllAsync() =>
				await _context.Set<TEntity>().OrderBy(x => x.CreatedAt).ToListAsync();

		public virtual async Task<List<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> expression) =>
				await _context.Set<TEntity>().Where(expression).ToListAsync();

		public virtual async Task CreateAsync(TEntity entity)
		{
			await _context.Set<TEntity>().AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public virtual async Task UpdateAsync(TEntity entity)
		{
			entity.SetUpdatedDate(DateTime.Now);

			_context.Set<TEntity>().Update(entity);
			await _context.SaveChangesAsync();
		}

		public virtual async Task DeleteAsync(TEntity entity)
		{
			_context.Set<TEntity>().Remove(entity);
			await _context.SaveChangesAsync();
		}

		public virtual async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression) =>
			await _context.Set<TEntity>().AnyAsync(expression);
	}
}
