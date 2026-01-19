## LeetCode 242 - Valid Anagram
**Difficulty:** Easy

### Description
Given two strings `s` and `t`, return `true` if `t` is an anagram of `s`, and `false` otherwise.

## Intuition
For two strings to be anagrams, they must have the same length and contain the same letters with the same frequency, even if the letters appear in different positions.

If two strings are anagrams, sorting their characters alphabetically will result in two identical sequences of characters.

## Approach
First, check if the two strings have the same length. If they do not, they cannot be anagrams and the method returns `false`.

Then, convert both strings into character arrays. After that, sort both arrays alphabetically.  
If the two strings are anagrams, the sorted character arrays will be exactly the same, with the same characters in the same positions.

Finally, compare the two sorted arrays element by element. If all characters match, return `true`. Otherwise, return `false`.

## Complexity
- Time complexity: `O(n log n)`  
Sorting each character array costs `O(n log n)`, which dominates the overall runtime.

- Space complexity: `O(n)`  
Two character arrays are created to store the characters of each string.
