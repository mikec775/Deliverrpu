using DataAccess.Models;
using FluentValidation;

namespace BusinessLogic.Validation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.Username).MinimumLength(3).WithMessage("Username must not be less than 3 symbols");
            RuleFor(u => u.Username).MaximumLength(30).WithMessage("Username must not be more than 30 symbols");

            RuleFor(u => u.Email).MinimumLength(4).WithMessage("Email must not be less than 4 symbols");
            RuleFor(u => u.Email).MaximumLength(40).WithMessage("Username must not be more than 40 symbols");

            RuleFor(u => u.PasswordHash).MinimumLength(8).WithMessage("Password must be more than 8 symbols");
            RuleFor(u => u.PasswordHash).Must(ValidatePassword!).WithMessage("Password must contain at least on digit, upper and lower case letters");
        }
        private bool ValidatePassword(string password)
        {
            if (!password.Any(p => char.IsDigit(p)))
                return false;
            if (!password.Any(p => char.IsLower(p)))
                return false;
            if (!password.Any(p => char.IsUpper(p)))
                return false;
            return true;
        }
    }
}
