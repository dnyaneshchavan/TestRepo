// See https://aka.ms/new-console-template for more information
//finding out version of the the compiler

//#error version
//System.Console.WriteLine("Hel.lo, World!");

//statements ends with semicolon order matters

//var totalPrice=subtotal + salestax;

//Comments
//Sales tax must be added to subtotal : single line comment;
//var totalPrice = subtotal + salestax;

// Multiple line comments
/*
 This is a 
multi-line comment.
*/

////Commenting in the middle of the of the code
//var subtotal = 10;
//var salestax = 20;
//var totalPrice = subtotal /*for this Item*/ +  salestax;


// Blocks, Here is the example of the statement and block
//using System; // semicolon (;) indicates the end of the statements Doubt?: why do they use semicolon to end statement but not fullstop instead?
//using System.Diagnostics;

//namespace Basics
//{ //Open brace indicates the start of the block
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!"); // a statement
//        }
//    }
//} // a close brace indicates the close of the block


//Understanding C# vocabulary
// C# vocabulary contains of keywords ex: using,int,string, symbol chartacters ex: +,[,$ and types example Class types

//Help for writting correct code

//Console.Writeline("Hello World!")

//fix coding errors like make the L capital and put semicolon to end the statement

// Importing namespaces


// Oxford.HighStreet.BobSmith Address: look for person name Bob Smith on High Street in city of Oxford

//In same way System.Console.WriteLine tells us that look for WriteLine Method in Console type in System namespace

//using System; // importing namespace System


// Implicitly (not directly express) and globally (in Entire Project) importing namespace
//Its introduce in c#.10 and .NET SDK 6

//using System; 
//using System.Linq;
//using System.Collections.Generic;

// SDK  and implicitly imported namespace
//Microsoft.Net.Sdk
//Mirosoft.Net.Sdk.Web
// Microsoft .Net.Sdk.Worker // Need to find out what is this use for
//https://learn.microsoft.com/en-us/dotnet/core/extensions/workers?pivots=dotnet-8-0

//Console.WriteLine("Hello World!");

//< ItemGroup >

//        < Using Include = "System.Thrleading" /> // If you misspell namepace then there will be 0 erros 0 warnings and 0 messages //Need to find out when messages is used// 
//error will be shown in output window as

//        < Using Remove = "System.Numerics" />

//    </ ItemGroup >



//< Project Sdk = "Microsoft.NET.Sdk" >

//  < PropertyGroup >
//    < OutputType > Exe </ OutputType >
//    < TargetFramework > net7.0 </ TargetFramework >
//    < ImplicitUsings > enable </ ImplicitUsings >
//    < Nullable > enable </ Nullable >
//  </ PropertyGroup >

//    < !--< ItemGroup >

//        < Using Include = "System.Thrleading" />

//        < Using Remove = "System.Numerics" />

//    </ ItemGroup > -->


//    < !--< ItemGroup >

//        < Using Include = "System.Thrleading" />

//        < Using Remove = "System.Numerics" />

//    </ ItemGroup > -->
//</ Project >

// You can disable the implicitly impported namesapces feature for all SDKS
// need to find what does all SDK'S  mean? All project or entire soultion or what?>
//using System;

//Console.WriteLine("Hello, World!");

//The name Console does not exist in current context error will be thrown
// Because  implicitly usings is set to disable or removed from <PorjectName>.csproj file     <ImplicitUsings>disable</ImplicitUsings> 
//Note csproj file is not case sensitive

// practice go to Solution Explorer right click on Project go to properties and  goto section Build
//and control Nullability and global using statements
//
// mispelling ImplicitUsings content does not produce any rutime or complie time or Build Errors in output  window

//< ImplicitUsings > enajjjjbke </ ImplicitUsings > -->

//     < !--< ImplicitUsings > disable </ ImplicitUsings > -->

//     < !--< ImplicitUsings > disable </ ImplicitUsings > -->

//     < ImplicitUsings > enable </ ImplicitUsings >


//Nouns (name to refer a thing)are types eg: Fido is the name of the Dog then 
//Word Dog is type of the thing that Fido is
//In C# their equivalents are types :, Fields,variables and propereties 
//In C# their equivalents are types :Dog, Fields: // need to find out this ,variables: int a then a is varaible and propereties: color of the dog,Size of the dog
// Important Note: type is often confused with "class" but it can be struct eg: int which is the alias of System.Int32 (Neded to find out how to create custom alias)
//enum , interface Delegate we will explore this later.

