using System;
using System.Collections.Generic;

using Xunit;

namespace SensorValidate.Tests
{
    public class SensorValidatorTest
    {
        [Fact]
        public void ReportsErrorWhenSOCjumps() {
            Assert.False(SensorValidator.ValidateSOCreadings(
                new List<double>{0.0, 0.01, 0.5, 0.51}
            ));
        }
        [Fact]
        public void ReportsErrorWhenCurrentjumps() {
            Assert.False(SensorValidator.ValidateCurrentreadings(
                new List<double>{0.03, 0.03, 0.03, 0.33}
            ));
        }
    }
}
