// EX 1

bool x = true;

if (x)
{
    Console.Beep();
    Console.Beep();
}
else
{
    Console.Beep(1500, 100);
    Console.Beep(1500, 100);
}

Console.WriteLine("Acabou");

// EX2

Console.Write("Olá, usuário. Por favor, digite sua senha: ");
string senhaDigitada = Console.ReadLine()!;
const string senhaCorreta = "1234abcd";

bool senhaValida = senhaDigitada == senhaCorreta;

if (senhaValida)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Acesso permitido");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Acesso negado");
    Console.Beep();
    Console.Beep();
}

Console.ResetColor();

// EX 3
bool w, t, r, p;

Console.WriteLine("[A]tivado / [D]esativado");

Console.Write("Sensor de temperatura...: ");
t = Console.ReadLine()!.ToUpper() == "A";

Console.Write("Sensor de pressão.......: ");
p = Console.ReadLine()!.ToUpper() == "A";

Console.Write("Sensor de rotação.......: ");
r = Console.ReadLine()!.ToUpper() == "A";

w = t && (p || !r);

if (w)
{
    Console.WriteLine("A luz de advertência estará ATIVADA.");
}
else
{
    Console.WriteLine("A luz de advertência estará DESATIVADA.");
}