//Revealing the extent of the C# vocabulary 
// Reflection : find out number of methods and other types used in C#

//Need to find what it menas by "Application Domain"
//Need to find what it means by "Message in Error List window": 
//using Microsoft.VisualBasic;
//using System.Reflection;
//using System.Xml.Linq;

//Assembly? myApp = Assembly.GetEntryAssembly();
//if (myApp == null) return;
//foreach(AssemblyName name in myApp.GetReferencedAssemblies())// Need to find what are refferenced assemblies
//{
//    Assembly a = Assembly.Load(name);
//    int methodCount = 0; 

//    foreach(TypeInfo t in a.DefinedTypes)
//    {
//        //methodCount += t.GetMethods().Count();
//        methodCount += t.GetMethods().Length;
//    }
//    Console.WriteLine(
//        "{0:N0} types with {1:N0} methods in {2}",arg0:a.DefinedTypes.Count(),arg1:methodCount,arg2:name.Name);
//}

//System.Runtime assembly produces 0 types with 0 methods in System.Runtime assembly
//beccuse it contains type forwarder it means it does not contain actual types but 
// types from third party types outside of dot net // need to find third party types outside of the dot net


//How numbers are stored in computer memory?
// 100 'a' "Hello World". These are example of Number literal(Actual =explicit meaning of a word) ,character literal and 
// string literal respectively 
// bit(small : a little bit) its Atomic(Unable to be split or made any smaller) smallest unit of storage
//Everything in computer is 0's and 1's
//0 means OFF (Positive:+) or false and 1(Negative:-) means  ON or True
// example Do research and find it out in night today
// Numbers can be represented in three types


//Working with variable(capable of change)
//All apllication process data(Information)
// Datum: An item of factual information that is derived from research or study measurement
// we can collect this data from user input,Files or databases(stored data i.e. An organized body of related information)
//Input data -->Process data-->ouput data

// do research on bits 64 bit operating systems

// We identify data by its type example int,char, string, bool (Data types)
// and it does have value 10,'a','Nitin',true respectively

//Naming conventions
// Camel case and Pascal case
//Camel case for local variables and private fields example: cost,orderDetail,dateOfBirth (underscore _ is used for private fields by microsoft to represent private fields
// since,private fields are not meant to be for outside world)
//  Pascal Case : for types,non-private fields, and other members like methods Example: Cost,OrderderDetail,DateofBirth,Run
// You can output the name of variable by using nameof keyword
double _heightInMeters = 1.88;
Console.WriteLine($"The variable {nameof(_heightInMeters)} has value {_heightInMeters}");

string _name = "Nitin";
Console.WriteLine($"the variable {nameof(_name)} has value {_name}");


//Literal values:=  we create variables and assign literal values like char ='a',int a=10; and so on....

//Storing Text

// For letter such as an A is stored as char (Alphabatic Character)
// we single quote ' or single- inverted commas '' to specify char thats punctuation to represent speech of someone else quote within a quote example: "I thought she likes me but then she said,"'I hate you'"".

//char _letter = 'a';
//char _digit = '1';
//char _symbole = '$';
//char _userChoice = GetSomekeyStrokes();// where GetSomekeyStrokes is function assigning value from a function
//char _MoreThanOneChar = 'aa';// This throws ans error: To many charcaters in Character Literal
//char _nullValue = null; // Throws an error "Can not convert null to char because its non-nullable type////"
//Note char 'a' requires two new char() so its not single chrarcter beacuse in anccient script picture is used to describe the word and acual word is also stored later when langauges were created. 
//For name like Bob we use String(series of characters(In programming:string with capital S  is a class)) or string(small s is alias(another name to identify) of the String class) 
//string _firstName = "Bob";
//string _lastName = "Smith";
//string _phoneNumber = "(215) 555-4256";

// assigning the string from the String class constructor(Construct= Build.Constructor=Builder. Buildng by combining parts )
//string _printHyphens = new('-', count: 74); // prints 74 Hyphens(-) Hyphen is a Punctuation Character which devides or combine two words for example: मराठी मध्ये
//Console.WriteLine($"Print the hyphen 74 times and hence form a line {_printHyphens}");
//In English
//string _nullValue = null; // Does not throw excepetion but shows the  warninng nad also a message as "Converting null literal or possible null value to non-nullable type". 
//We're looking for a dog-friendly hotel. She makes one-of-a-kind engagement rings in her studio. The new house has state-of-the-art features
// hyphens are known as Unicode Character :which means characters from all over the worlds langauges

