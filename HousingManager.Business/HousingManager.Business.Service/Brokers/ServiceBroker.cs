using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingManager.Business.Service.Interfaces;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Service.Brokers
{
    public class ServiceBroker<T> : BaseBroker<T> where T : IModel, new()
    {
        internal ServiceBroker( )
        {
            Url = "http://housingmanagerdata.azurewebsites.net/api/";
        }

        public override T Get( )
        {
           
            throw new NotImplementedException();
        }

        public override List<T> GetAll( )
        {
            

            return null;
        }

        public override string TestGet( )
        {
            var blah = new T();

            string temp = Url + blah.GetType().Name;

            var response = client.GetAsync(temp).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }

            return "Lol, wrong";
        }
    }
}
