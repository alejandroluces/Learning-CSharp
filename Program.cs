/*
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

