using Microsoft.AspNetCore.Http;
using NShop.Models.Common;
using NShop.Models.ProductImages;
using NShop.Models.Products;
using NShop.Repositories;
using NShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NShop.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> AddImage(int productId, ProductImageCreateRequest request)
        {   
            return await _productRepository.AddImage(productId,request);
        }

        public async Task AddViewcount(int productId)
        {
            await _productRepository.AddViewcount(productId);
        }

        public async Task<int> Create(ProductCreateRequest request)
        {          
            return await _productRepository.Create(request);
        }

        public async Task<int> Delete(int productId)
        {
            return await _productRepository.Delete1(productId);
        }

        public async Task<PagedResult<ProductVm>> GetAllPaging(GetManageProductPagingRequest request)
        {           
            return await _productRepository.GetAllPaging(request);
        }

        public async Task<ProductVm> GetById(int productId, string languageId)
        {          
            return await _productRepository.GetById(productId,languageId);
        }

        public async Task<ProductImageViewModel> GetImageById(int imageId)
        {          
            return  await _productRepository.GetImageById(imageId);
        }

        public async Task<List<ProductImageViewModel>> GetListImages(int productId)
        {
            return await _productRepository.GetListImages(productId);
        }

        public async Task<int> RemoveImage(int imageId)
        {
          
            return await _productRepository.RemoveImage(imageId);
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
           
            return await _productRepository.Update(request);
        }

        public async Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request)
        {
           
            return await _productRepository.UpdateImage(imageId,request);
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {           
            return await _productRepository.UpdatePrice(productId,newPrice);
        }

        public async Task<bool> UpdateStock(int productId, int addedQuantity)
        {         
            return await _productRepository.UpdateStock(productId,addedQuantity);
        }

        public async Task<PagedResult<ProductVm>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request)
        {
           
            return await _productRepository.GetAllByCategoryId(languageId,request);
        }

        public async Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request)
        {
            
            return await _productRepository.CategoryAssign(id,request);
        }

        public async Task<List<ProductVm>> GetFeaturedProducts(string languageId, int take)
        {
            
            return await _productRepository.GetFeaturedProducts(languageId,take);
        }

        public async Task<List<ProductVm>> GetLatestProducts(string languageId, int take)
        {           
            return await _productRepository.GetLatestProducts(languageId,take);
        }
    }
}
