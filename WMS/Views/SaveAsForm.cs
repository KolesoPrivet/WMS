﻿using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

using Presentation.Presenters;
using Presentation.Common;

using DomainModel.Entity;

namespace UI.Views
{
    public partial class SaveAsForm : Form, IView
    {
        private string filePath = Environment.CurrentDirectory;
        private readonly Regex regexPatternForTime = new Regex( "^(([0,1][0-9])|(2[0-3])):[0-5][0-9]$" );
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

        public SaveAsForm()
        {
            InitializeComponent();
        }

        private void SaveAsForm_Load(object sender, EventArgs e)
        {
            foreach (var s in OwnPresenter.GetSensorsNames())
            {
                comboBoxSensorName.Items.Add( s );
            }

            foreach (var s in OwnPresenter.GetSensorsTypes())
            {
                if (!comboBoxSensorType.Items.Contains( s ))
                    comboBoxSensorType.Items.Add( s );
            }
        }

        private void btnPathExplorer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                filePath = folderBrowser.SelectedPath;
        }

        private async void btnSaveFile_Click(object sender, EventArgs e)
        {
            await Task.Factory.StartNew( () =>
             {
                 if (!txtBoxFirstTimeValue.Enabled)
                 {
                     FinalList.AddRange( OwnPresenter.GetData( chBoxDates.CheckedItems.OfType<DateTime>() ) );
                     ((SaveAsPresenter)OwnPresenter).SaveFileExcel( FinalList, filePath, txtBoxFileName.Text );
                 }
                 else
                 {
                     //TODO: filter data by time interval
                 }
             } );
        }

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

        private void comboBoxSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSensorName.Items.Clear();

            foreach (var s in OwnPresenter.GetSensorsNames( comboBoxSensorType.Text ))
            {
                comboBoxSensorName.Items.Add( s );
            }
        }

        private void comboBoxSensorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var d in OwnPresenter.GetDates( comboBoxSensorName.Text ).OrderBy( d => d.Date ).ToList())
                chBoxDates.Items.Add( d );

            chBoxDates.Enabled = true;
            checkBoxEnableTimeInterval.Enabled = true;
            btnSaveFile.Enabled = true;
        }
    }
}