//string _address = GetAddressFromDatabase();// where GetAddressFromDatabase() is a funtion to retrieve the adddress

//Asigning a emoji (Any of various standardized icons used in electronic messaging to express an emotion or specific meaning)from coverting unicode

//string _grinnigEmoji = char.ConvertFromUtf32(0x1F600); // UTF= Unicode Transformation Format 
//Console.WriteLine($"");
//It can translate any Unicode character to a matching unique binary string, and can also translate the binary string back to a Unicode character. This is the meaning of “UTF”, or “Unicode Transformation Format.”10 Aug 2020
//Encoding: The activity of converting data or information into code. 
//ASCII: Converting Symbols to Binary example : char:A	ASCII:065	Binary=01000001
//for more information visit https://blog.hubspot.com/website/what-is-utf-8#:~:text=UTF%2D8%20is%20an%20encoding,or%20%E2%80%9CUnicode%20Transformation%20Format.%E2%80%9D
//UTF8=here 8 stands for 8 bits 
//English language needs  128 bits to store its chracters but we need to store characters of other languages and symbols as weel
//hence UTF-16 and UTF32 and so on...
//0x1F600 Now lets break down this code 0x stands for Hexadeciaml code which makes grining emojis for more emojis visit https://evgenyzborovsky.com/2018/04/07/the-ultimate-guide-to-emojis/#:~:text=Emoji%20in%20C%23&text=It%20requires%20a%20single%20unicode,0x%20to%20specify%20hexadecimal%20notation.&text=%F0%9F%91%A8%E2%80%8D%F0%9F%92%BB-,Example%3A,am%20going%20to%20%7BbikingEmoji%7D!%22
//Note: Above code will not print emoji on command prompt(use command Terminal Visual studios command prompt) because by default it will print ??
//use below code to fix it.

//Console.OutputEncoding= System.Text.Encoding.UTF8; // Do research on why System namespace needs to mention even though there is using global statement in <ProjectName>.GlobalUsings.g.cs file 
//string _grinnigEmoji = char.ConvertFromUtf32(0x1F600);
//Console.WriteLine($"Grinning Emoji :{_grinnigEmoji}");

//Verbatim(Using exactly the same words) String

//when storing "text in  string variable we can use escape sequences((Serial arrangement in which things follow in logical order or a recurrent pattern) like \t for tab and new lioe 
//print I am a "Senior Developer."
//string _myTitle = @"I am a ""Senior Dot Net Developer""";
//Console.WriteLine($"Print Title {_myTitle}");

// For valid window path
//string _filePath = "C:\telvision\sony\bravia"; // here /t stands for tab and new line, 
//string _backSlashB = "C:\bony"; // \b stands to remove colon
//Console.WriteLine($"_backSlashS {_backSlashB}");
//string _filePath =@"C:\telvision\sony\bravia";
//Console.WriteLine($"Here is the file path {_filePath}");
//use @ (at) symbol to 
//Confusion of "at" and "at the rate of" what @ means "at" or "at the rate of"
//It means “at.”

//Even when it means “at the rate of,” we don’t say “at the rate of,” we say “at.”

//I bought six widgets at fifty cents each. I could have got them at forty cents elsewhere but it wasn’t worth the trip.

//We don’t say “at the rate of fifty cents each” even though that’s what we mean.

// Raw ( being unprocessed or manufactured using only simple or minimal processes) String Literal
//introduced in c# 11
//Use it to store other Languages like XML,HTML,or JSON

// Three or more double quotes . why Three or more double-quotes?
//string _xml = """
//                <person age="50">
//                        <first_name>Mark</first_name>
//                </person>
//               """;

//Note: It removes indented
//string _xmlWithDoubleQuotes = """"
//                <person age="50">
//                        <first_name>Mark</first_name>
//                </person>
//                """";

//Console.WriteLine($"xml data: {_xmlWithDoubleQuotes}");                
// Research: Need to find out why double quotes does not work?
//Need to learn XML Basics

//Raw interpolated(insert text between words) string literal
//Building Json
//using System.Security.Cryptography.X509Certificates;

//var _person = new { FirstName = "Alice",Age=56 }; // Need to do research on anonymous(Having no known name, identity or known source) declarion

//string _json = $$"""

//                {
//                    "first_name": "{{_person.FirstName}}",
//                    "age": {{_person.Age}},
//                    "calcualtiion": {{{1+2}}}
//                    }

