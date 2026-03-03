string productName = "Wireless Mouse";

int productId = 101;

double price = 29.99;

bool instock = true;



// String Concatenation
Console.WriteLine("I Want to get " + productName + " the productId is " + productId + " it is " + price + ". Is it in stock:" + instock );

//String Interpolation
Console.WriteLine($"I want to get {productName}, the productId is {productId}, it is {price}. Is it in stock: {instock}");