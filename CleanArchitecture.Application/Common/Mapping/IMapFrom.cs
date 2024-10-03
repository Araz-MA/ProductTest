using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Common.Mapping
{
   public interface IMapFrom<T>
    {
        public int Id { get; set; }
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