//""";

//Console.WriteLine($"json code: {_json}");

//Number of dollar signs '$' indicates how many curly baraces '{}' needs to be in the output to recognize it as an interpolated expression 


//Storing Numbers


//Numbers are data we want to provide arithmatic oertaipons on
//Natural Numners = 42 also known as whole numners
//Negative numbers = -42 (Integers) here integral stands for constitutional

// Precision :The quality of having high accuracy and consistency
//The role of precision in computer science
//Pi (π) is a mathematical expression whose approximate value is 3.14159365…
//The given value of π is expressed in decimal which is non-terminating and non-repeating. As the value is non-terminating it shows the nature of irrational(Not consistent with or using reason) numbers.
// if we are calucating value of π it can be 3.14 with two decimal points or 3.1415926535 with ten digits.
//If we increse numbers after decimal point then we increase its accuracy
//For computers level of precision is determined by binary(bits) instead of decimal places
//Higher the bits then higher the precision
//
//Single-Precision:=32 bits
//Double-precision=64 bits
//why there is difference between bits?
//The base - 0 represents a positive number; 1 represents a negative number. 

//The biased exponent - The exponent(The number of times quatity multiply  itself) is used to represent both positive and negative exponents. Thus, a bias must be added to the actual exponent to get the stored exponent. 

//The mantissa - Also known as the significand, the mantissa represents the precision bits of the number
//Need to do mre research ont this visit : https://www.xilinx.com/applications/ai-inference/single-precision-vs-double-precision-main-differences.html#:~:text=The%20simplest%20way%20to%20distinguish,represent%20the%20floating%2Dpoint%20number.
//Example Eluers NUmber

// unsigned integer means posive whole number or 0
//uint _naturalNumber = 23;
//Integer means nagative or positive number or 0

//int _intgerNumber = -23;

//Float: Positive or negative whole number with decimal point(.) 

//Example: 1.1 of -111.0234  are flaoting numbers
//while 91 or 0 are not these are whole numbers(All positive non-Zero numbers are called whole numbers) or natural numbers(All positive numbers including 0 are called natural numbers)
// The name Float comes because decimal point float from its postion
// F suffix makes it float literal
//need to find out what are Real Numbers
//float _realNumner = 2.3F;
//double means double-precision floating point 
//double is default type of a number with decimal point.
//double _anotherRealNumnber = 2.3; //double literal 

//Improving legibility(readablity) by using digit(Example number 89 is two digit 8 and 9 where 9 is at 1's palce (ekak) and 9 is at 10's place (dashak)) sepertor

//Two imrovement in c# 7.0 and later
//1st improvemet: use of underscore(draw a line or lines underneath to call attention to words) to seperete digits
// Example 1 Million = 10 lakh(Indian 2/3 digit system(ekak ,dashak ,shatak ,hazar, dash-hazar and so on sepreted by commas((,)))= 10,00,000
//Hence 10_000_00 in India
//2nd improvemet:using underscore to improve legitibilty i.e. readability to of decimal(Human readbility numnbers from 0-9 base 16)
//binary(0's and 1's computers readabii:consisting of two (units, components, elements or terms)) and Hexadecimal(Efficient way to sotre data in memory
//It uses 0 9 and number greater than 9 replaced with a to f letters.
//A single Hexadecmal corresponds to 4 bits and so each byte of memory requires digits2 hexadeciaml 
// for more imfor,mation visit : https://statmath.wu.ac.at/a/data-analysis/itdtHTML/node55.html#:~:text=An%20even%20more%20efficient%20way,requires%20only%202%20hexadecimal%20digits.

// Exlploring whole numbers
//2 miliion =20 lakh=20,000,00 visit: https://byjus.com/maths/use-of-commas/ for more info.
//int _decimalNotationIND = 20_000_00;//(India)
//int _decimalNotationUSA = 2000_000;//(USA)
////Console.WriteLine($"Deciaml In India : {_decimalNotationIND}");
//Console.WriteLine($"Decimal in USA: {_decimalNotationUSA}");
// Three variables that stores 2 miliion =20 lakh=20,000,00=2000,000 USA

//using System.Xml;

//int _decimalNotation = 2000_000;
//int _binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
//int _hexadeciamlNotation = 0x_001E_8480;

//printing these three values


