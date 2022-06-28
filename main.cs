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
    public static void Main (string[] args) {
        Console.WriteLine("Please enter the degree of the binomial: ");
        int binom = int.Parse(Console.ReadLine());
        Console.WriteLine ("Please enter the index of the coefficient: ");
        int coeff = int.Parse(Console.ReadLine());
        Console.WriteLine("The result is: ");
        Program.bico(binom, coeff);
    }
}