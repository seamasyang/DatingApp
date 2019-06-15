using DatingAppApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DatingAppApi.Data
{
    public interface IUserRepository
    {
        Task<User> Resister(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }

    public class UserRepository : IUserRepository
    {
        private DatingContext _context { get; }

        public UserRepository(DatingContext context)
        {
            _context = context;
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => string.Compare(x.UserName, username, true) == 0);

            if (user == null)
                return null;

            if (!ValidatePasswordhash(user, password))
                return null;

            return user;
        }

        private bool ValidatePasswordhash(User user, string password)
        {
            using (var hmas = new HMACSHA512(user.PasswordSalt))
            {
                var computedHash = hmas.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (var i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != user.PasswordHash[i])
                        return false;
                }
            }

            return true;
        }

        public async Task<User> Resister(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmas = new HMACSHA512())
            {
                passwordSalt = hmas.Key;
                passwordHash = hmas.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _context.Users.AnyAsync(x => string.Compare(x.UserName, username, true) == 0))
                return true;

            return false;

        }
    }
}
