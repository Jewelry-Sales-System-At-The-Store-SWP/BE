﻿using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;
using Tools;

namespace DAO
{
    public class BillJewelryDao : Singleton<BillJewelryDao>
    {
        private readonly JssatsContext _context;
        public BillJewelryDao()
        {
            _context = new JssatsContext();
        }
        public async Task<IEnumerable<BillJewelry?>?> GetBillJewelries()
        {
            return await _context.BillJewelries.ToListAsync();
        }
        public async Task<BillJewelry?> GetBillJewelryById(string id)
        {
            return await _context.BillJewelries.FindAsync(id);
        }
        public async Task<int> CreateBillJewelry(BillJewelry billJewelry)
        {
            billJewelry.BillJewelryId = Generator.GenerateId();
            _context.BillJewelries.Add(billJewelry);
            return await _context.SaveChangesAsync();
        }
        public async Task<BillJewelry?> GetBillJewelryByBillId(string billId)
        {
            return await _context.BillJewelries.FirstOrDefaultAsync(b => b.BillId == billId);
        } 
    }
}
