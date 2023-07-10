function justifyText(words: string[], width: number): string[] {
  let lines: string[] = [];
  let currentLine = 0;

  while (words.length > 0) {
    let currentWord = words.splice(0, 1)[0];

    if (!lines[currentLine]) {
      lines[currentLine] = currentWord + " ";
      continue;
    }

    if (lines[currentLine].length + words[0].length < width) {
      // just push it to the current line string and continue
      lines[currentLine] += currentWord + " ";

      if (lines[currentLine].length === width) {
        currentLine++;
        continue;
      }
    }

    if (lines[currentLine].length + words[0].length === width) {
      // just push it to the current line string, increment currentLine, and continue
      lines[currentLine] += currentWord;
      currentLine++;
      continue;
    }

    if (lines[currentLine].length + words[0].length > width) {
      // if the current line isn't at width characters then append on X amount of spaces, increment currentLine, continue
      lines[currentLine] += " ".repeat(width - lines[currentLine].length);
      currentLine++;
      continue;
    }
  }

  if (lines[lines.length - 1].length < 16) {
    lines[lines.length - 1] += " ".repeat(width - lines[currentLine].length);
  }

  return lines;
}

console.log(
  justifyText(
    ["This", "is", "an", "example", "of", "text", "justification."],
    16
  )
);
