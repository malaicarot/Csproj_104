
//**Arrays unlike lists have a fixed size and cannot be changed once they are created.**//


//---------------------------------------------------------------------
// Part 1: Printing Array Elements
// Create an array of 5 countries and then print them out to the console.
// Hint: Use a foreach loop to print the array elements.

string[] countries = new string[] {"VietNam", "American", "Africa", "Japan", "Korea"};

foreach (string country in countries)
{
    Console.WriteLine(country);
    
}

//---------------------------------------------------------------------
// Part 2: Accessing Array Elements by Index
// Using the array of countries, find the name in the 3rd position and print it out to the console.
// Hint: Use the index of the array to access the name in the 3rd position.

Console.WriteLine($"The country in the 3rd position is: {countries[2]}");

//---------------------------------------------------------------------
// Part 3: Removing an Element from the Array
// Using the array of countries, remove the name in the 2nd position and then print the array out to the console.
// Hint: Use the RemoveAt() method to remove an item from the array.
Console.WriteLine("Arrays before remove element!!!");
foreach (string country in countries)
{
    Console.WriteLine(country);
    
}

int arrLength = countries.Length;
int indexToRemove = 1;

for(int i = indexToRemove; i < arrLength - 1; i++){
    countries[i] = countries[i + 1];
}
arrLength--;



Console.WriteLine("Arrays after remove element!!!");
for (int i = 0; i < arrLength; i++)
{
    Console.WriteLine(countries[i]);
    
}


//---------------------------------------------------------------------
// Part 4: Replacing an Element in the Array
// Using the array of countries, replace the name in the 3rd position with a new name and then print the array out to the console.
// Hint: Use the index of the array to replace the name in the 3rd position with a new name.
countries[2] = "Rusia";
Console.WriteLine("Arrays after replace country in the 3rd position");
for (int i = 0; i < arrLength; i++)
{
    Console.WriteLine(countries[i]);
    
}


//---------------------------------------------------------------------
// Part 5: Finding the Length of the Array
// Using the array of countries, find the length of the array and print it out to the console.
// Hint: Use the Length property to find the length of the array.

Console.WriteLine($"The Length of the Array: {arrLength}");


//---------------------------------------------------------------------
// Part 6: Checking if an Element Exists in the Array
// Using the array of countries, check if a name exists in the array and print out if it exists or not.
// Hint: Use the Contains() method to check if a name exists in the array.

string elementExists = "Rusia";

if(countries.Contains(elementExists)){
Console.WriteLine($"The country is: {elementExists}");

}else{
    Console.WriteLine($"The country is not exists!");

}


//---------------------------------------------------------------------
// Part 7: Finding the Index of an Element in the Array
// Using the array of countries, find the index of a name in the array and print it out to the console.
// Hint: Use the IndexOf() method to find the index of a name in the array.

int indexOfElement = Array.IndexOf(countries, elementExists);
Console.WriteLine($"the index of a country: {indexOfElement}");