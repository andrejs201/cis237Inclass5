using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            AdventureWorks2012Entities adventure = new AdventureWorks2012Entities();

            int counter = 0;
            Guid id = Guid.NewGuid();

            foreach (Person person in adventure.People)
            {
                if (counter == 0)
                {
                    id = person.rowguid;
                }
                if (counter++ > 20)
                {
                    break;
                }
                Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.rowguid);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(adventure.People.Find(id));
             */
            /*
            foreach (EmailAddress email in adventure.EmailAddresses)
            {
                Console.WriteLine(email);
            }
             */
            //*********************************************************************
            //List out all of the cars in the table
            //*********************************************************************
            //Gets access to the collection of tables we can interact with
            CarsATomsonsEntities carsATomsonsEntities = new CarsATomsonsEntities();

            //Loop through all the cars in the table called cars
            foreach (Car car in carsATomsonsEntities.Cars)
            {
                Console.WriteLine(car.id + " " + car.make + " " + car.model);
            }

            //********************************************************************
            //Find a specific one by any property
            //********************************************************************
            //Call the Where method on the table Cars and pass in a lambda expression for the criteria we are looking for. There is nothing special about the word car in the part that reads: 
            //car => car.id == "v0...". It could be any characters we want it to be. car made sense. Also, car represents the object we want to do the Where on. That's why we have car.id == "V0...".
            Car carToFind = carsATomsonsEntities.Cars.Where(car => car.id == "V0LCD1814").First();

            //We can look for a specific model from the database with a where clause based on any criteria we want. Here we are doing it with the car's model instead of it's id.
            Car otherCarToFind = carsATomsonsEntities.Cars.Where(car => car.model == "Challenger").First();

            //Print them out
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(carToFind.id + " " + carToFind.make + " " + carToFind.model);
            Console.WriteLine(otherCarToFind.id + " " + otherCarToFind.make + " " + otherCarToFind.model);

            
            //NOTE: this currently does not work because I forgot to set a primary Id on the tables. Will hopefully fix it soon.

            //Pull out a car from the table based on the primary id
            /*
            Car foundCar = carsATomsonsEntities.Cars.Find("V0LCD1814");

            //Print it out
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(foundCar.id + " " + foundCar.make + " " + foundCar.model);
             */

            //********************************************************************
            //Add a new car to the database
            //********************************************************************
            //NOTE: this currently does not work because I forgot to set a primary Id on the tables. Will hopefully fix it soon.
            /*
            //Make an instance of a new car
            Car newCarToAdd = new Car();

            //Assign properties to the parts of the model
            newCarToAdd.id = "88888";
            newCarToAdd.make = "Nissan";
            newCarToAdd.model = "GT-R";
            newCarToAdd.horsepower = 550;
            newCarToAdd.cylinders = 8;
            newCarToAdd.year = "2016";
            newCarToAdd.type = "Car";

            //Add the new car to the Cars table
            carsATomsonsEntities.Cars.Add(newCarToAdd);

            //This method call actually does the work of saving the changes to the database
            carsATomsonsEntities.SaveChanges();
             */

            //********************************************************************
            //How to update
            //********************************************************************
            //NOTE: this currently does not work because I forgot to set a primary Id on the tables. Will hopefully fix it soon.
            /*
            //Get car out of the database that we would like to update
            Car carToFindForUpdate = carsATomsonsEntities.Cars.Find("V0LCD1814");

            //Update some of the properties of the car we found. Don't need to update all of them if we want to. I choose these 4.
            carToFindForUpdate.make = "Nissan";
            carToFindForUpdate.model = "GT-R";
            carToFindForUpdate.horsepower = 550;
            carToFindForUpdate.cylinders = 8;

            //Save changes to the database
            carsATomsonsEntities.SaveChanges();
             */

            //********************************************************************
            //How to do a delete
            //********************************************************************
            //NOTE: this currently does not work because I forgot to set a primary Id on the tables. Will hopefully fix it soon.
            /*
            //Get car out of the database that we would like to update
            Car carToFindForDelete = carsATomsonsEntities.Cars.Find("V0LCD1814");

            //Remove cars from the cars table
            carsATomsonsEntities.Cars.Remove(carToFindForDelete);

            //Save changes to the database
            carsATomsonsEntities.SaveChanges();
             */
        }
    }
}
