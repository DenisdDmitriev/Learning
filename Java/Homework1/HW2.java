package Homework1;
import java.lang.Math;


public class HW2 {
    public static void main (String[] args){
        printPrimeNums();
    
    }
        
        
        public static void printPrimeNums(){
            boolean isPrime;
            for (int i = 1; i < 1000; i++){
                isPrime = false;
                for (int j = 2; j < i / 2; j++){
                    if ((i % j) == 0)
                    {
                        isPrime = true;
                    }
                }
               if (isPrime == false){
                System.out.println(i);
            }    
      }
  }
}     
        
    
    

