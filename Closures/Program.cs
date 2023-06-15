using System;
using System.Collections.Generic;

//ref link:https://www.youtube.com/watch?v=gBO_4BMbsO8&list=PLAE7FECFFFCBE1A54&index=10
//

class MainClass
{
    static void Main()
    {
        //int i = 0;
        //Action a = () => i++; // no argument lambda expression
        //a(); // 1
        //a(); a(); a(); // 3
        //Console.WriteLine(i);
        Action a = GiveMeAction();
        a();
        a();
        a(); 
        
    }
    static Action GiveMeAction()
    {
        //int i = 0;
        //return () => i++; // closure i scope
        Action ret = null; // delegate chain + 2 lambda expression + closure
        int i = 0;
        ret += () =>
        {
            Console.WriteLine("First method" + i++);
        };
        ret += () =>
        {
            Console.WriteLine("Second method" + i++);
        };
        return ret;
    }
}