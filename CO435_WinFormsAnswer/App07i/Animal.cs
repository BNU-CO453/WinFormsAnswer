
using System;
using System.Collections.Generic;
using CO435_WinFormsAnswer.App07;

namespace CO435_WinFormsAnswer.App07i
{
    public abstract class Animal
    {
        // The age at which a animal can start to breed.
        public virtual int BreedingAge { get; }
        
        // The age to which a animal can live.
        public virtual int MaxAge { get; }

        // The likelihood of a animal breeding.
        public virtual double BreedingProbability { get; }

        // The maximum number of births.
        public virtual int MaxLitterSize { get; }

        // The food value of a single animal. In effect, this is the
        // number of steps an animal can go before it has to eat again.
        public virtual int MainFoodValue { get; }

        // Any newborn animals will be added to the litter
        public virtual List<Animal> Litter { get; set; }

        protected int newBirths;

        // The animal's age.
        protected int age;

        // Whether the animal is alive or not.
        protected bool alive;

        // The animal's position.
        protected Location location;

        // The field occupied.
        protected Field field;

        // The animal's food level, which is increased by eating rabbits.
        protected int foodLevel;

        // A shared random number generator to control breeding.
        protected readonly static Random generator = 
            Randomizer.GetRandomGenerator();

        /// <summary>
        /// If randomAge is true create the animal with a random
        /// age and set the animal in a given location in the
        /// field.  Set the animal's food level to a random
        /// amount.
        /// </summary>
        public Animal(bool randomAge, Field field, Location location)
        {
            alive = true;

            if (randomAge)
            {
                age = generator.Next(MaxAge);
            }
            else
            {
                age = 0;
            }

            this.field = field;
            SetLocation(location);

            foodLevel = generator.Next(MainFoodValue);
        }

        /// <summary>
        /// This method represents all the animals actions
        /// for a given time period. Any implemented
        /// animal needs to () and Feed()
        /// </summary>
        protected virtual void Act()
        {
            IncrementAge();
            IncrementHunger();

            newBirths = GetLitterSize();
        }


        /**
         * This is what an animal does most of the time: it hunts for
         * food. In the process, it might breed, die of hunger,
         * or die of old age.
         * @param field The field currently occupied.
         */
        protected virtual void Feed()
        {
            if (alive)
            {
                // Move towards a source of food if found.
                Location newLocation = FindFood();
                MoveTo(newLocation);
            }
        }


        /// <summary>
        /// Select any free adjacent location and assume
        /// that it contains suitable food (e.g. grass)
        /// </summary>
        protected virtual Location FindFood()
        {
            return field.FreeAdjacentLocation(this.location); 
        }

        /// <summary>
        /// If newLocation is null then look for an adjacent 
        /// free location to move to else move to the new location.
        /// Animal will die if no move possible
        /// </summary>
        public void MoveTo(Location newLocation)
        {
            if (newLocation == null)
            {
                // No food found - try to move to a free location.
                newLocation = field.FreeAdjacentLocation(location);
            }
            // See if it was possible to move.
            if (newLocation != null)
            {
                SetLocation(newLocation);
            }
            else
            {
                // Overcrowding.
                Die();
            }

        }

        /// <summary>
        /// Generate a number representing the number of births,
        /// if it can breed.
        /// </summary>
        /// <return>
        /// The number of births (may be zero).
        /// </return>
        protected int GetLitterSize()
        {
            int births = 0;
            if (CanBreed() && generator.NextDouble() <= BreedingProbability)
            {
                births = generator.Next(MaxLitterSize) + 1;
            }
            return births;
        }


        /// <summary>
        /// Return the animals's location. 
        /// </summary>
        public Location GetLocation()
        {
            return location;
        }

        ///<summary>
        /// Place the animal at the new location in the given field.
        /// </summary>
        protected void SetLocation(Location newLocation)
        {
            if (location != null)
            {
                field.Clear(location);
            }
            location = newLocation;
            field.Place(this, newLocation);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected Boolean CanBreed()
        {
            return age >= BreedingAge;
        }

        /// <summary>
        /// 
        /// </summary>
        protected void IncrementAge()
        {
            age++;
            if (age > MaxAge)
            {
                Die();
            }
        }

        /**
         * Make this animal more hungry.
         * This could result in the animal's death.
         */
        protected void IncrementHunger()
        {
            foodLevel--;
            if (foodLevel <= 0)
            {
                Die();
            }
        }

        /// <summary>
        /// Indicate that the animal is no longer alive.
        /// It is removed from the field. 
        /// </summary>
        public void Die()
        {
            alive = false;
            if (location != null)
            {
                field.Clear(location);
                location = null;
                field = null;
            }
        }


        /// <summary>
        /// Check whether the animal is alive or not.
        /// </summary>        
        public bool IsAlive()
        {
            return alive;
        }
    }
}
