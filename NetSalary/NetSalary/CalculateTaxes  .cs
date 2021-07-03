

namespace NetSalary
{
    public static class CalculateTaxes
    {
        public static double SocialContributionse(double grossValue)
        {
            double social = 0;

            if (grossValue <= 1000)
            {
                social = 0;
            }
            else if (grossValue <= 3000)
            {
                var currentgrossValue = grossValue - 1000;

                social = (15f / 100f) * currentgrossValue;
            }
            else
            {
                social = (15f / 100f) * 2000;
            }

            return social;
        }

        public static double Tax(double grossValue)
        {
            double tax = 0;

            if (grossValue <= 1000)
            {
                tax = 0;
            }
            else
            {
                var currentgrossValue = grossValue - 1000;

                var taxCurrent = (10f / 100f) * currentgrossValue;

                tax = taxCurrent;
            }

            return tax;
        }
    }
}
