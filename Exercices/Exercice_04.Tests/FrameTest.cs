using Exercices.Core;
using Exercices.Core.Exercice_04.Models;
using Moq;
using System.Text;

namespace Exercice_04.Tests;

[TestClass]
public class FrameTest
{
    private Frame _frame;
    public FrameTest(Frame frame)
    {
        _frame = frame;
    }

    [TestMethod]
    public void Roll_SimpleFrame_FirstRoll_CheckScore()
    {
        // - S’il s’agit d’une série standard (round 1 par exemple)
        // - Le premier lancer d’une série doit augmenter le score de la série

        // Arrange 
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur).Setup(g => g.RandomPin(10)).Returns(4);

        //Act 
        _frame.MakeRoll();

        // Assert 
        Assert.AreEqual(4, _frame.GetScore());
    }

    // - S’il s’agit d’une série standard (round 1 par exemple)
    // Le second lancer d’une série doit augmenter le score de cette série
    [TestMethod]
    public void Roll_SimpleFrame_SecondRoll_CheckScore()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur).Setup(g => g.RandomPin(4)).Returns(2);

        _frame.MakeRoll();

        Assert.AreEqual(6, _frame.GetScore());
    }

    [TestMethod]
    public void Roll_SimpleFrame_SecondRoll_FirstRollStrick_ReturnFalse()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur).Setup(g => g.RandomPin(10)).Returns(10);

        bool result = _frame.MakeRoll();

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Roll_SimpleFrame_MoreRolls_ReturnFalse()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur).Setup(g => g.RandomPin(8)).Returns(5);

        bool result = _frame.MakeRoll();

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Roll_LastFrame_SecondRoll_FirstRollStrick_ReturnTrue()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur).Setup(g => g.RandomPin(10)).Returns(10);

        bool result = _frame.MakeRoll();

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Roll_LastFrame_SecondRoll_FirstRollStrick_CheckScore()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur).Setup(g => g.RandomPin(10)).Returns(7);

        Assert.AreEqual(16, _frame.GetScore());
    }

    [TestMethod]
    public void Roll_LastFrame_ThirdRoll_FirstRollStrick_ReturnTrue()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur).Setup(g => g.RandomPin(10)).Returns(4);

        bool result = _frame.MakeRoll();

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Roll_LastFrame_ThirdRoll_FirstRollStrick_CheckScore()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur).Setup(g => g.RandomPin(10)).Returns(6);

        Assert.AreEqual(16, _frame.GetScore());
    }

    [TestMethod]
    public void Roll_LastFrame_ThirdRoll_Spare_ReturnTrue()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur).Setup(g => g.RandomPin(6)).Returns(6);

        bool result = _frame.MakeRoll();

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Roll_LastFrame_ThirdRoll_Spare_CheckScore()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur).Setup(g => g.RandomPin(5)).Returns(5);

        Assert.AreEqual(16, _frame.GetScore());
    }

    [TestMethod]
    public void Roll_LastFrame_FourthRoll_ReturnFalse()
    {
        IGenerateur generateur = Mock.Of<IGenerateur>();
        Mock.Get(generateur).Setup(g => g.RandomPin(5)).Returns(5);

        bool result = _frame.MakeRoll();

        Assert.IsFalse(result);
    }
}
