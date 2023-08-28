package Seminars;
import java.util.Scanner;
public class Seminar1 {
    public static void main (String[] args){
    Scanner in = new Scanner(System.in);
    System.out.println("Введите число: ");
    int num = 5;
    int countNum = 3;
    for (int i = 0; i < num; i++){
        Integer number = in.nextInt();
        if (number == num){
            System.out.println("Вы угадали число");
            break;
        }

    }
    
    }
}