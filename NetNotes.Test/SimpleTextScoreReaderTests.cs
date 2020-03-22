using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetNotes.Business;
using NetNotes.Business.Elements;
using System.Linq;

namespace NetNotes.Test
{
    [TestClass]
    public class SimpleTextScoreReaderTests
    {
        [TestMethod]
        public void CreateAScore()
        {
            // Arrange
            var reader = new SimpleTextScoreReader();

            // Act
            var score = reader.CreateNewScore("");

            // Assert
            Assert.IsInstanceOfType(score, typeof(Score));
        }

        [TestMethod]
        public void AddAStave()
        {
            // Arrange
            var reader = new SimpleTextScoreReader();

            // Act
            var score = reader.CreateNewScore("");
            reader.AddNewStaff(score, "");

            // Assert
            Assert.AreEqual(2, score.Staves.Count);
        }

        [TestMethod]
        public void CreateAScoreWithAPattern()
        {
            // Arrange
            var reader = new SimpleTextScoreReader();

            // Act
            var score = reader.CreateNewScore("A/4, G/4, F/8, F/8, C/4");

            // Assert
            Assert.AreEqual("A4/4,G4/4,F4/8,F4/8,C4/4", score.Staves.First().Measures.First().ToString());
        }

        [TestMethod]
        public void CreateAScoreWithMultipleMeasurePattern()
        {
            // Arrange
            var reader = new SimpleTextScoreReader();

            // Act
            var score = reader.CreateNewScore("A4/4, G4/4, 8r, C4/4|D4/16, D4/16, D4/16, D4/16, E4/4, D4/8, D4/8, C4/4");

            // Assert
            Assert.AreEqual("A4/4,G4/4,8r,C4/4", score.Staves.First().Measures[0].ToString());
            Assert.AreEqual("D4/16,D4/16,D4/16,D4/16,E4/4,D4/8,D4/8,C4/4", score.Staves.First().Measures[1].ToString());
        }
    }
}
