using AutoMapper;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.EFCore;
using CleanArchitecture.Application.Features.Products.Models;
using CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean14000716.Application.Features.School.Queries
{
    public class GetProductQuery : IRequest<GetProductDto>
    {
        public int Id { get; set; }
        public class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductDto>
        {

            private readonly IDatabaseContext _context;
            private readonly IMapper _mapper;
            public DbSet<Product> Products { get; }


            public GetProductQueryHandler(IDatabaseContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
                Products = _context.Set<Product>();
            }

            public async Task<GetProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
            {
                var originalRecord = await Products.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
                var entity = _mapper.Map<GetProductDto>(originalRecord);
                return entity;
            }
        }

    }
}