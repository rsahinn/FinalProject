using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entitiy.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI2.Controllers
{
    //Eğer sen bir bağımlılık görürsen bunun karşılığı için bir newleme işlemi yapacaksın.
    //Bu newleme işlemi de ikinci olarak verdiğimiz newlemedir.

    [Route("api/[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var result = _productService.getAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("Put")]
        public IActionResult Put(Product product)
        {
            var result=_productService.Update(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
//Constructor yapı kullanmak yerine newleme işlemi yaparsak o Manager
//sınıfına bağımlı hale gelmiş oluruz. Bunun için constructor kullanmamız gerekir. Ancak bunu
//kullanabilmek için de Program.cs içindeki Add.controllers altında bir addsingleton yapmamız 
//gerekiyor. Bunu yapmak demek arka planda bir newleme işlemini biz yazmadan kendisi yazmak demek.
//Örnek: builder.Services.AddSingleton<IProductService, ProductManager>();
//Yukarıdaki örnekte programa bir IProductService gördüğü zaman onun için bir ProductManager
// sınıfı newleme işlemi yapacağını söylemiş oldu. Eğer bunu yapmazsak program hata verir. 

