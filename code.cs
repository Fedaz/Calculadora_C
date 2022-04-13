using TpCalculadora;

public class Code {


    public static int getRandomNumber() {
        Random random = new Random();
        return random.Next(1,50);
    }

    static void Main()
    {
        CalculadoraEstandar calculadora = new CalculadoraEstandar();
        for (int i = 1; i <= 10; i++){
            int number1 = getRandomNumber();
            int number2 = getRandomNumber();
            Console.WriteLine($"Operación número: {i}°");
            Console.WriteLine($"La suma de {number1} y {number2} da {calculadora.sumar(number1, number2)}");
            Console.WriteLine("");
            Console.WriteLine($"La resta de {number1} y {number2} da {calculadora.restar(number1, number2)}");
            Console.WriteLine("");
            Console.WriteLine($"La multiplicación de {number1} y {number2} da {calculadora.multiplicar(number1, number2)}");
        }
        
        
    }
}
