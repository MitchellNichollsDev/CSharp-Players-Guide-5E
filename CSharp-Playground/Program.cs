#region ********* Level 5 - VARIABLES **********

//string username;                        // Declaring a variable
//username = Console.ReadLine();          // Assigning a value to the variable
//Console.WriteLine("Hi " + username);    // Retrieving its current value
//username = Console.ReadLine();          // Reassigning a new value to the variable
//Console.WriteLine("Hi " + username);    // Retrieving its current value

//string username;
//username = Console.ReadLine();
//Console.WriteLine("Hi " + username);

//string favouriteColor;
//favouriteColor = Console.ReadLine();
//Console.WriteLine("Hi " + favouriteColor);

//int score;

//score = "Generic User"; // DOESN'T COMPILE!
//score = "0"; // DOESN'T COMPILE!

//score = 0; // 0 is an integer literal

//score = 4;
//score = 11;
//score = -1564;

//int a;
//int b;

//a = 5;
//b = 2;

//b = a;
//a = -3;

//int x = 0;

//int a, b, c = 10;

//Console.WriteLine(10);

#endregion

#region ********* Level 6 - THE C# TYPE SYSTEM **********

//byte aSingleByte = 255; // 1 byte - Maximum value
//aSingleByte = 0; // Minimum value

//short aNumber = 32767; // 2 bytes - Maximum value
//aNumber = -32768; // Minimum value

//long aVeryBigNumber = 9223372036854775807; // 8 bytes - Maximum value
//aVeryBigNumber = -9223372036854775808; // Minimum value

//byte aByteNumber = 32; // Integer literal
//aByteNumber = 256; // DOESN'T COMPILE! - 256 is too big for a byte

//aVeryBigNumber = 10000000000; // 10 billion would be a 'long' literal.

//ulong aVeryBigLongNumber = 10000000000U; // 10 billion is a 'long' literal, but we can use the 'U' suffix to make it an 'ulong' literal
//aVeryBigLongNumber = 10000000000L; // 10 billion is a 'long' literal, but we can use the 'L' suffix to make it a 'ulong' literal
//aVeryBigLongNumber = 10000000000UL; // 10 billion is a 'long' literal, but we can use the 'UL' suffix to make it a 'ulong' literal

//int bigNumber = 1_000_000_000; // 1 billion - underscores are ignored in numeric literals

//int a = 123_456_789; // 123 million - underscores are ignored in numeric literals
//int b = 12_34_56_78_9; // 123 million - underscores are ignored in numeric literals
//int c = 1_2__3___4____5; // 12345 - underscores are ignored in numeric literals, but cannot be at the start or end of a number, or next to a decimal point

//Console.WriteLine(c);

//int thirteen = 0b00001101; // 13 in binary
//int theColorMagenta = 0xFF00FF; // Magenta in hexadecimal

//char aLetter = 'a'; // A single character literal
//char baseball = '⚾'; // A single character literal

//aLetter = '\u0061'; // Unicode escape sequence for 'a'

//string message = "Hello, World!"; // A string literal

//double number1 = 3.5623;
//float number2 = 3.5623f; // 'f' suffix indicates a float literal
//decimal number3 = 3.5623m; // 'm' suffix indicates a decimal literal

//double avogadrosNumber = 6.022e23; // 6.022 x 10^23

//bool itWorked = true; // Boolean literal
//itWorked = false;

//var x; // DOESN'T COMPILE! - 'var' requires an initializer to infer the type

//var something = "Hello, World!"; // 'something' is inferred to be of type 'string'
//something = 3; // DOESN'T COMPILE! - 'something' is of type 'string', so it cannot be assigned an 'int'

/* Demonstrates the use of type conversion. User inputs a string, which is converted to an integer. */
//Console.Write("What is your favorite number? ");
//string favouriteNumberText =  Console.ReadLine();
//int favouriteNumber = Convert.ToInt32(favouriteNumberText);
//Console.Write(favouriteNumber + " is a great number!");

//int number  = int.Parse("45"); // Converts the string "45" to an integer 45
//Console.WriteLine(number);

