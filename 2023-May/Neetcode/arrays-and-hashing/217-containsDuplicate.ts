/*
PROMPT: Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
*/

function containsDuplicate(nums: number[]): boolean {
  /* 
  Create a set which can only have 1 of any value
  If the set is smaller than the nums arrray that means there's a duplicate because it removed it when creating the set 
  */
  return new Set(nums).size < nums.length ? true : false;
};