//Conditional Operator (? :)

int num = 40;
String result = (num % 2 == 0) ? "Even" : "Odd";
Console.WriteLine(num + " is an " + result + " number.");


//Null Coalescing Operator (??)

string name = null;
//set username = name, if name is not null.
//set username = “user”, if name is null.
string username = name ?? "user";
Console.WriteLine(username);


