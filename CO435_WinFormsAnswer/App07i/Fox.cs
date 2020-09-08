using CO435_WinFormsAnswer.App07;
using System;
using System.Collections.Generic;

namespace CO435_WinFormsAnswer.App07i
{
    /**
     * A simple model of a fox.
     * Foxes age, move, eat rabbits, and die.
     * 
     * @author David J. Barnes and Michael Kölling
     * @version 2016.02.29
     * 
     * @modified Derek Peacock
     */
    public class Fox : Animal
    {
        // Characteristics shared by all foxes 
        // (Animal class constants).
        
        // 10 Months
        public override int BreedingAge
        {
            get { return 10; }
        }

        // 24 Months
        public override int MaxAge 
        { 
            get { return 24; } 
        }

        public override double BreedingProbability 
        { 
            get { return 0.08; } 
        }

        public override int MaxLitterSize 
        {
            get { return 5; } 
        }

        public override int MainFoodValue 
        {
            get { return 9; } 
        }

        public Fox(bool randomAge, Field field, Location location):
            base(randomAge, field, location)
        {
        }

        public void Act()
        {
            base.Act();

            Feed();
            Breed();
        }

        /// <summary>
        /// THIS IS A DUPLICATION OF THE BASE CLASS!!!
        /// </summary>
        protected override void Feed()
        {
            if (alive)
            {
                // Move towards a source of food if found.
                Location newLocation = FindFood();
                MoveTo(newLocation);
            }
        }


        /**
         * Look for rabbits adjacent to the current location.
         * Only the first live rabbit is eaten.
         * @return Where food was found, or null if it wasn't.
         */
        protected override Location FindFood()
        {
            List<Location> adjacent = field.AdjacentLocations(location);

            foreach(Location where in adjacent)
            {
                Object animal = field.GetAnimalAt(where);
                
                if (animal is Rabbit) 
                {
                    Rabbit rabbit = (Rabbit)animal;
                    if (rabbit.IsAlive())
                    {
                        rabbit.Die();
                        foodLevel = MainFoodValue;
                        return where;
                    }
                }
            }
            return null;
        }

        /**
         * Check whether or not this fox is to give birth at this step.
         * New births will be made into free adjacent locations.
         * @param newFoxes A list to return newly born foxes.
         */
        public void Breed()
        {
            List<Location> free = field.GetFreeAdjacentLocations(location);
            Litter.Clear();

            for (int b = 0; b < newBirths && free.Count > 0; b++)
            {
                Location loc = free[0];
                free.RemoveAt(0);

                Fox young = new Fox(false, field, loc);
                Litter.Add(young);
            }
        }


        public override string ToString()
        {
            return "F";
        }

    }
}
