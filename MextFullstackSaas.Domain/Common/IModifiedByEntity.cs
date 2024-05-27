using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MextFullstackSaas.Domain.Common
{
    public interface IModifiedByEntity
    {
        DateTimeOffset? ModifiedOn {get; set; }
        string? ModifiedByUserId {get; set; }
    }
}