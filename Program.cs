Console.WriteLine("Hello, World!");

Console.Write("What is your name?");
string? name = Console.ReadLine();
Console.WriteLine($"Hello, {name}");


// There are multiple data types 
int number = 1;
double number1 = 10.10;
decimal salary = 45000.50m;
char grade = 'A'; // a single character, single quotes
string name1 = "Santosh"; // text, double quotes
bool isStudent = false;


int score;
score = 40;
Console.WriteLine($"Hello, {name1}, you got this score: {score}");



// var will let the compiler infer the type

var city = "Ktm";
var age = 10;
var total = 100.10;

// city = 5; ERROR: city is still a string, var is not dynamic


const double Pi = 3.14;
const int MaxUsers = 100;


// Pi = 3.0; Error


//Value types vs reference types
// Value types ( int , double , bool , char , decimal , struct s) hold their data directly.Copying one copies the value.

// Reference types ( string , arrays, classes, List<T> ) hold a reference (an address) to data stored elsewhere. Copying one copies the reference, so both variables point to the same object.

// Value type: independent copies
int a = 10;
int b = a; // b gets its own copy of 10
b = 20;
Console.WriteLine(a); // 10, a is unchanged
// Reference type: shared object
int[] first = { 1, 2, 3 };
int[] second = first; // second points to the SAME array
second[0] = 99;
Console.WriteLine(first[0]); // 99, first sees the change

//string is a reference type but behaves like a value because strings are immutable: every "change" creates a new string.
string firstName = "Santosh";
string lastName = "Upadhyay";

string fullName = firstName + " " + lastName; //concatenation
string fullName1 = $"{firstName} {lastName}"; //interpolation

Console.WriteLine(fullName1.Length);
Console.WriteLine(fullName1.ToUpper());
Console.WriteLine(fullName1.ToLower());
Console.WriteLine(fullName1.Contains("a"));
Console.WriteLine(fullName1.Replace("antosh", "andy"));
Console.WriteLine(fullName1.Substring(0,10));
Console.WriteLine(fullName1[0]);

string[] parts = fullName1.Split(" ");
Console.WriteLine(string.Join(", ", parts));
Console.WriteLine(parts[1]);


//converting between types
double pi = 3.99;
int truncated = (int)pi; // 3 will be printed and the numbers after deicmal are dropped

int n = int.Parse("42"); //throws if the text is not a number

//so safe method is using TryParse

if(int.TryParse("abc", out int result))
{
    Console.WriteLine($"Successful. {result}");
} 
else
{
    Console.WriteLine("Not a valid number"); 
}

//Nullable types
int? maybeAge = null;
if(maybeAge.HasValue) Console.WriteLine(maybeAge.Value);

int ageOrDefault = maybeAge ?? 0;
string? nickname = null;
int length = nickname?.Length ?? 0; // ?. returns null instead of crashing
/*
?? (null-coalescing) means "use the left value, or the right one if the left is null"
?. (null-conditional) means "access this member only if the object is not null".
*/