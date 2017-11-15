function solution(input) {
    let n = Number(input[0]);
    let arr = new Array(Number(n)).fill(0);

    for (i = 1; i < input.length; i++){
        let inputToken = input[i].split(' - ');
        let index = inputToken[0];
        let value = inputToken[1];
        arr[index] = value;
    }

    for (let num of arr){
        console.log(num);
    }
}