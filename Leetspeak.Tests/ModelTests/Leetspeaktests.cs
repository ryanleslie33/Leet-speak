using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeakname;

namespace Leetspeakname.Test
{
  [TestClass]
  public class SpeakTest
  {
    [TestMethod]
    public void Replace_inputaletterandreturnnumber1_True()
    {
      Leet testLeetSpeak = new Leet();
      Assert.AreEqual("3", testLeetSpeak.PlayGame("e"));
    }
    [TestMethod]
    public void Replace_inputaletterandreturnnumber2_True()
    {
      Leet testLeetSpeak = new Leet();
      Assert.AreEqual("0", testLeetSpeak.PlayGame("o"));
    }
    [TestMethod]
    public void Replace_inputaletterandreturnnumber3_True()
    {
      Leet testLeetSpeak = new Leet();
      Assert.AreEqual("1", testLeetSpeak.PlayGame("I"));
    }
    [TestMethod]
    public void Replace_inputaletterandreturnnumber4_True()
    {
      Leet testLeetSpeak = new Leet();
      Assert.AreEqual("7", testLeetSpeak.PlayGame("t"));
    }
    [TestMethod]
    public void Replace_inputaletterandreturnnumber5_True()
    {
      Leet testLeetSpeak = new Leet();
      Assert.AreEqual("z", testLeetSpeak.PlayGame("s"));
    }
  }
}
