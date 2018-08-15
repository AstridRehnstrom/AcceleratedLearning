using ElevatorDomain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        const int bottomfloor = -2;
        const int topfloor = 3;
        private const int untilmaintainance = 6;

        Elevator e1 = new Elevator("Kalle", bottomfloor, topfloor,  1,  6);

        [TestMethod]
        public void elevator_should_be_at_level_2_when_it_starts_at_1_and_go_up_one_floor()
        {
            e1.GoUp();
            Assert.AreEqual(2, e1.CurrentFloor);

        }


        [TestMethod]
        public void elevaror_should_be_at_level_3_when_it_starts_at_1_and_go_up_is_called_twice()
        {
            e1.GoUp();
            e1.GoUp();
            Assert.AreEqual(3, e1.CurrentFloor);

        }
    }
}
