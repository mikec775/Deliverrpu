using BusinessLogic.Helpers;
using BusinessLogic.Services;
using DataAccess;
using DataAccess.Models;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic.Tests.ServicesTests
{
    public class AuthTests
    {
        private readonly AuthService authService;
        private readonly DeliverContext _db;
        public AuthTests()
        {
            _db = TestHelper.GetForumDbContext();
            authService = new AuthService(_db);
        }
        [Test]
        public async Task UserSignUp_ThenReturnedNewUser()
        {
            string password = "Pass123456789";
            User user = new User()
            {
                Username = "Test user",
                Email = "Email1@gmail.com",
                PasswordHash = password
            };

            User registeredUser = await authService.Register(user);

            Assert.IsNotNull(registeredUser);
            Assert.AreEqual(user.Username, registeredUser.Username);
            Assert.AreEqual(user.Email, registeredUser.Email);
            Assert.True(HashHelper.CompareHash(registeredUser.PasswordHash!, password));

            Assert.IsNotNull(_db.Users!.Where(user => user.Email == user.Email));
        }
        [Test]
        public async Task UserSignUpWhenThereIsUserSameEmail_ThenInvalidOperationExceptionThrown()
        {
            string password = "Pass123456789";
            User firstUser = new User()
            {
                Username = "Test1 user",
                Email = "UserEmail@gmail.com",
                PasswordHash = password
            };
            User secondUser = new User()
            {
                Username = "Test2 user",
                Email = "UserEmail@gmail.com",
                PasswordHash = password
            };

            await authService.Register(firstUser);
            Assert.ThrowsAsync<InvalidOperationException>(async () => await authService.Register(secondUser));

        }
        [Test]
        public void UserSignUp_WhenUserIsNull_ThenArgumentNullExceptionThrown()
        {
            User user = null!;
            Assert.ThrowsAsync<ArgumentNullException>(async () => await authService.Register(user));
        }

        [TestCase("u", "email@gmail.com", "Pass123456789")]
        [TestCase("user1234", "em", "Pass123456789")]
        [TestCase("user1234", "email@gmail.com", "12789")]
        [TestCase("user1234", "email@gmail.com", "1123456789")]
        [TestCase("user1234", "email@gmail.com", "p1123456789")]
        public void UserSignUp_WhenUserDetailsInvalid_ThenArgumentExceptionThrown(string username, string email, string password)
        {
            User user = new User()
            {
                Username = username,
                Email = email,
                PasswordHash = password
            };
            Assert.ThrowsAsync<ArgumentException>(async () => await authService.Register(user));
        }


        [Test]
        public async Task UserSignIn_ThenReturnedNewUser()
        {
            string password = "Pass123456789";
            string email = "RegisterEmail@gmail.com";
            User user = new User()
            {
                Username = "Register user",
                Email = email,
                PasswordHash = password
            };

            await authService.Register(user);
            User authUser = await authService.Login(email, password);

            Assert.IsNotNull(authUser);
            Assert.AreEqual(user.Username, authUser.Username);
            Assert.AreEqual(user.Email, authUser.Email);
        }

        [Test]
        public async Task UserSignIn_WhenUserDoesNotExit_ThenAgumentNullExceptionThrown()
        {
            string password = "Pass123456789";
            string rightEmail = "RegisterEmailRight@gmail.com";
            string wrongEmail = "RegisterEmailWrong@gmail.com";
            User user = new User()
            {
                Username = "Register user",
                Email = rightEmail,
                PasswordHash = password
            };

            await authService.Register(user);
            Assert.ThrowsAsync<ArgumentNullException>(async () => await authService.Login(wrongEmail, password));
        }
        [Test]
        public async Task UserSignIn_WhenPasswordWrong_ThenAgumentExceptionThrown()
        {
            string password = "Pass123456789";
            string wrongPassword = "Pas123456789";
            string rightEmail = "RegisterEmailRight2@gmail.com";
            User user = new User()
            {
                Username = "Register user",
                Email = rightEmail,
                PasswordHash = password
            };

            await authService.Register(user);
            Assert.ThrowsAsync<ArgumentException>(async () => await authService.Login(rightEmail, wrongPassword));
        }
    }
}
