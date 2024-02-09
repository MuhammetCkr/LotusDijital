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
        private readonly IImageGalleryReposiyory _imageGalleryReposiyory;
        private readonly IMapper _mapper;

        public ProductManager(IProductRepository productRepository, IMapper mapper, IImageGalleryReposiyory imageGalleryReposiyory)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _imageGalleryReposiyory = imageGalleryReposiyory;
        }

        public async Task<bool> CreateAsync(AddProductDto addProductDto)
        {
            var productAdd = _mapper.Map<Product>(addProductDto);
            var product = await _productRepository.CreateAsync(productAdd);

            if (product == null)
                return false;

            if (addProductDto.CategoryIds != null && addProductDto.CategoryIds.Count > 0)
            {
                await _productRepository.SaveProductCategoriesAsync(product.Id, addProductDto.CategoryIds);
            }
            if (addProductDto.ImageGalleryIds != null && addProductDto.ImageGalleryIds.Count > 0)
            {
                foreach (var imageGallery in addProductDto.ImageGalleryIds)
                {
                    var gallery = await _imageGalleryReposiyory.GetByIdAsync(imageGallery.Value);
                    gallery.ProductId = product.Id;
                    await _imageGalleryReposiyory.UpdateAsync(gallery);
                }
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

        public async Task<List<ProductDto>> GetProductsWithCategories()
        {
            var productList = await _productRepository.GetProductsWithCategories();
            var productListDto = _mapper.Map<List<ProductDto>>(productList);
            return productListDto;
        }

        public async Task<bool> UpdateAsync(UpdateProductDto updateProductDto)
        {
            var updateProduct = _mapper.Map<Product>(updateProductDto);
            var result = await _productRepository.UpdateAsync(updateProduct);
            return result != null;
        }
    }
}
