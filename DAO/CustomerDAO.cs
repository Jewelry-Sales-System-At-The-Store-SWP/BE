using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDAO
    {
        public readonly JssatsV2Context _context;
        public static CustomerDAO? instance;
        public CustomerDAO()
        {
            _context = new JssatsV2Context();
        }
        public static CustomerDAO Instance
        {
            get
            {
                instance ??= new CustomerDAO();
                return instance;
            }
        }
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }
        public async Task<Customer?> GetCustomerById(int id)
        {
            return await _context.Customers.FindAsync(id);
        }
        public async Task<int> CreateCustomer(Customer customer)
        {
            var maxCustomerId = await _context.Customers.MaxAsync(c => c.CustomerId);
            customer.CustomerId = maxCustomerId + 1;
            _context.Customers.Add(customer);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> UpdateCustomer(Customer customer)
        {
            var existingCustomer = await _context.Customers
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CustomerId == customer.CustomerId);
            if (existingCustomer == null)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                _context.Entry(customer).State = EntityState.Modified;
            }
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return 0;
            }
            _context.Customers.Remove(customer);
            return await _context.SaveChangesAsync();
        }

    }
}
