﻿Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine($"Days until expiration: {daysUntilExpiration}");

if (daysUntilExpiration < 1)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (daysUntilExpiration > 0 && daysUntilExpiration <= 5)
{
    if (daysUntilExpiration == 1)
    {
        discountPercentage = 20;
    }
    else
    {
        discountPercentage = 10;
    }
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}