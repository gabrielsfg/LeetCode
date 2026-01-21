## LeetCode 49. Group Anagrams
**Difficulty:** Medium

### Description
Given an array of strings `strs`, group the anagrams together. You can return the answer in any order.

An anagram is a word formed by rearranging the letters of another word using all original letters exactly once.

### Intuition

I have an array of strings and I need to group together all strings that are anagrams of each other.

Two strings are anagrams if, after sorting their characters, they result in the same string.  
For example, the strings `"eat"`, `"tea"` and `"ate"` all become `"aet"` after sorting.

A brute force approach would be to compare every string with every other string to check if they are anagrams, but this would require nested loops and would be inefficient.

To optimize this, I realized that I can use a hash map where:
- The key is the sorted version of the string
- The value is a list of strings that match this sorted representation

This way, all anagrams naturally end up grouped under the same key.

---

### Approach

1. Create a dictionary where the key is a sorted string and the value is a list of original strings
2. Loop through each string in the input array
3. Convert the string to a character array and sort it
4. Convert the sorted character array back to a string
5. Use the sorted string as the key in the dictionary
   - If the key already exists, add the original string to the existing list
   - If the key does not exist, create a new list with the current string
6. After processing all strings, collect all dictionary values into the result list
7. Return the result

---

### Complexity

- **Time Complexity:** `O(n * k log k)`
  - `n` is the number of strings
  - `k` is the maximum length of a string
  - Each string is sorted individually

- **Space Complexity:** `O(n * k)`
  - All strings are stored in the dictionary
