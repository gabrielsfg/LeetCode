## LeetCode 1. Two Sum
**Difficulty:** Easy

### Description
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

### Intuition

I have an array of integers and I need to find two numbers whose sum is equal to `target`.

The first idea is to try every possible pair by summing two numbers until the result matches the target.  
That works, but it requires two nested loops, which gives a time complexity of **O(n²)**.

To improve the logic, I realized that instead of checking every pair directly, I can:

- Pick the current number `nums[i]`
- Calculate what value is missing to reach the target:
  - `missing = target - nums[i]`
- Search for this `missing` value inside the array

This way, I only need one main loop and a search for the missing value.

---

### Approach

1. Loop through the array using index `i`
2. Compute the value needed to complete the target (`missing`)
3. Use `Array.IndexOf` to search for `missing`, starting from `i + 1`
   - This avoids using the same index twice
   - This also works with duplicates
4. If found, return `[i, missingIndex]`
5. If no solution is found, return `[-1, -1]` to always return a value

---

### Complexity

- **Time Complexity:** `O(n²)`
  - Loop = `O(n)`
  - `Array.IndexOf` inside loop = `O(n)`
- **Space Complexity:** `O(1)`
  - Only constant extra variables are used