﻿using System;

namespace CO435_WinFormsAnswer.App07
{
    /**
     * Provide control over the randomization of the simulation. By using the shared, fixed-seed 
     * randomizer, repeated runs will perform exactly the same (which helps with testing). Set 
     * 'useShared' to false to get different random behaviour every time.
     * 
     * @author David J. Barnes and Michael Kölling
     * @version 2016.02.29
     */
    public static class Randomizer
    {
        // The default seed for control of randomization.
        private const int SEED = 1111;
        // A shared Random object, if required.
        private static Random generator = new Random(SEED);
        // Determine whether a shared random generator is to be provided.
        private readonly static bool useShared = true;


        /**
         * Provide a random generator.
         * @return A random object.
         */
        public static Random GetRandomGenerator()
        {
            if (useShared)
            {
                return generator;
            }
            else
            {
                return new Random();
            }
        }

        /**
         * Reset the randomization.
         * This will have no effect if randomization is not through a shared Random generator.
         */
        public static void Reset()
        {
            if (useShared)
            {
                generator = new Random(SEED);
            }
        }

    }
}
