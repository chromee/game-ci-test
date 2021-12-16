using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class NewTestScript
    {
        [Test]
        public void Success()
        {
            Debug.Log("Hoge");
        }

        [Test]
        public void Failed()
        {
            Debug.Log("Fuga");
            Assert.IsTrue(true);
        }
    }
}
