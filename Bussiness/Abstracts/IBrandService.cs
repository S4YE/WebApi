using Bussiness.Dtos.Requests;
using Bussiness.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstracts;

public interface IBrandService
{
    CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);
    List<GetAllBrandResponse> GetAll();
}
//responses and requests