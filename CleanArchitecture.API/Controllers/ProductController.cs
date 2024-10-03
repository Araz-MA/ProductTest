using Clean14000716.Application.Features.School.Queries;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.EFCore;
using CleanArchitecture.Application.Common.Interfaces.Public;
using CleanArchitecture.Application.Features.Products.Commands.Create;
using CleanArchitecture.Application.Features.Products.Models;
using CleanArchitecture.WebCommon.Controller;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{



    public class ProductController : BaseController
    {
      
  
        public ProductController(IMediator mediator, IRedisManager redisManager) : base(mediator, redisManager){}

      
        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public async Task<ActionResult<int>> Create(CreateProductCommand createSchoolCommand) => await Execute(createSchoolCommand);

        [HttpPost]
        [AllowAnonymous]
        [Route("[action]")]
        public async Task<ActionResult<int>> Update(UpdateProductCommand updateProductCommand) => await Execute(updateProductCommand);


        [HttpGet]
        [AllowAnonymous]
        [Route("[action]")]
        public async Task<ActionResult<List<GetProductDto>>> GetAll() => await Execute(new GetAllProductsQuery());



        [HttpGet]
        [AllowAnonymous]
        [Route("[action]")]        
        public async Task<ActionResult<GetProductDto>> GetById(int id) => await Execute(new GetProductQuery() { Id = id});



    }
}