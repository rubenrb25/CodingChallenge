using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ClimateMonitor.DataAnnotations
{
    public class ValidateExpression : ValidationAttribute
    {

        public override bool IsValid(object? value)
        {
            Regex r = new Regex(@"^(0|[1-9]\d*)\.(0|[1-9]\d*)\.(0|[1-9]\d*)(?:-((?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\.(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\+([0-9a-zA-Z-]+(?:\.[0-9a-zA-Z-]+)*))?$");
             
            if(value == null ) return false;

            return r.IsMatch(value.ToString());
        }

    }
}
