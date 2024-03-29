﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToSports.Data.Models
{
    public interface IBaseballData
    {
        IEnumerable<BaseballPlayer> GetAllInfo();
        BaseballPlayer Get(int id);

        void Add(BaseballPlayer baseballPlayer);

        void Update(BaseballPlayer baseballPlayer);

        void Delete(int id);

    }
}
