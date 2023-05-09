// Given an m x n matrix, return all elements of the matrix in spiral order.

// Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
// Output: [1,2,3,6,9,8,7,4,5]

function spiralOrder(matrix: number[][]): number[] {
  const result: number[] = [];
  let left = 0, right = matrix[0].length - 1, top = 0, bottom = matrix.length - 1;

  while (left <= right && top <= bottom) {
    // Traverse right
    for (let i = left; i <= right; i++) {
      result.push(matrix[top][i]);
    }
    top++;

    // Traverse down
    for (let i = top; i <= bottom; i++) {
      result.push(matrix[i][right]);
    }
    right--;

    // Traverse left
    for (let i = right; i >= left && top <= bottom; i--) {
      result.push(matrix[bottom][i]);
    }
    bottom--;

    // Traverse up
    for (let i = bottom; i >= top && left <= right; i--) {
      result.push(matrix[i][left]);
    }
    left++;
  }

  return result;
}
