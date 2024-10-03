using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities.Base
{
    /// <summary>
    /// Base entity with audit and soft delete
    /// </summary>
    /// <typeparam name="T">Type of Entity key</typeparam>
    public class BaseEntityWithAuditAndSoftDelete<T> : IBaseEntity<T>
    {
        public T Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? LastModified { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
    }
    /// <summary>
    /// Base entity with audit and soft delete
    /// </summary>
    public class BaseEntityWithAuditAndSoftDelete : BaseEntityWithAuditAndSoftDelete<int>
    {
    }
}
