﻿/*
var sale = new SaleWhitTax(15, 1.16m);
var message = sale.GetInfo();

Console.WriteLine(message);

class SaleWhitTax : Sale
{
    public decimal Tax { get; set; }

    public SaleWhitTax (decimal total, decimal tax) : base(total)
    {
        Tax = tax;

    }

    public override string GetInfo()
    {
        return "el total es " + Total + " Impuesto " + Tax;
    }

    public string GetInfo(string message)
    {
        return message;
    }
    public string GetInfo(int a)
    {
        return a.ToString();
    }


}
class Sale
{
    public decimal Total { get; set; }

    public Sale(decimal total)
    {
        Total = total;
    }

    public virtual string GetInfo()
    {
        return "El total " + Total;
    }
}


*/





/*

var sale = new Sale();

var beer = new Beer();

Some(sale);
Some(beer);



void Some(ISave save)
{
    save.Save();
}


interface ISale
{
    decimal Total { get; set; }

}

interface ISave
{
    public void Save();

}

public class Sale : ISale, ISave
{
    public decimal Total { get; set; }

    public void Save() 
    {
        Console.WriteLine("Se guardo en BD");
    }


}

public class Beer : ISave
{
    public void Save()
    {
        Console.WriteLine("Se guardo en Servicio");
    }


}

*/


/*

var numbers = new Mylist<int>(5);
var names = new Mylist<string>(5);
var beers = new Mylist<Beer>(3);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);

names.Add("Roberto");
names.Add("Mario");
names.Add("Daniel");
names.Add("Franco");
names.Add("Jose");
names.Add("Jesus");


beers.Add(new Beer()
{
    Name = "Escudo",
    Price = 2

});

beers.Add(new Beer()
{
    Name = "Sol",
    Price = 2

});

beers.Add(new Beer()
{
    Name = "Polar",
    Price = 5

});

beers.Add(new Beer()
{
    Name = "Regional",
    Price = 6

});

beers.Add(new Beer()
{
    Name = "Escudo",
    Price = 8

});

Console.WriteLine(numbers.GetContent());
Console.WriteLine(names.GetContent());
Console.WriteLine(beers.GetContent());


public class Mylist<T>
{
    private List<T> _list;
    private int _limit;


    public Mylist(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void Add(T item) // El numero 6 no forma parte del listado debido a esta condicional
    {
        if (_list.Count < _limit)
        {
            _list.Add(item);
        }
    }

    public string GetContent() 
    {
        string content = "";
        foreach (var item in _list)
        {
            content += item + ", ";
        }
        return content;
    }
}

public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return "Nombre: " + Name + " Precio " + Price;
    }

}


*/

/*


using System.Text.Json;

var alejo = new People()
{
    Name = "Alejandro",
    Age = 37,
};

string json = JsonSerializer.Serialize(alejo);
Console.WriteLine(json);


//Deserializacion-------

string myJson = @"{
    ""Name"": ""Juan"",
    ""Age"":36

}";
People juan = JsonSerializer.Deserialize<People>(myJson);
Console.WriteLine(juan.Name);
Console.WriteLine(juan.Age);

public class People
{
    public string Name { get; set; }

    public int Age { get; set; }
}


*/

// PROGRAMACION FUNCIONAL


/*
int Sub(int a , int b)
    { 
        return a - b; 
    }

Console.WriteLine(Sub(2, 1));


DateTime GetTomorrow(DateTime date)
{
    return DateTime.Now.AddDays(1);
}


*/



/*

using System;

var beer = new Beer()
{
    Name = "guinnes"
};

Console.WriteLine(beer.Name);
Console.WriteLine(toUpper(beer).Name);


Beer toUpper(Beer beer)
{
    var beer2 = new Beer()
    {
        Name = beer.Name.ToUpper(),
    };

    return beer2;
}
class Beer
{

    public string Name { get; set; }

}

*/





// PROGRAMACION FUNCIONAL
/*

var show = Show;

Some(show, "Hola Que talco");

string Show(string message) 
{
    return message.ToUpper();
 };

void Some(Func<string,string> fn,string message)
{
    Console.WriteLine("Hace algo aqui");
    Console.WriteLine(fn(message));
    Console.WriteLine("hace algo al final");
}


*/

// FUNCIONES LAMBDA

// EJEJMPLO:

