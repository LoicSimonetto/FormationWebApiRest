using ExempleJedi;

namespace TestJeuDroide
{
    [TestClass]
    public class JediUnitTest
    {
        [TestMethod]
        public void TesterAttaquerToutEstOk()
        {
            Jedi jedi= new Jedi();
            Droide droide= new Droide();
            droide.PointDeVie = 100;
            jedi.Attaquer(droide);

            Assert.IsTrue(droide.PointDeVie == 50);
        }
    }
}