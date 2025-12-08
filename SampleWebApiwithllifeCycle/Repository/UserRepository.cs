using Microsoft.EntityFrameworkCore;
using SampleWebApiwithllifeCycle.Data;
using SampleWebApiwithllifeCycle.DTO;
using System.Collections.Generic;
namespace SampleWebApiwithllifeCycle.Repository
{
    public class UserRepository
    {

        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserDTO>> GetAllusers()
        {
            return await _context.Users.AsNoTracking().
                Select(u => new UserDTO
                {
                    Id = u.Id,
                    Email = u.Email,
                    DisplayName = u.DisplayName
                }).ToListAsync();
        }

    }
}
