using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MextFullstackSaas.Domain.Common
{
    public interface ICreatedByEntity
    {
        public DateTimeOffset CreatedOn { get; set; }

        public string CreatedByUserId { get; set; }
    }
}