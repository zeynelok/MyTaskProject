using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using TaskProjectWebApp.Business.Abstract;
using TaskProjectWebApp.Entities.JsonResults;
using TaskProjectWebApp.Entities.ViewModels;

namespace TaskProjectWebApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public bool AddCategory(CategoryViewModel categoryViewModel)
        {
           
            var client = new RestClient($"http://localhost:61481/api/categories/add");
            var request = new RestRequest(Method.POST);
            var body = JsonConvert.SerializeObject(categoryViewModel);
            IRestResponse response = client.ExecuteAsync(request.AddJsonBody(body)).Result;
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<CategoryResult>(response.Content);
                return content.Success;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var client = new RestClient($"http://localhost:61481/api/categories/delete");
            var request = new RestRequest(Method.GET);
          
            IRestResponse response = client.ExecuteAsync(request.AddParameter("id",id)).Result;
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<CategoryResult>(response.Content);
                return content.Success;
            }
            return false;
        }

        public CategoryListViewModel GetAll()
        {
            var model = new CategoryListViewModel();

            var client = new RestClient($"http://localhost:61481/api/categories/getall");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.ExecuteAsync(request).Result;
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<CategoryListResult>(response.Content);
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

      

        public CategoryViewModel GetById(int id)
        {
            var model = new CategoryViewModel();

            var client = new RestClient($"http://localhost:61481/api/categories/getbyid");
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.ExecuteAsync(request.AddParameter("id", id)).Result;
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<CategoryResult>(response.Content);
                if (content.Success)
                {
                    model.Description = content.Data.Description;
                    model.Name = content.Data.Name;
                    model.Id = content.Data.Id;                 
                }             
            }
            return model;
        }

        public bool UpdateCategory(CategoryViewModel categoryViewModel)
        {
           

            var client = new RestClient($"http://localhost:61481/api/categories/update");
            var request = new RestRequest(Method.POST);
            var body = JsonConvert.SerializeObject(categoryViewModel);
            IRestResponse response = client.ExecuteAsync(request.AddJsonBody(body)).Result;
            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<CategoryResult>(response.Content);
                return content.Success;
            }
            return false;
        }
    }
}
