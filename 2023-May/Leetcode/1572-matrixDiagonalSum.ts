// Time Complexity: O(n)
function diagonalSum(mat: number[][]): number {
  let primary = 0;
  let secondary = mat[0].length - 1;
  let sum = 0;

  while (primary < mat.length) {
    sum += mat[primary][primary];
    if (primary !== secondary) {
      sum += mat[primary][secondary];
    }

    primary++;
    secondary--;
  }

  return sum;
};