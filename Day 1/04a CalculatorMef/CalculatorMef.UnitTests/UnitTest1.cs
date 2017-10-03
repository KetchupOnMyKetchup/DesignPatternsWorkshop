using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.ComponentModel.Composition.Hosting;

namespace CalculatorMef.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Mock<IOperationData> data = new Mock<IOperationData>();
            data.Setup(x => x.Symbol).Returns(() => '+');

            // Mock the IOperation interface for use in the composition part
            IEnumerable<Lazy<IOperation, IOperationData>> operations = new[]
            {
                new Lazy<IOperation, IOperationData>(() => new Add(), data.Object)
            };

            // Create the concrete instance to compose into.
            MySimpleCalculator calculator = new MySimpleCalculator();


            CompositionContainer container = new CompositionContainer();

            // Create an export composition of the mocked IDog interface
            container.ComposeExportedValue(new Add());

            // Actually compose the concrete animal manager instance.
            container.ComposeParts(calculator);

            Assert.AreEqual(2, calculator.Calculate("1+1"));
        }

        [TestMethod]
        public void AnimalManager_GetDog_RetrievesDog()
        {
            // Mock the IDog interface for use in the composition part
            Mock<IDog> dog = new Mock<IDog>();

            // Create the concrete instance to compose into.
            AnimalManager animalManager = new AnimalManager();
            CompositionContainer container = new CompositionContainer();

            // Create an export composition of the mocked IDog interface
            container.ComposeExportedValue(dog.Object);

            // Actually compose the concrete animal manager instance.
            container.ComposeParts(animalManager);
            Assert.IsNotNull(animalManager.GetAnimal<IDog>());
        }
    }
}
