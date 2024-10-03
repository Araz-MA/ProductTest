using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities.Base
{
    /// <summary>
    /// An interface for sign objects
    /// </summary>
    public interface IEntity
    {
    }

    /// <summary>
    /// An interface for base entity
    /// </summary>
    /// <typeparam name="T"> Type of Entity key</typeparam>
    public interface IBaseEntity<T> : IEntity
    {
        T Id { get; set; }
    }
    /// <summary>
    /// An interface for base entity
    /// </summary>
    public interface IBaseEntity : IBaseEntity<int>
    {
    }
}
