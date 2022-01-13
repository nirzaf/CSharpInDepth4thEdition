﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter15
{
    [Description("Listing 15.17")]
    public interface IGeoService
    {
        Task<ListCitiesResponse> ListCitiesAsync(ListCitiesRequest request);
    }

    public class ListCitiesRequest
    {
        public string? PageToken { get; }
        public ListCitiesRequest(string? pageToken) =>
            PageToken = pageToken;
    }

    public class ListCitiesResponse
    {
        public string? NextPageToken { get; }
        public List<string> Cities { get; }

        public ListCitiesResponse(string? nextPageToken, List<string> cities) =>
            (NextPageToken, Cities) = (nextPageToken, cities);
    }
}
