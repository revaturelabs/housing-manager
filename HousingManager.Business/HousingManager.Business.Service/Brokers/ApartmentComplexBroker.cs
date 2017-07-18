using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingManager.Business.Library.Models;
using Newtonsoft.Json;

namespace HousingManager.Business.Service.Brokers
{
    public class ApartmentComplexBroker : DataBroker
    {
        private string _myUrl = _Url + "/api/ApartmentComplex";

        public List<ApartmentComplex> GetAll()
        {
            var response = _Client.GetAsync(_myUrl).Result;

            if(response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<ApartmentComplex>>(content);
            }

            else
            {
                return null;
            }
        }

        public ApartmentComplex Get()
        {
            var response = _Client.GetAsync(_myUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<ApartmentComplex>(content);
            }

            else
            {
                return null;
            }
        }

        public async Task<bool> AddComplex(ApartmentComplex toAdd)
        {
            System.Net.Http.StringContent send = new System.Net.Http.StringContent(
            JsonConvert.SerializeObject(toAdd));
            
            var response = await _Client.PostAsync(_myUrl + "/post/", send);

            if(response.IsSuccessStatusCode)
                return true;

            return false;
        }
    }
}
 