#endregion

#region ********* Level 7 - MATH *********

//int a = 2 + 3; // Addition
//int b = 10 - 5; // Subtraction

//int c; // Declaration of variable c
//c = 9 - 2; // Assignment of value to c
//c = 6 + 9; // Reassignment of value to c

//int d = 5 + 2; // declaring and assigning a value to d all in one line
//d = 3 + 2; // Reassigning a new value to d

//int e = 3; // Declaration and assignment of value to e
//int f = e + 3; // Assigning a value to f based on the value of e
//int g = e - f; // Assigning a value to g based on the values of e and f

//float totalPies = 4; // Declaration and assignment of value to totalPies
//float slicesPerPie = 8; // Declaration and assignment of value to slicesPerPie
//float totalSlices = totalPies * slicesPerPie; // Assigning a value to totalSlices based on the values of totalPies and slicesPerPie

//double moneyMadeFromGame = 100000;
//double totalProgrammers = 4;
//double moneyPerProgrammer = moneyMadeFromGame / totalProgrammers; // Assigning a value to moneyPerProgrammer based on the values of moneyMadeFromGame and totalProgrammers

//int result = (2 + 5) * 2; // Assigning a value to result based on the values of 2, 5, and 2
//result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
//Console.WriteLine(result);

//double side1 = 4.5;
//double side2 = 3.5;
//double height = 1.5;

//double areaOfTrapezoid = (side1 + side2) / 2 * height;

//int aBigNumber = int.MaxValue;
//short aBigNegativeNumber = short.MinValue;
//double infinity = double.PositiveInfinity;
//double negativeInfinity = double.NegativeInfinity;
//double notAnyRealNumber = double.NaN;

//Console.WriteLine("Big Number: " + aBigNumber + "\nBig Negative Number: " + aBigNegativeNumber + "\nInfinity: " + infinity + "\nNegative Infinity: " + negativeInfinity + "\nNaN: " + notAnyRealNumber);

//int a = 6;
//int b = -a;
//int c = +a;

//int d = 8;
//int e = -(a + 2) / 5;
//int f = +(a + 2) / 5;

//Console.WriteLine($"{a}, {b}, {c}, {d}, {e}, {f}");

//int leftOverApples = 23 % 3;
//int remainder = leftOverApples % 2;

//Console.WriteLine($"{leftOverApples}, {remainder}");

//int a = 5;
//a = a + 1; // a = 6;

//a += 1; // Equivalent to a = a + 1;

//int b = 0;
//b += 5; // b = 5
//b -= 2; // b = 3
//a *= 6; // b = 18
//b /= 2; // b = 9
//b %= 3; // b = 3

//int c = 0;
//c++; // Equivalent to c = c + 1 and c += 1
//c--; // Equivalent to c = c - 1 and c -= 1


// SAFE 
//byte aByte = 3;
//int anInt = aByte;

// SAFE - Only when using byte case (byte)
//int anInt = 3;
//byte aByte = (byte)anInt;

//string text = "0";
//int number = (int)text; // DOES NOT WORK

//short a = 2;
//short b = 3;
//int total = a + b; // a and b are converted to ints automatically.

//short a = 2;
//short b = 3;
//short total = (short)(a + b); // Converted to short after the addition is performed

//int amountDone = 20;
//int amountToDo = 100;
//double fractionDone = amountDone / amountToDo; // Division performed as integers giving 0 as the value and then converted to double (0.0)

//Console.WriteLine(fractionDone);

//fractionDone = (double)amountDone / amountToDo; // Division performed as doubles giving 0.2 as the value

//Console.WriteLine(fractionDone);

//short a = 30000;
//short b = 30000;
//short sum = (short)(a + b); // Too big to fit into short range - Loops back to the bytes min range from its max range (Result: -5536)

//Console.WriteLine(sum);

//float a = 10000;
//float b = 0.00001f;
//float sum = a + b; // Rounds down to 10000 due to distinguishing precision - Roundoff error

//Console.WriteLine(sum);

