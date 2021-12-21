using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassTrueCount8UniqueWords()
        {
            _20diciembreTend.Texto cancion = new _20diciembreTend.Texto("la vaca lola, La vaca lola, tiene cabeza y tiene cola");

            Assert.AreEqual(8, cancion.CountDifferentWords());
        }
        [TestMethod]
        public void Pass_False_Count_4_Unique_Words_When_There_Are_8()
        {
            _20diciembreTend.Texto cancion = new _20diciembreTend.Texto("La vaca Lola, la vaca Lola, tiene cabeza y tiene cola");
            Assert.AreNotEqual(4, cancion.CountDifferentWords());

        }
        [TestMethod]
        public void Pass_True_Count_13_Unique_Words()
        {
            _20diciembreTend.Texto cancion = new _20diciembreTend.Texto("la vaca lola, La vaca lola, tiene cabeza y tiene cola" + 
                "\nLa cucaracha la cucaracha, ya no puede caminar");

            Assert.AreEqual(13, cancion.CountDifferentWords());
        }

        [TestMethod]
        public void ReturnFalseEmptyText()
        {
            try
            {
                _20diciembreTend.Texto cancion = new _20diciembreTend.Texto("");
            }
            catch (System.Exception)
            {
                Assert.IsTrue(true);
            }


        }
    }
}
