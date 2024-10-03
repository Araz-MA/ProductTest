using AutoMapper;
using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.EFCore;
using CleanArchitecture.Application.Common.Interfaces.Public;
using CleanArchitecture.Application.Features.Products.Models;
using CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Features.Products.Commands.Create
{
    public class UpdateProductCommand : UpdateProductDto, IRequest<int>
    {
        public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, int>
        {
            private readonly IDatabaseContext _context;
            private readonly IMapper _mapper;
            public DbSet<Product> Products { get; }

            public UpdateProductCommandHandler(IDatabaseContext context, IMapper mapper)
            {
                _context = context;
                Products = _context.Set<Product>();
                _mapper = mapper;
            }

            public async Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
            {
             
                var originalRecord = await Products.FindAsync(request.Id);

                originalRecord = _mapper.Map<UpdateProductCommand, Product>(request, originalRecord);
                
                var reternedId = await _context.SaveChangesAsync();
                return reternedId;
            }
        }
    }
}