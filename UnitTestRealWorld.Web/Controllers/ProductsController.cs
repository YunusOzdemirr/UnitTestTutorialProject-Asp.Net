using Microsoft.AspNetCore.Mvc;
using UnitTestRealWorld.Web.Context;
using UnitTestRealWorld.Web.Models;
using UnitTestRealWorld.Web.Repository;

namespace UnitTestRealWorld.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IRepository<Product> _repository;

        public ProductsController(IRepository<Product> repository)
        {
            _repository = repository;
        }
        
    }
}