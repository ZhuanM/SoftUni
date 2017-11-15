function solution(commands) {
    let arr = [];

    for (i = 0; i < commands.length; i++){
        let commandTokens = commands[i].split(' ');
        if (commandTokens[0] == 'add'){
            arr.push(commandTokens[1]);
        } else if (commandTokens[0] == 'remove') {
            arr.splice(commandTokens[1], 1)
        }
    }

    for (let element of arr){
        console.log(element)
    }
}