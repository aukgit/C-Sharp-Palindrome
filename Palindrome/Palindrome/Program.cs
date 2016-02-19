using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome {
    class Program {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("Write words to test Palindrome (write 'e' to exit):");
                var word = Console.ReadLine();
                var isNotEmpty = !string.IsNullOrWhiteSpace(word);

                if (isNotEmpty  && word.Equals("e")) {
                    return;
                } else if (isNotEmpty) {
                    // test
                    var isPalindrome = IsPalindrome(word);
                    Console.WriteLine(isPalindrome ? "Yes, it is a palindrome" : "No it is not a palindrome.");
                }
            }
        }

        static bool IsPalindrome(string word) {
            int len = word.Length,
                mid = word.Length/2;

            for (int i = 0; i < mid; i++) {
                var firstChar = word[i];
                var lastChar = word[len - 1 - i];
                if (firstChar.CompareTo(lastChar) != 0) {
                    return false;
                }
            }
            return true;
        }
    }
}
