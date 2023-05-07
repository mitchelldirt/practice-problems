// First solution - lot of extra space and time
function isAnagram(s: string, t: string): boolean {
  return s.split("").sort().join("") === t.split("").sort().join("") ? true : false;
};

// Second solution - less space and time
function isAnagramBetter(s: string, t: string): boolean {
  // Can't be an anagram if the lengths are different
  if (s.length !== t.length) return false;

  // Create new maps
  let sLetters = new Map();
  let tLetters = new Map();

  // Set map[char] = map[char] + 1 to get a count of chars in the string
  for (let i = 0; i < s.length; i++) {
    sLetters.set(s[i], (sLetters.get(s[i]) || 0) + 1);
    tLetters.set(t[i], (tLetters.get(t[i]) || 0) + 1);
  }

  // iterate through sLetters and compare if the value (count) of each char is equal to that of tLetters and if it isn't return false
  let iterator = sLetters.keys();
  for (let i = 0; i < sLetters.size; i++) {
    let letter = iterator.next().value;
    if (sLetters.get(letter) !== tLetters.get(letter)) return false;
  }
  return true;
}