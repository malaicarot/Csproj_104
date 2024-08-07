// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.


/*


//Part 1
//Create a program so that it concatenates three strings and then outputs the result in uppercase.
//Hint: You can use the ToUpper() method to convert a string to uppercase.
//Hint: You can use the Console.WriteLine() method to output the result.

void concatenates(string firstName, string lastName, string job, bool isUpper)
{
    string identity = "";
    if (isUpper)
    {
        //     firstName.ToUpper();
        //     lastName.ToUpper();
        //    job = job.ToUpper();
        identity = $"{firstName.ToUpper()} {lastName.ToUpper()} - {job.ToUpper()}";
    }
    else
    {
        identity = $"{firstName.ToLower()} {lastName.ToLower()} - {job.ToLower()}";

    }

    Console.WriteLine(identity);

};
string _firstName = "Pham";
string _lastName = "Anh Khoa";
string _job = "Student";
bool isUpper = true;
concatenates(_firstName, _lastName, _job, isUpper);

//Part 2
//Create a program so that it concatenates three strings and then outputs the result in lowercase.
//Hint: You can use the ToLower() method to convert a string to lowercase.
//Hint: You can use the Console.WriteLine() method to output the result.

concatenates(_firstName, _lastName, _job, false);

//Part 3
//Write a program to find the length of a string.
//Hint: You can use the Length property to find the length of a string.
//Hint: You can use the Console.WriteLine() method to output the result.

void FindTheLength(string template)
{
    Console.WriteLine($"The length of a string is: {template.Length}");

}
FindTheLength(_firstName);

//Part 4
//Write a program to find the index of a character in a string.
//Hint: You can use the IndexOf() method to find the index of a character in a string.
//Hint: You can use the Console.WriteLine() method to output the result.

char needTofind = 'a';
void FindIndex(string template, char needTofind)
{
    int targetIndex = template.IndexOf(needTofind);
    Console.WriteLine($"Index Of {needTofind} is : {targetIndex}");
};
FindIndex(_firstName, needTofind);
//Part 5
//Write a program to find the index of a character in a string starting from a specified position.
//Hint: You can use the IndexOf() method to find the index of a character in a string starting from a specified position.
//Hint: You can use the Console.WriteLine() method to output the result.

int position = 3;

void FindIndexFromPosition(string template, char needTofind, int position)
{
    int targetIndex = template.IndexOf(needTofind, position);
    Console.WriteLine($"Index Of {needTofind} starting from index {position} is : {targetIndex}");
};

FindIndexFromPosition(_firstName, needTofind, position);

//Part 6
//Write a program to count the occurrences of a specific character in a string.
//Hint: You can use the Count() method to count the occurrences of a specific character in a string.
//Hint: You can use the Console.WriteLine() method to output the result.

char _occurrences = 'a';
string myName = "Pham Anh Khoaaaaaaaaa";

void CountOccurrences(string template, char occurrences)
{
    int occurrencesOfChar = template.Count(f => f == occurrences);
    Console.WriteLine($"The occurrences of a specific character {_occurrences} in a string {myName} is: {occurrencesOfChar}");
};

CountOccurrences(myName, _occurrences);



//Part 7
//Write a program to replace a character in a string with another character.
//Hint: You can use the Replace() method to replace a character in a string with another character.
//Hint: You can use the Console.WriteLine() method to output the result.

string _originString = "refrigerater";
char _originChar = 'e';
char _replaceChar = 'o';


void ReplaceCharacter(string originString, char originChar, char replaceChar)
{
    string modifiedString = originString.Replace(originChar, replaceChar);
    Console.WriteLine($"The string after replace a character {originChar} with {replaceChar} is: {modifiedString}");
};

ReplaceCharacter(_originString, _originChar, _replaceChar);

// //Part 8
// //Write a program to remove a character from a string.
// //Hint: You can use the Remove() method to remove a character from a string.
// //Hint: You can use the Console.WriteLine() method to output the result.

string stringNeedToRemove = "Skarterr";

void RemoveCharacter(string template)
{
    string afterRemoveString = template.Remove(7);
    Console.WriteLine($"The string after remove: {afterRemoveString}");
};
RemoveCharacter(stringNeedToRemove);

//Part 9
//Write a program to replace all occurrences of a specific character in a string with another character.
//Hint: You can use the Replace() method to remove all occurrences of a specific character from a string.
//Hint: You can use the Console.WriteLine() method to output the result.

string quotes = "This' is @a e;x.ercise!";
string[] removeChar = new string[] {"'", "@", ";", "."};

foreach (string item in removeChar)
{
    quotes = quotes.Replace(item, string.Empty);
}

Console.WriteLine($"String after replace: {quotes}");




//Part 10
//Write a program to extract a substring from a string.
//Hint: You can use the Substring() method to extract a substring from a string.
//Hint: You can use the Console.WriteLine() method to output the result.

string parentString = "ABCDEF";
string childString = parentString.Substring(3);
Console.WriteLine($"String after substring at index 3: {childString}");


//Part 11
//Write a program to extract a substring from a string starting from a specified position.
//Hint: You can use the Substring() method to extract a substring from a string starting from a specified position.
//Hint: You can use the Console.WriteLine() method to output the result.
string childString2 = parentString.Substring(0, 3);
Console.WriteLine($"String after substring start index 0: {childString2}");



//Part 12
//Write a program to remove leading and trailing whitespace from a string.
//Hint: You can use the Trim() method to remove leading and trailing whitespace from a string.
//Hint: You can use the Console.WriteLine() method to output the result.

string haveWhitespace = "     Death is like the wind always by my side!    ";
string trimmedText = haveWhitespace.Trim();
Console.WriteLine($"String after trimmed: {trimmedText}");


//Part 13 
//Write a program to parse a string to a number.
//Hint: You can use the Parse() method to parse a string to a number.
//Hint: You can use the Console.WriteLine() method to output the result.
string numberString = "1";
int number = int.Parse(numberString);
int number2 = 3;

Console.WriteLine($"After parse string to number, i have a calculator: {number + number2}");



//Part 14
//Write a program to convert a number to a string.
//Hint: You can use the ToString() method to convert a number to a string.
//Hint: You can use the Console.WriteLine() method to output the result.

float myScore = 9.75F;

string scoreString = myScore.ToString();

Console.WriteLine($"After parse number to string: {scoreString}");


*/





