namespace homework1.Exceptions;

public static class ExceptionInfo
{
    public static string GetLastInnerExMessage(Exception ex)
    {
        if (ex == null)
        {
            return string.Empty;
        }

        Exception currentEx = ex;
        while (currentEx.InnerException != null)
        {
            currentEx = currentEx.InnerException;
        }
        return currentEx.Message;
    }
    public static string GetAllInnerExMessageTogether(Exception ex)
    {
        var messages = new List<string>();
        Exception currentEx = ex;
        while (currentEx != null)
        {
            messages.Add(currentEx.Message);
            currentEx = currentEx.InnerException;
        }
        return string.Join(", ", messages);
    }
}