using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMP1903M_A01_2223;
using System.Collections.Generic;

namespace Testings
{
    [TestClass]
    public class Testing
    {

        //Utils utils = new Utils();

        [TestMethod]
        public void TestRiffleShuffle()
        {
            Pack pack = new Pack();
            Pack.shuffleCardPack(Pack.ShuffleType.RiffleShuffle);
            List<Card> cards = Pack.getCardList();
            string output = Utils.FormatReadableCards(cards);
            string expected = Utils.GetExpectedOuput(1);
            Assert.AreEqual(cards.Count, 52);
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestFischerYatesShuffle()
        {
            Pack pack = new Pack();
            Pack.shuffleCardPack(Pack.ShuffleType.FisherYatesShuffle);
            List<Card> cards = Pack.getCardList();
            string output = Utils.FormatReadableCards(cards);
            string expected = Utils.GetExpectedOuput(2);
            Assert.AreEqual(cards.Count, 52);
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestNoShuffle()
        {
            Pack pack = new Pack();
            Pack.shuffleCardPack(Pack.ShuffleType.NoShuffle);
            List<Card> cards = Pack.getCardList();
            string output = Utils.FormatReadableCards(cards);
            string expected = Utils.GetExpectedOuput(3);
            Assert.AreEqual(cards.Count, 52);
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestRiffleShuffleDeal()
        {
            Pack pack = new Pack();
            Pack.shuffleCardPack(Pack.ShuffleType.RiffleShuffle);
            Card card = Pack.deal();
            string output = Utils.FormatReadableCard(card);
            string expected = Utils.GetExpectedOuput(4);
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestFischerYatesShuffleDeal()
        {
            Pack pack = new Pack();
            Pack.shuffleCardPack(Pack.ShuffleType.FisherYatesShuffle);
            Card card = Pack.deal();
            string output = Utils.FormatReadableCard(card);
            string expected = Utils.GetExpectedOuput(5);
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestNoShuffleDeal()
        {
            Pack pack = new Pack();
            Pack.shuffleCardPack(Pack.ShuffleType.NoShuffle);
            Card card = Pack.deal();
            string output = Utils.FormatReadableCard(card);
            string expected = Utils.GetExpectedOuput(6);
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestRiffleShuffleDealCard()
        {
            Pack pack = new Pack();
            Pack.shuffleCardPack(Pack.ShuffleType.RiffleShuffle);
            List<Card> cards = Pack.dealCard(10);
            string output = Utils.FormatReadableCards(cards);
            string expected = Utils.GetExpectedOuput(7);
            Assert.AreEqual(cards.Count, 10);
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestFischerDealCard()
        {
            Pack pack = new Pack();
            Pack.shuffleCardPack(Pack.ShuffleType.FisherYatesShuffle);
            List<Card> cards = Pack.dealCard(10);
            string output = Utils.FormatReadableCards(cards);
            string expected = Utils.GetExpectedOuput(8);
            Assert.AreEqual(cards.Count, 10);
            Assert.AreEqual(output, expected);
        }

        public void TestNoShuffleDealCard()
        {
            Pack pack = new Pack();
            Pack.shuffleCardPack(Pack.ShuffleType.NoShuffle);
            List<Card> cards = Pack.dealCard(10);
            string output = Utils.FormatReadableCards(cards);
            string expected = Utils.GetExpectedOuput(9);
            Assert.AreEqual(cards.Count, 10);
            Assert.AreEqual(output, expected);
        }
    }
 }
