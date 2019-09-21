using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToSports.Data.Models
{
    public interface IBaseballData
    {
        IEnumerable<BaseballPlayer> GetAllInfo();


    }
}
