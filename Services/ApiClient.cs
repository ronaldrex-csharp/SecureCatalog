
using SecureCatalog.Models;
using System;
using System.Linq;
using System.Net.Http.Json;
using SecureCatalog.Exceptions;   

namespace SecureCatalog.Services;

public class ApiClient
{
    private readonly HttpClient _http;
    // Use the injected HttpClient.BaseAddress configured in Program.cs

    public ApiClient(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        try
        {
            var resp = await _http.GetAsync("api/products");
            if (!resp.IsSuccessStatusCode) return new List<Product>();
            return await resp.Content.ReadFromJsonAsync<List<Product>>() ?? new List<Product>();
        }
        catch (HttpRequestException)
        {
            return new List<Product>();
        }
    }

    public async Task CreateProductAsync(CreateProductRequest request)
    {
        // Database access (SqliteConnection / builder) is a server-side concern.
        // Remove client-side DB code and call the server API instead.
        var response = await _http.PostAsJsonAsync(
            "api/products",
            request);

        if (!response.IsSuccessStatusCode)
            {
                     var result = await response.Content
                    .ReadFromJsonAsync<ValidationErrorResponse>();

            var errors = result?.Errors
                            ?? new List<string>
                    {
                            "Validation failed."
                    };

            throw new ApiValidationException(errors);
        }
    }

    public async Task UpdateProductAsync(Product product)
    {
        await _http.PutAsJsonAsync(
            $"api/products/{product.Id}",
            product);
    }

    public async Task DeleteProductAsync(int id)
    {
        await _http.DeleteAsync($"api/products/{id}");
    }
}
