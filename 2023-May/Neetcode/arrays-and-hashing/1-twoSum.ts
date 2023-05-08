// Solution 1 - Brute Force - O(n^2) time complexity
function twoSum(nums: number[], target: number): number[] {
  for (let i = 0; i < nums.length; i++) {
    for (let j = i + 1; j < nums.length; j++) {
      if (nums[i] + nums[j] === target) return [i, j];
    }
  }

  return [];
};

// Solution 2 - Hash Map - O(n) time complexity
function twoSum2(nums: number[], target: number): number[] {
  const map = new Map();

  for (let i = 0; i < nums.length; i++) {
    let val = map.get(target - nums[i]);
    if (val !== undefined) {
      return [val, i];
    }

    map.set(nums[i], i);
  }

  return [];
};