using System;
using System.IO;
using System.Collections;



class Sample
{
    public static void Main()
    {

       Console.WriteLine();
       Console.WriteLine("GetEnvironmentVariables: ");
	string path = @".\\CWriteLines.txt";
	using (var sw= new StreamWriter(path, true))
    		{
        		sw.WriteLine(" ");
			sw.WriteLine(" **************************");
			sw.WriteLine(" ");
			DateTime now = DateTime.Now;
			sw.WriteLine(now);
			sw.WriteLine(" ");
       			sw.Close();
   		 };

       foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
		{
		var test =Convert.ToString(de.Key);
		var test2=Convert.ToString(de.Value);
		var test3=test+" : "+test2;

    		using (var tw = new StreamWriter(path, true))
    		{
        		tw.WriteLine(test3);
       			tw.Close();
   		 }
		}


    }
}
