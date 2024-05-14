function maxProduct(nums: number[]): number {
  nums.sort((a, b) => a - b);
  const n = nums.length;
  // If the smallest two numbers are negative (and multiplied become bigger than the top three) we'll use those
  // Otherwise we multiply the 3 largest numbers and return that
  return Math.max(
    nums[0] * nums[1] * nums[n - 1],
    nums[n - 3] * nums[n - 2] * nums[n - 1]
  );
}

console.log(maxProduct([2, 4, 1, 3, -5, 6])); // 72