//////////////////Formating////////////////////





// Part 1

// You're organizing a team outing and need to print personalized event invitations.
// Develop a C# program that uses placeholders to create customized invitations.
// Replace the placeholders with the recipient's name, event date, and current time.
// Hint: Use composite formatting with placeholders to create personalized invitations.
// Test Data:
// Recipient's name: Alice
// Event date: January 15, 2025
// Expected Output:
// Hello, Alice! You're invited to our team outing on January 15, 2025. The event starts at 09:00.

string _RecipientName = "Anh Khoa";
string _month = "January";
string _day = "15";
string _year = "2025";
string _time = "09:00";

void invitation(string name, string month, string day, string year, string time)
{
    Console.WriteLine($"Hello {name}! You're invited to our team outing on {month} {day}, {year}. The event starts at {time}.");

}

// invitation(_RecipientName, _month, _day, _year, _time);






// Part 2

// Imagine you're managing an online store and need to send order confirmation emails.
// Write a C# program that utilizes placeholders to generate order confirmation emails.
// Fill in the placeholders with the customer's name, order ID, and purchase details.
// Hint: Use composite formatting with placeholders to generate order confirmation emails.
// Test Data:
// Customer's name: John Doe
// Order ID: 123456
// Purchase details: 2 x T-shirts, 3 x Jeans
// Expected Output:
// Dear John Doe, your order (ID: 123456) has been confirmed. You've purchased: 2 x T-shirts, 3 x Jeans.

string customerName = "PAK";
string ID = "123456";
string PurchaseDetails = "2 x T-shirts, 3 x Jeans";

void orderConfirmation(string name, string ID, string purchase)
{
    Console.WriteLine($"Dear {name}, your order (ID: {ID}) has been confirmed. You've purchased: {purchase}.");

}

// orderConfirmation(customerName, ID, PurchaseDetails);






// Part 3

// Picture yourself developing a task management application and need to display task reminders.
// Create a C# program that employs placeholders to format task reminder messages.
// Populate the placeholders with the task name, due date, and priority level.
// Hint: Use composite formatting with placeholders to format task reminder messages.
// Test Data:
// Task name: Complete Project Proposal
// Due date: May 10, 2025
// Priority level: High
// Expected Output:
// Reminder: Complete Project Proposal is due on May 10, 2025. Priority: High.

string taskName = "Complete Project Proposal";
string dueDate = "May 10, 2025";
string priority = "High";


