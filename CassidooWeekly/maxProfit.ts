// Given an array where each element is the price of a given stock on that index's day, choose a single day to buy a stock and a different day (in the future/later in the array) to sell the stock to maximize your profit. Return the maximum profit that you can get from a given input. If you can't profit, return 0.
// maximumProfit([7,1,5,3,6,4])
// 5 (buy on day 2 sell on day 5)

function maxProfit(nums: number[]): number {
  // for each number each the profit of the other numbers
  let currentBestProfit = 0;
  let currentBestDay = 0;

  for (let buyDate = 0; buyDate < nums.length; buyDate++) {
    for (let sellDate = buyDate + 1; sellDate < nums.length; sellDate++) {
      let isProfitable = nums[sellDate] > nums[buyDate];
      let profit = nums[sellDate] - nums[buyDate];
      if (isProfitable && profit > currentBestProfit) {
        currentBestProfit = profit;
        currentBestDay = sellDate + 1;
      }
    }
  }

  return currentBestDay;
}

console.log(maxProfit([7, 1, 5, 3, 6, 4]));
