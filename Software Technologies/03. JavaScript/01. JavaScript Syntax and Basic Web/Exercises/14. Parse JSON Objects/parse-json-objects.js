function solution(input) {
    let objectList = [];

    for (i = 0; i < input.length; i++){
        let obj = JSON.parse(input[i]);
        objectList.push(obj)
    }

    for (let obj of objectList){
        console.log(`Name: ${obj.name}`);
        console.log(`Age: ${obj.age}`);
        console.log(`Date: ${obj.date}`);
    }
}