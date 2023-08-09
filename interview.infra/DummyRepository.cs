using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace interview.infra
{
    public class DummyRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public YourService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<ExternalItemDto>> GetExternalItemsWithPaginationAsync(int pageNumber, int pageSize)
        {
            using (var client = _httpClientFactory.CreateClient("ExternalApi"))
            {
                var response = await client.GetAsync($"items?page={pageNumber}&size={pageSize}");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var items = JsonConvert.DeserializeObject<IEnumerable<ExternalItem>>(content);

                return items.Select(item => new ExternalItemDto
                {
                    // Map properties from the ExternalItem to ExternalItemDto
                });
            }
        }
    }
}
