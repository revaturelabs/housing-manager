using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingManager.Business.Service.Brokers;
using HousingManager.Business.Service.Interfaces;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Service.Brokers
{
    public static class  BrokerFactory<T> where T: IModel, new()
    {
        public static ServiceBroker<T> GetInstance()
        {
            return new ServiceBroker<T>();
        }
    }
}
