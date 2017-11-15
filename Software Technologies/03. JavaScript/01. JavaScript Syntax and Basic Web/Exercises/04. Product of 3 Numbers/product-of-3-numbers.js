function solution(nums) {
    let numArr = nums.map(Number);
    
    let negativeCounter = 0;
    for (i = 0; i < numArr.length; i++){
        if (numArr[i] === 0){
            return 'Positive';
        }
        if (numArr[i] < 0){
            negativeCounter++;
        }
    }
    if (negativeCounter % 2 == 0){
        return 'Positive';
    } else {
        return 'Negative';
    }
}