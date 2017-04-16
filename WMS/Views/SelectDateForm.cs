﻿using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using Presentation.Common;

using WMS.Domain.WMSDatabaseService;
using WMS.Domain.Cache;

namespace WMS.WinformsClient.Views
{
    public partial class SelectDateForm : Form, IView
    {
        #region Fields

        private readonly Regex _regexPatternForTime = new Regex( "^(([0,1][0-9])|(2[0-3])):[0-5][0-9]$" );


        public static List<Data> FinalList { get; } = new List<Data>();


        private Presenter _ownPresenter;
        public Presenter OwnPresenter
        {
            get
            {
                return _ownPresenter;
            }

            set
            {
                if (value != null)
                {
                    _ownPresenter = value;
                }
            }
        }

        #endregion


        #region Constructors

        public SelectDateForm()
        {
            InitializeComponent();
        }


        private void SelectDateForm_Load(object sender, EventArgs e)
        {
            dgvForSensorSelection.DataSource = CacheEntity.CurrentSensors;

            SettingDataGridViewColumns();
        }


        #endregion


        #region Setting and auxiliary methods

        private void WarningTime()
        {
            toolTipForSelectDateForm.ToolTipTitle = "Внимание!";
            toolTipForSelectDateForm.SetToolTip( txtBoxFirstTimeValue, "Введите время в 24-часовом формате. 00:00" );
            toolTipForSelectDateForm.SetToolTip( txtBoxSecondTimeValue, "Введите время в 24-часовом формате. 00:00" );
        }


        private void SetCheckboxItems()
        {
            chBoxDates.Items.Clear();

            Sensor currentSensor = dgvForSensorSelection.CurrentRow.DataBoundItem as Sensor;

            List<DateTime> currentSensorDates = OwnPresenter.GetDates( currentSensor.Id ).Distinct().ToList();

            if (currentSensorDates != null)
            {
                foreach (DateTime d in currentSensorDates)
                {
                    chBoxDates.Items.Add( d );
                }
            }
        }


        private void SettingDataGridViewColumns()
        {
            dgvForSensorSelection.Columns["Id"].Visible = false;
            dgvForSensorSelection.Columns["Lat"].Visible = false;
            dgvForSensorSelection.Columns["Lng"].Visible = false;
            dgvForSensorSelection.Columns["Radius"].Visible = false;

            dgvForSensorSelection.Columns["SensorType"].Name = "Sensor type";
        }

        #endregion


        #region Controls

        private void checkBoxEnableTimeInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxFirstTimeValue.Enabled)
            {
                txtBoxFirstTimeValue.Enabled = false;
                txtBoxSecondTimeValue.Enabled = false;
            }
            else
            {
                txtBoxFirstTimeValue.Enabled = true;
                txtBoxSecondTimeValue.Enabled = true;
            }
        }


        private void btnAcceptSelection_Click(object sender, EventArgs e)
        {
            FinalList.Clear();

            if (!txtBoxFirstTimeValue.Enabled)
            {
                foreach (var d in OwnPresenter.GetDataByDates( chBoxDates.CheckedItems.OfType<DateTime>() ))
                {
                    if (!FinalList.Contains( d ))
                        FinalList.Add( d );
                }


                Close();
            }
            else
            {
                if (_regexPatternForTime.IsMatch( txtBoxFirstTimeValue.Text )
                    && _regexPatternForTime.IsMatch( txtBoxSecondTimeValue.Text ))
                {
                    FinalList.AddRange( OwnPresenter.GetDataByDates( chBoxDates.CheckedItems.OfType<DateTime>(),
                                        TimeSpan.Parse( txtBoxFirstTimeValue.Text ),
                                        TimeSpan.Parse( txtBoxSecondTimeValue.Text ) ) );

                    Close();
                }
                else
                {
                    MessageBox.Show( "Неккоректный ввод времени!" );
                }
            }
        }


        private void dgvForSensorSelection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetCheckboxItems();
        }


        private void txtBoxFirstTimeValue_MouseEnter(object sender, EventArgs e)
        {
            WarningTime();
        }


        private void txtBoxSecondTimeValue_MouseEnter(object sender, EventArgs e)
        {
            WarningTime();
        }

        #endregion

    }
}
