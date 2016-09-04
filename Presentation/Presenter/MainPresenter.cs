﻿using System.Collections.Generic;
using System.Linq;

using DomainModel.Abstract;
using DomainModel.Entity;
using DomainModel.Extentions;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using Presentation.Common;

namespace Presentation.Presenter
{
    public class MainPresenter : IPresenter
    {
        private readonly IView view;
        public static IRepository<Sensor> SensorRepository { get; private set; }
        public static IRepository<Data> DataRepository { get; private set; }
        public static List<Sensor> RequestList { get; private set; }

        public MainPresenter(IView viewParam)
        {
            view = viewParam;
            RequestList = new List<Sensor>();
        }

        public static IEnumerable<Sensor> GetSensorsList()
        {
            return SensorRepository.Get.ToList();
        }

        public static IEnumerable<Data> GetDataList()
        {
            return (from c in DataRepository.Get
                    where c.SensorId == SensorRepository.Get.FirstOrDefault().Id
                    orderby c.Date
                    select c).ToList();
        }

        public static Data GetLastData(Sensor currentSensorParam)
        {
            return DataRepository.SingleDataFilter( d => d.SensorId == currentSensorParam.Id );
        }

        public static Sensor GetSensorByName(string sensorNameParam)
        {
            return SensorRepository.Get.Where( s => s.Name == sensorNameParam ).FirstOrDefault();
        }

        public static GMapOverlay GetMarkersOfSensors()
        {
            var markersOverlay = new GMapOverlay( "markers" );
            markersOverlay.Markers.Clear();

            foreach (Sensor s in SensorRepository.Get)
            {
                if (s.Lat != null && s.Lng != null)
                {
                    GMarkerGoogle marker = new GMarkerGoogle( new PointLatLng( (double)s.Lat, (double)s.Lng ), GMarkerGoogleType.red );

                    markersOverlay.Markers.Add( marker );
                    marker.ToolTipText = s.Name;
                }
            }
            return markersOverlay;
        }

        public void Run(IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            view.Show(sensorRepositoryParam, dataRepositoryParam);
        }
    }
}
