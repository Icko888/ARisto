using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        class Wizards
        {
            public string Name;
            public int Power;
            public int Age;
            public DateTime Date;
            public bool Graduation;

            public Wizards() { }

            public Wizards(string name, int power, int age, DateTime date, bool graduation)
            {
                this.Name = name;
                this.Power = power;
                this.Age = age;
                this.Date = date;
                this.Graduation = graduation;
            }

            public void Print1Wizard(Wizards dum)
            {
                Console.WriteLine("Name: {0}, Power Level: {1}, Age: {2} Years old, Date of entrance in Hogwarts: {3} , Graduation: {4},",dum.Name,dum.Power,dum.Age,dum.Date.AddYears(-115).AddMonths(9).AddDays(15),dum.Graduation );
            }

            public void Print2Wizard(Wizards harry)
            {
                Console.WriteLine("Name: {0}, Power Level: {1}, Age: {2} Years old, Date of entrance in Hogwart: {3}, Graduation: {4},", harry.Name, harry.Power, harry.Age, harry.Date.AddYears(-27).AddMonths(3), harry.Graduation);
            }

            public void Print3Wizard (Wizards herm)
            {
                Console.WriteLine($"Name: {Name}, Power Level: {Power}, Age: {Age} Years old, Date of entrance in Hoqwarts: {Date.AddYears(-27).AddMonths(3)}, Graduation: {Graduation}");
            }
        }
        
        class Creatures
        {
            public string Name;
            public int Power;
            public int Age;


            public Creatures () { }

            

            public Creatures(string name,int power,int age)
            {
                this.Name = name;
                this.Power = power;
                this.Age = age;
                
            }

            public void Print1Creatures (Creatures demet)
            {
                Console.WriteLine("Name: {0}, Power Level: {1}, Age: {2} Years old, ", demet.Name, demet.Power, demet.Age);
            }

            public void Print2Creatures ( Creatures gob)
            {
                Console.WriteLine($"Name: {Name}, Power Level: {Power}, Age: {Age} Years old");
            }

            public void Print3Creatures(Creatures cent)
            {
                Console.WriteLine($"Name: {Name}, Power Level: {Power}, Age: {Age} Years old");
            }
        }

        


        static void Main(string[] args)
        {
            Wizards dum = new Wizards();
            dum.Name = "Dumbledore";
            dum.Power = 1500;
            dum.Age = 135;
            dum.Date = DateTime.Now;
            dum.Graduation = true;
            dum.Print1Wizard(dum);
            Console.ReadLine();

            Wizards harry = new Wizards();
            harry.Name = "Harry Potter";
            harry.Power = 2000;
            harry.Age = 39;
            harry.Date = DateTime.Now;
            harry.Graduation = true;
            harry.Print2Wizard(harry);
            Console.ReadLine();

            Wizards herm = new Wizards();
            herm.Name = "Hermione Granger";
            herm.Power = 1300;
            herm.Age = 39;
            herm.Date = DateTime.Now;
            herm.Graduation = true;
            herm.Print2Wizard(herm);
            Console.ReadLine();

            

            Creatures demet = new Creatures();
            demet.Name = "Dementor";
            demet.Power = 1800;
            demet.Age = 1000;
            demet.Print1Creatures(demet);
            Console.ReadLine();

            Creatures gob = new Creatures();
            gob.Name = "Goblin";
            gob.Power = 800;
            gob.Age = 120;
            gob.Print1Creatures(gob);
            Console.ReadLine();

            Creatures cent = new Creatures();
            cent.Name = "Centaurs";
            cent.Power = 1400;
            cent.Age = 180;
            cent.Print1Creatures(cent);
            Console.ReadLine();


            if (dum.Power > demet.Power)
            {
                Console.WriteLine("Dumbledore Tamed the Dementor");
            }
            else
            {
                Console.WriteLine("Dumbledore can't Tamed the Dementor because is to Powerful");
            }

            if (dum.Power > gob.Power)
            {
                Console.WriteLine("Dumbledore Tamed the Goblin");
            }
            else
            {
                Console.WriteLine("Dumbledore can't Tamed the Goblin because is to Powerful");
            }
            if (dum.Power > cent.Power)
            {
                Console.WriteLine("Dumbledore Tamed the Centaurs");
            }
            else
            {
                Console.WriteLine("Dumbledore can't Tamed the Centaurs because is to Powerful");
            }

            if (harry.Power > demet.Power)
            {
                Console.WriteLine("Harry Potter Tamed the Dementor");
            }
            else
            {
                Console.WriteLine("Harry Potter can't Tamed the Dementor because is to Powerful");
            }

            if (harry.Power > gob.Power)
            {
                Console.WriteLine("Harry Potter Tamed the Goblin");
            }
            else
            {
                Console.WriteLine("Harry Potter can't Tamed the Goblin because is to Powerful");
            }
            if (harry.Power > cent.Power)
            {
                Console.WriteLine("Harry Potter Tamed the Centaurs");
            }
            else
            {
                Console.WriteLine("Harry Potter can't Tamed the Centaurs because is to Powerful");
            }

            

            if (herm.Power > demet.Power)
            {
                Console.WriteLine("Hermione Granger Tamed the Dementor");
            }
            else
            {
                Console.WriteLine("Hermione Granger can't Tamed the Dementor because is to Powerful");
            }

            if (herm.Power > gob.Power)
            {
                Console.WriteLine("Hermione Granger Tamed the Goblin");
            }
            else
            {
                Console.WriteLine("Hermione Granger can't Tamed the Goblin because is to Powerful");
            }
            if (herm.Power > cent.Power)
            {
                Console.WriteLine("Hermione Granger Tamed the Centaurs");
            }
            else
            {
                Console.WriteLine("Hermione Granger can't Tamed the Centaurs because is to Powerful");
            }

            Console.ReadLine();












        }
       
    }
}
