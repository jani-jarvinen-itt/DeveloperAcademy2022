using System;

namespace BadProgramming
{
    public class CustomerDiscountManager
    {
        // available customer tiers
        const int CustomerTierNormal = 1;
        const int CustomerTierSilver = 2;
        const int CustomerTierGold = 3;
        const int CustomerTierPlatinum = 4;

        // discount level
        const double SilverTierDiscount = 0.1; // 10 %
        const double GoldTierDiscount = 0.3; // 30 %
        const double PlatinumTierDiscount = 0.5; // 50 %

        // additional discount based on membership years
        const int MaximumMembershipDiscountYears = 5;

        public double CalculateCustomerPrice(double listPrice,
            int customerTier, int membershipYears)
        {
            double discountPercent = customerTier switch
            {
                CustomerTierNormal   => 0.0, // no discount
                CustomerTierSilver   => SilverTierDiscount,
                CustomerTierGold     => GoldTierDiscount,
                CustomerTierPlatinum => PlatinumTierDiscount,
                _ => throw new Exception("Unknown customer tier.")
            };

            // step 1: calculate the base discounted price based tier
            double result = (listPrice - (discountPercent * listPrice));

            // step 2: calculate additional discount based on membership years
            double additionalDiscountPercent = (double)membershipYears / 100;
            if (membershipYears > MaximumMembershipDiscountYears)
            {
                // the maximum additional discount is 5 years
                additionalDiscountPercent = (double)MaximumMembershipDiscountYears / 100;
            }

            // final step: calculate the price with the possible additional discount
            result = result - (result * additionalDiscountPercent);
            
            return result;
        }
    }
}