//Console.WriteLine(Math.PI); // PI (3.14) syntax

//double x = 3.0;
//double xSquared = Math.Pow(x, 2); // Calculating the power of a number (Math.Pow)
//Console.WriteLine(xSquared);

//double y = Math.Sqrt(xSquared); // Calculating the square root of a number (Math.Sqrt)
//Console.WriteLine(y);

//int z = Math.Abs(-6); // Calculating the absolute of a number (Math.Abs) - Only converts Negatives to Positives and no effect on Positives to Negatives
//Console.WriteLine(z);
//z = Math.Abs(6);
//Console.WriteLine(z);

//double y1 = Math.Sin(0);
//double y2 = Math.Cos(0);

//Console.WriteLine($"{y1}, {y2}");

//int smaller = Math.Min(2, 10);
//int larger = Math.Max(2, 10);

//Console.WriteLine($"{smaller}, {larger}");

//int health = 0;
//health += 10;
//health = Math.Clamp(health, 0, 100);
//Console.WriteLine(health);

//float x = 3;
//float xSquared = MathF.Pow(x, 2);
//Console.WriteLine(xSquared);

#endregion

#region ******** LEVEL 8 - CONSOLE 2.0 ***********
//Console.Write("What is your name, human? ");
//string username = Console.ReadLine();

//Console.WriteLine("Press any key when you're ready to begin.");
//Console.ReadKey(); // Input key is registered in the console.

//Console.WriteLine("Press any key when you're ready to begin.");
//Console.ReadKey(true);  // Removes the input key in the console.

//Console.BackgroundColor = ConsoleColor.Yellow;
//Console.ForegroundColor = ConsoleColor.Black;

//Console.Clear();

/*Console Title appears in debug console tab at the top and in the console messages. When the user presses a key, the title disappears.*/

//Console.Title = "Hello, World!";

//Console.WriteLine($"Current console title: {Console.Title}");
//Console.WriteLine("Press any key to finish.");

//Console.ReadKey(true);

//Console.Beep(); // Standard beep
//Console.Beep(440, 1000); // (Frequency, duration) of the beep

//Console.WriteLine(""");

//Console.WriteLine("\""); // Write a " using \ in ""

//Console.WriteLine("C:\\Users\\CSharp-Players-Guide-5E\\MyFile.txt"); // \\ Allows a \ to be used where it's entered - Backslash escape character
//Console.WriteLine(@"C:\Users\CSharp-Players-Guide-5E\MyFile.txt"); // No \\ needed, using @ before the "" - verbatim string literal

//int favouriteNumber = 35;
//Console.WriteLine($"My Favourite Number is {favouriteNumber}."); // Single Interpolation - $ before speech marks

/*Whitespace before the variable names entered*/
//string name1 = Console.ReadLine();
//string name2 = Console.ReadLine();
//Console.WriteLine($"#1: {name1,20}");
//Console.WriteLine($"#2: {name2,20}");


/*Whitespace after the variable names entered*/
//string name1 = Console.ReadLine();
//string name2 = Console.ReadLine();
//Console.WriteLine($"{name1,-20} - 1"); 
//Console.WriteLine($"{name2,-20} - 2");

//Console.WriteLine($"{Math.PI:0.000}"); // Round three digits after the decimal place

//Console.WriteLine($"{42:#.##}");
//Console.WriteLine($"{42.1234:#.##}");

//float currentHealth = 4;
//float maxHealth = 9;
//Console.WriteLine($"{currentHealth / maxHealth:0.0%}"); // Rounds to 1 decimal place - Result: 44.4%
#endregion

#region ******** LEVEL 9 - Decision Making ***********

/*************************************** VARIABLES FOR CODE BELOW ************************************************************************************************/
//string input = Console.ReadLine();
//int score = Convert.ToInt32(input);

// CORRECT USING BLOCK STATEMENTS ({})
//if(score == 100)
//{
//    Console.WriteLine("A+");
//    Console.WriteLine("Perfect Score!");
//}

