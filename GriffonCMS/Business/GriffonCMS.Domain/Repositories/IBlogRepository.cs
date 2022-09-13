using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Entities.Tag;
using GriffonCMS.Domain.Repositories.Base.Abstract;

namespace GriffonCMS.Domain.Repositories;
public interface IBlogRepository: IBaseRepository<BlogEntity, Guid>
{
    public Task<IEnumerable<BlogEntity>> GetAllByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
