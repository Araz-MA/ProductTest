using AutoMapper;
using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.EFCore;
using CleanArchitecture.Application.Common.Interfaces.Public;
using CleanArchitecture.Application.Features.Products.Events;
using CleanArchitecture.Application.Features.Products.Models;
using CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Features.Products.Commands.Create
{
    public class CreateProductCommand : CreateProductDto, IRequest<int>
    {
        //برای راحتی کار بدون نویگیشن ها ایجاد شده
        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
        {
            private readonly IPublisher _publisher;
            private readonly IDatabaseContext _context;
            private readonly IMapper _mapper;
            public DbSet<Product> Products { get; }

            public CreateProductCommandHandler(IDatabaseContext context, IMapper mapper, IPublisher publisher)
            {
                _context = context;
                Products = _context.Set<Product>();
                _mapper = mapper;
                _publisher = publisher;
            }

            public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var product = _mapper.Map<Product>(request);
                await Products.AddAsync(product);
                var reternedId = await _context.SaveChangesAsync();
                await _publisher.Publish(new SendMessageNotification("admin@site.com", "A New Product Was Added"));
                return reternedId;
            }
        }
    }
}