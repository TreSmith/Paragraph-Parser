class ParagraphParser
{
    #region Helper Methods
    static string[] StripSentences(string paragraph)
    {
        //This function will take the paragraph as the input and output the sentences
        char[] splitChars = {'.', '!', '?', '\n'};
        string[] sentences = paragraph.Split(splitChars, StringSplitOptions.TrimEntries).Where(sentence => !string.IsNullOrWhiteSpace(sentence)).ToArray();
        return sentences;
    }

    static string[] StripWords(string paragraph)
    {
        //this function will take the paragraph as the input and output the words
        char[] splitChars = { '.', '!', '?', ' ', ',' };
        //this statement splits the paragraph into different words separated by the characters above chars and removing the empty entries
        string[] words = paragraph.Split(splitChars, StringSplitOptions.TrimEntries).Where(word => !string.IsNullOrWhiteSpace(word)).ToArray();
        return words;
    }
    #endregion

    #region Problem Methods
    static int PalindromeFinder(string[] list)
    {
        //Takes in the sentences or word lists and outputs the amount of palindromes
        int palindromeCount=0;
        int right;
        //Goes through each item in the sentence or word list and determines if it's a palindrome
        foreach(string item in list)
        {
            //Takes each string and uses the incrementing index as the left index check
            for (int left = 0; left < (item.Length / 2); left++)
            {
                //find the right index that corresponds to the left index
                right = item.Length - 1 - left;
                //Check if the right and left character are equal
                //if they aren't break out of this loop and check next item
                if (item[left] != item[right])
                    break;
                //checks if we reached the middle first before counting up
                else if ((left + 1) >= (item.Length / 2))
                {
                    palindromeCount++;
                }
            }

        }
        return palindromeCount;
    }

    static void uniqueWordFinder(string[] words)
    {
        Console.WriteLine("Unique Words:\n");
        //Takes in the word list and determines what the unique words are and how many there are
        //we want the lowercase of each word like for example The and the are the same word
        var uniqueWords = words.GroupBy(word => word.ToLower());
        foreach(var uword in uniqueWords)
        {
            Console.WriteLine($"{uword.Key} : {uword.Count()}");
        }
        
    }

    static void allWordsContaining(string[] words) 
    {
        //Pass in word list, enter a letter, and outputs the words containing that letter
        Console.Write("Enter a character: ");
        char let;

        //Checking if character is valid to search and setting letter variable to that character entered
        if (Char.IsLetter(let = Char.ToLower(Convert.ToChar(Console.Read()))))
        {
            Console.WriteLine($"Checking if {let} is in any word...");
            foreach (string word in words)
            {
                //Check if the word has the letter in it
                if (word.Contains(let))
                {
                    //Output the word
                    Console.Write($"{word} ");
                }
            }
            Console.Write("\n");
        }
        else
        {
            //If user doesn't enter a letter print out statment informing them
            Console.WriteLine("Invalid Character; please enter a letter");
        }
    }
    #endregion

    static int Main(string[] args)
    {
        //Start off by declaring a variable that will contain the paragraph
        //Sentences is the array that will contain the split sentences from paragraph and words is the words split from paragraph
        string paragraph;
        string[] sentences = null;
        string[] words = null;
        
        //Check if command line args has a file path and if that path is valid
        //if it is valid then read all the text of that file to the paragraph
        //if not valid then output a message expecting a valid file path in command line
        if (args.Length == 1 && File.Exists(args[0]))
        {
            paragraph = File.ReadAllText(args[0]);
        }
        else
        {
            //no valid file path
            return -1;
        }

        //Strip sentences and words from the paragraph obtained from the file
        words = StripWords(paragraph);
        sentences = StripSentences(paragraph);

        //Obtain the number of plaindrome words in the paragraph
        int wPalindrome = PalindromeFinder(words);
        Console.WriteLine($"Word Palindromes: {wPalindrome}");

        //Obtain the number of palindrome sentences in the paragraph
        int sPalindrome = PalindromeFinder(sentences);
        Console.WriteLine($"Sentence Palindromes: {sPalindrome}");

        //List unique words and word count
        uniqueWordFinder(words);

        //Input a letter and list all words containing the letter. (case insensitive)
        allWordsContaining(words);

        return 0;
    }
}