﻿using WMS.WinformsClient.LogsBuilder.Abstract;
using WMS.WinformsClient.ViewModels;

namespace WMS.WinformsClient.LogsBuilder.Concrete
{
    public class InfoLogBuilder : LogBuilder
    {
        public override void SetDescription(string additionalDescriptionParam)
        {
            buildingLog.Description = string.Format( "Info: {0}", additionalDescriptionParam ); //TODO: Info description
        }

        public override void SetLevelType()
        {
            buildingLog.LevelType = Level.Info;
        }
    }
}
