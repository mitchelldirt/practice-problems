function uniqueSubstr(str: string): number {
  const n = str.length;
  let maxLen = 0;
  let start = 0;
  const freq: { [key: string]: number } = {};

  for (let i = 0; i < n; i++) {
    // Update the frequency of the current character
    freq[str[i]] = (freq[str[i]] || 0) + 1;

    // If there are more than two unique characters, slide the window
    while (Object.keys(freq).length > 2) {
      freq[str[start]]--;
      if (freq[str[start]] === 0) {
        delete freq[str[start]];
      }
      start++;
    }

    // Update the maximum length
    maxLen = Math.max(maxLen, i - start + 1);
  }

  return maxLen;
}

console.log(uniqueSubstr("eceba")); // Output: 3
console.log(uniqueSubstr("ccaabbb")); // Output: 5
console.log(uniqueSubstr("abcabcabc")); // Output: 2
