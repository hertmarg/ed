import java.util.Scanner;

public class mensajeDesDelTeclado {

	public static void main(String[] args) {
		String name;
		int edad;
		Scanner scanner = new  Scanner(System.in);
		System.out.print("escriba su nombre: ");
		name = scanner.nextLine();
		
		System.out.println("Bienvenido señor " + name);
		
		System.out.print("escriba su edad: ");
		edad = scanner.nextInt();
		System.out.println("El año que viene tendrás: " + (edad+1));
	}

}
