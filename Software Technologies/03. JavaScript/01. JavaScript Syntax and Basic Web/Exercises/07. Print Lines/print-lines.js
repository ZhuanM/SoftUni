function solution(arr) {
    for (i = 0; i < arr.length; i++){
        if (arr[i] == 'Stop'){
            break;
        } else {
            console.log(arr[i]);
        }
    }
}