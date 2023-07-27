
const int limit = 4000000;


int i = 0;
int j = 1;
int sum = 0;
while (j < limit){
    j = i + j;
    i = j - i;

    if( j % 2 == 0){
        sum += j;
    }
}

Console.WriteLine(sum);
