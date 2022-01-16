using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using NUnit.Framework;

namespace FlightPlanner.Tests
{
    public class FlighPlannerTests
    {
        private FlightPlanner.Planner _target;
        [SetUp]
        public void Setup()
        {
            _target = new Planner();
        }

        [Test]
		public void InputCity_CityNameRiga_ReturnsCityNameRiga()
        { 
            // Arrange  
            var city = "Riga";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var setInCity = new StringReader(city);
            Console.SetIn(setInCity);
             
            // Act
            Planner.InputCity();
             
            // Assert
            var output = stringWriter.ToString();
            Assert.AreEqual($"Insert name of the city\r\nYou chose {city}\r\n", output);
        }

        [Test]
        public void InsertText_InsertRigaTallinn_ReturnDictionary()
        {
            // Arrange
            string[] path = {"Riga -> Tallinn"};
            Dictionary<string, List<string>> expectedOutput = new Dictionary<string, List<string>>();
            expectedOutput.Add("Riga", new List<string>());
            expectedOutput.Add("Tallinn", new List<string>());
            
            // Act
            var list = Planner.InsertText(path);
            
            // Assert
            Assert.AreEqual(expectedOutput, list);
        }
    }
}