using SharedKernel.Core;
using SharedKernel.Rules;

namespace Configuration.Domain.ValueObjects
{
    public record TextoValue : ValueObject
    {
        public string Text { get; }

        public TextoValue(string text)
        {
            CheckRule(new StringNotNullOrEmptyRule(text));
            if (text.Length > 500)
            {
                throw new BussinessRuleValidationException("Text can't be more than 500 characters");
            }
            Text = text;
        }

        public static implicit operator string(TextoValue value)
        {
            return value.Text;
        }

        public static implicit operator TextoValue(string text)
        {
            return new TextoValue(text);
        }
    }
}
