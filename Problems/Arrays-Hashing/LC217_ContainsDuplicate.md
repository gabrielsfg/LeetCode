## LeetCode 217 - Contains Duplicate
**Difficulty:** Easy

### Description
Given an integer array `nums`, return `true` if any value appears at least twice in the array, and return `false` if every element is distinct.

## Intuition
If the array contains duplicate values, there are different ways to detect them.

One possible idea is to sort the array. After sorting, duplicate values will appear next to each other, which allows duplicates to be detected by comparing adjacent elements.

Another approach is to use a hash-based data structure. Since a HashSet stores only unique values, it can be used to track which elements have already appeared while iterating through the array.

## Approach
In the first approach, the array is sorted using `Array.Sort`. After sorting, the algorithm iterates through the array starting at index `1` and compares each element with the previous one. If two adjacent elements are equal, a duplicate exists and the method returns `true`. If the loop finishes without finding any equal adjacent elements, the array contains no duplicates and the method returns `false`.

In the second approach, a `HashSet<int>` is used. The algorithm iterates through each element in the array and attempts to add it to the HashSet. If an element cannot be added, it means the value already exists in the set, so a duplicate has been found and the method returns `true`. If the loop completes without detecting duplicates, the method returns `false`.

## Complexity
- Time complexity:  
The sorting approach runs in `O(n log n)` time due to the sorting operation.  
The HashSet approach runs in `O(n)` time on average because each element is processed once and insert operations are constant time on average.

- Space complexity:  
The sorting approach uses `O(1)` to `O(log n)` extra space depending on the sorting implementation.  
The HashSet approach uses `O(n)` extra space to store the seen elements.
