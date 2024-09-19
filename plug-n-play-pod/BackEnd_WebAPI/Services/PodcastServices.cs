using BackEnd_WebAPI.Interfaces;
using BackEnd_WebAPI.Models;
using System.Text.Json;

namespace BackEnd_WebAPI.Services
{
    public class PodcastServices : IPodcastData
    {
        private static readonly HttpClient _httpClient;

        static PodcastServices()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://podcast-api.netlify.app")
            };
        }

        public async Task<List<Preview>> GetPreviewsAsync()
        {
            try
            {
                var url = string.Format("");
                var result = new List<Preview>();
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    var productsResponse = JsonSerializer.Deserialize<List<Preview>>(stringResponse);

                    result.AddRange(productsResponse);
                }
                else
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        throw new Exception("previews not found");
                    }
                    else
                    {
                        throw new Exception("failed to connect to server");
                    }
                }

                return result;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("http request failed: " + ex.Message);
            }
            catch (JsonException ex)
            {
                throw new Exception("json failed: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("error: " + ex.Message);
            }
        }

        public async Task<Genre> GetGenreAsync(int id)
        {
            try
            {
                var url = string.Format($"/genre/{id}");
                var result = new Genre();
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    var productsResponse = JsonSerializer.Deserialize<Genre>(stringResponse);

                    result = productsResponse;
                }
                else
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        throw new Exception("genres not found");
                    }
                    else
                    {
                        throw new Exception("failed to connect to server");
                    }
                }

                return result;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("http request failed: " + ex.Message);
            }
            catch (JsonException ex)
            {
                throw new Exception("json failed: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("error: " + ex.Message);
            }
        }

        public async Task<Show> GetShowAsync(string id)
        {
            try
            {
                var url = string.Format($"/id/{id}");
                var result = new Show();
                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    var productsResponse = JsonSerializer.Deserialize<Show>(stringResponse);

                    result = productsResponse;
                }
                else
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        throw new Exception("genres not found");
                    }
                    else
                    {
                        throw new Exception("failed to connect to server");
                    }
                }

                return result;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("http request failed: " + ex.Message);
            }
            catch (JsonException ex)
            {
                throw new Exception("json failed: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("error: " + ex.Message);
            }
        }
    }
}
