using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using ZipCodeSearch.Models;

namespace ZipCodeSearch.Data
{
    public class ViaCepREST
    {
        private static string ApiUrlFirstPart = "https://viacep.com.br/ws";
        private static string ApiUrlThirdPart = "json";

        private HttpClient client = new HttpClient();

        public async Task<Address> GetZipCodeAsync(string zipCode)
        {
            Uri url = new Uri(ApiUrlFirstPart + "/" + zipCode + "/" + ApiUrlThirdPart);

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();

                Address address = JsonConvert.DeserializeObject<Address>(content);

                return address;
            }
            else
            {
                return null;
            }
        }
    }
}
