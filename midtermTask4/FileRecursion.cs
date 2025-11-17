namespace homework1.midtermTask4;

public class FileRecursion
{
    public static void main()
    {
        while (true)
        {
            Console.WriteLine("To turn off program type \"exit\" otherwise enter the directory path ");
            string directoryPath = Console.ReadLine();
            if (directoryPath == "exit")
            {
                break;
            }

            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("Directory does not exist");
                continue;
            }
            printFilesRecursively(directoryPath);
        }
       
        
    }

    public static void printFilesRecursively(string directoryPath)
    {
        string[] files = Directory.GetFiles(directoryPath);
        if (files.Length == 0)
        {
            return;
        }

        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine(files[i]);
        }

        for (int i = 0; i < files.Length; i++)
        {
            printFilesRecursively(files[i]);
        }
        
       
    }
}