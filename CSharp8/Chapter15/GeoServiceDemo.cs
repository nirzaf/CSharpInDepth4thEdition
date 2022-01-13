﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter15
{
    [Description("Listing 15.19")]
    public class GeoServiceDemo
    {
        async static Task Main()
        {
            var fakeService = new FakeGeoService();
            fakeService.AddPage("London", "Paris", "Washington");
            fakeService.AddPage(); // Empty pages are valid
            fakeService.AddPage("Nairobi", "Sydney", "New Delhi");
            fakeService.AddPage("Moscow");

            var client = new GeoClient(fakeService);

            await foreach (var city in client.ListCitiesAsync())
            {
                Console.WriteLine(city);
            }
        }
    }
}
