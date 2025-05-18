using System;

class program
{
    static void Main(string[] args)
    {

        bool fibo;
        int x, f, z, w, r,o;
        bool limit=true;
         f = 0;
    inicio:
        Console.WriteLine("1-Numeros limitados o 2- Cantidad de numeros");
        o = int.Parse(Console.ReadLine());
        if (o==1)
        {
            limit = true;
            
        }
        else if (o ==2)
        {
            limit = false;
            Console.Write("Cantidad de numeros:"); 
            f = int.Parse(Console.ReadLine());
            if (f <= 0)
            {
                Console.WriteLine("La cantidad de numeros no puede ser menor a 0");
                goto inicio;
            }
            
        }
        else if (o> 1 || o>2) 
        {
            Console.WriteLine("Opcion no valida");
            goto inicio;
        }

        fibo = false;
        z = 0; r = 0; w = 0; x = 0;
        Console.WriteLine("Los números de fibonacci son:");
        while (fibo == false)
        {
            int temp = r + z;
            r = z;
            z = temp;
            Console.WriteLine(r);
            if (z <= 0)
            {
                z = 1;
            }
            if (limit == true)
            {
                if (r < 4000000 && r % 2 == 0)
                {
                    w = w + r;
                    Console.WriteLine("La suma de los números pares es: " + w);
                }
                if (r > 4000000)
                {
                    fibo = true;
                }
            }
            else if (limit==false)
            {
                
                    x++;
                    if (x == f)
                    {
                        fibo = true;
                    }


                
            }
            
        }


    }
}
