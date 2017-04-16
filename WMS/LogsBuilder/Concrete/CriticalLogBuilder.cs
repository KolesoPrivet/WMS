﻿using WMS.WinformsClient.LogsBuilder.Abstract;
using WMS.WinformsClient.ViewModels;

namespace WMS.WinformsClient.LogsBuilder.Concrete
{
    public class CriticalLogBuilder : LogBuilder
    {   
        public override void SetDescription(string additionalDescriptionParam)
        {
            buildingLog.Description = string.Format( "Description \n{0}", additionalDescriptionParam ); //TODO: Critical description
        }

        public override void SetLevelType()
        {
            buildingLog.LevelType = Level.Critical;
        }
    }
}
