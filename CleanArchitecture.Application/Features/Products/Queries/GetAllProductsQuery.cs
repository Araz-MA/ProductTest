using AutoMapper;
using CleanArchitecture.Application.Common.Caching;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.EFCore;
using CleanArchitecture.Application.Features.Products.Commands.Create;
using CleanArchitecture.Application.Features.Products.Models;
using CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ZstdSharp.Unsafe;

namespace Clean14000716.Application.Features.School.Queries
{
    [Cached]
    public class GetAllProductsQuery : GetProductDto, IRequest<List<GetProductDto>>
    {

        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<GetProductDto>>
        {
            private readonly IDatabaseContext _context;
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public DbSet<Product> Products { get; }

            public GetAllProductsQueryHandler(IDatabaseContext context, IUnitOfWork unitOfWork, IMapper mapper)
            {
                _context = context;
                _unitOfWork = unitOfWork;
                _mapper = mapper;
                Products = _context.Set<Product>();    
            }

            public async Task<List<GetProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                // via dapper


                //var watch = Stopwatch.StartNew();

                //var list1 = await _unitOfWork.SchoolRepository.GetAllListAsync();

                //var conStr = "Server=.;Database=library1000;Trusted_Connection=True;";
                //var query = @"SELECT [Id]
                //              ,[Name]
                //              ,[Created]
                //              ,[CreatedBy]
                //              ,[LastModified]
                //              ,[LastModifiedBy]
                //              ,[IsDeleted]
                //              ,[DeletedAt]
                //              ,[RowVersion]
                //               FROM [dbo].[Schools]";
                //using IDbConnection connection = new SqlConnection(conStr);
                //var res = await connection.QueryAsync<Domain.Entities.School>(query);


                var originalRecords = await Products.AsNoTracking().ToListAsync(cancellationToken: cancellationToken);
                 
                var list = _mapper.Map<List<GetProductDto>>(originalRecords);

               
                return list;





            }
        }

    }
}