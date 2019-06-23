using System;
using System.Collections.Generic;
using System.Diagnostics;
using FluentAssertions;
using Xunit;

namespace NetFabric.Hyperlinq.UnitTests
{
    public class ContainsReadOnlyListTests
    {
        [Theory]
        [MemberData(nameof(TestData.Contains), MemberType = typeof(TestData))]
        public void Contains_With_ValidData_Should_Succeed(int[] source, int value, bool expected)
        {
            // Arrange
            var wrapped = Wrap.AsReadOnlyList(source);

            // Act
            var result = ReadOnlyList.Contains<Wrap.ReadOnlyList<int>, int>(wrapped, value);

            // Assert
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(TestData.Contains), MemberType = typeof(TestData))]
        public void Contains_With_ValidData_And_Comparer_Should_Succeed(int[] source, int value, bool expected)
        {
            // Arrange
            var wrapped = Wrap.AsReadOnlyList(source);

            // Act
            var result = ReadOnlyList.Contains<Wrap.ReadOnlyList<int>, int>(wrapped, value, EqualityComparer<int>.Default);

            // Assert
            result.Should().Be(expected);
        }    

        [Theory]
        [MemberData(nameof(TestData.Contains), MemberType = typeof(TestData))]
        public void Contains_With_ValidData_And_NullComparer_Should_Succeed(int[] source, int value, bool expected)
        {
            // Arrange
            var wrapped = Wrap.AsReadOnlyList(source);

            // Act
            var result = ReadOnlyList.Contains<Wrap.ReadOnlyList<int>, int>(wrapped, value, null);

            // Assert
            result.Should().Be(expected);
        }  
    }
}