void taskReminders(string _taskName, string _dueDate, string _priority)
{
    Console.WriteLine($"Reminder: {taskName} is due on {dueDate}. Priority: {priority}.");

}

// taskReminders(taskName, dueDate, priority);





// Part 4

// You're working on a scheduling application and need to generate event reminders.
// Develop a C# program that utilizes placeholders to format event reminder notifications.
// Fill in the placeholders with the event title, location, and start time.
// Hint: Use composite formatting with placeholders to format event reminder notifications.
// Test Data:
// Event title: Team Meeting
// Location: Conference Room A
// Start time: 10:00 AM
// Expected Output:
// Reminder: Team Meeting at Conference Room A starts at 10:00 AM.

string eventTitle = "Team Meeting";
string location = "Conference Room A";
string startTime = "10:00 AM";

void eventReminder(string _eventTitle, string _location, string _startTime)
{
    Console.WriteLine($"Reminder: {_eventTitle} at {_location} starts at {_startTime}.");

}

// eventReminder(eventTitle, location, startTime);









// Part 5

// Imagine you're designing a travel app and need to provide flight departure information.
// Write a C# program that employs placeholders to format flight departure notifications.
// Populate the placeholders with the flight number, departure airport, and scheduled time.
// Hint: Use composite formatting with placeholders to format flight departure notifications.
// Test Data:
// Flight number: ABC123
// Departure airport: JFK International Airport
// Scheduled time: 08:30 AM
// Expected Output:
// Flight ABC123 departing from JFK International Airport is scheduled for 08:30 AM.


string flightNumber = "ABC123";
string airport = "JFK International Airport";
string scheduled = "08:30 AM";
void flightDeparture(string _flightNumber, string _airport, string _scheduled)
{
    Console.WriteLine($"Flight {_flightNumber} departing from {_airport} is scheduled for {_scheduled}.");

}
// flightDeparture(flightNumber, airport, scheduled);










// Part 6

// You're developing a messaging application and want to greet the user.
// Write a C# program that asks the user to enter their name.
// Then, use interpolation to display a personalized greeting message.
// Hint: Use the Console.ReadLine() method to get user input and string interpolation to format the message.
// Test Data:
// Enter your name: Alice
// Expected Output:
// Hello, Alice! Welcome to our messaging app.

void greetingMessage(){
    Console.Write("Enter Your Name: ");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello, {name}! Welcome to our messaging app.");

}

// greetingMessage();










// Part 7

// You're organizing a fantasy-themed event and need to print custom badges for the participants.
// Develop a C# program that prompts the user to enter their character's name and class.
// Then, concatenate the name and class, and print the result.
// Hint: Use the + operator to concatenate strings and the Console.WriteLine() method to print the result.
// Test Data:
// Character's name: Legolas
// Character's class: Archer
// Expected Output:
// Custom Badge: Legolas the Archer

void customBadges(){
    Console.Write("Enter Character's Name: ");
    string characterName = Console.ReadLine();
    Console.Write("Enter Character's Class: ");
    string characterClass = Console.ReadLine();
    Console.WriteLine(characterName + " the " + characterClass);

}
//  customBadges();



// Part 8

// Picture yourself managing a music playlist and need to display the total duration of a song.
// Write a C# program that calculates and formats the total duration of a song in minutes and seconds.
// Prompt the user to enter the song's duration in seconds.
// Then, calculate the minutes and seconds and display the formatted duration.
// Hint: Use integer division and modulus to separate minutes and seconds, and composite formatting to display them.
// Test Data:
// Enter the song's duration in seconds: 245
// Expected Output:
// Song Duration: 4 minutes 5 seconds

void songDuration(){
    int minutesDuration;
    int secondsDuration;
    Console.Write("Enter the song's duration in seconds: ");
    string secondsString = Console.ReadLine();
    
    secondsDuration = int.Parse(secondsString);

    minutesDuration = secondsDuration / 60;
    secondsDuration %= 60;

    Console.Write($"Song Duration: {minutesDuration} minutes {secondsDuration} seconds");
}

// songDuration();





// Part 9

// Imagine you're developing a recipe app and want to display the serving size.
// Create a C# program that formats and displays the serving size of a recipe.
// Prompt the user to enter the number of servings.
// Then, display the serving size aligned to the right with a width of 5 characters.
// Hint: Use composite formatting with alignment to display the serving size.
// Test Data:
// Enter the number of servings: 8
// Expected Output:
// Serving Size: 8

