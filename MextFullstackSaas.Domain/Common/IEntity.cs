//Db'ye gidecek objelerin en temiz hali
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MextFullstackSaas.Domain.Common
{
    public interface IEntity<Tkey>
    {
        public Tkey Id { get; set; }
    }
}