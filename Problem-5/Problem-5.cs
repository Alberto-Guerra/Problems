
int num = 20;

while(true){

    if(isDivisibleFrom1To20(num)){
        break;
    }

    num++;

}

Console.WriteLine(num);


bool isDivisibleFrom1To20(long num){

    for(int i = 2; i <= 20; i++){

        if(num % i != 0){
            return false;
        }

    }

    return true;

}
