﻿using AllBookedUp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AllBookedUp.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public List<Category> Categories { get; set; } = new List<Category>();

        //retrieves available categories
        public async Task GetCategories()
        {
            var response = await _http.GetFromJsonAsync <ServiceResponse<List < Category >>> ("api/category");
            Categories = response.Data;
        }
    }
}
