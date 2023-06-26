const letters = "abcdefghijklmnopqrstuvwxyz";

function returnMissingLetters(chars: string[]): string[] {
  const beg = letters.indexOf(chars[0]);
  const end = letters.indexOf(chars[chars.length - 1]);
  const charSlice = letters.slice(beg, end + 1).split("");

  for (let char of chars) {
    if (charSlice.includes(char)) {
      charSlice.splice(charSlice.indexOf(char), 1);
    }
  }

  return charSlice;
}

console.log(returnMissingLetters(["c", "d", "e", "g", "h"])); // ["f"]
console.log(returnMissingLetters(["x", "z"])); // ["y"]
console.log(returnMissingLetters(["a", "b", "c", "d", "f"])); // ["e"]
console.log(returnMissingLetters(["o", "q", "r", "s"])); // ["p"]
console.log(returnMissingLetters(["a", "g"])); // ["b", "c", "d", "e", "f"]
