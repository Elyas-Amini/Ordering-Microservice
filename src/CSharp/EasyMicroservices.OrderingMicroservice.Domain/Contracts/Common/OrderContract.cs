﻿using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Domain.Contracts.Common;
using EasyMicroservices.Domain.DataTypes;
using System;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class OrderContract : IUniqueIdentitySchema, ISoftDeleteSchema, IDateTimeSchema
    {
        public long Id { get; set; }

        [ContentLanguage]
        public string Name { get; set; }

        [ContentLanguage]
        public string Description { get; set; }

        public PriceContract Price { get; set; }
        public long? ParentId { get; set; }
        public long ProductId { get; set; }
        public ProductContract Product { get; set; }

        public string UniqueIdentity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
    }
}
