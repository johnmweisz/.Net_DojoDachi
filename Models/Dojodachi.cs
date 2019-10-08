using System;

namespace Dojodachi.Models
{
    public class aDojodachi
    {
        private int Happiness;
        private int Fullness;
        private int Energy;
        private int Meals;

        public aDojodachi()
        {
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meals = 3;
        }
        public string Feed()
        {
            bool isLiked = (new Random().Next(1, 5) != 1);
            int randFullness = new Random().Next(5, 11);
            if(Meals > 0)
            {
                Meals -= 1;
                if(isLiked)
                {
                    Fullness += randFullness;
                    return $"Tutoro was fed a meal and gained {randFullness} fullness.";
                }
                return $"Tutoro did not like the meal.";
            }
            return "You do not have any meals remaining.";
        }
        public string Play()
        {
            bool isLiked = (new Random().Next(1, 5) != 1);
            int randPlay = new Random().Next(5, 11);
            if(Energy >= 5)
            {
                Energy -= 5;
                if(isLiked)
                {
                    Happiness += randPlay;
                    return $"You used 5 energy to play with Tutoro and he gained {randPlay} happiness.";
                }
                return $"Tutoro did not playing.";
            }
            return "You do not have energy remaining.";
        }
        public string Work()
        {
            int randMeal = new Random().Next(1, 4);
            if(Energy >= 5)
            {
                Energy -= 5;
                Meals += randMeal;
                return $"You used 5 energy to work Tutoro and he gained {randMeal} meals.";
            }
            return "You do not have energy remaining.";
        }
        public string Sleep()
        {
            int randEnergy = new Random().Next(10, 21);
            if(Fullness >= 5 && Happiness >= 5)
            {
                Fullness -= 5;
                Happiness -= 5;
                Energy += randEnergy;
                return $"You used 5 fullness and 5 happiness to sleep and he gained {randEnergy} energy.";
            }
            return "You do not have fullness or happiness remaining.";
        }
        public string GetStatus()
        {
            return $"Fullness: {Fullness} Happiness: {Happiness} Meals: {Meals} Energy: {Energy}";
        }
        public bool isWon()
        {
            if(Energy > 100 && Fullness > 100 && Happiness > 100)
            {
                return true;
            }
            return false;
        }
        public bool isLost()
        {
            if(Fullness <= 0 && Happiness <= 0)
            {
                return true;
            }
            return false;
        }
    }
}