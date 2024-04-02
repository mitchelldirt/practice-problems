function uniqueSum(arr: number[]) {
  const uniqueNums = arr.map((value) => {
    const textNum = value.toString();
    const textNumSet = new Set(textNum.split(""));
    if (textNum.length === textNumSet.size) {
      return value;
    }
  });

  let sum = 0;

  uniqueNums.forEach((value) => {
    sum += value ?? 0;
  });

  return sum;
}

console.log(uniqueSum([1, 2, 3]));
console.log(uniqueSum([11, 22, 33]));
console.log(uniqueSum([101, 2, 3]));
