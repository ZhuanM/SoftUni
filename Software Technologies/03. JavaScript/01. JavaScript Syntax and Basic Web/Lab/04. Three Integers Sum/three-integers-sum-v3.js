function solution(arr) {
    //arr[0] zashtoto se podava naprimer '8 15 7', koeto e edno cqlo
    let nums = arr[0].split(' ').map(Number);
    //Print the first non-false expression
    console.log(
        check(nums[0], nums[1], nums[2]) ||
        check(nums[0], nums[2], nums[1]) ||
        check(nums[1], nums[2], nums[0]) || 'No');
    //Nested function: returns either a string or false
    function check(num1, num2, sum) {
        if (num1 + num2 !== sum)
            return false;
        if (num1 > num2)
            [num1, num2] = [num2, num1];
        return `${num1} + ${num2} = ${sum}`;
    }
}