using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BMW_Testing
{
    public class BMW_Tests
    {
        // (1)
        [Fact]
        public void IsStopped_velocity0_true()
        {
            // Arrange
            BMW bmw = new BMW();
            bmw.velocity = 0;

            // Act
            bool result = bmw.IsStopped();

            // Boolean Asserts
            Assert.True(result);
        }

        // (2)

        // Test1
        [Fact]
        public void TimeToCoverDistance_PositiveVelocity_2()
        {
            // Arrange
            BMW bmw = new BMW();
            bmw.velocity = 50;
            double distance = 100;

            // Act
            double result = bmw.TimeToCoverDistance(distance);

            // Assert
            Assert.Equal(2, result);
        }

        // Test2
        [Fact]
        public void TimeToCoverDistance_NegativeVelocity_negative2()
        {
            // Arrange
            BMW bmw = new BMW();
            bmw.velocity = -50;
            double distance = 100;

            // Act
            double result = bmw.TimeToCoverDistance(distance);

            // Assert
            Assert.Equal(-2, result);
        }
        //(3)


        // Test 1
        [Fact]
        public void GetCarInfo_ReturnsCorrectString_VelocityIsZeroAndModeIsStopped()
        {
            // Arrange
            BMW bmw = new BMW();
            bmw.velocity = 0;
            bmw.drivingMode = DrivingMode.Stopped;

            // Act
            string info = bmw.GetCarInfo();

            // Assert
            Assert.Equal("Velocity: 0, Driving Mode: Stopped", info);
        }
        // Test 2
        [Fact]
        public void GetCarInfo_DirectionContainForward_Forward()
        {
            // Arrange
            BMW bmw = new BMW();

            bmw.drivingMode = DrivingMode.Forward;

            // Act
            string info = bmw.GetCarInfo();

            // Assert

            Assert.Contains("war", info);
        }
        // Test3
        [Fact]
        public void GetCarInfo_DirectionBackward_Backward()
        {
            // Arrange
            BMW bmw = new BMW();

            bmw.drivingMode = DrivingMode.Backward;

            // Act
            string info = bmw.GetCarInfo();

            // Assert

            Assert.EndsWith("ward", info);


        }
        // Test4

        [Fact]
        public void GetCarInfo_DirectionStopped_Stopped()
        {
            // Arrange
            BMW bmw = new BMW();

            bmw.drivingMode = DrivingMode.Stopped;

            // Act
            string info = bmw.GetCarInfo();

            // Assert
            Assert.Contains("Stop", info);

        }
        // Test5
        [Fact]
        public void GetCarInfo_DirectionForward_Forward()
        {
            // Arrange
            BMW bmw = new BMW();

            bmw.drivingMode = DrivingMode.Forward;

            // Act
            string info = bmw.GetCarInfo();

            // Assert

            Assert.DoesNotContain("zx", info);
        }
        // (4)
        [Fact]
        public void GetMyCar_callFunction_SameCar()
        {
            // Arrange
            BMW bmw = new BMW();


            // Act
            Car car = bmw.IsCarType();

            // Refrence Assert
            Assert.Same(bmw, car);

        }
        //(5)
        [Fact]
        public void IsCarTypeReturnsTrue()
        {
            // Arrange
            BMW bmw = new BMW();

            // Act
            Car car = bmw.IsCarType();
            // Assert
            Assert.IsType<BMW>(car);
        }

        // (6)
        [Fact]
        public void NewCar_CarTypeHonda_Exception()
        {
          // arrange
           
            // Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
        }

    }
}
