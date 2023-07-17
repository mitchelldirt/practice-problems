function explodeString(str: string): string[] {
  // Create a map to store like characters
  const charMap = new Map<string, string>();

  // loop over string and add each character to the map
  for (let char of str) {
    // if char is space continue
    if (char === " ") {
      continue;
    }

    // If it has it will return value else returns -1
    const charValue = charMap.get(char);
    if (charValue !== undefined) {
      charMap.set(char, charValue + char);
    } else {
      charMap.set(char, char);
    }
  }

  // combine the map into an array
  let arr: string[] = [];

  charMap.forEach((char) => {
    arr.push(char);
  });
  // return the array sorted
  return arr.sort();
}

console.log(explodeString("Ahh, abracadabra!"));

console.log(explodeString("Mitchell Mudd"));
