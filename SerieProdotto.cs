using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        int maxp = 0;

        int lenght = digits.Length;


        if(span > lenght){
            throw new System.ArgumentException();
        }

        if(span < 0){
            throw new System.ArgumentException();
        }
        if (span ==0){
            return 1;
        }

        char[] array = digits.ToCharArray();

        for (int i = 0; i < lenght;i++){
            if(char.IsLetter(array[i])){
                throw new System.ArgumentException();
            }
        }

        for (int j = 0; j <= lenght - span;j++){
            int p = 1; //prodotto
            int supp = j;
            for (int x = 0; x < span;x++){
                p = p * (array[supp] - 48);
                supp = supp + 1;
            }
            if (p>maxp){
                maxp = p;
            }
        }

            return maxp;
    }
}