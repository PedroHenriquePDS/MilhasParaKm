
double milhas, kms;

Console.Write("Entre com a medida (em milhas): ");
milhas = Convert.ToDouble(Console.ReadLine());

kms = milhas * 1.609;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"{kms:N3} Km");
Console.ResetColor();


