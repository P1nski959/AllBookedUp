using AllBookedUp.Server.Data;
using AllBookedUp.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllBookedUp.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetFeaturedProducts()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                    .Where(p => p.Featured)
                    .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower())).ToListAsync()
            };

            return response;
        }

        //Retrieves the Product by Id
        public async Task<ServiceResponse<Product>> GetProductById(int id)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but it appears that this product does not exist.";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }

        //Retrieves products from the service response class
        public async Task<ServiceResponse<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>
            {
                Data = products
            };

            return response;
        }

        //retrieves suggestions for the search feature from the service response class
        public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText)
        {
            var products = await FindProductsBySearchText(searchText);

            List<string> result = new List<string>();

            foreach (var product in products)
            {
                if (product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product.Title);
                }
            }

            return new ServiceResponse<List<string>> { Data = result };
        }

        //retrieves products from the searched text
        public async Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page)
        {
            var pageResults = 2f;
            var pageCount = Math.Ceiling((await FindProductsBySearchText(searchText)).Count / pageResults);

            var products = await _context.Products
                            .Where(p => p.Title.ToLower().Contains(searchText.ToLower()))
                            .Skip((page - 1) * (int)pageResults)
                            .Take((int)pageResults)
                            .ToListAsync();

            //adds pagination response at bottom of the page
            var response = new ServiceResponse<ProductSearchResult>
            {
                Data = new ProductSearchResult
                {
                    Products = products,
                    CurrentPage = page,
                    Pages = (int)pageCount
                }
            };

            return response;
        }

        //Finds products by text searched
        private async Task<List<Product>> FindProductsBySearchText(string searchText)
        {
            return await _context.Products
                            .Where(p => p.Title.ToLower().Contains(searchText.ToLower()))
                            .ToListAsync();
        }
    }
}
