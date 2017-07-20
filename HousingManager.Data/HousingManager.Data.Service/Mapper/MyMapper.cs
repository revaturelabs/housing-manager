using AutoMapper;
using HousingManager.Data.Library.EFModels;
using HousingManager.Data.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.Mapper
{
    public class MyMapper
    {
    private MapperConfiguration AddressEntity_AddressDTO = new MapperConfiguration(c => c.CreateMap<Address, AddressDTO>());


    public T AddressEntitytoAddressDTO<T>(Address la)
    {
      return AddressEntity_AddressDTO.CreateMapper().Map<T>(la);
    }
  }
}
