using Fougerite;
using RustPP;
using System;
using RustPP.Commands;

public class rustpp : ConsoleSystem
{
    [Admin]
    public static void day(ref ConsoleSystem.Arg arg)
    {
        World.GetWorld().Time = 6f;
        arg.ReplyWith("El sol esta sonriendo");
    }

    [Admin]
    public static void night(ref ConsoleSystem.Arg arg)
    {
        World.GetWorld().Time = 18f;
        arg.ReplyWith("¡Es de noche!");
    }

    [Admin]
    public static void savealldata(ref ConsoleSystem.Arg arg)
    {
        TimedEvents.savealldata();
        arg.ReplyWith("Datos de RustPP guardados.");
    }

    [Admin]
    public static void shutdown(ref ConsoleSystem.Arg arg)
    {
        ShutDownCommand.StartShutdown();
        arg.ReplyWith("Iniciando cierre de servidor en " + ShutDownCommand.ShutdownTime + " segundos.");
        //TimedEvents.shutdown();
    }
}