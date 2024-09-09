// Number Data Types

using System.Diagnostics.Contracts;
string breakpoint = ("--------------------------------------------------------------");
Console.Clear();

// ints are your whole numbers, and we use these most of the time
int wholeNumber = 5;

// Really big whole numbers that can exceed the size of the largest possible integer
long bigNumber = 2000000000000000000;

// Default decimal number
double withDecimal = 3.14;

// lightweight decimal number
float littleDecimal = 5.467f;
// Note: If we do NOT put an f on the end of our number, we get an error because the code assumes our decimal number is a "double" .
// We need an f on the end of the number literal -- a literal being standalone value.

// heavy but accurate decimal number
decimal bigDecimal = 2.33333333444444444555555555m;
// Note: Just like our float, decimals need an m at the end of its number literal -- or standalone value


// Converting to numbers
Console.Clear();
Console.WriteLine(breakpoint);
// we usually use Console.ReadLine to take input from our users -- problem is that it will provide a string
string strNumber = "89";
string strSecNum = "7";
// This may look like it will add the numbers, but it will actually concatenate
Console.WriteLine(strNumber + strSecNum);

// we are making an integer, called firstInt, equal to the result, of converting our strNumber, to an Int32
int firstInt = Convert.ToInt32(strNumber);
Console.WriteLine(firstInt.GetType());
Console.WriteLine(bigNumber.GetType());
int secInt = Convert.ToInt32(strSecNum);

Console.WriteLine(firstInt + secInt);


// More Data Types
Console.WriteLine(breakpoint);
// Strings: A collection of characters, indicated by ""
// Int (and his variosly sized cousins): Numbers (for doing math and such)
// char: a single character, indicated by '' and only being a single character
char singleLetter = 'S';
Console.WriteLine(singleLetter.GetType());

// Boolean: also known as a bool, this hadles our 'yes and no' kind of logic.
// More specifically, a bool is either valued as true or false
bool answerYes = true;
// When we declare our booleans, we start with 'bool' and then literal value that we provide does NOT need any kind of quotion marks for fanciness.

// Null: this has been left intentionally blank
// string? dontTouchMe = null;
// Console.WriteLine(dontTouchMe.GetType());

Console.WriteLine(breakpoint);

// Math Operators
int darrylsNum = 11;
int treysNum = 3;
darrylsNum += 53;

// Addition Operator
Console.WriteLine(darrylsNum + treysNum);

// Subtraction Operator
Console.WriteLine(darrylsNum - treysNum);

// Multiplication Operator
Console.WriteLine(darrylsNum * treysNum);

// Division Operator
Console.WriteLine(darrylsNum / treysNum);
// If you are working with integers, and you have fractional or decimal place values LEFT OVER, the int will drop it off because it wants to be a whole number, it 11/3 = an int of 3 instead of 3.6666666

// Modulo/Modulous Operator
// In the division operator I refer to fracional or remaining values from deviding a number. Modulo is ONLY concerned with the remainders!
Console.WriteLine(darrylsNum % treysNum);
Console.WriteLine(1234 % 6);
Console.WriteLine("Is 123456790087 even or odd?");
Console.WriteLine(123456790087 % 2);
Console.WriteLine("The remainder is not equal to 0, so the number is odd");
Console.WriteLine("Is 323457800928 odd or even?");
Console.WriteLine(323457800928 % 2);
Console.WriteLine("The remainder is 0, so this number is even");

// Order of Operations
// You can group you math operators with parenthasis () in order to be more specific about what your operations happen,
// using PEMDAS
// Parenthesis, Exponentials, Multiply, Divide, Add, Subtract, in that order

// this will be 8
Console.WriteLine(2+3*4/2);

// this will be 10
Console.WriteLine((2+3)*4/2); 

Console.WriteLine(breakpoint);
// Assignment Operators
// = : Assignment operator, or reassigning a value to a variable
// += : remember that plus signs can be used for both strings and numbers
string myFavFruit = "My favorite is ";
myFavFruit += "banana";
// this is exactly the same as the followoing:
// myFavFruit = myFavFruit + "banana";
Console.WriteLine(myFavFruit);
int digit = 9;
digit += 17;
//This is the same as saying: digit = digit + 17;
Console.WriteLine(digit);

int digit2 = 5;
digit2 -= 3;
Console.WriteLine(digit2);

//Note: strings do not have a value for -, and just as such for * and /, so the following assignment operators are for numbers/math only!
// only the '+=' operator will work with strings
// myFavFruit -= "fruit";

int digit3 = 9;
digit3 /= 3;
Console.WriteLine(digit3);

int digit4 = 5;
digit4 *= 7;
Console.WriteLine(digit4);

Console.WriteLine(breakpoint);

int counter = 0;
// count up by 1;
counter++;
// counter += 1;
// counter = counter + 1;
Console.WriteLine(counter);
counter++;
Console.WriteLine(counter);
// this counts down by 1
counter --;
// counter -= 1;
// counter = counter - 1;
Console.WriteLine(counter);