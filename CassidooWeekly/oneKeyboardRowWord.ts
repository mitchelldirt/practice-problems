const row0 = new Set(["q", "w", "e", "r", "t", "y", "u", "i", "o", "p"]);
const row1 = new Set(["a", "s", "d", "f", "g", "h", "j", "k", "l"]);
const row2 = new Set(["z", "x", "c", "v", "b", "n", "m"]);

const rows = [row0, row1, row2];

function oneRow(words: string[]): string[] {
  let resultingWords: string[] = [];

  while (words.length > 0) {
    let word = words.pop();

    if (typeof word === "string") {
      let wordLowerCase = word.toLowerCase();
      let foundRow: number | undefined = undefined;
      let currentRow: number;

      for (let char of wordLowerCase) {
        for (let i = 0; i < rows.length; i++) {
          if (rows[i].has(char)) {
            currentRow = i;
            if (foundRow === undefined) {
              foundRow = currentRow;
            } else if (foundRow !== currentRow) {
              foundRow = -1; // Set an invalid value to indicate characters from multiple rows
              break;
            }
          }
        }
        if (foundRow === -1) {
          break;
        }
      }

      if (foundRow !== -1) {
        resultingWords.push(word);
      }
    }
  }

  return resultingWords;
}

console.log(oneRow(["candy", "fart", "pop", "Zelda", "flag", "typewriter"]));

// This will return ['pop', 'flag', 'typewriter']
