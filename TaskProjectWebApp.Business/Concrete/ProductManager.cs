using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using TaskProjectWebApp.Business.Abstract;
using TaskProjectWebApp.Entities.JsonResults;
using TaskProjectWebApp.Models;
using TaskProjectWebApp.Entities.Concrete;

namespace TaskProjectWebApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly ICategoryService _categoryManager;
        public ProductManager(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public ProductListViewModel GetAll()
        {
            var model = new ProductListViewModel();

            var client = new RestClient($"http://localhost:61481/api/products/getall");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.ExecuteAsync(request).Result;
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<ProductListResult>(response.Content);
                if (content.Success)
                {
                    foreach (var item in content.Data)
                    {
                        model.Data.Add(item);
                    }


                }
                else
                {
                    model.Message = content.Message;
                }
            }
            else
            {
                model.Message = "Listeleme yapılamadı!";
            }

            return model;
        }

        public ProductListViewModel GetByCategoryId(int id)
        {
            var model = new ProductListViewModel();

            var client = new RestClient($"http://localhost:61481/api/products/getallbycategoryid");
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.ExecuteAsync(request.AddParameter("categoryId", id)).Result;
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<ProductListResult>(response.Content);
                if (content.Success)
                {
                    foreach (var item in content.Data)
                    {
                        model.Data.Add(item);
                    }
                    model.Category = content.Category;

                }
                else
                {
                    model.Message = content.Message;
                }
            }
            else
            {
                model.Message = "Listeleme yapılamadı!";
            }

            return model;
        }

        public ProductViewModel GetById(int id)
        {
            var model = new ProductViewModel();

            var client = new RestClient($"http://localhost:61481/api/products/getbyid");
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.ExecuteAsync(request.AddParameter("id", id)).Result;
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<ProductResult>(response.Content);
                if (content.Success)
                {
                    model.Id = content.Data.Id;
                    model.Name = content.Data.Name;
                    model.Description = content.Data.Description;
                    model.CategoryId = content.Data.CategoryId;
                    model.Price = content.Data.Price;

                    return model;
                }
            }

            return null;
        }

        public bool UpdateProduct(ProductViewModel product)
        {
            var client = new RestClient($"http://localhost:61481/api/products/update");
            var request = new RestRequest(Method.POST);

            var body = JsonConvert.SerializeObject(product);

            IRestResponse response = client.ExecuteAsync(request.AddJsonBody(body)).Result;
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<ProductResult>(response.Content);
                return content.Success;
            }

            return false;
        }


        public void DeleteById(int id)
        {
            var client = new RestClient($"http://localhost:61481/api/products/delete");
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.ExecuteAsync(request.AddParameter("id", id)).Result;
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<CategoryResult>(response.Content);
            }
        }

        public bool AddProduct(ProductViewModel product)
        {
            var client = new RestClient($"http://localhost:61481/api/products/add");
            var request = new RestRequest(Method.POST);
            var body = JsonConvert.SerializeObject(product);
            IRestResponse response = client.ExecuteAsync(request.AddJsonBody(body)).Result;
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<ProductResult>(response.Content);
                return content.Success;

            }


            return false;
        }
    }
}
