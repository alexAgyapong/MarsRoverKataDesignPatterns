using MarsRoverKata.Domain.Commands;
using NUnit.Framework;
using System.Collections.Generic;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    public class CommandParserShould
    {
        private Dictionary<string, ICommand> availableCommands;

        [SetUp]
        public void SetUp()
        {
            availableCommands = AvailableCommands.AllCommands;
        }

        [Test]
        public void Get_Correct_Command_To_Move()
        {
            var commandParser = new CommandParser(availableCommands);
            var command = commandParser.ParseCommand("M");

            Assert.That(command, Is.TypeOf<MoveCommand>());
        }

        [Test]
        public void Get_Correct_Command_To_Rotate_Right()
        {
            var commandParser = new CommandParser(availableCommands);
            var command = commandParser.ParseCommand("R");

            Assert.That(command, Is.TypeOf<RotateRightCommand>());
        }

        [Test]
        public void Get_Correct_Command_To_Rotate_Left()
        {
            var commandParser = new CommandParser(availableCommands);
            var command = commandParser.ParseCommand("L");

            Assert.That(command, Is.TypeOf<RotateLeftCommand>());
        }
    }
}