using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MextFullstackSaas.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace MextFullstackSaas.Domain.Identity
{
    public class User : IdentityUser<Guid>, IEntity<Guid>, ICreatedByEntity, IModifiedByEntity
{
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public UserBalance Balance { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string? ModifiedByUserId { get; set; }
    }
        
}

