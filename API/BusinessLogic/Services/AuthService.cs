using BusinessLogic.Helpers;
using BusinessLogic.Interfaces;
using BusinessLogic.Validation;
using DataAccess;
using DataAccess.Models;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class AuthService : IAuthService
    {
        private readonly DeliverContext _db;
        private readonly UserValidation _validationRules;
        public AuthService(DeliverContext db)
        {
            _db = db;
            _validationRules = new UserValidation();
        }
        public async Task<User> Login(string email, string password)
        {
            User? user = await _db.Users!.Where(u => u.Email == email).FirstOrDefaultAsync();

            if (user == null)
                throw new ArgumentNullException(nameof(User), "User with provided email was not found");

            if (HashHelper.CompareHash(user.PasswordHash!, password))
                throw new ArgumentException("Passwords do not match");

            return user;
        }

        public async Task<User> Register(User newUser)
        {
            if (newUser == null)
                throw new ArgumentNullException(nameof(newUser), "User is null");

            ValidationResult result = await _validationRules.ValidateAsync(newUser);

            if (!result.IsValid)
                throw new ArgumentException($"Validation failed: {result.Errors}");

            newUser.PasswordHash = HashHelper.HashPassword(newUser.PasswordHash!);
            if (await _db.Users!.AnyAsync(u => u.Email == newUser.Email))
                throw new InvalidOperationException("User with provided username already exists");

            await _db.Users!.AddAsync(newUser);
            await _db.SaveChangesAsync();
            return await _db.Users!.Where(u => u.Email == newUser.Email).FirstOrDefaultAsync();
        }
    }
}
