using System;
using System.Collections.Generic;
using CO435_WinFormsAnswer.App07;

namespace CO435_WinFormsAnswer.App07i
{
    /**
     * A simple model of a rabbit.
     * Rabbits age, move, breed, and die.
     * 
     * @author David J. Barnes and Michael Kölling
     * @version 2016.02.29
     */
    public class Rabbit: Animal
    {
        // Characteristics shared by all rabbits (class variables).

        // Characteristics shared by all foxes 
        // (Animal class constants).
        
        // 4 Months
        public override int BreedingAge
        {
            get { return 4; }
        }

        // 30 months
        public override int MaxAge
        {
            get { return 30; }
        }

        public override double BreedingProbability
        {
            get { return 0.12; }
        }

        public override int MaxLitterSize
        {
            get { return 14; }
        }

        public override int MainFoodValue
        {
            get { return 4; }
        }

    
        // Individual characteristics (variables).
    
        private int age;

        private bool alive;

        private Location location;

        private Field field;

        public Rabbit(bool randomAge, Field field, Location location) :
            base(randomAge, field, location)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public void Act()
        {
            base.Act();

            Feed();
            Breed();
        }


        /**
         * Check whether or not this rabbit is to give birth at this step.
         * New births will be made into free adjacent locations.
         * New born rabbits are added to the Litter.
         */
        public void Breed()
        {
            // New rabbits are born into adjacent locations.
            // Get a list of adjacent free locations.
            List<Location> free = field.GetFreeAdjacentLocations(location);
            Litter.Clear();

            for (int b = 0; b < newBirths && free.Count > 0; b++)
            {
                Location loc = free[0];
                free.RemoveAt(0);

                Rabbit young = new Rabbit(false, field, loc);
                Litter.Add(young);
            }
        }

        public override string ToString()
        {
            return "R";
        }

    }
}
