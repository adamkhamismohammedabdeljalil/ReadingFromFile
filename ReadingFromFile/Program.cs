
class Program
{
    
    static void Main(string[] args)
    {
      
        Console.WriteLine("Please write a file path");
        // 1 - What happens when you point it to a text file?
        string filePath = Console.ReadLine();

        // 2 - What happens when you point it to the PowerPoint file for this unit?
        Console.WriteLine("Please write a file path for the powerpoint slides");
        string filePathPowerPoint=Console.ReadLine();

        // 3-Make it work for both absolute and relative apth
        string absolutePath=Path.GetFullPath(filePath); 
        try
        {

            Console.WriteLine("Success!");
            // 1- reading a text file
            //Console.WriteLine(File.ReadAllText(filePath));
            // 2- reading powerpoint file
            //Console.WriteLine(File.ReadAllText(filePathPowerPoint));
            // 3 - 
            Console.WriteLine(absolutePath);
            Console.WriteLine(File.ReadAllText(absolutePath));

        }
        catch(Exception ) {
            Console.WriteLine("Error:please write a valid filepath");
        }
    }
}