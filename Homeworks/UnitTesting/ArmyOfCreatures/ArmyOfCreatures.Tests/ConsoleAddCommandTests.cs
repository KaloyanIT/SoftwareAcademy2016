
using System;
using ArmyOfCreatures.Console;
using ArmyOfCreatures.Console.Commands;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using Moq;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace ArmyOfCreatures.Tests
{
    [TestFixture]
    public class ConsoleAddCommandTests
    {
        [Test]
        public void ProcessCommand_ShouldThrowNullException_WhenBattleManagerIsNull()
        {
            IBattleManager battleManager = null;
            string[] parameters = new[] {"pesho", "ivan", "dragan", "moqn"};
            AddCommand command = new AddCommand();
            var fixtures = new Fixture();
            try
            {
                command.ProcessCommand(battleManager, parameters);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(ex.Message, "Value cannot be null.\r\nParameter name: battleManager");
            }
        }

        [Test]
        public void ProcessCommand_ShouldThrowNullException_WhensStringParametersIsNull()
        {
            var mockedCreatureFactory = new Mock<ICreaturesFactory>();
            var mockedConsoleLogger = new Mock<ConsoleLogger>();
            IBattleManager battleManager = new BattleManager(mockedCreatureFactory.Object, mockedConsoleLogger.Object);
            string[] parameters = null;
            AddCommand command = new AddCommand();
            var fixtures = new Fixture();
            try
            {
                command.ProcessCommand(battleManager, parameters);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(ex.ParamName, "arguments");
            }
        }

        [Test]
        public void ProcessCommand_ShouldThrowNullException_WhensStringParametersIsInvalid()
        {
            var mockedCreatureFactory = new Mock<ICreaturesFactory>();
            var mockedConsoleLogger = new Mock<ConsoleLogger>();
            IBattleManager battleManager = new BattleManager(mockedCreatureFactory.Object, mockedConsoleLogger.Object);
            string[] parameters = new[] {"2", "Pesho" };
            AddCommand command = new AddCommand();
            var fixtures = new Fixture();
            try
            {
                command.ProcessCommand(battleManager, parameters);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(ex.ParamName, "Invalid number of arguments for add command");
            }
        }



    }
}