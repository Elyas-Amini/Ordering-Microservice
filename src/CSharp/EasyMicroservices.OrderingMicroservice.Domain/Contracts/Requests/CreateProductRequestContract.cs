﻿using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Domain.Contracts.Common;
using EasyMicroservices.Domain.DataTypes;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Requests
{
    public class CreateProductRequestContract : IUniqueIdentitySchema
    {
        [ContentLanguage(nameof(OrderContract.Name))]
        public List<LanguageDataContract> Names { get; set; }
        [ContentLanguage(nameof(OrderContract.Description))]
        public List<LanguageDataContract> Descriptions { get; set; }
        public PriceContract Price { get; set; }
        public string UniqueIdentity { get; set; }
        public long? ParentId { get; set; }

        public List<CreateProductRequestContract> Children { get; set; }
    }
}
