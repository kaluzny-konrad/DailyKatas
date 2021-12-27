using NUnit.Framework;

namespace User.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void UserCanBeCreated()
        {
            // Act
            User user = new User();

            // Assert
            Assert.NotNull(user);
        }

        [Test]
        public void UserHasCorrectInitialRank()
        {
            // Arrange
            var expectedRank = -8;

            // Act
            User user = new User();

            // Assert
            Assert.AreEqual(expectedRank, user.rank);
        }

        [Test]
        public void UserHasCorrectInitialProgress()
        {
            // Arrange
            var expectedProgress = 0;

            // Act
            User user = new User();

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
        }

        [Test]
        public void NewUserGetsCorrectProgressForCompleting_OneLevelHigherRankedActivity()
        {
            // Arrange
            User user = new User();
            var newUserRank = user.rank;
            var activityRank = newUserRank + 1;
            var expectedProgress = 10;

            // Act
            user.incProgress(activityRank);

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
        }

        [Test]
        public void NewUserGetsCorrectProgressForCompleting_ThreeLevelHigherRankedActivity()
        {
            // Arrange
            User user = new User();
            var newUserRank = user.rank;
            var activityRank = newUserRank + 3;
            var expectedProgress = 90;

            // Act
            user.incProgress(activityRank);

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
        }

        [Test]
        public void NewUserGetsCorrectProgressForCompleting_ExactRankedActivity()
        {
            // Arrange
            User user = new User();
            var newUserRank = user.rank;
            var activityRank = newUserRank;
            var expectedProgress = 3;

            // Act
            user.incProgress(activityRank);

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
        }

        [Test]
        public void UserGetsCorrectProgressForCompleting_OneLevelLowerRankedActivity()
        {
            // Arrange
            User user = new User();
            user.incProgress(user.rank + 1);
            user.incProgress(user.rank + 3);
            var userRank = user.rank;
            var activityRank = userRank - 1;
            var expectedProgress = 1;

            // Act
            user.incProgress(activityRank);

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
        }

        [Test]
        public void NewUserGetsMinusOneLevel_AfterOneAndThreeHigherRankedActivitySevenTimes()
        {
            // Arrange
            var expectedProgress = 0;
            var expectedRank = -1;
            User user = new User();

            // Act
            for (int i = 0; i < 7; i++)
            {
                var oneLevelHigher = user.rank + 1 == 0 ? 1 : user.rank + 1;
                var threeLevelHigher = user.rank + 3 >= 0 ? user.rank + 4 : user.rank + 3;
                user.incProgress(oneLevelHigher);
                user.incProgress(threeLevelHigher);
            }

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
            Assert.AreEqual(expectedRank, user.rank);
        }

        [Test]
        public void UserMinusOneLevel_GetsCorrectProgressForCompleting_OneLevelHigherRankedActivity()
        {
            // Arrange
            User user = new User();
            for (int i = 0; i < 7; i++)
            {
                var oneLevelHigher = user.rank + 1 == 0 ? 1 : user.rank + 1;
                var threeLevelHigher = user.rank + 3 >= 0 ? user.rank + 4 : user.rank + 3;
                user.incProgress(oneLevelHigher);
                user.incProgress(threeLevelHigher);
            }

            Assert.AreEqual(-1, user.rank);
            Assert.AreEqual(0, user.progress);

            var activityRank = 1;
            var expectedProgress = 10;

            // Act
            user.incProgress(activityRank);

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
        }

        [Test]
        public void NewUserGetsCorrectProgressForCompleting_TwoLevelHigherRankedAcitivity_TwoTimes()
        {
            // Arrange
            User user = new User();
            var newUserRank = user.rank;
            var activityRank = newUserRank + 2;
            var expectedProgress = 80;

            // Act
            user.incProgress(activityRank);
            user.incProgress(activityRank);

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
        }

        [Test]
        public void NewUserGetsPromotionForCompleting_OneAndThreeLevelHigherRankedActivity()
        {
            // Arrange
            User user = new User();
            var newUserRank = user.rank;
            var firstActivityRank = newUserRank + 1;
            var secondActivityRank = newUserRank + 3;
            var expectedProgress = 0;
            var expectedRank = newUserRank + 1;

            // Act
            user.incProgress(firstActivityRank);
            user.incProgress(secondActivityRank);

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
            Assert.AreEqual(expectedRank, user.rank);
        }

        [Test]
        public void NewUserGetsPromotionForCompleting_TwoAndThreeLevelHigherRankedActivity()
        {
            // Arrange
            User user = new User();
            var newUserRank = user.rank;
            var firstActivityRank = newUserRank + 2;
            var secondActivityRank = newUserRank + 3;
            var expectedProgress = 30;
            var expectedRank = newUserRank + 1;

            // Act
            user.incProgress(firstActivityRank);
            user.incProgress(secondActivityRank);

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
            Assert.AreEqual(expectedRank, user.rank);
        }

        [Test]
        public void NewUserGetsPromotionForCompleting_FiveLevelHigherRankedActivity()
        {
            // Arrange
            User user = new User();
            var newUserRank = user.rank;
            var activityRank = newUserRank + 5;
            var expectedProgress = 50;
            var expectedRank = newUserRank + 2;

            // Act
            user.incProgress(activityRank);

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
            Assert.AreEqual(expectedRank, user.rank);
        }

        [Test]
        public void NewUserGetsMaxLevel_AfterCompleteOneMaxRankedActivity()
        {
            // Arrange
            User user = new User();
            var maxActivityLevel = 8;
            var expectedProgress = 0;
            var expectedRank = 8;

            // Act
            user.incProgress(maxActivityLevel);

            // Assert
            Assert.AreEqual(expectedProgress, user.progress);
            Assert.AreEqual(expectedRank, user.rank);
        }

        [Test]
        public void NewUserGetsMaxLevel_AfterCompleteOneLevelLowerActivity1500Times()
        {
            // Arrange
            User user = new User();
            var expectedProgress = 0;
            var expectedRank = 8;

            // Act
            for (int i = 0; i < 1500; i++)
            {
                if (user.rank == 1)
                {
                    user.incProgress(-1);
                }
                else if (user.rank == -8)
                {
                    user.incProgress(-8);
                }
                else
                {
                    user.incProgress(user.rank - 1);
                }
            }

            // Assert
            Assert.AreEqual(expectedProgress, user.progress, "progress");
            Assert.AreEqual(expectedRank, user.rank, "rank");
        }

        [Test]
        [TestCase(9)]
        [TestCase(-9)]
        [TestCase(0)]
        public void TestInvalidRangeNine(int progressLevel)
        {
            // Arrange
            User user = new User();
            Assert.That(() => user.incProgress(progressLevel),
                Throws.Exception.TypeOf<System.ArgumentException>());
        }
    }
}
