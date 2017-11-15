function solution(input) {
    let dict = {};

    for (i = 0; i < input.length - 1; i++){
        let inputTokens = input[i].split(' ');
        let key = inputTokens[0];
        let value = inputTokens[1];

        if (key in dict)
            dict[key].push(value);
        else
            dict[key] = [value];
    }

    let lastElementOfArray = input.slice(-1).pop();
    // if dict contains last element of array
    if (dict.hasOwnProperty(lastElementOfArray)){
        for (let value of dict[lastElementOfArray])
            console.log(value);
    } else
        console.log('None');
}