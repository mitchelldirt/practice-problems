// Given a positive integer n, generate an n x n matrix filled with elements from 1 to n2 in spiral order.

// Input: n = 3
// Output: [[1,2,3],[8,9,4],[7,6,5]]

function generateMatrix(n: number): number[][] {
  const matrix: number[][] = [];

  // Push the empty arrays to add numbers to
  for (let i = 0; i < n; i++) {
    matrix.push([]);
  }

  let num = 1;

  // Set the boundaries... You shrink them as you continue the "spiral"
  let rowBegin = 0;
  let rowEnd = n - 1;
  let colBegin = 0;
  let colEnd = n - 1;

  while (rowBegin <= rowEnd && colBegin <= colEnd) {

    // left => right
    for (let i = colBegin; i <= colEnd; i++) {
      matrix[rowBegin][i] = num++;
    }
    rowBegin++;

    // top => bottom
    for (let i = rowBegin; i <= rowEnd; i++) {
      matrix[i][colEnd] = num++;
    }
    colEnd--;

    // right => left
    if (rowBegin <= rowEnd) {
      for (let i = colEnd; i >= colBegin; i--) {
        matrix[rowEnd][i] = num++;
      }
      rowEnd--;
    }

    // bottom => top
    if (colBegin <= colEnd) {
      for (let i = rowEnd; i >= rowBegin; i--) {
        matrix[i][colBegin] = num++;
      }
      colBegin++;
    }
  }

  return matrix;
}