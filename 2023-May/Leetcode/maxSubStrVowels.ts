/*
Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.
*/

// First attempt. Not fast enough for leet code
let vowels = new Set(['a', 'e', 'i', 'o', 'u']);

function maxVowels(s: string, k: number): number {
  let maxVowels: number = 0;
  let currentVowels: number;
  let slowPoint = 0;
  let fastPoint = k;

  while (fastPoint < s.length + 1) {
    currentVowels = qtyOfVowels(s.slice(slowPoint, fastPoint), k);
    if (currentVowels > maxVowels) {
      maxVowels = currentVowels;
      if (maxVowels >= k) return k;
    }

    slowPoint++;
    fastPoint++;
    while (vowels.has(s[fastPoint - 1]) === false) {
      if (fastPoint > s.length + 1) break;
      slowPoint++;
      fastPoint++;
    }
  }

  return maxVowels;
};


function qtyOfVowels(subStr: string, max: number) {
  console.log(subStr)

  const vowelCount = subStr.split("").filter(str => vowels.has(str)).length;

  return vowelCount > max ? max : vowelCount;
}

// My final accepted solution

// Same idea as above, but instead of creating a bunch of extra strings and arrays, I just keep track of the current vowel count and update it as I go.

// This is an example of a sliding window problem.
function maxVowels2(s: string, k: number): number {
  let maxVowels: number = 0;
  let currentVowels: number = 0;
  let slowPoint = 0;
  let fastPoint = k;

  for (let i = 0; i < k; i++) {
    if (vowels.has(s[i])) {
      currentVowels++;
    }
  }

  maxVowels = currentVowels;

  while (fastPoint <= s.length) {

    if (currentVowels > maxVowels) {
      maxVowels = currentVowels;
    }

    if (vowels.has(s[fastPoint])) {
      currentVowels++;
    }

    if (vowels.has(s[slowPoint])) {
      currentVowels--;
    }


    if (maxVowels >= k) {
      return k;
    }

    fastPoint++;
    slowPoint++;
  }

  return maxVowels;
};