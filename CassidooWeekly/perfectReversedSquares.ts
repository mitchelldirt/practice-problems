/*
perfectReversedSquare(9) // true
becomes 9

perfectReversedSquare(411) // true
becomes 114

perfectReversedSquare(25) // false
becomes 52
*/

function perfectReversedSquare(num: number): boolean {
  let numString = num.toString();
  let numReversed = numString.split("").reverse().join("");

  if (Math.sqrt(num).toString().length > numString.length) {
    return false;
  }

  if (Math.sqrt(Number(numReversed)).toString().length > numReversed.length) {
    return false;
  }

  return true;
}

console.log(perfectReversedSquare(9));
console.log(perfectReversedSquare(441));
console.log(perfectReversedSquare(25));
