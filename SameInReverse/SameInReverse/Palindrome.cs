using System;
using System.Collections.Generic;
using System.Text;

namespace SameInReverse
{
    class Palindrome
    {
        private string longestPali = null;
        // Constructor for Palindrome class, automatically finds the longest palindrome in the given string.
        public Palindrome(string text)
        {
            LongestPali(text);
        }
        // Method used for finding the longest palindrome in any given string.
        private void LongestPali(string text)
        {
            for (int i = 0; i < text.Length; i++) // Starts at the leftmost character and moves right with every loop.
            {
                for (int j = text.Length - i; j > 0; j--) // Starts with the biggest sub string that can be created from the starting character.
                {
                    if (IsPalindrome(text.Substring(i, j)))
                    {
                        if (longestPali == null) // If it is the first palindrome found, it automatically becomes the longest one.
                        {
                            longestPali = text.Substring(i, j);
                            break; // Since the loop goes from long string to short, if there's a palindrome found, there can't be a longer one for that starting character.
                        }
                        else if ((text.Substring(i, j).Length > longestPali.Length))
                        {
                            longestPali = text.Substring(i, j);
                            break; // Since the loop goes from long string to short, if there's a palindrome found, there can't be a longer one for that starting character.
                        }
                    }
                }
                if (longestPali.Length >= text.Length - i)
                    break; // Since the maximum length of string gets smaller at every loop, if a palindrome is longer or equal to the next loops max length, it means there can't be a longer one.
            }
        }
        // Method used to check if a given string is a palindrome
        private bool IsPalindrome(string pali)
        {
            if (pali == StringReverser(pali))
                return true;
            else
                return false;
        }
        // Method to get the string of the longest palindrome
        public string GetLongestPali()
        {
            return longestPali;
        }
        // Method to reverse a string 
        private string StringReverser(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        // Method to find the longest palindrome in a different string.
        public void ChangeString(string text)
        {
            LongestPali(text);
        }
    }
}
