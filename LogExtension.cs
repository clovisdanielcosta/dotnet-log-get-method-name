using System.Runtime.CompilerServices;

namespace LogGetMethodName;

public static class LogExtension
{
    public static void Logue([CallerMemberName] string nomeMetodo = null)
    {
        Console.WriteLine($"\n Método - {nomeMetodo}: {DateTime.Now}");
    }
}
