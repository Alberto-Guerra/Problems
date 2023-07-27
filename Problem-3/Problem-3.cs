

double limit = 600851475143;
//long limit = 13195;

long largestPrimeFactor = 0;

int divisor = 2;
double factor;
while(true){

    factor = limit / divisor;


    if(factor % 1 != 0){  
        divisor = nextPrime(divisor);
        continue;
    }


    limit = factor;

    largestPrimeFactor = Convert.ToInt64(limit);
    if(!isPrime(largestPrimeFactor)){
        divisor = 2;
        continue;
    }

    break;


}


Console.WriteLine(largestPrimeFactor);

bool isPrime(long number){

 for(long i = number - 1; i > 1; i--){
    if(number % i == 0){
        return false;
    }
 }
 return true;

}

int nextPrime(int number){

 for(int i = number + 1; i < 50000; i++){
    if(isPrime(i)){
        return i;
    }
 }
 return 0;

}