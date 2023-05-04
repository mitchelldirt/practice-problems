function findDifference(nums1: number[], nums2: number[]): number[][] {
    // Sets can only contains unique values
    const set = new Set<number>(nums1);
    const set2 = new Set<number>(nums2);

    // Mark the end point of the first array
    let endOfNums1 = set.size;

    for (let num of set2) {
        if (set.has(num)) {
            set.delete(num);

            // Move the end point of the first array back one index
            endOfNums1 -= 1;
            continue;
        }
        set.add(num);
    }

    // Convert the set to an array
    const setArray = Array.from(set);

    return [setArray.slice(0, endOfNums1), setArray.slice(endOfNums1)]
};