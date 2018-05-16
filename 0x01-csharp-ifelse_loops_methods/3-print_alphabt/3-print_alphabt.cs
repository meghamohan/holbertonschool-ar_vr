using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
	    char a;
	    for (a = 'a'; a <='z'; a++)
	    {
	        if (a != 'q' & a != 'e')
            	    Console.Write(a);
	    }
        }
    }
}
