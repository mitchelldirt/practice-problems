/*
Given a string, calculate the score that it would get in a game of Scrabble. For extra credit, try verifying if the string is a valid word, or take into account premium squares!

Scoring and example:

1 point: E, A, I, O, N, R, T, L, S, U
2 points: D, G
3 points: B, C, M, P
4 points: F, H, V, W, Y
5 points: K
8 points: J, X
10 points: Q, Z

> scrabbleScore('FIZZBUZZ')
> 49
*/

function scrabble(str: string): number {
  const scores = new Map<string, number>();
  scores.set("K", 5);
  scores.set("DG", 2);
  scores.set("JX", 8);
  scores.set("QZ", 10);
  scores.set("BCMP", 3);
  scores.set("FHVWY", 4);
  scores.set("EAIONRTLSU", 1);

  let total = 0;

  for (let char of str) {
    const scoresIter = scores.keys();

    let current = scoresIter.next().value;

    while (typeof current !== "undefined") {
      if (current.includes(char)) {
        total += Number(scores.get(current));
        break;
      }

      current = scoresIter.next().value;
    }
  }

  return total;
}

console.log(scrabble("FIZZBUZZ"));
