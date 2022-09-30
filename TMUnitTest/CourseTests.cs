namespace TMUnitTest
{
    public class CourseTests
    {
        /// <summary>
        /// A test to check that Level 4 and 5 cannot add more than the require module credits
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="level"></param>
        [Theory]
        [InlineData(40, 4)]
        [InlineData(60, 5)]
        public void NoOptionalAllowedPassOne(int credits, int level)
        {
            //Arrange
            TmLms.TM.Course cource = new TmLms.TM.Course();
            bool isCore = false;

            TmLms.TM.Module module1 = new TmLms.TM.Module("U100", "");
            module1.Credits = (TmLms.TM.Module.CreditEnum) credits ;
            module1.Level = (TmLms.TM.Module.LevelEnum) level;

            //Act
            bool isModuleAdded = cource.AddModule(module1, isCore);

            //Assert
            Assert.False(isModuleAdded);
        }

        /// <summary>
        /// A test to check that Level 6 cannot add more that 100 optional module credits
        /// </summary>
        [Fact]
        public void NoOptionalAllowedPassTwo()
        {
            //Arrange
            TmLms.TM.Course cource = new TmLms.TM.Course();
            bool isCore = false;

            TmLms.TM.Module module1 = new TmLms.TM.Module("U100", "");
            module1.Credits = TmLms.TM.Module.CreditEnum.SIXTY;
            module1.Level = TmLms.TM.Module.LevelEnum.SIX;

            TmLms.TM.Module module2 = new TmLms.TM.Module("U101", "");
            module1.Credits = TmLms.TM.Module.CreditEnum.SIXTY;
            module1.Level = TmLms.TM.Module.LevelEnum.SIX;

            //Act

            bool isModuleAdded = cource.AddModule(module1, isCore);
            bool isModuleNotAdded = cource.AddModule(module2, isCore);

            //Assert
            Assert.False(isModuleAdded);
            Assert.True(isModuleNotAdded);
        }

        /// <summary>
        /// A test to make sure that a course does not exceed 360 Credits.
        /// The course class should only add modules as core or option
        /// Everytime a module is added the course should add all core module credits
        /// and make sure they do not exceedd 360. If an optional module exists it should
        /// only be added in the credit count for the appropriate level. If an optional 
        /// </summary>
        [Theory]
        [InlineData(20, true, 4)]
        [InlineData(20, false, 4)]
        [InlineData(20, true, 5)]
        [InlineData(20, false, 5)]
        [InlineData(20, true, 6)]
        [InlineData(20, false, 6)]
        public void NotExceedingCredits(int Credits, bool IsCore, int Level)
        {
            // Arrange
            TmLms.TM.Course cource = new TmLms.TM.Course();
            for (int i = 4; i < 7; i++)
            {
                TmLms.TM.Module module1 = new TmLms.TM.Module("U100", "");
                module1.Credits = TmLms.TM.Module.CreditEnum.SIXTY;
                module1.Level = (TmLms.TM.Module.LevelEnum)i;

                TmLms.TM.Module module2 = new TmLms.TM.Module("U101", "");
                module2.Credits = TmLms.TM.Module.CreditEnum.SIXTY;
                module2.Level = (TmLms.TM.Module.LevelEnum)i;
                cource.AddModule(module1, true);
                cource.AddModule(module2, true);
            }
            // Act
            TmLms.TM.Module moduleToAdd = new TmLms.TM.Module("U100", "");
            moduleToAdd.Credits = (TmLms.TM.Module.CreditEnum)  Credits;
            moduleToAdd.Level = (TmLms.TM.Module.LevelEnum) Level;
            bool isModuleAdded = cource.AddModule(moduleToAdd, IsCore);

            // Assert
            Assert.False(isModuleAdded);
        }
    }
}