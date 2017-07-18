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
    }
}
 