//Console.WriteLine($"Decimal Notation : {_decimalNotation}");
//Console.WriteLine($"Binary Notation  : {_binaryNotation}");
//Console.WriteLine($"Decimal Notation : {_hexadeciamlNotation}");
//output : 2000000 for all thre values
//Check if three variable have same value
//Console.WriteLine("Cheking Equality of these three numbers: ");
//Console.WriteLine($"{_decimalNotation==_binaryNotation}");
//Console.WriteLine($"{_decimalNotation==_hexadeciamlNotation}");
//Console.WriteLine();

//Storing real numbers // Need to find what are reall numbers for more info visit https://byjus.com/maths/real-numbers/

//when to use decimal,Hexadecimal and binary to store values in computer programming? 

//Writting code to explore number sizes

//sizeof keyword to get number of bytes that uses in memory
//SOME types (Not all types has min and max value  need to do research on this)


//Console.WriteLine($"int uses {sizeof(int)} bytes and the range {int.MinValue:0N} to {int.MaxValue:0N}");
//Console.WriteLine($"double uses {sizeof(double)} bytes and the range {double.MinValue:0N} to {double.MaxValue}");
//Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and the range {decimal.MinValue:0N} to {decimal.MaxValue:0N}");

//Comparing double and decimal
//Console.WriteLine($"Using double");
//double a = 0.1d; // suffix d is optional
//double b = 0.2d;
//if (a + b == 0.3)
//{
//    Console.WriteLine($"{a} +{b} equals {0.3}");

//}
//else
//{
//    Console.WriteLine($"{a} and {b} does NOT equal {0.3}");

//}


// rewite the code using underscore _
//Console.WriteLine($"Using double");
//double a = 0_1;// Its not readable and does not make any sense it represents it as a=1 and b=2 repectively.
//double b = 0_2;
//if (a + b == 0.3)
//{
//    Console.WriteLine($"{a} +{b} equals {0.3}");

//}
//else
//{
//    Console.WriteLine($"{a} and {b} does NOT equal {0.3}");

//}

//why does it not equals?
//double can not be represented accurate with  floating point
// Number 0.1 to store this number in binary format it uses 0.01100011... and repeating forever 
//Note: do not use double when comparing two values for equality we can use it for less than greter than and so on..
//Gulf war example read more on https://www.ima.umn.edu/~arnold/disasters

//Using decimal

//using System.Runtime.CompilerServices;
//M stands for Money that was the sugestion but Peter Golde: C# program manager at Microsoft recalls M is just the next best letter in decimal because d is taken by double
//Console.WriteLine($"Using decimal");

//decimal c = 0.1M;
//decimal d = 0.2M;
//if (c + d == 0.3M)
//{
//    Console.WriteLine($"{c} + {d} equals {0.3M}");

//}
//else
//{
//    Console.WriteLine($"{c} and {d} does NOT equal");
//}
//why it works?
//The decimal is accurate because it stores as large integer number and shifts the decimal point 
//Example: 12.75 is stored as 1275 and with note of position of decimal point
//test use deciaml and double together and determine tyoe and value equality
//watch: https://www.youtube.com/watch?v=SvNh2onhE-w
//
//Infinity Learn NEET

//Good Practice: Use int for whole numbers(collection of 0 and positive negative numbers to count like 0,1,2,3..upto infinity and and -1,-2 ).
//Use double for real numbers that will not be compared for equality to other values

//use uint for o or Positive whole numbers
//use int for 0 or nagative number 
//use decimal for money,CAD drawings,general enginnering
//and where ever accuracy of real numbers is required.
//do research on NaN positive and negative infinity.

//Storing Booleans Of or relating to a combinatorial system devised by George Boole that combines propositions with the logical operators AND and OR and IF THEN and EXCEPT and NOT
//In programming booleans can store only two values ture and false
////Boolean Example
//bool _happy = true;
//bool _sad = false;
////Note: Boolean and bool are same bool is aliase of class Boolean

//Console.WriteLine($"type of keyword: {typeof(bool)}");// output: Syte,.Boolean
//Console.WriteLine($"{(_happy)}");




//Storing any type of obeject(a discrete (distinct)item that provides a description of virtually anything known to a computer)
// We can store anything in this type 
// We sould avoid using obect becuase its not good for performance.
//object _height = 1.88;
//object _name = "Amir";

//Console.WriteLine($"{_name} is {_height} meter tall");
//Console.WriteLine($"Finding what type of data sotored in object type: {typeof()}");

//int _length1 = _name.Lenght; //gives compiler error
int _length=((string)(_name)).Length;// using type casting opertaor to use Length property
