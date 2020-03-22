using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetNotes.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetNotes.Test
{
    [TestClass]
    public class MusicXMLScoreReaderTests
    {
        [TestMethod]
        public void ReadLaetatusSum()
        {
            // Arrange
            var reader = new MusicXmlScoreReader();
            
            // Act
            var score = reader.ParseFile("laetatus_sum.xml");

            // Assert
            Assert.IsNotNull(score);
            Assert.AreEqual("Laetatus Sum", score.Title);
            Assert.AreEqual("Johann Michael Haydn", score.Composer);
            Assert.AreEqual(3, score.Staves.Count);
        }
    }
}
