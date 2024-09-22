
namespace SEG.Logging;

public class CustomerLogger : ILogger
{
    readonly string loggerName;
    readonly CustomLoggerProviderConfiguration loggerConfig;

    public CustomerLogger(string loggerName, CustomLoggerProviderConfiguration loggerConfig)
    {
        loggerName = loggerName;
        loggerConfig = loggerConfig;
    }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return logLevel == loggerConfig.LogLevel;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        string mensagem = $"{logLevel.ToString()}: {eventId} - {formatter(state, exception)}";
        EscreverTextoNoArquivo(mensagem);
    }

    private void EscreverTextoNoArquivo(string mensagem)
    {
        string caminhoArquivoLog =  @$"C:\Users\faelz\Documents\GitHub\SEG\SEG\Logging\log_{DateTime.Now:yyyy-MM-dd}.txt";


        using (StreamWriter streamWrite = new StreamWriter(caminhoArquivoLog, true)) 
        {
            try
            {
                streamWrite.WriteLine(mensagem);
                streamWrite.Close();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
