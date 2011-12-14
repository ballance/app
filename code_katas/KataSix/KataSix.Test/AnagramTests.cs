using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataSix.Test
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void should_verify_hannah_lowercase_is_valid_anagram()
        {
            var anagram = new Anagram();
            
            var isAnagram = anagram.IsAnagram("hannah");

            Assert.IsTrue(isAnagram);
        }

        [TestMethod]
        public void should_verify_hannah_mixed_case_is_valid_anagram()
        {
            var anagram = new Anagram();

            var isAnagram = anagram.IsAnagram("Hannah");

            Assert.IsTrue(isAnagram);
        }

        [TestMethod]
        public void should_verify_chris_lowercase_case_is_not_valid_anagram()
        {
            var anagram = new Anagram();

            var isAnagram = anagram.IsAnagram("chris");

            Assert.IsFalse(isAnagram);
        }

        [TestMethod]
        public void should_verify_Chris_mixed_case_is_not_valid_anagram()
        {
            var anagram = new Anagram();

            var isAnagram = anagram.IsAnagram("Chris");

            Assert.IsFalse(isAnagram);
        }
    }
}
