﻿using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;
using Repositories.Interface.GenericRepository;
namespace Repositories.Interface;

public interface IJewelryRepository : IReadRepository<JewelryResponseDto>, ICreateRepository<Jewelry>, IUpdateRepository<Jewelry>, IDeleteRepository<Jewelry>
{
    Task<(int,int,IEnumerable<JewelryResponseDto>)> GetsJewelryPaging(int pageNumber, int pageSize);
    Task<(int,int,IEnumerable<JewelryResponseDto>)> GetsJewelryPagingByType(string jewelryTypeId, int pageNumber, int pageSize);
}
