using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DemoXUnit.Tests
{
    public class MathTestsData : IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>()
        {
            new object[]
            {
                1,
                3,
                4
            },
            new object[]
            {
                -1,
                -3,
                -4
            },
            new object[]
            {
                -1,
                3,
                2
            }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
