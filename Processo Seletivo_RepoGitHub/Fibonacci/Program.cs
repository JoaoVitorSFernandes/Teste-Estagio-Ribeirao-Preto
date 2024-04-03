class Program
{
    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main()
    {
        int i = 0;

        Console.Write("Informe um número para verificar se está na sequência de Fibonacci: ");
        if (!int.TryParse(Console.ReadLine(), out int res) || res < 0)
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo válido.");
            return;
        }

        while (true)
        {
            var result = Fibonacci(i++);

            if (result == res)
            {
                Console.WriteLine($"O número {res} está presente na sequência de Fibonacci.");
                break;
            }
            else if (result > res)
            {
                Console.WriteLine($"O número {res} não está presente na sequência de Fibonacci.");
                break;
            }
        }
    }
}