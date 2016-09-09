﻿using Presentation.Presenters;
using Presentation.Common;

using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace UI.Views
{
    public partial class SaveAsForm : Form, IView
    {
        public SaveAsForm()
        {
            InitializeComponent();
        }

        private string _filePath;
        private readonly Regex regexPatternForTime = new Regex( "^(([0,1][0-9])|(2[0-3])):[0-5][0-9]$" );

        public Presenter OwnPresenter
        {
            get
            {
                return OwnPresenter;
            }

            set
            {
                if (value != null)
                {
                    OwnPresenter = value;
                }
            }
        }

        private void SaveAsForm_Load(object sender, EventArgs e)
        {
            foreach (var s in OwnPresenter.GetSensorsNames())
            {
                comboBoxSensorName.Items.Add( s );
            }

            foreach (var s in OwnPresenter.GetSensorsTypes())
            {
                if(!comboBoxSensorType.Items.Contains(s))
                    comboBoxSensorType.Items.Add( s );
            }
        }

        private void btnPathExplorer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                _filePath = folderBrowser.SelectedPath;
        }

        private async void btnSaveFile_Click(object sender, EventArgs e)
        {
            await Task.Factory.StartNew( () =>
             {
                 if (!txtBoxFirstTimeValue.Enabled)
                 {
                     SaveAsPresenter.FinalList.AddRange( OwnPresenter.GetData( chBoxDates.CheckedItems.OfType<DateTime>() ) );

                 }
                 else
                 {

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
            //TODO: filter comboboxSensorName by sensor type
            foreach (var s in ((SelectSensorsPresenter)OwnPresenter).GetSensorsNames( comboBoxSensorType.Text ))
            {
                comboBoxSensorName.Items.Add( s );
            }
        }

        private void comboBoxSensorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: filter chBox by sensor name
        }
    }
}
