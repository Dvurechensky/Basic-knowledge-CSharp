using System;
using System.Collections.Generic;

namespace Lesson_22___Вложенные_циклы.Как_работают
{
    public class GameInfo
    {
        public GameType TypeOfGame { get; set; }
        
        public List<Game> Games { get; set; }
    }

    public enum GameType
    {
        RPG,
        Shooter,
        Strategy
    }
}
