public class Computer {

    int ssd = 500;
    int ram;

    Computer() {
        System.out.println("Я был создан");
    }

    Computer(int newSsd) {
        ssd = newSsd;

    }

    Computer(int ssd, int newRam) {
        this.ssd = ssd;
        ram = newRam;

    }

    void load() {
        System.out.println("Я загрузился");
    }
    void load(boolean open){
        System.out.println("Я загрузился");
        if(open){
            System.out.println("Я открыл крышку");
        }
    }

    void printState() {
        System.out.println(ssd);
        System.out.println(ram);
        System.out.println();

    }
}
