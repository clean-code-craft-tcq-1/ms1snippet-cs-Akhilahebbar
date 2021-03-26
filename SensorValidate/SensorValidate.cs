using System;
using System.Collections.Generic;

namespace SensorValidate
{
    public class SensorValidator
    {
        public static bool CheckValueJumps(double value, double nextValue, double maxDelta) {
            return nextValue - value > maxDelta ? false : true;
        }
        public static bool ValidateSOCreadings(List<Double> values) {
            return validateReadings(values,0.05);
        }
        public static bool ValidateCurrentreadings(List<Double> values) {
            return ValidateReadings(values,0.1);
        }
        public static bool ValidateReadings(List<Double> values,Double maxDelta)
        {
            for (int i = 0; i < values.Count - 1; i++)
            {
                if (!CheckValueJumps(values[i], values[i + 1], maxDelta))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

