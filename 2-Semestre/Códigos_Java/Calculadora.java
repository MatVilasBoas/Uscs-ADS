public class Main
{
	public static void main(String[] args) 
	{
	    int a = 100, b = 20;
	    System.out.println("A soma é = " + soma(a,b));
	    System.out.println("A subtração é = " + sub(a,b));
	    System.out.println("A multiplicação é = " + multi(a,b));
	    System.out.println("A divisão é = " + div(a,b));
	}   	
	public static int soma(int a, int b)
	{
	    return a+b;
	}
	public static int sub(int a, int b)
	{
	    return a-b;
	}
	public static int multi(int a, int b)
	{
	    return a*b;
	}
	public static int div(int a, int b)
	{
	    return a/b;
	}
}
