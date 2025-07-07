
public class LoggerSystem
{
    private readonly string _nameFile;

    private List<string> _logs = new List<string>();

    public LoggerSystem(string nameFile)
    {
        _nameFile = nameFile;
    }

    public void CatchError(Exception ex)
    {
        _logs.Add($@"
        [{DateTime.Now}]
        The exception message:{ex.Message}
        The stack trace:{ex.StackTrace}");



        File.AppendAllLines(_nameFile, _logs);
    }
}