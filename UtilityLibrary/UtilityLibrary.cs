namespace UtilityLibrary
{
    public class UtilityLibrary
    {
        public static bool ValidateIsNumeric(String value,
     String messageIdentifier, out String message, out double? doubleValue)
        {
            bool valid = false;
            double valueCheck = 0;
            doubleValue = null;
            message = String.Empty;

            if (String.IsNullOrEmpty(value))
                message = $"{messageIdentifier} is required.";
            else if (double.TryParse(value, out valueCheck))
            {
                valid = true;
                doubleValue = valueCheck;
            }
            else
                message = $"{messageIdentifier} is not numeric.";

            return valid;
        }
    }
}