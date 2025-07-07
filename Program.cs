
using Game_Data_Parser.ExistingErrorsRead;

using Game_Data_Parser.startParsing;
using Game_Data_Parser.UserInterActions;


const string NameFile = "Log.txt";
var LoggerSystem = new LoggerSystem(NameFile);
var applictionStart = new StartParsing(
    new UserInteraction(
       LoggerSystem
        ),
    new ExsistingErrorFile(NameFile, new UserInteraction(LoggerSystem))
    );

try
{

    applictionStart.mainAppliction(NameFile);
}
catch (Exception ex)
{
    Console.WriteLine("“Sorry! The application has experienced an unexpected error and will have to be closed.");
    LoggerSystem.CatchError(ex);
}


