using SharedKernel.Core;
using System.Text.RegularExpressions;

namespace Configuration.Domain.Model.Rules
{
    public class NotSpecialCharactersRule : IBussinessRule
    {
        private readonly string _value;

        public NotSpecialCharactersRule(string value)
        {
            _value = value;
        }

        public string Message => "El texto no puede contener caracteres especiales ()*/-?!";

        public bool IsValid()
        {
            Regex rg = new Regex("[^A-Za-z0-9]");
            return rg.IsMatch(_value);
        }
    }
}
