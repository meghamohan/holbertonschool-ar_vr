﻿using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
	    for(int i=0; i<100; i++)
	    {
	        if(i != 99)
	            Console.Write("{0}, ",i);
		else
		    Console.Write("{0}\n",i);
	    }
        }
    }
}
