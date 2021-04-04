using System.Text.RegularExpressions;
using FluentValidation;

namespace medium_dio_artigo_fluentvalidation_webapi.Extensions
{
  public static class FluentExtensions
  {
    public static IRuleBuilderOptions<T, TElement> Phone<T, TElement>(
      this IRuleBuilder<T, TElement> ruleBuilder) => ruleBuilder.Must((_, value, _) =>
        value?.ToString().Length == 12 && Regex.IsMatch(value.ToString(), "^[0-9]*$"));
  }
}