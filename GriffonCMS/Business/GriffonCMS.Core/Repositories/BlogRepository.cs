using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Core.Repositories.Base;

using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Entities.Tag;
using GriffonCMS.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GriffonCMS.Core.Repositories;
public class BlogRepository : AuditableBaseRepository<BlogEntity, Guid>, IBlogRepository
{
    private readonly GriffonEFContext _dbContext;
    protected readonly DbSet<BlogEntity> _dbSet;
    public BlogRepository(GriffonEFContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        _dbSet = _dbContext.Set<BlogEntity>();
    }

    public async Task<IEnumerable<BlogEntity>> GetAllByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbSet.AsNoTracking().Where(q => id.Equals(q.UserId)).ToListAsync(cancellationToken);
    }
}
