using System;

class Program {
    private static int bico(int n, int i)
    {
        int num = 1;
        if(i > n - i){
            i = n - i;
        }
        for(int j = 0; j < i; j++){
            num = num * (n-j);
            num = num / (j + 1);
        }
        Console.WriteLine(num);
        return num;
    }
}