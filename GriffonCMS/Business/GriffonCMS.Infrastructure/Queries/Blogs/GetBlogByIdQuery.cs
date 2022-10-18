﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Blogs;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.Blogs;
public class GetBlogByIdQuery : IRequest<List<GetBlogDto>>

{
    public Guid UserId { get; set; }
}
