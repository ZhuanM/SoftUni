function solution(arr) {
    let nums = arr.map(Number);

    for (i = nums.length - 1; i >= 0; i--){
        console.log(nums[i]);
    }
}