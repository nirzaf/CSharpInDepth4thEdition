using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter15
{
    [Description("Listing 15.18 and 15.20")]
    public class GeoClient
    {
        private readonly IGeoService service;

        public GeoClient(IGeoService service) =>
            this.service = service;

        public async IAsyncEnumerable<string> ListCitiesAsync()
        {
            string? pageToken = null;
            do
            {
                var request = new ListCitiesRequest(pageToken);
                var response = await service.ListCitiesAsync(request);
                foreach (var city in response.Cities)
                {
                    yield return city;
                }
                pageToken = response.NextPageToken;
            } while (pageToken != null);
        }
    }
}
