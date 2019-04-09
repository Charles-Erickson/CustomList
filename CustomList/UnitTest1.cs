using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomList<int> MyList = new CustomList<int>;
            int value = 5;


            //Act
            MyList.Add(value);




            //Assert
            Assert.AreEqual(value, MyList[0]);

        }
    }
}
