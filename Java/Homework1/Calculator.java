package Homework1;
import java.util.Scanner;


public class Calculator {
    public static void main (String[] args){
        // Scanner in = new Scanner(System.in);
        // System.out.print("Введите число: ");
        // Integer a = in.nextInt();
        // Integer b = in.nextInt();
        // Character op = '-';
        System.out.println(Calculate('-' , 6, 7));

    }
    public static int Calculate(char op, int a, int b){
        Scanner in = new Scanner(System.in);
        System.out.print("Введите первое значение: ");
        a = in.nextInt();
        System.out.print("Введите второе значение: ");
        b = in.nextInt();
        System.out.print("Введите операцию: ");
        op = input.next(".").charAt(0);

        return a;
        

}
}