/*

Func<int,int, int> sub = (a, b) => a - b;

Func<int,int> some = a => a * 5;

Func<int, int> some2 = a =>{
    a = a + 1;
    return a * 5;
};

Console.WriteLine(sub(212, 112));
Console.WriteLine(some(5));
Console.WriteLine(some2(5));

*/

// OTRO EJEMPLO:

/*

Some((a, b) => a + b, 6);

void Some(Func<int, int, int> fn, int number)
{
   var result = fn(number, number);
}

*/




// LINQ: es una libreria que nos permite hacer consultas a colecciones de datos. Es similar a SQL
// Ejemplo:


 /*

var names = new List<string>()
{
    "Alejandro",
    "Juan",
    "Pedro",
    "Jose",
    "Daniel",
    "Franco",
    
};

var namesResult = from n in names
                    where n.Length > 4 && n.Length < 7
                    orderby n descending
                    select n;

var namesResult2 = names.Where(n => n.Length > 4 && n.Length < 7)
                        .OrderByDescending(n => n)
                        .Select(n => n);

 // Resultado de la consulta LINQ . NamesResult y NamesResult2 son iguales

     

foreach (var item in namesResult)
{
    Console.WriteLine("Resultado 1 :"+item);
}

foreach (var item in namesResult2)
{
    Console.WriteLine("Resultado 2 :"+item);
}

*/


// Validando si un numero es par o impar_______________________


/*class Program
{
    static void Main(string[] args)
    {
        int numberOne = 9;
        if (numberOne % 2 == 0)
        {
            Console.WriteLine($"{numberOne} Es par");
        }
        else
        {
            Console.WriteLine($"{numberOne} Es impar");
        }
        
    }
}

*/
/*

namespace tips{
    class Program
    {
        static void Main(string[] args)
        {
         const double PI = 3.1416;
         Console.WriteLine("Ingrese el radio del circulo");
            double radio = double.Parse(Console.ReadLine());

            // double area = PI * radio * radio;
            double area = PI * Math.Pow(radio, 2);

            Console.WriteLine($"El area del circulo es {area}");
         
        }
    }
}

*/

// EXPLICACION DEL USO DEL STATIC VOID MAIN_______________________ Y DE LOS METODOS


/*

using System;

namespace Metodos_Learning
{
    class Program
    {
        static void Main(string[] args)
         {
               
                sumNum(5,20); 
                
         }
        
        static void sumNum(int num1, int num2)
        {
          

            int result = num1 + num2;

            Console.WriteLine($"El resultado de la suma es : {result}");

        }

    }

}


*/


// EJEMPLO DEL USO STATIC VOID MAIN_______________________ Y DE LOS METODOS

/*

using System;

namespace Metodos_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            searchNumPar();

        }

        static void searchNumPar()
        {
            int numLimit = 20;
        //    Validar si un numero es par o impar_______________________
            for (int i = 1; i <= numLimit; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} Es par");
                }
                else
                {
                    Console.WriteLine($"{i} Es impar");
                }
            }
        }

    }

}

*/


// VIDEO 11___________________________

/*
using System;

namespace Metodos_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(divideNum(10,3));

        }

        static double divideNum(double num1, int num2)
        {
            double resultado;

            resultado = num1 / num2;

            return resultado;
        }
        

    }

}

*/





//Uso de condiciona IF

/*
using System;

namespace Metodos_Learning
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Vamos a evaluar si puedes conducir");
            Console.WriteLine("introduce tu edad");

            int edad = Int32.Parse(Console.ReadLine());
            if (edad>=18)
            {
            Console.WriteLine("tienes carnet?");

            }
            
            string carnet = Console.ReadLine();

            if (edad >= 18 && carnet.ToLower() == "si")
            {
                Console.WriteLine("puedes conducir vehiculo");
            } 
            else
            {
                Console.WriteLine("no puedes conducir");
            }
        }

    }
}

*/


// esto es un ejemplo del uso ddel operador || (or) en un condicional if

/*
using System;

namespace Metodos_Learning
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Introduce nota 1er parcial");
            float parcial1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce nota 2do parcial");
            float parcial2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce nota 3er parcial");
            float parcial3 = Int32.Parse(Console.ReadLine());

            if (parcial1 >=5 || parcial2 >= 5 || parcial3 >= 5)
            {
                float average = (parcial1 + parcial2 + parcial3) / 3;
                Console.WriteLine($"Tu promedio es : {average}");
            }
            else Console.WriteLine("Devuelve en septiembre");

        }
    }
  
}


*/


