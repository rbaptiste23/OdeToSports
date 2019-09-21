using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToSports.Data.Models
{
    public enum PlayerPosition
    {
        Pitcher,
        Catcher,
        [Display(Name="First Basemen")]
        FirstBase,
        [Display(Name ="Second Basemen")]
        SecondBaseman,
        [Display(Name ="Third Basemen")]
        ThirdBaseman,
        [Display(Name = "Short Stop")]
        ShortStop,
        [Display(Name = "Left Fielder")]
        LeftFielder,
        [Display(Name = "Center Fielder")]
        CenterFielder,
        [Display(Name = "Right Fielder")]
        RightFielder,

    }
}
