int userId = 1;

string fullName = "Tope Abiola";

double accountBalance = 1500.75;

bool isVerified = true;


//String Interpolation
Console.WriteLine($"{fullName} is a client in our organization with a userId {userId}. Has her account balance been verified to be {accountBalance}, {isVerified}");

//String Concatenation
Console.WriteLine(fullName + " is a client in our organization with the userId " + userId + ". Has her account balance been verified to be" + accountBalance + ":" + isVerified);