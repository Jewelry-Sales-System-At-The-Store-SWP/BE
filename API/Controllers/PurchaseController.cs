﻿using BusinessObjects.Dto.BuyBack;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interface;
using Services.Interface;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseService _purchaseService;

        public PurchaseController(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        [HttpPost("BuyBackById")]
        public async Task<IActionResult> BuybackById([FromBody] BuybackByIdRequest request)
        {
            var result = await _purchaseService.ProcessBuybackById(request.JewelryId);
            return Ok(new { Message = result });
        }

        [HttpPost("BuyBackByName")]
        public async Task<IActionResult> BuybackByName([FromBody] BuybackByNameRequest request)
        {
            try
            {
                var result = await _purchaseService.ProcessBuybackByName(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}