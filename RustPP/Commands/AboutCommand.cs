namespace RustPP.Commands
{
    using Fougerite;
    using RustPP;
    using System;

    public class AboutCommand : ChatCommand
    {
        public override void Execute(ref ConsoleSystem.Arg Arguments, ref string[] ChatArguments)
        {
            var pl = Fougerite.Server.Cache[Arguments.argUser.userID];
            pl.MessageFrom(Core.Name, "Este servidor esta utilizando RustPP v" + Core.Version);
            pl.MessageFrom(Core.Name, "Creado por ForwardDevs Team");
        }
    }
}