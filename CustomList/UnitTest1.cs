﻿using System;
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
            CustomList<int> myList = new CustomList<int>();
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
        public void Test_of_Add_Method_With_Multiple_Values_Other_Index()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;

            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(value1, myList[1]);
        }


    [TestMethod]
    public void Test_Of_List_Capicaty()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;
            int value2 = 12;
            int value3 = 14;
            int value4 = 6;
            int expectedValue = 6;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            //Assert
            Assert.AreEqual(expectedValue, myList[4]);
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
        public void Test_Of_Remove_Checking_Proper_Index()
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
            Assert.AreEqual(expectedValue, myList[0]);
        }

        [TestMethod]
        public void Test_Of_List_To_String()
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

        [TestMethod]
        public void Test_Of_List_String2()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string name = "Dog";
            string name2 = "Cat";
            string expectedName = "DogCat";
            string testName;

            //Act
            myList.Add(name);
            myList.Add(name2);
            testName = myList.ToString();

            //Assert
            Assert.AreEqual(expectedName, testName);
        }

        [TestMethod]
        public void Test_Of_Zipper_Method()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> TestList = new CustomList<int>();
            int value = 1;
            int value2 = 3;
            int number = 2;
            int number2 = 4;
            int expectedValue = 2;

            //Act
            myList.Add(value);
            myList.Add(value2);
            myList2.Add(number);
            myList2.Add(number2);
            TestList = myList.Zipper(myList2);

            //Assert
            Assert.AreEqual(expectedValue, TestList[2]);
        }
        
        [TestMethod]
        public void Test_Of_Zipper_Method_Length()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> TestList = new CustomList<int>();
            int value = 1;
            int value2 = 3;
            int number = 2;
            int number2 = 4;
            int expectedValue = 4;

            //Act
            myList.Add(value);
            myList.Add(value2);
            myList2.Add(number);
            myList2.Add(number2);
            TestList = myList.Zipper(myList2);

            //Assert
            Assert.AreEqual(expectedValue, TestList.Count);
        }
    }
}

       
    

  


    

