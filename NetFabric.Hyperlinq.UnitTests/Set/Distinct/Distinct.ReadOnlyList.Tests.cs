﻿using NetFabric.Assertive;
using Xunit;

namespace NetFabric.Hyperlinq.UnitTests.Set.Distinct
{
    public class ReadOnlyListTests
    {
        [Theory]
        [MemberData(nameof(TestData.Empty), MemberType = typeof(TestData))]
        [MemberData(nameof(TestData.Single), MemberType = typeof(TestData))]
        [MemberData(nameof(TestData.Multiple), MemberType = typeof(TestData))]
        public void Distinct_With_ValidData_Must_Succeed(int[] source)
        {
            // Arrange
            var wrapped = Wrap.AsValueReadOnlyList(source);
            var expected =
                System.Linq.Enumerable.Distinct(wrapped);

            // Act
            var result = ReadOnlyList
                .Distinct<Wrap.ValueReadOnlyList<int>, int>(wrapped);

            // Assert
            _ = result.Must()
                .BeEnumerableOf<int>()
                .BeEqualTo(expected);
        }

        [Theory]
        [MemberData(nameof(TestData.Empty), MemberType = typeof(TestData))]
        [MemberData(nameof(TestData.Single), MemberType = typeof(TestData))]
        [MemberData(nameof(TestData.Multiple), MemberType = typeof(TestData))]
        public void Distinct_ToArray_ToArray_With_ValidData_Must_Succeed(int[] source)
        {
            // Arrange
            var wrapped = Wrap.AsValueReadOnlyList(source);
            var expected =
                System.Linq.Enumerable.ToArray(
                    System.Linq.Enumerable.Distinct(source));

            // Act
            var result = ReadOnlyList
                .Distinct<Wrap.ValueReadOnlyList<int>, int>(wrapped)
                .ToArray();

            // Assert
            _ = result.Must()
                .BeArrayOf<int>()
                .BeEqualTo(expected);
        }

        [Theory]
        [MemberData(nameof(TestData.Empty), MemberType = typeof(TestData))]
        [MemberData(nameof(TestData.Single), MemberType = typeof(TestData))]
        [MemberData(nameof(TestData.Multiple), MemberType = typeof(TestData))]
        public void Distinct_ToList_With_ValidData_Must_Succeed(int[] source)
        {
            // Arrange
            var wrapped = Wrap.AsValueReadOnlyList(source);
            var expected =
                System.Linq.Enumerable.ToList(
                    System.Linq.Enumerable.Distinct(source));

            // Act
            var result = ReadOnlyList
                .Distinct<Wrap.ValueReadOnlyList<int>, int>(wrapped)
                .ToList();

            // Assert
            _ = result.Must()
                .BeEnumerableOf<int>()
                .BeEqualTo(expected);
        }
    }
}
