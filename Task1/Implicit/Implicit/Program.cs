using System;

namespace Implicit
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Kelvin kelvin = new Kelvin(50);
            //Celcius celcius = kelvin;
            //Console.WriteLine(celcius.Degree);
            #endregion

            Person person1= new Person("Ibrahim","Aliyev",27);
            Person person2 = new Person("Samir", "Aliyev", 23);
            Console.WriteLine(person1>person2);



        }
    }

    #region
    //class Kelvin
    //{
    //    public double Degree { get; set; }
    //    public Kelvin(double a)
    //    {
    //        Degree = a;
    //    }
    //    public static implicit operator Celcius(Kelvin kelvin)
    //    {
    //        return new Celcius(kelvin.Degree - 273);

    //    }

    //}


    //class Celcius
    //{
    //    public double Degree { get; set; }
    //    public Celcius(double b)
    //    {
    //        Degree = b;
    //    }
    //}
    #endregion 
}

