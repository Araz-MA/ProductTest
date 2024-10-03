using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities.Base
{
    /// <summary>
    /// Base entity with soft delete
    /// </summary>
    /// <typeparam name="T">Type of Entity key</typeparam>
    public class BaseEntityWithSoftDelete<T> : IBaseEntity<T>
    {
        public T Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
    }
    /// <summary>
    /// Base entity with soft delete
    /// </summary>
    public class BaseEntityWithSoftDelete : BaseEntityWithSoftDelete<int>
    {
    }

}
