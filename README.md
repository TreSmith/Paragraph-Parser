# Paragraph-Parser

This is a program that takes in a paragraph from a file and does the following to the paragraph.

1. Find the number of palindrome words
2. Find the number of palindrome sentences
3. List the unique words of a paragraph with the count of that word
4. Based on user input of a single character list all the words containing that letter

## How it works

This program first takes in a file from the command line. Then with that file it reads it and puts it into a string. 
Two functions are called to break that string into words and sentences. This is done using the string split function.
Those word and sentence lists are passed into the palindrome method which takes each word/sentence and checks each character starting on the first and last character to check if they are equal and incrementing towards the middle if it reaches the middle it will count up.
The unique words and count are then found by passing in the word list and grouping the words. The key is the word and the count is the amount of times it appears.
Then the user enters a letter and the words containing that letter are printed out.

## How to use

1. First step in opening this file is to click open in visual studio
<img src="./Paragraph Parser/img/openWithVS.PNG" alt="openInVS">

2. Next we must configure the command line argument to contain a file path
<img src="./Paragraph Parser/img/commandLineArgs1.PNG" alt="commandLineArgs1">
<img src="./Paragraph Parser/img/commandLineArgs2.PNG" alt="commandLineArgs2">

3. Fire up the program!

## Accessing Code

To access the code: <a href="./Paragraph Parser/Program.cs">Paragraph Parser/Program.cs</a>

## Sample Input/Output

<a href="./Paragraph Parser/Sample Input Output/Sample Input Output.txt">Sample Input Output File</a>

### Sample Input 

This is a sample paragraph. This is meant to check out some of the cool functions I have been creating!
Dad. Ddadd dadd wow this is so cool coollooc 
Check it out!
The wise men were jumping the hurdles to obtain the prize.
JumppmuJ.
DAD.
Dad Bad Had daH daB daD.

### Sample Output

<img src="./Paragraph Parser/img/sampleOutput.PNG" alt="sampleOutput">
