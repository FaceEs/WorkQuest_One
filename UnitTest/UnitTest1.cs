using NUnit.Framework;
using System;
using WorkQuest_One;

namespace UnitTest
{
    public class Tests
    {
        GeometyCalcAPI api;
        [SetUp]
        public void Setup()
        {
            api = new GeometyCalcAPI();
        }
        /// <summary>
        /// Тестирование расчета площади круга
        /// </summary>
        [Test]
        public void circleSquareTestRad1_true()
        {
            if (api.getSquareOfCircle(1) == Math.PI)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
            
        }
        /// <summary>
        /// Тестирование расчета площади круга
        /// </summary>
        [Test]
        public void circleSquareTestRad2_false()
        {
            if (api.getSquareOfCircle(2) != Math.PI)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
        /// <summary>
        /// Тестирование расчета площади круга
        /// </summary>
        [Test]
        public void circleSquareTestRad5_true()
        {
            if (api.getSquareOfCircle(5) == 25*Math.PI)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
        /// <summary>
        /// Тестирование расчета площади круга
        /// </summary>
        [Test]
        public void circleSquareTestRad_minus_1_error()
        {
            if (api.getSquareOfCircle(-1) != Math.PI)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
        /// <summary>
        /// Тестирование расчета площади треугольника
        /// </summary>
        [Test]
        public void triangleSquareTest_1_1_1_true()
        {
            if (Math.Round(api.getSquareOfTriangle(1,1,1),3)==0.433)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        /// <summary>
        /// Тестирование расчета площади треугольника
        /// </summary>
        [Test]
        public void triangleSquareTest_2_2_1_false()
        {
            if (Math.Round(api.getSquareOfTriangle(2, 2, 1), 3) != 2)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
        /// <summary>
        /// Тестирование расчета площади треугольника
        /// </summary>
        [Test]
        public void triangleSquareTest_minus_1_all_true()
        {
            if (Math.Round(api.getSquareOfTriangle(-1, -1, -1), 3) == -1)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}