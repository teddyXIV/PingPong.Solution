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
            // Assert.AreEqual(expectedList, actualList);
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

            // string expected = "ping";
            // string actual = pingpong.DivisibleBy3Check();
            // Assert.AreEqual(expected, actual);
        }

        // [TestMethod]
        // public void DivisibleBy3Check_ChecksIfValueDivisibleBy3_Number()
        // {
        //     PingPongCalc pingpong = new PingPongCalc(4);
        //     int expected = 4;
        //     string actual = pingpong.DivisibleBy3Check();
        //     Assert.AreEqual(expected, actual);
        // }


        // public void DivisibleBy5Check_ChecksIfValueDivisibleBy5_StringOrNumber()
        // {
        //     PingPongCalc pingPong = new PingPongCalc(10);
        //     string expected = "pong";
        //     string actual = pingPong.DivisibleBy5Check();
        //     Assert.AreEqual(expected, actual);
        // }
    }
}