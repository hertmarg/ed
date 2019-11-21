import java.util.Scanner;

public class randome {

	public static void main(String[] args) {
		int num;
		int num_max = 10;
		int num_al = (int) (Math.random()*num_max+1);
		
		Scanner scanner = new  Scanner(System.in);
		
		System.out.println("Un numero del 1 al 10: ");
		num = scanner.nextInt();

		if (num == num_al) {
			System.out.println("Has acertado!");
		}else
			System.out.println("Paquete!");
	}
	

}