void servingSize(){
    Console.Write("Enter the number of servings: ");
    string input = Console.ReadLine();
    
    // int servings = int.Parse(input);

    Console.Write($"Serving Size: {input.PadLeft(5)}");
}

// servingSize();


// Part 10

// You're designing a finance application and need to show the current account balance.
// Develop a C# program that formats and displays the account balance.
// Prompt the user to enter the account balance.
// Then, display the balance aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the account balance.
// Test Data:
// Enter the account balance: 1050.75
// Expected Output:
// Account Balance: 1050.75

void accountBalance(){
    Console.Write("Enter the account balance: ");
    string input = Console.ReadLine();

    double amountOfMoney =  Math.Round(double.Parse(input), 2);

    Console.WriteLine($"Account Balance: {amountOfMoney}");

}
//  accountBalance();


// Part 11

// You're building a movie ticket booking system and need to present the ticket price.
// Write a C# program that calculates and formats the ticket price with discounts.
// Prompt the user to enter the ticket price and discount percentage.
// Then, calculate the discounted price and display it aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the discounted price.
// Test Data:
// Enter the ticket price: 25.50
// Enter the discount percentage: 15
// Expected Output:
// Discounted Price: 21.68

void ticketPrice(){
    Console.Write("Enter the ticket price: ");
    string input = Console.ReadLine();
    Console.Write("Enter the discount percentage: ");
    string input2 = Console.ReadLine();

    float ticketCost = float.Parse(input);
    float discount = (100 - float.Parse(input2)) / 100;

    float discountedPrice = (float)Math.Round(ticketCost * discount, 2);
    Console.Write($"Discounted Price: {discountedPrice}");

}
// ticketPrice();






// Part 12

// Picture yourself developing a gaming platform and need to display the player's score.
// Create a C# program that formats and displays the player's score.
// Prompt the user to enter the player's score.
// Then, display the score aligned to the right with a width of 8 characters.
// Hint: Use composite formatting with alignment to display the player's score.
// Test Data:
// Enter the player's score: 10325
// Expected Output:
// Player's Score:   10325

void playerScore(){
    Console.Write("Enter the player's score: ");

    string input = Console.ReadLine();

    Console.WriteLine($"Player's Score: {input.PadLeft(8)}");

}
// playerScore();







// Part 13

// You're working on a data analysis tool and need to present the statistical results.
// Develop a C# program that formats and displays the average value of a dataset.
// Prompt the user to enter a series of numbers separated by spaces.
// Then, calculate the average value and display it aligned to the right with two decimal places.
// Hint: Use composite formatting with alignment and precision to display the average value.
// Test Data:
// Enter a series of numbers: 10 15 20 25 30
// Expected Output:
// Average Value: 20.00

void statistical(){
    Console.Write("Enter a series of numbers: ");

    string input = Console.ReadLine();

    string[] values = input.Split(' ');

    double[] numbers = values.Select(double.Parse).ToArray();

    double average = numbers.Average();

    string result = average.ToString("F2");

    Console.WriteLine($"Average Value: {result}");



}

// statistical();



// Part 14

// Imagine you're designing a weather app and need to show the temperature forecast.
// Write a C# program that calculates and formats the average temperature.
// Prompt the user to enter the temperatures for three days separated by spaces.
// Then, calculate the average temperature and display it aligned to the right with one decimal place.
// Hint: Use composite formatting with alignment and precision to display the average temperature.
// Test Data:
// Enter temperatures for 3 days: 25.5 28.7 22.3
// Expected Output:
// Average Temperature: 25.5

void averageTemperature(){
    Console.Write("Enter temperatures for 3 days: ");
    string input = Console.ReadLine();

    string[] values = input.Split(' ');

    float[] temperatures = values.Select(float.Parse).ToArray();

    float average = temperatures.Average();

    string result = average.ToString("F1");

    Console.WriteLine($"Average Temperature: {result}");


}

// averageTemperature();



// Part 15

// You're building a fitness tracker and need to present the daily step count.
// Create a C# program that formats and displays the total steps for a day.
// Prompt the user to enter the steps taken.
// Then, display the step count aligned to the right with a width of 6 characters.
// Hint: Use composite formatting with alignment to display the step count.
// Test Data:
// Enter the steps taken: 12345
// Expected Output:
// Step Count:  12345



void totalSteps(){
    Console.Write("Enter the steps taken: ");

    string input = Console.ReadLine();

    Console.WriteLine($"Step Count: {input.PadLeft(8)}");


}
totalSteps();
