function arraySign(nums: number[]): number {
  if (nums.includes(0)) return 0;
  
  let neg = 0;
      for(let n of nums) {
          if(n < 0) neg++;
      }
      return neg%2===0 ? 1 : -1
  };