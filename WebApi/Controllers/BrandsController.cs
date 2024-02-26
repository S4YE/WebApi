using Bussiness.Abstracts;
using Bussiness.Dtos.Requests;
using Bussiness.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
            CreatedBrandResponse createdBrandResponse = _brandService.Add(createBrandRequest);

            return Ok(createdBrandResponse);

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_brandService.GetAll());
        }

    }
}


//404 - Hata
//401 - Yetkisiz bir islem 
//200 - basarili 
//201 - basarili ve eklendi