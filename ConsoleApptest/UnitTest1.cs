using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleApptest
{
    [TestClass]
    public class App01Test
    {
        DistanceConverter distanceConverter = new DistanceConverter();
        [TestMethod]

        public void TestFeetToMiles()
        { 
                distanceConverter.Run();
            {
                distanceConverter.fromUnit = DistanceUnits.Miles;
                distanceConverter.toUnit = DistanceUnits.Feet;
                NewMethod();

                distanceConverter.Calculate();
                Assert.AreEqual(520000, actual: distanceConverter.toUnit);



            }
        }

        private void NewMethod() => distanceConverter.fromUnit = (DistanceUnits)100;
    }
    }