// INCORRECT
//if (score == 100)
//    Console.WriteLine("A+");
//    Console.WriteLine("Perfect Score"); // Bug doesn't print both statements, only the first. USE {} FOR BLOCK STATEMENTS

/* WORKS WHEN grade is created in the main method rather than the if method. */
//if(score == 100)
//{
//    char grade = 'A';
//}
//Console.WriteLine(grade); // COMPILER ERROR. grade variable isn't created in the same context. create and use grade before the if statement


/* CORRECT WHEN USING grade VARIABLE CREATED IN THE MAIN BLOCK */
//char grade = '?'; // Created in the same scope as input and score variable to be used throughout the main method.

//if (score == 100)
//{
//    grade = 'A';
//}

//Console.WriteLine(grade);


/* Variable grade made twice but in different if method scopes - INPUT OR SCORE VARIABLES CAN BE MADE IN EITHER IF SCOPE BUT ONE GRADE CAN BE MADE IN THE SCOPE OF THE MAIN BLOCK OF CODE */
//if(score == 100)
//{
//    char grade = 'A';
//    Console.WriteLine(grade);
//}

//if(score == 82)
//{
//    char grade = 'B';
//    Console.WriteLine(grade);
//}

/* if else condition. else runs when if isn't met. */
//if (score == 100)
//{
//    Console.WriteLine("A+! Perfect Score!");
//}
//else
//{
//    Console.WriteLine("Try Again!");
//}

/* 4 different conditions for the program to consider. Followed through from top to bottom until a condition is met, one will always run. */
//if(score == 100)
//{
//    Console.WriteLine("A+! Perfect Score!");
//}
//else if(score == 99)
//{
//    Console.WriteLine("Missed it by THAT much.");
//}
//else if(score == 42)
//{
//    Console.WriteLine("Oh no, not again");
//}
//else
//{
//    Console.WriteLine("Try Again.");
//}

//if (score >= 90)
//    Console.WriteLine("A");
//else if (score >= 80)
//    Console.WriteLine("B");
//else if (score >= 70)
//    Console.WriteLine("C");
//else if (score >= 60)
//    Console.WriteLine("D");
//else
//    Console.WriteLine("F");

/****************************************************************************************************************************************************/

/* NEW VARIABLES USED ONLY FOR CHALLENGES BELOW */
//int score = 45;
//int pointsNeededToPass = 100;

//bool levelComplete; // OR bool levelComplete = score >= pointsNeededToPass
//levelComplete = score >= pointsNeededToPass;

/* USING THE BOOL CONDITION IF AN IF ELSE CONDITION FORMAT */

//if (score >= pointsNeededToPass)
//    levelComplete = true;
//else
//    levelComplete = false;

//if (levelComplete)
//    Console.WriteLine("You've beaten the level!");

/* ! PERFORMS THE OPPOSITE OF THE CONDITION THE VARIABLE LEVELCOMPLETE IS CURRENTLY IN */
//if (!levelComplete)
//    Console.WriteLine("This Level is not over yet!");

// condition expression ? expression if true : expression if false
//string textToDisplay = score > 70 ? "You Passed" : "You Failed.";
//Console.WriteLine(textToDisplay);


/* NEW VARIABLES USED FOR ONLY CODE BELOW */
//int shields = 50;
//int armor = 20;
//bool stillHasShields = shields > 0;
//bool stillHasArmor = armor > 0;

//// NO RESULT - shields or armor aren't LESS THAN OR EQUAL TO 0
//if (shields <= 0 && armor <= 0)
//    Console.WriteLine("You're Dead.");

//// RESULT - shields or armor are greater than 0 - armor: 20 shield: 50
//if (shields > 0 || armor > 0)
//    Console.WriteLine("You're still alive. Keep going!");

//// RESULT - stillHasShields == shields > 0 and stillHasArmor == armor > 0 remains the same result with more clarity when statements overload
//if (stillHasShields || stillHasArmor)
//    Console.WriteLine("You're still alive. Keep going!");

