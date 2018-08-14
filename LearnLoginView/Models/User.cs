using Prism.Windows.Validation;
using System.ComponentModel.DataAnnotations;

namespace LearnLoginView.Models
{
    public class User : ValidatableBindableBase
    {
        //TODO: Adjust to readable regex.
        private const string NAME_REGEX = @"\A\p{L}+([\p{Zs}\-][\p{L}]+)*\z";
        private const string AGE_REGEX = @"\A[1-9]\d*\z";
        private const string MAIL_REGEX = @"\A[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}\z";

        private string _name;
        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(NAME_REGEX, ErrorMessage = "Invalid format.")]
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _age;
        [Required(ErrorMessage = "Age is required.")]
        [RegularExpression(AGE_REGEX, ErrorMessage = "Invalid format.")]
        public string Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }

        private string _mail;
        [Required(ErrorMessage = "Mail address is required.")]
        [RegularExpression(MAIL_REGEX, ErrorMessage = "Invalid format.")]
        public string Mail
        {
            get => _mail;
            set => SetProperty(ref _mail, value);
        }

        //TODO: Validation doesn't fired on focus lost from PasswordBox.
        private string _password;
        [Required(ErrorMessage = "Password is required.")]
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        //TODO: Add Submit button validation.
    }
}
