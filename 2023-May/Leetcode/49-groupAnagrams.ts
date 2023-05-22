function groupAnagrams(strs: string[]): string[][] {
  // Create a map to hold sorted strings
  const map = new Map();

  for (let str of strs) {
    let sorted = str.split("").sort();
    let sortedStr = sorted.join("");
    let exists = map.get(sortedStr);

    if (typeof exists !== "undefined") {
      exists.push(str);
    } else {
      map.set(sortedStr, [str]);
    }
  }

  let result: string[][] = [];

  map.forEach((arr) => result.push(arr));

  return result;
}
