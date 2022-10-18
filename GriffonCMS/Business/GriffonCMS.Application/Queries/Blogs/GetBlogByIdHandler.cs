using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Blogs;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Queries.Blogs;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.Blogs;
public class GetBlogByIdHandler : IRequestHandler< GetBlogByIdQuery, List<GetBlogDto>>
{

        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetBlogByIdHandler> _logger;

        public GetBlogByIdHandler(IBlogRepository blogRepository, IMapper mapper, ILogger<GetBlogByIdHandler> logger)
        {
            _blogRepository = blogRepository ?? throw new ArgumentNullException(nameof(blogRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<GetBlogDto>> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _blogRepository.GetAllByIdAsync(request.UserId, cancellationToken);
            var mapped = _mapper.Map<List<GetBlogDto>>(response);
            return mapped;
        }
}
