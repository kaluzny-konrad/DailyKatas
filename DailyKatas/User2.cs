namespace User2
{
    public class User
    {
        public User()
        {
            _rank = INIT_RANK;
            _progress = INIT_PROGRESS;
        }

        public void incProgress(int activityRank)
        {
            AddProgressByActivityRank(activityRank);
            LevelUpIfProgressLimitHasBeenReached();
            ResetProgressIfUserHasBeenReachedMaxRank();
        }

        private void AddProgressByActivityRank(int activityRank)
        {
            if (activityRank > 8 || activityRank < -8 || activityRank == 0)
            {
                throw new ArgumentException();
            }
            if (activityRank > rank)
            {
                AddProgressByHigherRankActivity(activityRank);
            }
            else if (activityRank == rank)
            {
                AddProgressBySameRankActivity();
            }
            else if (activityRank < rank)
            {
                AddProgressByLowerRankActivity(activityRank);
            }
        }

        private void AddProgressByHigherRankActivity(int activityRank)
        {
            var difference = activityRank - rank;
            difference = rank < 0 && activityRank > 0 ? difference - 1 : difference;
            _progress += HIGHER_RANK_POINTS_MULTIPLY * difference * difference;
        }

        private void AddProgressBySameRankActivity()
        {
            _progress += SAME_RANK_POINTS;
        }

        private void AddProgressByLowerRankActivity(int activityRank)
        {
            var difference = rank - activityRank;
            difference = rank > 0 && activityRank < 0 ? difference - 1 : difference;
            _progress = difference == 1 ? progress + ONE_LEVEL_LOWER_RANK_POINTS : progress;
        }

        private void LevelUpIfProgressLimitHasBeenReached()
        {
            if (progress >= MAX_PROGRESS)
            {
                var levelUp = progress / MAX_PROGRESS;
                _progress = progress % MAX_PROGRESS;
                _rank = rank < 0 && rank + levelUp >= 0 ? rank + 1 : rank;
                _rank += levelUp;
            }
        }

        private void ResetProgressIfUserHasBeenReachedMaxRank()
        {
            if (rank >= MAX_RANK)
            {
                _rank = MAX_RANK;
                _progress = 0;
            }
        }

        public int rank => _rank;
        public int progress => _progress;

        private int _rank;
        private int _progress;

        private const int MAX_RANK = 8;
        private const int HIGHER_RANK_POINTS_MULTIPLY = 10;
        private const int SAME_RANK_POINTS = 3;
        private const int ONE_LEVEL_LOWER_RANK_POINTS = 1;
        private const int INIT_RANK = -8;
        private const int INIT_PROGRESS = 0;
        private const int MAX_PROGRESS = 100;
    }
}
