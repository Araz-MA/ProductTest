using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities.Base
{
    public class BaseEntityWithAudit<T> : IBaseEntity<T>
    {
        /// <summary>
        /// Base entity with audit log
        /// </summary>
        /// <typeparam name="T">Type of Entity key</typeparam>
        public T Id { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }

    /// <summary>
    /// Base entity with audit log
    /// </summary>
    public class BaseEntityWithAudit : BaseEntityWithAudit<int>
    {
    }
}
