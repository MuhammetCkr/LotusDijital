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
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;

        }

        public Task<List<ProductDto>> GetManyAsync(Expression<Func<ProductDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> GetProductById(int id)
        {
            var product = await _productRepository.GetProductById(id);
            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }

        public async Task<List<ProductDto>> GetProductsWithCategories()
        {
            var productList = await _productRepository.GetProductsWithCategories();
            var productListDto = _mapper.Map<List<ProductDto>>(productList);
            return productListDto;
        }

        public async Task<bool> UpdateAsync(UpdateProductDto updateProductDto)
        {
            var product = await _productRepository.GetProductById(updateProductDto.Id);
            var productImageGalleries = new List<ImageGallery>();
            if (updateProductDto.ImageGalleryIds != null && updateProductDto.ImageGalleryIds.Count > 0)
            {
                foreach (var galleryId in updateProductDto.ImageGalleryIds)
                {
                    var productImageGallery = await _imageGalleryReposiyory.GetImageGallery(galleryId);
                    productImageGalleries.Add(productImageGallery);
                }
            }

            product.ImageGalleries = (updateProductDto.ImageGalleryIds != null && updateProductDto.ImageGalleryIds.Count > 0) ? productImageGalleries : product.ImageGalleries;
            product.Banner = updateProductDto.Banner;
            product.Title = updateProductDto.Title;
            product.Contents = updateProductDto.Contents;
            product.ShortContent = updateProductDto.ShortContent;
            product.Id = updateProductDto.Id;
            product.IsActive = updateProductDto.IsActive;
            product.Name = updateProductDto.Name;
            product.IsHome = updateProductDto.IsHome;
            product.Link = updateProductDto.Link;
            product.SmallImage = updateProductDto.SmallImage;
            product.Image = updateProductDto.Image;
            product.Url = updateProductDto.Url;
            product.TrendyolLink = updateProductDto.TrendyolLink;
            product.HepsiBuradaLink = updateProductDto.HepsiBuradaLink;
            product.CicekSepetiLink = updateProductDto.CicekSepetiLink;
            product.ProductCategories = updateProductDto
                .CategoryIds
                .Select(catId => new ProductCategories { ProductId = product.Id, CategoryId = catId })
                .ToList();
            var result = await _productRepository.UpdateAsync(product);
            return result != null;
        }
    }
}
