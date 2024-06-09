using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class RoleDao : Singleton<RoleDao>
{
    private readonly JssatsContext _context;

    public RoleDao()
    {
        _context = new JssatsContext();
    }
    public async Task<Role?> GetRoleById(int id)
    {
        return await _context.Roles.FindAsync(id);
    }
    public async Task<IEnumerable<Role?>?> GetRoles()
    {
        return await _context.Roles.ToListAsync();
    }
}