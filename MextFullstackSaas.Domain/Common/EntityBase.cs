using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MextFullstackSaas.Domain.Common
{

    //EntityBase class lari abstract olur
    public abstract class EntityBase<Tkey>:IEntity<Tkey>,ICreatedByEntity,IModifiedByEntity
    {
        public Tkey Id { get; set; }
        public DateTimeOffset CreatedOn {get; set; }
        public string CreatedByUserId { get; set;}
        public DateTimeOffset? ModifiedOn { get; set; }
        public string? ModifiedByUserId {get; set; }

    }
}