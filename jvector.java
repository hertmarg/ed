import java.util.Scanner;

public class jvector {

	public static void main(String[] args) {
		/*	int[] v = {11,12,13,14,15};
			
			System.out.print("v[0]= " + v[0]);
			System.out.print("v[1]= " + v[1]);
			System.out.print("v[2]= " + v[2]);
			System.out.print("v[3]= " + v[3]);
			System.out.println("v[4]= " + v[4]);
			System.out.println();
			for (int index = 0; index < 5; index++) 
				
		System.out.println(index + " valor = " + v[index]);
		}*/
		
		int[] v = new int [] {17,12,15,9,14};
	
		Scanner scanner = new  Scanner(System.in);
		
		System.out.println("Todos sabemos que Axel es puto, pero que posición necesitas?: ");
		int x = scanner.nextInt();
		int position = 0;
		position = indexOf(v, x);
		
			System.out.println("index= " + position);
			System.out.println("fin");
		}
	
	public static int indexOf(int[] v, int x) {
		int position = 0;
		while (position < v.length && v[position] !=x)
			position++;
		if (position == v.length)
			return -1;
		return position;
	}
}
