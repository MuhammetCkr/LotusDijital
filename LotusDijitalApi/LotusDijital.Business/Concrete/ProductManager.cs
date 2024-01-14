using AutoMapper;
using LotusDijital.Business.Abstract;
using LotusDijital.Data.Abstract;
using LotusDijital.Entity;
using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductManager(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(AddProductDto addProductDto)
        {
            var productAdd = _mapper.Map<Product>(addProductDto);
            var result = await _productRepository.CreateAsync(productAdd);

            if (result == null)
                return false;

            if (addProductDto.CategoryIds != null && addProductDto.CategoryIds.Count > 0)
            {
                await _productRepository.SaveProductCategoriesAsync(result.Id, addProductDto.CategoryIds);
            }
            return true;
        }

        public async Task<bool> DeleteAsync(ProductDto dto)
        {
            var product = _mapper.Map<Product>(dto);
            var response = await _productRepository.DeleteAsync(product);
            return response;
        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            if (products.Count == 0)
            {
                return new List<ProductDto> { new ProductDto() { ErrorMessage = "Hiç ürün bulunamadı!" } };
            }
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product != null)
            {
                var productDto = _mapper.Map<ProductDto>(product);
                return productDto;
            }
            return new ProductDto { ErrorMessage = "Ürün bulunamadı" };
        }

        public Task<List<ProductDto>> GetManyAsync(Expression<Func<ProductDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(UpdateProductDto updateProductDto)
        {
            var updateProduct = _mapper.Map<Product>(updateProductDto);
            var result = await _productRepository.UpdateAsync(updateProduct);
            return result != null;
        }
    }
}
