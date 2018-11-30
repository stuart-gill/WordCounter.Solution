# Word Counter

A C# program to check how many times a user entered word appears in a user entered sentence.

## Plain English specifications for program functionality in sequential order

1. Program asks user to enter a word: "please enter a word"
2. User enters a word. 
* EXAMPLE INPUT: "dog"
3. Program reads the word and assigns it to a variable (string)
4. Program asks user to enter a sentence: "please enter a sentence"
5. User enters a sentence. 
* EXAMPLE INPUT 2: "my dog likes another dog"
6. Program reads the sentence and assigns it to another variable (string)
7. Program splits the sentence variable into a list of strings, one for each word
8. Program then splits the sentence words into individual characters and checks each one to make sure it is an alphabetic character.
9. Program converts all letters in the sentence to lower case for ease of matching.
10. Program then compares the initial user entered word to each word retrieved from the sentence, one by one
11. As it compares these words, any time the sentence-retrieved word matches the original word, a counter is incremented by one.
12. Once all the words in the sentence have been checked, the program tells the user how many times the word appears in the sentence, using the counter. 
* EXAMPLE OUTPUT: "Your word 'dog' appears 2 times in your sentence"

### Setup

Follow this link: https://stuart-gill.github.io/word-counter-csharp (currently a dead link, will be updated once front end is built)

OR:

Download .NET Core 2.1.3 SDK and .NET Core Runtime 2.0.9 and install them. Download Mono and install it.

Clone this repository: $ git clone repo name
Change into the work directory:: $ cd WordCounter.Solution
To edit the project, open the project in your preferred text editor.

To run the program, first navigate to the location of the WordCounter.cs file then compile and execute: $ cd WordCounter/Models $ mcs WordCounter.cs; mono WordCounter.exe;

To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test 

## Running the tests

To run tests, navigate to WordCounter.Test in your editor and run the command "dotnet test"

### List of tests

The tests test the ability of the program to:
1. Create a RepeaterCounter object of the class RepeatCounter
2. Set the user inputted sentence as a sentence object of the class RepeatCounter
3. Retrieve the sentence stored in the sentence object of the class RepeatCounter
4. Count the instances of a user inputted word in the sentence object
5. Verify that the sentence object is in fact comprised of words. If the sentence object contains anything other than alphabetic characters, the test fails. Numerals and symbols will fail the test. 
6. Verify that the sentence is converted to all lower case. 

## Built With

* C#
* .NET
* MSTest


## Author

* **Stuart Gill** 

Contact me at stuart.a.gill@gmail.com

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
