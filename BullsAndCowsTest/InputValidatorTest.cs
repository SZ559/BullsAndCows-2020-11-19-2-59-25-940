﻿using BullsAndCows;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace BullsAndCowsTest
{
    public class InputValidatorTest
    {
        [Fact]
        public void Should_Return_True_If_Format_Is_Correct()
        {
            //when
            //new Regex(@"^([0-9]\s){3}[0-9]$")
            var actual = new InputValidator().IsValidGuess("0 1 2 3");
            //then
            Assert.True(actual);
        }
    }
}