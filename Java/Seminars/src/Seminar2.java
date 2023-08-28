import java.util.Scanner;
import java.io.*;

public class Seminar2 {
    public static void WriteFile() {
        try (BufferedWriter bw = new BufferedWriter(new FileWriter("Note1.txt"))) {
            bw.write("Hello");
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }

    public static void ReadFile() {
        try (BufferedReader br = new BufferedReader(new FileReader("Note1.txt"))) {
            int c;
            while ((c = br.read()) != -1) {
                System.out.print((char) c);

            }
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }

    public static void main(String[] args) {
        ReadFile();
    }
}
