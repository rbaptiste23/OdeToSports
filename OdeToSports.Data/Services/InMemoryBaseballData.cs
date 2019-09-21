using OdeToSports.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToSports.Data.Services
{
   

    public class InMemoryBaseballData : IBaseballData
    {
        List<BaseballPlayer> bb;

        public InMemoryBaseballData()
        {
            bb = new List<BaseballPlayer>()
            {
                new BaseballPlayer{ ID = 1, PlayerName="Dave Stewart", Position = PlayerPosition.Pitcher },
                new BaseballPlayer{ ID = 2, PlayerName="Earl Willams", Position = PlayerPosition.Catcher },
                new BaseballPlayer{ ID = 3, PlayerName="Frank Thomas", Position = PlayerPosition.FirstBase },
                new BaseballPlayer{ ID = 4, PlayerName="Ray Durham", Position = PlayerPosition.SecondBaseman },
                new BaseballPlayer{ ID = 5, PlayerName="Josh Harrison", Position = PlayerPosition.ThirdBaseman },
                new BaseballPlayer{ ID = 6, PlayerName="Ozzie Smith", Position = PlayerPosition.ShortStop },
                new BaseballPlayer{ ID = 7, PlayerName="Barry Bonds", Position = PlayerPosition.LeftFielder },
                new BaseballPlayer{ ID = 8, PlayerName="Ken Griffy Jr.", Position = PlayerPosition.CenterFielder },
                new BaseballPlayer{ ID = 9, PlayerName="Andrew Mccutchen", Position = PlayerPosition.RightFielder },


            };
        }

        public IEnumerable<BaseballPlayer> GetAllInfo()
        {
            return bb.OrderBy(r => r.ID);
        }
    }
}
