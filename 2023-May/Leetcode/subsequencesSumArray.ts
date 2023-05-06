// This one was TOUGH for me. I had to look at the solution to get it. I'm going to try to explain it as best as I can :)
function numSubseq(nums: number[], target: number): number {
  // Sorting allows a two pointer approach. There will be a consistent
  // Amount of subsequences in between the start and end if it's sorted
  nums.sort((a, b) => a - b);

  let res = 0;

  // The mod variable is just to prevent an overload - number is less than 
  // mod in this line of code: `num % mod`
  // Then mod just gets ignored
  const mod = Math.pow(10, 9) + 7;
  let [left, right] = [0, nums.length - 1];

  // The amount of subsequences in between the start and end is literally just how many numbers there are to get to the end including the end number to the power of two. So you can pre calculate those powers and put them in an array based on the lengths of the `nums` array
  const pows: number[] = [1];
  for (let i = 1; i < nums.length; i++)
    // % mod in every step to avoid number going beyond the range
    pows.push(pows[i - 1] * 2 % mod)

  // Start at the end of the array and and work backwards until the start + end <= the target number. Then grab the qty of numbers between them to the second power and add that to res. *note left++ just moves the start forward after updating res :)
  while (left <= right) {
    // Do not use res += pows[right - left++] % mod => res can go beyond the range
    if (nums[left] + nums[right] <= target) res = (res + pows[right - left++]) % mod;
    else right--;
  }

  return res;
};