// RESULT - The world is safe - Current armor and shield are above 0 with minimal NESTED IF STATEMENTS
//if(shields <= 0)
//{
//    if (armor <= 0)
//        Console.WriteLine("Shields and armor at zero! You're dead!");
//    else
//        Console.WriteLine("Shields are gone, but armor is keeping you alive!");
//}
//else
//{
//    Console.WriteLine("You still have shields left. The world is safe.");
//}
#endregion

#region ******** LEVEL 10 - Switches *********

//int choice = Convert.ToInt32(Console.ReadLine());

//// if else if else version - Same result as the switch case below
//if (choice == 1)
//    Console.WriteLine("Ye rest and recover your health.");
//else if (choice == 2)
//    Console.WriteLine("Raiding the port town ye get 50 gold doubloons.");
//else if (choice == 3)
//    Console.WriteLine("The wind is at your back; the open horizon ahead.");
//else if (choice == 4)
//    Console.WriteLine("'Tis but a baby Kraken, but still eats toy boats.");
//else
//    Console.WriteLine("Apologies. I do not know that one.");


//// Switch case version - Same result as if else if else above
//switch (choice)
//{
//    case 1:
//        Console.WriteLine("Ye rest and recover your health.");
//        break;
//    case 2:
//        Console.WriteLine("Raiding the port town ye get 50 gold doubloons.");
//        break;
//    case 3:
//        Console.WriteLine("The wind is at your back; the open horizon ahead.");
//        break;
//    case 4:
//        Console.WriteLine("'Tis but a baby Kraken, but still eats toy boats.");
//        break;
//    default:
//        Console.WriteLine("Apologies. I do not know that one.");
//        break;
//}

//// Typing 1 or 2 results in the statements in the arm of case 2 to be executed.
//switch (choice)
//{
//    case 1:
//    case 2:
//        Console.WriteLine("That's a good choice!");
//        break;
//}

//string response;

//response = choice switch
//{
//    1 => "Ye rest and recover your health.",
//    2 => "Raiding the port town get ye 50 gold doubloons",
//    3 => "The wind is at your back; the open horizon ahead.",
//    4 => "'Tis but a baby Kraken, but still eats toy boats.",
//    _ => "Apologies. I do not know this one."
//};

//Console.WriteLine(response);

#endregion

#region ********* LEVEL 11 - Looping **********

//int x = 1;

//while (x <= 5)
//{
//    Console.WriteLine(x);
//    x++;
//}

/* STANDARD WHILE LOOP - WHILE LOOP CONTINUES UNTIL A NUMBER BETWEEN 0 AND 10 IS ENTERED */
//int playersNumber = -1;

//while(playersNumber < 0 || playersNumber > 10)
//{
//    Console.Write("Enter a number between 0 and 10: ");
//    string playerResponse = Console.ReadLine();
//    playersNumber = Convert.ToInt32(playerResponse);
//}


/* DO/WHILE LOOP - PERFORM THE DO FIRST AND THEN THE WHILE. NO VALUE INITIALISATION FOR THE VARIABLE REQUIRED AS THE USER PROVIDES THIS IN DO */
//int playersNumber;

//do
//{
//    Console.Write("Enter a number between 0 and 10: ");
//    string playersResponse = Console.ReadLine();
//    playersNumber = Convert.ToInt32(playersResponse);
//} 
//while (playersNumber < 0 || playersNumber > 10);

/* FOR LOOP - INITIALISATION STATEMENT; CONDITION TO EVALUATE; UPDATING ACTION RESULT: NUMBERS 1 TO 5 IN THE CONSOLE. */
//for (int x = 1; x <= 5; x++)
//    Console.WriteLine(x);


/* WHILE LOOP - USER CONDITIONED ON TYPING THE NUMBER 12, ASKED TO CHOOSE A DIFFERENT NUMBER. THE WHILE LOOP ENDLESSLY ASKS FOR A NUMBER UNTIL THE USER TYPES QUIT OR EXIT INSTEAD OF A NUMBER. */
//while(true)
//{
//    Console.Write("Think of a number and type it here: ");
//    string input = Console.ReadLine();

