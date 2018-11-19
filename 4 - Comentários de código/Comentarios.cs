using System;

class BarService
{
    public void DoStuff()
    {
        // Renato, 20/12/1999 (changed because of business requirement 666)
        // ----------------------------------------------------------------
        // Check if the customer is eligible for standard account
        // if ((customer.flags & STANDARD_FLAG) && (customer.Visits > 15))
		if ((customer.flags & PREMIUM_FLAG) && (customer.Age > 5))
        {
            ApplyPremiumAccount(this);
        }
    }

    private void ApplyPremiumAccount(BarService barService)
    {
        // Boom! Sorry =P
        throw new NotImplementedException();
    }
}