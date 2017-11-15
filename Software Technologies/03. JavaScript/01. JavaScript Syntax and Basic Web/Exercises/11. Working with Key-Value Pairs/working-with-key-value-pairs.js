function solution(input) {
    let dict = {};

    for (i = 0; i < input.length - 1; i++){
        let inputTokens = input[i].split(' ');
        let key = inputTokens[0];
        let value = inputTokens[1];

        dict[key] = value;
    }

    let lastElementOfArray = input.slice(-1).pop();
    // if dict contains last element of array
    if (dict.hasOwnProperty(lastElementOfArray)){
        console.log(dict[lastElementOfArray]);
    } else {
        console.log('None');
    }
}