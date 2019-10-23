using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            var xspace = "";
            var yspace = "";
            var xyspace = "";
            var zspace = " ";
            // ----- string 
            /*
            var names = new List<string> { "Ana", "Felipe", "Felix" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            */
            // 1x1
            var zweiundzwei = new List<int>  { 1,2,3,4,5,6,7,8,9,10};

            // 1x1
            var einsundeins = new List<int>  { 1,2,3,4,5,6,7,8,9,10};
            foreach (var x in einsundeins)
            {
                foreach (var y in zweiundzwei)
                {
                    
                    if (x<10){
                        xspace = " ";
                    } else {
                        xspace="";
                    }
                    if (y<10){
                        yspace = " ";
                    } else {
                        yspace="";
                    }
                    if (x*y<10){
                        xyspace="  ";
                    } else if (x*y<100){
                        xyspace=" ";
                    } else {
                        xyspace="";
                    }
                        
                    Console.WriteLine($"{xspace}{x} mal {yspace}{y} = {xyspace}{x*y}");
                }    
                //Console.WriteLine(x);
            }

            for (int z=0; z<2; z++) {
                
                if (z==0) {
                    zspace=" ";
                } else {
                    zspace="";
                }
                
                Console.WriteLine("|-----------|-----------|-----------|-----------|-----------|");
                Console.WriteLine($"|     {1+z*5}     |      {2+z*5}    |      {3+z*5}    |      {4+z*5}    |     {zspace}{5+z*5}    |");
                Console.WriteLine("|-----------|-----------|-----------|-----------|-----------|");
                
                for (int y=1; y < 6; y++) {
                
                
                    for (int x=1; x < 6; x++) {
                            if ((x+5*z)*y<10){
                                xspace = "  ";
                            } else if ((x+5*z)*y<100){
                                xspace = " ";
                            } else {
                                xspace="";
                            }
                                if ((y+5)*(x+5*z)<10){
                                yspace = "  ";
                            } else if ((y+5)*(x+5*z)<100){
                                yspace=" ";
                            } else {
                                yspace= "";
                            }
                        
                        
                        Console.Write($"| {xspace}{(x+5*z)*y} | {yspace}{(y+5)*(x+5*z)} ");
                    }
                    Console.WriteLine("|");
                
                }
                
            }
            Console.WriteLine("|-----------------------------------------------------------|");
            
        }
    }
}