//    if (input == "quit" || input == "exit")
//        break;

//    int number = Convert.ToInt32(input);

//    if(number == 12)
//    {
//        Console.WriteLine("I don't like that number. Pick another one.");
//        continue;
//    }
//    Console.WriteLine($"I like {number}. It's the one before {number + 1}!");
//}


/* NESTED FOR LOOP - ALL COMBINATION MULTIPLES FROM 1 TO 10. IN THE NESTED FOR LOOP, THE FIRST VALUE OF A IS CALLED AT WHICH ALL B VARIABLES ARE CALLED AFTERWARDS E.G. 1 * 0, 1 * 1 ETC UNTIL 1 * 10 AT WHICH A SWITCHES TO 2 UP UNTIL 10 */
//for (int a = 1; a <= 10; a++)
//	for (int b = 0; b <= 10; b++)
//		Console.WriteLine($"{a} * {b} = {a * b}");

//int totalRows = 5;
//int totalColumns = 10;

//for (int currentRow = 1; currentRow <= totalRows; currentRow++)
//{
//	for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
//		Console.Write("*");

//	Console.WriteLine();
//}

#endregion

#region ********* LEVEL 12 - Arrays **************
//int[] scores = new int[12];
//scores = new int[24];
//scores[0] = 99;
//scores[1] = 95;
//scores[2] = 90;
//scores[^1] = 24;

/* OTHER WAYS OF DEFINING AN ARRAY */
//int[] scores = new int[10] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

//int[] scores2 = new int[] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

//int[] scores3 = new [] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

/* PRINTING AN INDEX OF THE ARRAY
//Console.WriteLine(scores[0]);

/* ACCESS THE LAST VALUE IN AN ARRAY USING ^1 */
//int lastScore = scores[^1];
//Console.WriteLine(lastScore);

/* USING .. FOR THE RANGE COLLECTED. EITHER THE FIRST OR SECOND CAN BE NULL BUT ONE NUMBER MUST BE PRESENT FOR THE CODE TO BE VALID*/
//int[] firstThreeScores = scores[0..3];
//Console.WriteLine(string.Join(", ", firstThreeScores));

/* ALL INDEX VALUES APART FROM THE START AND END OF THE ARRAY - SECOND NUMBER ^1 NOT INCLUDED IN THE RANGE AND THE FIRST NUMBER IS THE 2ND POSITION OF THE ARRAY
int[] theMiddle = scores[1..^1];
Console.WriteLine(string.Join(", ", theMiddle));

/* OUT OF RANGE ERROR DUE TO [10] INDEX IS NOT IN ARRAY OF [5] */
//int[] scores = new int[5];
//scores[10] = 1000;

/* FIND THE LENGTH OF ANY ERROR USING .LENGTH AS SHOWN */
//int[] scores = new int[5];
//Console.WriteLine(scores.Length);

/* USER PROVIDES A LENGTH FOR THE ARRAY, CREATES IT AS THE INT SIZE, FILLS WITH VALUES FROM THE FOR LOOP. NUMBER ONES ARE PRINTED IN THE TERMINAL FOR THE LENGTH OF THE ARRAY (LENGTH 4 = 1, 1, 1, 1)*/
//int length = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[length];

//for (int index = 0; index < array.Length; index++)
//    array[index] = 1;
//Console.WriteLine(string.Join(", ", array));


/* Find the smallest number within the array - Printed in the console from the relevant index*/
//int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

//int currentSmallest = int.MaxValue;
//for (int index = 0; index < array.Length; index++)
//{
//    if (array[index] < currentSmallest)
//        currentSmallest = array[index];
//}
//Console.WriteLine(currentSmallest);


/* Finds the average of the array, iterating each index to add the value to the total. When complete, total is converted to float divided by the length of the array for the average*/
//int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

//int total = 0;
//for (int index = 0; index < total; index++)
//    total += array[index];

//float average = (float)total / array.Length;
//Console.WriteLine(average);


int[] scores = new int[10];

foreach (int score in scores)
{
    Console.WriteLine(score);
}
#endregion