﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.Comments;
using GriffonCMS.Domain.Entities.Contact;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Command.Contacts;

namespace GriffonCMS.Infrastructure.Maps.Contacts;
public class ContactMap : Profile
{
    public ContactMap()
    {
        CreateMap<ContactEntity, CreateContactCommand>().ReverseMap();
        CreateMap<ContactEntity, DeleteContactByIdCommand>().ReverseMap();
    }
}