/*
using System;

namespace Metodos_Learning
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("introduce tu edad ");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine(" Eres un niño");
            else if (edad < 30) Console.WriteLine("Eres un joven");
            else if (edad < 60) Console.WriteLine("Eres un adulto");
            else Console.WriteLine("Eres un anciano");
           

        }
    }
  
}

*/

/*
using System;

namespace EstructuraSwith
{
    class Program
    {
        static void Main(string[] args)
        {

         Console.WriteLine("Elige medio de transporte (coche, avion, tren, barco)");

         string medioTransporte = Console.ReadLine();

            switch (medioTransporte.ToLower())
            {
                case "coche":
                    Console.WriteLine("El coche tiene 100 Km/h");
                    break;

                case "avion":
                    Console.WriteLine("El avion tiene 800 Km/h");
                    break;

                case "tren":
                    Console.WriteLine("El tren tiene 300 Km/h");
                    break;

                case "barco":
                    Console.WriteLine("El barco tiene 180 Km/h");
                    break;

                default:
                    Console.WriteLine("No has elegido un medio de transporte valido");
                    break;
            }

        }
    }
  
}

*/



// EJERCICIO DE ESTRUCTURA SWITCH CON COMISIONES
// Ejemplo de su uso en el video.
/*
using System;

namespace EstructuraSwithComision
{
    class Program
    {
        static void Main(string[] args)
        {

         Console.WriteLine("Introduce el N° de mes para el calculo de la comision");

            int mes = Int32.Parse(Console.ReadLine());
    
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Mes Escogido Enero: La comision es de 1000");
                        break;

                    case 2:
                        Console.WriteLine("Mes Escogido Febrero: La comision es de 2000");
                        break;

                    case 3:
                        Console.WriteLine("Mes Escogido Marzo: La comision es de 3000");
                        break;

                    case 4:
                        Console.WriteLine("Mes Escogido Abril: La comision es de 4000");
                        break;

                    case 5:
                        Console.WriteLine("Mes Escogido Mayo: La comision es de 5000");
                        break;

                    case 6:
                        Console.WriteLine("Mes Escogido Junio: La comision es de 6000");
                        break;

                    case 7:
                        Console.WriteLine("Mes Escogido Julio: La comision es de 7000");
                        break;

                    case 8:
                        Console.WriteLine("Mes Escogido Agosto: La comision es de 8000");
                        break;

                    case 9:
                        Console.WriteLine("Mes Escogido Septiembre: La comision es de 9000");
                        break;

                    case 10:
                        Console.WriteLine("Mes Escogido Octubre: La comision es de 10000");
                        break;

                    case 11:
                        Console.WriteLine("Mes Escogido Noviembre: La comision es de 11000");
                        break;

                    case 12:
                        Console.WriteLine("Mes Escogido Diciembre: La comision es de 12000");
                        break;

                    default:
                        Console.WriteLine("No has elegido un mes valido");
                        break;

                }
         
        }
    }
  
}

*/

// Este es un ejemplo de como usar el bucle while

/*
using System;

namespace UsoBuclewhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseas entrar al bucle? (si/no)");
            string respuesta = Console.ReadLine();

            while (respuesta.ToLower() != "no")
            {
                Console.WriteLine("Estas dentro del bucle");
                Console.WriteLine("Introduce tu nombre, por favor");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Hola, {nombre} saldrs del bucle si escribes no");
                Console.WriteLine("Deseas repetir el bucle? (si/no)");
                respuesta = Console.ReadLine();


            }
            Console.WriteLine("Has salido del bucle");

         
        }
    }
  
}

*/



/*
// Ejercicio de bucle while 

//Genera un un numero aleatorio entre 1 y 100 y pide al usuario que lo adivine. Si el usuario introduce un numero bajo,
//debe mostrar el mensaje "El numero que estas buscando es mayor". Si el usuario introduce un numero alto, debe mostrar el mensaje
//"El numero que estas buscando es menor". El programa debe terminar cuando el usuario introduzca el numero correcto y mostrar
//el mensaje "Has acertado" y el numero de intentos que ha necesitado el usuario para acertarlo.

using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);
            int numeroUsuario = 0;
            int intentos = 0;

            while (numeroUsuario != numeroAleatorio)
            {
                Console.WriteLine("Introduce un numero");
                numeroUsuario = Int32.Parse(Console.ReadLine());
                intentos++;

                if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es mayor");
                }
                else if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es menor");
                }
                else
                {
                    Console.WriteLine($"--> Has acertado..!!! en {intentos} intentos");
                }
            }
        }
    }
}

*/




