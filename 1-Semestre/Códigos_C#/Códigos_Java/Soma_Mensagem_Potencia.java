public class Main
{
    public static void main(String[]args)
    {
       System.out.println("88 + 44 = " + soma(88,44));
       mensagem("texto");
       potencia(4,3);
    }
    public static int soma (int a, int b)
    {
        return a + b;
    }
    public static void mensagem (String m)
    {
        System.out.println(m);
    }
    public static void potencia (int x, int y)
    {
        mensagem (x + " elevado a " + y + " é igual a = " + Math.pow(x,y));
    }
}