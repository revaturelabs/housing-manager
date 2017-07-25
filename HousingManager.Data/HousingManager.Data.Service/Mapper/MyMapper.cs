﻿using AutoMapper;
using HousingManager.Data.Library.Models;
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
    private MapperConfiguration PersonEntity_PersonDTO = new MapperConfiguration(c => c.CreateMap<Person, PersonDTO>());
    private MapperConfiguration BatchEntity_BatchDTO = new MapperConfiguration(c => c.CreateMap<Batch, BatchDTO>());
    private MapperConfiguration TenantEntity_TenantDTO = new MapperConfiguration(c => c.CreateMap<TenantInfo, TenantDTO>());


    public T AddressEntitytoAddressDTO<T>(Address la)
    {
      return AddressEntity_AddressDTO.CreateMapper().Map<T>(la);
    }

    public T PersonEntitytoPersonDTO<T>(Person p)
    {
      return PersonEntity_PersonDTO.CreateMapper().Map<T>(p);
    }

    public T BatchEntitytoBatchDTO<T>(Batch b)
    {
      return BatchEntity_BatchDTO.CreateMapper().Map<T>(b);
    }

    public T TenantEntitytoTenantDTO<T>(TenantInfo t)
    {
      return TenantEntity_TenantDTO.CreateMapper().Map<T>(t);
    }
  }
}
