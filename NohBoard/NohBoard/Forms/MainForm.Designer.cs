/*
Copyright (C) 2016 by Eric Bataille <e.c.p.bataille@gmail.com>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 2 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace ThoNohT.NohBoard.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            UpdateTimer = new System.Windows.Forms.Timer(components);
            MainMenu = new System.Windows.Forms.ContextMenuStrip(components);
            mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            mnuKeyboards = new System.Windows.Forms.ToolStripMenuItem();
            MainMenuSep2 = new System.Windows.Forms.ToolStripSeparator();
            mnuToggleEditMode = new System.Windows.Forms.ToolStripMenuItem();
            mnuUpdateTextPosition = new System.Windows.Forms.ToolStripMenuItem();
            mnuMoveElement = new System.Windows.Forms.ToolStripMenuItem();
            mnuMoveToTop = new System.Windows.Forms.ToolStripMenuItem();
            mnuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            mnuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            mnuMoveToBottom = new System.Windows.Forms.ToolStripMenuItem();
            mnuAddElement = new System.Windows.Forms.ToolStripMenuItem();
            mnuAddKeyboardKeyDefinition = new System.Windows.Forms.ToolStripMenuItem();
            mnuAddMouseKeyDefinition = new System.Windows.Forms.ToolStripMenuItem();
            mnuAddMouseScrollDefinition = new System.Windows.Forms.ToolStripMenuItem();
            mnuAddMouseSpeedIndicatorDefinition = new System.Windows.Forms.ToolStripMenuItem();
            mnuRemoveElement = new System.Windows.Forms.ToolStripMenuItem();
            mnuAddBoundaryPoint = new System.Windows.Forms.ToolStripMenuItem();
            mnuRemoveBoundaryPoint = new System.Windows.Forms.ToolStripMenuItem();
            MainMenuSep1 = new System.Windows.Forms.ToolStripSeparator();
            mnuKeyboardProperties = new System.Windows.Forms.ToolStripMenuItem();
            mnuElementProperties = new System.Windows.Forms.ToolStripMenuItem();
            mnuEditKeyboardStyle = new System.Windows.Forms.ToolStripMenuItem();
            mnuEditElementStyle = new System.Windows.Forms.ToolStripMenuItem();
            MainMenuSep4 = new System.Windows.Forms.ToolStripSeparator();
            mnuSaveDefinition = new System.Windows.Forms.ToolStripMenuItem();
            mnuSaveDefinitionAsName = new System.Windows.Forms.ToolStripMenuItem();
            mnuSaveDefinitionAs = new System.Windows.Forms.ToolStripMenuItem();
            mnuSaveStyle = new System.Windows.Forms.ToolStripMenuItem();
            mnuSaveStyleToName = new System.Windows.Forms.ToolStripMenuItem();
            mnuSaveToGlobalStyleName = new System.Windows.Forms.ToolStripMenuItem();
            mnuSaveStyleAs = new System.Windows.Forms.ToolStripMenuItem();
            MainMenuSep3 = new System.Windows.Forms.ToolStripSeparator();
            borderlessModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            mnuGenerateLog = new System.Windows.Forms.ToolStripMenuItem();
            KeyCheckTimer = new System.Windows.Forms.Timer(components);
            MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // UpdateTimer
            // 
            UpdateTimer.Interval = 33;
            UpdateTimer.Tick += UpdateTimer_Tick;
            // 
            // MainMenu
            // 
            MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuSettings, mnuKeyboards, MainMenuSep2, mnuToggleEditMode, mnuUpdateTextPosition, mnuMoveElement, mnuAddElement, mnuRemoveElement, mnuAddBoundaryPoint, mnuRemoveBoundaryPoint, MainMenuSep1, mnuKeyboardProperties, mnuElementProperties, mnuEditKeyboardStyle, mnuEditElementStyle, MainMenuSep4, mnuSaveDefinition, mnuSaveStyle, MainMenuSep3, borderlessModeToolStripMenuItem, mnuExit, mnuUpdate, mnuGenerateLog });
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new System.Drawing.Size(288, 636);
            MainMenu.Opening += MainMenu_Opening;
            // 
            // mnuSettings
            // 
            mnuSettings.Name = "mnuSettings";
            mnuSettings.Size = new System.Drawing.Size(287, 32);
            mnuSettings.Text = "&Settings";
            mnuSettings.Click += mnuSettings_Click;
            // 
            // mnuKeyboards
            // 
            mnuKeyboards.Name = "mnuKeyboards";
            mnuKeyboards.Size = new System.Drawing.Size(287, 32);
            mnuKeyboards.Text = "&Load Keyboard";
            mnuKeyboards.Click += mnuLoadKeyboard_Click;
            // 
            // MainMenuSep2
            // 
            MainMenuSep2.Name = "MainMenuSep2";
            MainMenuSep2.Size = new System.Drawing.Size(284, 6);
            // 
            // mnuToggleEditMode
            // 
            mnuToggleEditMode.CheckOnClick = true;
            mnuToggleEditMode.Name = "mnuToggleEditMode";
            mnuToggleEditMode.Size = new System.Drawing.Size(287, 32);
            mnuToggleEditMode.Text = "Start &Editing";
            mnuToggleEditMode.Click += mnuToggleEditMode_Click;
            // 
            // mnuUpdateTextPosition
            // 
            mnuUpdateTextPosition.Checked = true;
            mnuUpdateTextPosition.CheckOnClick = true;
            mnuUpdateTextPosition.CheckState = System.Windows.Forms.CheckState.Checked;
            mnuUpdateTextPosition.Name = "mnuUpdateTextPosition";
            mnuUpdateTextPosition.Size = new System.Drawing.Size(287, 32);
            mnuUpdateTextPosition.Text = "&Update Text Position";
            mnuUpdateTextPosition.Click += mnuUpdateTextPosition_Click;
            // 
            // mnuMoveElement
            // 
            mnuMoveElement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuMoveToTop, mnuMoveUp, mnuMoveDown, mnuMoveToBottom });
            mnuMoveElement.Name = "mnuMoveElement";
            mnuMoveElement.Size = new System.Drawing.Size(287, 32);
            mnuMoveElement.Text = "&Move";
            // 
            // mnuMoveToTop
            // 
            mnuMoveToTop.Name = "mnuMoveToTop";
            mnuMoveToTop.Size = new System.Drawing.Size(251, 34);
            mnuMoveToTop.Text = "Move to &top";
            mnuMoveToTop.Click += mnuMoveToTop_Click;
            // 
            // mnuMoveUp
            // 
            mnuMoveUp.Name = "mnuMoveUp";
            mnuMoveUp.Size = new System.Drawing.Size(251, 34);
            mnuMoveUp.Text = "Move &up";
            mnuMoveUp.Click += mnuMoveUp_Click;
            // 
            // mnuMoveDown
            // 
            mnuMoveDown.Name = "mnuMoveDown";
            mnuMoveDown.Size = new System.Drawing.Size(251, 34);
            mnuMoveDown.Text = "Move &down";
            mnuMoveDown.Click += mnuMoveDown_Click;
            // 
            // mnuMoveToBottom
            // 
            mnuMoveToBottom.Name = "mnuMoveToBottom";
            mnuMoveToBottom.Size = new System.Drawing.Size(251, 34);
            mnuMoveToBottom.Text = "Move to &bottom";
            mnuMoveToBottom.Click += mnuMoveToBottom_Click;
            // 
            // mnuAddElement
            // 
            mnuAddElement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuAddKeyboardKeyDefinition, mnuAddMouseKeyDefinition, mnuAddMouseScrollDefinition, mnuAddMouseSpeedIndicatorDefinition });
            mnuAddElement.Name = "mnuAddElement";
            mnuAddElement.Size = new System.Drawing.Size(287, 32);
            mnuAddElement.Text = "&Add Element";
            mnuAddElement.Visible = false;
            // 
            // mnuAddKeyboardKeyDefinition
            // 
            mnuAddKeyboardKeyDefinition.Name = "mnuAddKeyboardKeyDefinition";
            mnuAddKeyboardKeyDefinition.Size = new System.Drawing.Size(351, 34);
            mnuAddKeyboardKeyDefinition.Text = "Add &Keyboard Key";
            mnuAddKeyboardKeyDefinition.Click += mnuAddKeyboardKeyDefinition_Click;
            // 
            // mnuAddMouseKeyDefinition
            // 
            mnuAddMouseKeyDefinition.Name = "mnuAddMouseKeyDefinition";
            mnuAddMouseKeyDefinition.Size = new System.Drawing.Size(351, 34);
            mnuAddMouseKeyDefinition.Text = "Add &Mouse Key";
            mnuAddMouseKeyDefinition.Click += mnuAddMouseKeyDefinition_Click;
            // 
            // mnuAddMouseScrollDefinition
            // 
            mnuAddMouseScrollDefinition.Name = "mnuAddMouseScrollDefinition";
            mnuAddMouseScrollDefinition.Size = new System.Drawing.Size(351, 34);
            mnuAddMouseScrollDefinition.Text = "Add Mouse &Scroll";
            mnuAddMouseScrollDefinition.Click += mnuAddMouseScrollDefinition_Click;
            // 
            // mnuAddMouseSpeedIndicatorDefinition
            // 
            mnuAddMouseSpeedIndicatorDefinition.Name = "mnuAddMouseSpeedIndicatorDefinition";
            mnuAddMouseSpeedIndicatorDefinition.Size = new System.Drawing.Size(351, 34);
            mnuAddMouseSpeedIndicatorDefinition.Text = "Add Mouse Speed &Indicator";
            mnuAddMouseSpeedIndicatorDefinition.Click += mnuAddMouseSpeedIndicatorDefinition_Click;
            // 
            // mnuRemoveElement
            // 
            mnuRemoveElement.Name = "mnuRemoveElement";
            mnuRemoveElement.Size = new System.Drawing.Size(287, 32);
            mnuRemoveElement.Text = "&Remove Element";
            mnuRemoveElement.Visible = false;
            mnuRemoveElement.Click += mnuRemoveElement_Click;
            // 
            // mnuAddBoundaryPoint
            // 
            mnuAddBoundaryPoint.Name = "mnuAddBoundaryPoint";
            mnuAddBoundaryPoint.Size = new System.Drawing.Size(287, 32);
            mnuAddBoundaryPoint.Text = "Add Boundary Point";
            mnuAddBoundaryPoint.Visible = false;
            mnuAddBoundaryPoint.Click += mnuAddBoundaryPoint_Click;
            // 
            // mnuRemoveBoundaryPoint
            // 
            mnuRemoveBoundaryPoint.Name = "mnuRemoveBoundaryPoint";
            mnuRemoveBoundaryPoint.Size = new System.Drawing.Size(287, 32);
            mnuRemoveBoundaryPoint.Text = "Remove Boundary Point";
            mnuRemoveBoundaryPoint.Visible = false;
            mnuRemoveBoundaryPoint.Click += mnuRemoveBoundaryPoint_Click;
            // 
            // MainMenuSep1
            // 
            MainMenuSep1.Name = "MainMenuSep1";
            MainMenuSep1.Size = new System.Drawing.Size(284, 6);
            // 
            // mnuKeyboardProperties
            // 
            mnuKeyboardProperties.Name = "mnuKeyboardProperties";
            mnuKeyboardProperties.Size = new System.Drawing.Size(287, 32);
            mnuKeyboardProperties.Text = "Keyboard &Properties";
            mnuKeyboardProperties.Click += mnuKeyboardProperties_Click;
            // 
            // mnuElementProperties
            // 
            mnuElementProperties.Enabled = false;
            mnuElementProperties.Name = "mnuElementProperties";
            mnuElementProperties.Size = new System.Drawing.Size(287, 32);
            mnuElementProperties.Text = "Element &Properties";
            mnuElementProperties.Click += mnuElementProperties_Click;
            // 
            // mnuEditKeyboardStyle
            // 
            mnuEditKeyboardStyle.Name = "mnuEditKeyboardStyle";
            mnuEditKeyboardStyle.Size = new System.Drawing.Size(287, 32);
            mnuEditKeyboardStyle.Text = "Keyboard &Style";
            mnuEditKeyboardStyle.Click += mnuEditKeyboardStyle_Click;
            // 
            // mnuEditElementStyle
            // 
            mnuEditElementStyle.Enabled = false;
            mnuEditElementStyle.Name = "mnuEditElementStyle";
            mnuEditElementStyle.Size = new System.Drawing.Size(287, 32);
            mnuEditElementStyle.Text = "Element &Style";
            mnuEditElementStyle.Visible = false;
            mnuEditElementStyle.Click += mnuEditElementStyle_Click;
            // 
            // MainMenuSep4
            // 
            MainMenuSep4.Name = "MainMenuSep4";
            MainMenuSep4.Size = new System.Drawing.Size(284, 6);
            // 
            // mnuSaveDefinition
            // 
            mnuSaveDefinition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuSaveDefinitionAsName, mnuSaveDefinitionAs });
            mnuSaveDefinition.Name = "mnuSaveDefinition";
            mnuSaveDefinition.Size = new System.Drawing.Size(287, 32);
            mnuSaveDefinition.Text = "Save &Definition";
            // 
            // mnuSaveDefinitionAsName
            // 
            mnuSaveDefinitionAsName.Name = "mnuSaveDefinitionAsName";
            mnuSaveDefinitionAsName.Size = new System.Drawing.Size(343, 34);
            mnuSaveDefinitionAsName.Text = "&Save &To <DefinitionName>";
            mnuSaveDefinitionAsName.Click += mnuSaveDefinitionAsName_Click;
            // 
            // mnuSaveDefinitionAs
            // 
            mnuSaveDefinitionAs.Name = "mnuSaveDefinitionAs";
            mnuSaveDefinitionAs.Size = new System.Drawing.Size(343, 34);
            mnuSaveDefinitionAs.Text = "Save &As";
            mnuSaveDefinitionAs.Click += mnuSaveDefinitionAs_Click;
            // 
            // mnuSaveStyle
            // 
            mnuSaveStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuSaveStyleToName, mnuSaveToGlobalStyleName, mnuSaveStyleAs });
            mnuSaveStyle.Name = "mnuSaveStyle";
            mnuSaveStyle.Size = new System.Drawing.Size(287, 32);
            mnuSaveStyle.Text = "Save St&yle";
            // 
            // mnuSaveStyleToName
            // 
            mnuSaveStyleToName.Name = "mnuSaveStyleToName";
            mnuSaveStyleToName.Size = new System.Drawing.Size(361, 34);
            mnuSaveStyleToName.Text = "&Save To <StyleName>";
            mnuSaveStyleToName.Click += mnuSaveStyleToName_Click;
            // 
            // mnuSaveToGlobalStyleName
            // 
            mnuSaveToGlobalStyleName.Name = "mnuSaveToGlobalStyleName";
            mnuSaveToGlobalStyleName.Size = new System.Drawing.Size(361, 34);
            mnuSaveToGlobalStyleName.Text = "Save To &Global <StyleName>";
            mnuSaveToGlobalStyleName.Click += mnuSaveToGlobalStyleName_Click;
            // 
            // mnuSaveStyleAs
            // 
            mnuSaveStyleAs.Name = "mnuSaveStyleAs";
            mnuSaveStyleAs.Size = new System.Drawing.Size(361, 34);
            mnuSaveStyleAs.Text = "Save &As";
            mnuSaveStyleAs.Click += mnuSaveStyleAs_Click;
            // 
            // MainMenuSep3
            // 
            MainMenuSep3.Name = "MainMenuSep3";
            MainMenuSep3.Size = new System.Drawing.Size(284, 6);
            // 
            // borderlessModeToolStripMenuItem
            // 
            borderlessModeToolStripMenuItem.CheckOnClick = true;
            borderlessModeToolStripMenuItem.Name = "borderlessModeToolStripMenuItem";
            borderlessModeToolStripMenuItem.Size = new System.Drawing.Size(287, 32);
            borderlessModeToolStripMenuItem.Text = "Overlay Mode";
            borderlessModeToolStripMenuItem.Click += borderlessModeToolStripMenuItem_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new System.Drawing.Size(287, 32);
            mnuExit.Text = "E&xit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuUpdate
            // 
            mnuUpdate.Name = "mnuUpdate";
            mnuUpdate.Size = new System.Drawing.Size(287, 32);
            mnuUpdate.Text = "Update available";
            mnuUpdate.Visible = false;
            // 
            // mnuGenerateLog
            // 
            mnuGenerateLog.Name = "mnuGenerateLog";
            mnuGenerateLog.Size = new System.Drawing.Size(287, 32);
            mnuGenerateLog.Text = "Generate crash log";
            mnuGenerateLog.Click += mnuGenerateLog_Click;
            // 
            // KeyCheckTimer
            // 
            KeyCheckTimer.Interval = 1000;
            KeyCheckTimer.Tick += KeyCheckTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(521, 482);
            ContextMenuStrip = MainMenu;
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6);
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "NohBoard";
            Deactivate += MainForm_Deactivate;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResizeEnd += MainForm_ResizeEnd;
            DoubleClick += MainForm_DoubleClick;
            KeyUp += MainForm_KeyUp;
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            MouseUp += MainForm_MouseUp;
            Move += MainForm_Move;
            MainMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuKeyboards;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripSeparator MainMenuSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuToggleEditMode;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveStyle;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveStyleToName;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveStyleAs;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveDefinition;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveDefinitionAsName;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveDefinitionAs;
        private System.Windows.Forms.ToolStripSeparator MainMenuSep2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditKeyboardStyle;
        private System.Windows.Forms.ToolStripMenuItem mnuEditElementStyle;
        private System.Windows.Forms.ToolStripSeparator MainMenuSep3;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveToGlobalStyleName;
        private System.Windows.Forms.Timer KeyCheckTimer;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveElement;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveToTop;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveUp;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveDown;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveToBottom;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBoundaryPoint;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveBoundaryPoint;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveElement;
        private System.Windows.Forms.ToolStripMenuItem mnuAddElement;
        private System.Windows.Forms.ToolStripMenuItem mnuAddKeyboardKeyDefinition;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMouseKeyDefinition;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMouseScrollDefinition;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMouseSpeedIndicatorDefinition;
        private System.Windows.Forms.ToolStripMenuItem mnuElementProperties;
        private System.Windows.Forms.ToolStripSeparator MainMenuSep4;
        private System.Windows.Forms.ToolStripMenuItem mnuKeyboardProperties;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateTextPosition;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateLog;
        private System.Windows.Forms.ToolStripMenuItem borderlessModeToolStripMenuItem;
    }
}

