using BadProgramming;

// original implementation
Class1 bad = new();
double result = bad.Calculate(500, 2, 7);
Console.WriteLine(result); // 427,5

// improved implementation
CustomerDiscountManager better = new();
result = better.CalculateCustomerPrice(500, 2, 7);
Console.WriteLine(result); // 427,5


// testing code
result = better.CalculateCustomerPrice(500, 1, 0);
double expected = 500.0;
if (result == expected)
{
    Console.WriteLine("Test 1 succeeded.");
}
else
{
    Console.WriteLine("Test 1 FAILED!");
}

// test case 2
result = better.CalculateCustomerPrice(100, 2, 0);
expected = 90.0;
if (result == expected)
{
    Console.WriteLine("Test 2 succeeded.");
}
else
{
    Console.WriteLine("Test 2 FAILED!");
}