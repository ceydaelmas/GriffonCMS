﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Blogs;
public class DeleteBlogByIdCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
}