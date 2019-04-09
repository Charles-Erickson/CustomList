using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Of_Add()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>;
            int value = 5;


            //Act
            myList.Add(value);




            //Assert
            Assert.AreEqual(value, myList[0]);

        }
        [TestMethod]
        public void Test_Of_Count()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expectedCount = 1;
            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedCount, myList.Count);
        }
        [TestMethod]
        public void Test_of_Add_Method_With_Multiple_Values()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;

            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(value, myList[0]);
        }

        [TestMethod]
        public void Test_Of_Remove()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 4;
            int expectedCount = 1;

            //Act
            myList.Add(value);
            myList.Add(value2);
            myList.Remove(value);



            //Assert
            Assert.AreEqual(expectedCount, myList.Count);            
        }

        [TestMethod]
        public void Test_Of_Remove_Checking_Proper_()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 4;
            int expectedValue = 4;

            //Act
            myList.Add(value);
            myList.Add(value2);
            myList.Remove(value);



            //Assert
            Assert.AreEqual(expectedValue, myList[0});
        }

        [TestMethod]
        public void Test_Of_List_To_string()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value2 = 4;
            string expectedString = "54";
            string name;

            //Act
            myList.Add(value);
            myList.Add(value2);
            name = myList.ToString();

            //Assert
            Assert.AreEqual(expectedString, name);
        }
    }
}
