using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    /// <summary>
    /// ShoppingCartTest 的摘要描述
    /// </summary>
    [TestClass]
    public class ShoppingCartTest
    {
        public ShoppingCartTest()
        {
            //
            // TODO: 在此加入建構函式的程式碼
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///取得或設定提供目前測試回合
        ///相關資訊與功能的測試內容。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 其他測試屬性
        //
        // 您可以使用下列其他屬性撰寫測試: 
        //
        // 執行該類別中第一項測試前，使用 ClassInitialize 執行程式碼
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在類別中的所有測試執行後，使用 ClassCleanup 執行程式碼
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在執行每一項測試之前，先使用 TestInitialize 執行程式碼 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在執行每一項測試之後，使用 TestCleanup 執行程式碼
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ShoppingCart_buy_1_book()
        {
            //arrange
            ShoppingCart target = new ShoppingCart();
            PotterBook book = new PotterBook { Episode = 1 };
            target.AddToCart(book);
            var expected = 100;

            //act
            var actual = target.Billing();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShoppingCart_buy_2_different_books()
        {
            //arrange
            ShoppingCart target = new ShoppingCart();
            List<PotterBook> books = new List<PotterBook>
            {
                new PotterBook { Episode=1 },
                new PotterBook { Episode=2 },
            };
            target.AddToCart(books);
            var expected = 190;

            //act
            var actual = target.Billing();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
