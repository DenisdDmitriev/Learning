package Homework1;
import java.util.Scanner;


public class HW1 {
    public static void main (String[] args){
        Scanner in = new Scanner(System.in);
        System.out.print("Введите число: ");
        Integer n = in.nextInt();
        System.out.println(countNTriangle(n));
        

    }
    
    public static int countNTriangle(int n) {
        Integer nTriangle = 0;
        for (int i = 0; i <= n; i++) {
            nTriangle = nTriangle + i;
        }
        return nTriangle;
    }
}
