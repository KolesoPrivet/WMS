﻿using System.Collections.Generic;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using Presentation.Common;
using Presentation.ViewModels;

using DomainModel.WMSDatabaseService;
using System.Linq;

namespace Presentation.Presenters
{
    public class MainPresenter : Presenter
    {
        #region Fields

        public static List<Sensor> RequestList { get; private set; }


        public static List<Log> LogsList { get; private set; }

        #endregion


        #region Constructors

        public MainPresenter()
        {
            RequestList = new List<Sensor>();

            LogsList = new List<Log>();
        }

        #endregion


        #region Help methods

        public Data GetLastData(Sensor currentSensorParam)
        {
            return GetData().Where( d => d.SensorId == currentSensorParam.Id ).OrderBy( s => s.Date ).AsEnumerable().LastOrDefault();
        }


        public GMapOverlay GetMarkersOfSensors(List<Sensor> sensorsParam)
        {
            GMapOverlay markersOverlay = new GMapOverlay( "markers" );
            markersOverlay.Markers.Clear();

            foreach (Sensor s in sensorsParam) //TODO: Повторный запрос к бд. Оптимизация?
            {
                GMarkerGoogle marker = new GMarkerGoogle( new PointLatLng( s.Lat, s.Lng ), GMarkerGoogleType.red );

                markersOverlay.Markers.Add( marker );
                marker.ToolTipText = s.Name;
            }
            return markersOverlay;
        }


        public override void Run(IView viewParam)
        {
            View = viewParam;

            View.Show();
        }

        #endregion
    }
}