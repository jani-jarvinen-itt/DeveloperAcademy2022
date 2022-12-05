using BadProgramming;

// original implementation
Class1 bad = new();
double result = bad.Calculate(500, 2, 7);
Console.WriteLine(result); // 427,5

// improved implementation
CustomerDiscountManager better = new();
result = better.CalculateCustomerPrice(500, 2, 7);
Console.WriteLine(result); // 427,5
