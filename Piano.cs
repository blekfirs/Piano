void Beep(int hz)
{
    Console.Beep(hz, 200);
}
int[] Octava(int a)

{
    switch (a)
    {

        case 0:
            return new int[] { 130, 138, 146, 155, 164, 174, 185 };

        case 1:
            return new int[] { 261, 277, 293, 311, 329, 349, 370 };

        case 2:
            return new int[] { 523, 554, 587, 622, 659, 698, 740 };

        case 3:
            return new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480 };

        case 4:
            return new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960 };

        default:
            return new int[] { 65, 69, 73, 4978, 5274, 5588, 5920 };

    }
}

Console.WriteLine("Октавы: Q, W, E. Звуки: A, S, D, F, G, H, J");
Console.WriteLine("Для использования пианино сначала надо нажать октаву, а потом звук(Например:Q-A, W-S, E-D...)");

while (true)
{
    int a = 0;
    ConsoleKeyInfo b = Console.ReadKey(true);
    switch (b.Key)
    {
        case ConsoleKey.Q:
            a = 1;
            break;
        case ConsoleKey.W:
            a = 2;
            break;
        case ConsoleKey.E:
            a = 3;
            break;
        default:
            Console.WriteLine("Ошибка, выбрана октава 1(Q)");
            break;
    }
    
    int[] octava = Octava(a);
    ConsoleKeyInfo ki = Console.ReadKey(true);
    switch (ki.Key)
    {
        case ConsoleKey.A:
            Beep(octava[0]);
            break;

        case ConsoleKey.S:
            Beep(octava[1]);
            break;

        case ConsoleKey.D:
            Beep(octava[2]);
            break;

        case ConsoleKey.F:
            Beep(octava[3]);
            break;

        case ConsoleKey.G:
            Beep(octava[4]);
            break;

        case ConsoleKey.H:
            Beep(octava[5]);
            break;

        case ConsoleKey.J:
            Beep(octava[6]);
            break;

        default:
            Console.WriteLine("Такой клавиши не существует");
            break;
    }
}