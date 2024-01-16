using System.Collections.Generic;
using System;
using PingPong.Models;

namespace PingPong.Tests
{

    [TestClass]
    public class PingPongTests
    {
        [TestMethod]
        public void CreateListFromUserInt_CreateListOfValues_List()
        {
            PingPongCalc pingPong = new PingPongCalc(5);
            List<int> expectedList = new List<int> { 1, 2, 3, 4, 5 };
            List<int> actualList = pingPong.CreateListFromUserInt();
            CollectionAssert.AreEqual(expectedList, actualList);  //CollectionAssert is for lists (maybe arrays too?)
        }

        [TestMethod]
        public void DivisibleBy3Check_ChecksIfValueDivisibleBy3_ListObject()
        {
            PingPongCalc pingPong = new PingPongCalc(3);

            List<int> intList = pingPong.CreateListFromUserInt();
            List<object> initialList = intList.ConvertAll(x => (object)x);
            List<object> actualList = pingPong.DivisibleBy3Check(initialList);
            List<object> expectedList = new List<object> { 1, 2, "ping" };
            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestMethod]
        public void DivisibleBy5Check_ChecksIfValueDivisibleBy5_ListObject()
        {
            PingPongCalc pingPong = new PingPongCalc(10);
            List<int> intList = pingPong.CreateListFromUserInt();
            List<object> initialList = intList.ConvertAll(x => (object)x);
            List<object> actualList = pingPong.DivisibleBy5Check(initialList);
            List<object> expectedList = new List<object> { 1, 2, 3, 4, "pong", 6, 7, 8, 9, "pong" };
            CollectionAssert.AreEqual(expectedList, actualList);
        }

        [TestMethod]
        public void DivisibleBy3And5Check_ChecksIfValueDivisibleBy3And5_ListObject()
        {
            PingPongCalc pingPong = new PingPongCalc(15);
            List<int> intList = pingPong.CreateListFromUserInt();
            List<object> initialList = intList.ConvertAll(x => (object)x);
            List<object> actualList = pingPong.DivisibleBy3And5Check(initialList);
            List<object> expectedList = new List<object> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, "ping-pong" };
            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}