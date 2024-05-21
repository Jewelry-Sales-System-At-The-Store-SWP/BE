﻿using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class JewelryDAO
    {
        private readonly JssatsV2Context _context;
        public static JewelryDAO? instance;
        public JewelryDAO()
        {
            _context = new JssatsV2Context();
        }
        public static JewelryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JewelryDAO();
                }
                return instance;
            }
        }
        public async Task<IEnumerable<Jewelry>> GetJewelries()
        {
            return await _context.Jewelries.ToListAsync();
        }

        public async Task<Jewelry> GetJewelryById(int id)
        {
            return await _context.Jewelries.FindAsync(id) ?? new Jewelry();
        }

        public async Task<int> CreateJewelry(Jewelry jewelry)
        {
            var maxJewelryId = await _context.Jewelries.MaxAsync(j => j.JewelryId);
            jewelry.JewelryId = maxJewelryId + 1;
            _context.Jewelries.Add(jewelry);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateJewelry(Jewelry jewelry)
        {
            var existingJewelry = await _context.Jewelries
                .AsNoTracking()
                .FirstOrDefaultAsync(j => j.JewelryId == jewelry.JewelryId);

            if (existingJewelry == null)
            {
                _context.Jewelries.Add(jewelry);
            }
            else
            {
                _context.Entry(jewelry).State = EntityState.Modified;
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteJewelry(int id)
        {
            var jewelry = await _context.Jewelries.FindAsync(id);
            _context.Jewelries.Remove(jewelry ?? new Jewelry());
            return await _context.SaveChangesAsync();
        }
    }
}
