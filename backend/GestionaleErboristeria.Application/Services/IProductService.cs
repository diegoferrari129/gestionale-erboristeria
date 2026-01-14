using GestionaleErboristeria.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionaleErboristeria.Application.Services
{
    public interface IProductService
    {
        Task CreateProductAsync(CreateProductDto dto);
    }
}