// Excepciones y uso do while
// eceptcion es un error que se produce en tiempo de ejecucion. Try catch es un bloque de codigo que nos permite capturar
// una excepcion y manejarla. El bloque finally se ejecuta siempre, haya o no haya excepcion.


/*
using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);
            int numeroUsuario = 0;
            int intentos = 0;
            Console.WriteLine("Introduce un numero");

            do{
                intentos++;
                
                try
                {
                    numeroUsuario = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Debes introducir un valor numerico, Por defecto se asignara el valor 0");
                    Console.WriteLine(ex.Message);
                    numeroUsuario = 0;
                }

                if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es mayor");
                }
                if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es menor");
                }
                
                }while (numeroUsuario != numeroAleatorio);
            
                Console.WriteLine($"--> Has acertado..!!! en {intentos} intentos");

                Console.WriteLine("apartir de esta linea de codigo el programa continua");
        }
    }
}
    

*/


//Conflictos de excepciones.
/*

using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);
            int numeroUsuario = 0;
            int intentos = 0;
            Console.WriteLine("Introduce un numero");

            do{
                intentos++;
                
                try
                {
                    numeroUsuario = Int32.Parse(Console.ReadLine());
                }
                // con esto capturamos todad las excepciones que se produzcan menos la de tipo FormatException
                // Esto se denomina filtrado de excepciones
                catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un error, Se tomara el valor 0");
                    // Console.WriteLine(ex.Message);
                    numeroUsuario = 0;
                }
              
                if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es mayor");
                }
                if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El numero que estas buscando es menor");
                }
                
                
               
            } while (numeroUsuario != numeroAleatorio);
                Console.WriteLine($"--> Has acertado..!!! en {intentos} intentos");

                Console.WriteLine("apartir de esta linea de codigo el programa continua");
        }
    }
}

*/




// En este ejemplo se muestra como usar el checked para controlar el desbordamiento de un numero entero

/*
using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
           

           int numero = int.MaxValue;
           int resultado = checked(numero + 20);
              Console.WriteLine(resultado);
        }
    }
}

*/



// Este ejemplo muestra como usar el throw new para lanzar una excepcion
/*
using System;
namespace LanzamientoExcepciones
{
        class Program
        {
            static void Main(string[] args)
            {
            
                Console.WriteLine("Introduce un numero entre 1 y 12");
                int numeroMes = Int32.Parse(Console.ReadLine());

                try
                {
                    Console.WriteLine(NombreDelMes(numeroMes));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Mensagge de la excepcion: " + ex.Message);

                }
               
                Console.WriteLine("apartir de esta linea de codigo el programa continua");

            

            }
             public static string NombreDelMes(int mes)
            {
                switch (mes)
                {
                    case 1:
                        return "Enero";
                    case 2:
                        return "Febrero";
                    case 3:
                        return "Marzo";
                    case 4:
                        return "Abril";
                    case 5:
                        return "Mayo";
                    case 6:
                        return "Junio";
                    case 7:
                        return "Julio";
                    case 8:
                        return "Agosto";
                    case 9:
                        return "Septiembre";
                    case 10:
                        return "Octubre";
                    case 11:
                        return "Noviembre";
                    case 12:
                        return "Diciembre";

                    default:
                        throw new ArgumentOutOfRangeException("mes", "El mes debe estar entre 1 y 12");

                 }
            }
        }
}


*/

// Este es un ejemplo de como usar el bloque finally
/*
using System;
namespace BloqueFinally
{
        class Program
        {
            static void Main(string[] args)
            {
            
                System.IO.StreamReader archivo = null;

                try
                {
                    string linea;
                    int contador = 0;
                    string ruta = @"C:\Users\aluces\Desktop\Prueba_finnaly.txt";
                    archivo = new System.IO.StreamReader(ruta);

                    while ((linea = archivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                        contador++;
                    }
                    Console.WriteLine($"El archivo tiene {contador} lineas");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha habido un error");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (archivo != null) archivo.Close();
                        
                    Console.WriteLine("Se ha cerrado el archivo");
                    
                }   
          
            }
        }
}
*/
