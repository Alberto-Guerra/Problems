
using System;
using System.Collections;



Console.WriteLine(largestPalindromeProduct(999,999));


int largestPalindromeProduct(int num1, int num2){

    int maxPalindrome = 0;

    for(int i = 0; i <= num1; i++){

        for(int j = 0; j <= num2; j++){

            int product = i * j;

            if(!isPalindrome(i * j))
                continue;
                
            if(product > maxPalindrome)
                maxPalindrome = product;
        }   

    }

    return maxPalindrome;


}




bool isPalindrome(int num){
    int numCopy = num;
    int numReverse = 0;
    Stack<int> stack = new Stack<int>();
    while(numCopy > 0){
        stack.Push(getLastDigit(numCopy));
        numCopy = numCopy / 10;
        
    }


    int totalLength = stack.Count;

    for(int i = 0; i < totalLength; i++){
        numReverse += stack.Pop() * (int) Math.Pow(10,i);
     
    
    }

    // Console.WriteLine("Original: " + num);
    // Console.WriteLine("Reversed: " + numReverse);
    return num == numReverse;

}

int getLastDigit(int num){
    if(num < 10){
        return num;
    }

    int numWithoutLastDigit = ( num / 10 ) * 10;

    return num - numWithoutLastDigit;
    

}