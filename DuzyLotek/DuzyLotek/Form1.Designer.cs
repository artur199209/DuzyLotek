﻿namespace DuzyLotek
{
    partial class Form1
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
        private void InitializeComponent()
        {
			this.lastScoresLabel = new System.Windows.Forms.Label();
			this.lastScoresDate = new System.Windows.Forms.Label();
			this.lastScores = new System.Windows.Forms.Label();
			this.drawScores = new System.Windows.Forms.Button();
			this.loadFromFile = new System.Windows.Forms.Button();
			this.loadFromWeb = new System.Windows.Forms.Button();
			this.checkUpdatesButton = new System.Windows.Forms.Button();
			this.DataGridView = new System.Windows.Forms.DataGridView();
			this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Liczba1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Liczba2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Liczba3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Liczba4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Liczba5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Liczba6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.viewDataFromDatabase = new System.Windows.Forms.Button();
			this.sinceDate = new System.Windows.Forms.DateTimePicker();
			this.toDate = new System.Windows.Forms.DateTimePicker();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// lastScoresLabel
			// 
			this.lastScoresLabel.AutoSize = true;
			this.lastScoresLabel.Location = new System.Drawing.Point(27, 16);
			this.lastScoresLabel.Name = "lastScoresLabel";
			this.lastScoresLabel.Size = new System.Drawing.Size(81, 13);
			this.lastScoresLabel.TabIndex = 0;
			this.lastScoresLabel.Text = "Ostatnie wyniki:";
			// 
			// lastScoresDate
			// 
			this.lastScoresDate.AutoSize = true;
			this.lastScoresDate.Location = new System.Drawing.Point(114, 16);
			this.lastScoresDate.Name = "lastScoresDate";
			this.lastScoresDate.Size = new System.Drawing.Size(0, 13);
			this.lastScoresDate.TabIndex = 4;
			// 
			// lastScores
			// 
			this.lastScores.AutoSize = true;
			this.lastScores.Location = new System.Drawing.Point(192, 16);
			this.lastScores.Name = "lastScores";
			this.lastScores.Size = new System.Drawing.Size(0, 13);
			this.lastScores.TabIndex = 5;
			// 
			// drawScores
			// 
			this.drawScores.Location = new System.Drawing.Point(448, 254);
			this.drawScores.Name = "drawScores";
			this.drawScores.Size = new System.Drawing.Size(113, 23);
			this.drawScores.TabIndex = 6;
			this.drawScores.Text = "Losuj";
			this.drawScores.UseVisualStyleBackColor = true;
			this.drawScores.Click += new System.EventHandler(this.drawScores_Click);
			// 
			// loadFromFile
			// 
			this.loadFromFile.Location = new System.Drawing.Point(30, 254);
			this.loadFromFile.Name = "loadFromFile";
			this.loadFromFile.Size = new System.Drawing.Size(118, 23);
			this.loadFromFile.TabIndex = 7;
			this.loadFromFile.Text = "Załaduj z pliku";
			this.loadFromFile.UseVisualStyleBackColor = true;
			this.loadFromFile.Click += new System.EventHandler(this.loadFromFile_Click);
			// 
			// loadFromWeb
			// 
			this.loadFromWeb.Location = new System.Drawing.Point(170, 254);
			this.loadFromWeb.Name = "loadFromWeb";
			this.loadFromWeb.Size = new System.Drawing.Size(111, 23);
			this.loadFromWeb.TabIndex = 8;
			this.loadFromWeb.Text = "Załaduj ze strony";
			this.loadFromWeb.UseVisualStyleBackColor = true;
			this.loadFromWeb.Click += new System.EventHandler(this.loadFromWeb_Click);
			// 
			// checkUpdatesButton
			// 
			this.checkUpdatesButton.Location = new System.Drawing.Point(307, 254);
			this.checkUpdatesButton.Name = "checkUpdatesButton";
			this.checkUpdatesButton.Size = new System.Drawing.Size(123, 23);
			this.checkUpdatesButton.TabIndex = 9;
			this.checkUpdatesButton.Text = "Sprawdź aktualizacje";
			this.checkUpdatesButton.UseVisualStyleBackColor = true;
			this.checkUpdatesButton.Click += new System.EventHandler(this.checkUpdatesButton_Click);
			// 
			// DataGridView
			// 
			this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Liczba1,
            this.Liczba2,
            this.Liczba3,
            this.Liczba4,
            this.Liczba5,
            this.Liczba6});
			this.DataGridView.Location = new System.Drawing.Point(30, 56);
			this.DataGridView.Name = "DataGridView";
			this.DataGridView.Size = new System.Drawing.Size(445, 147);
			this.DataGridView.TabIndex = 10;
			// 
			// Data
			// 
			this.Data.HeaderText = "Data";
			this.Data.Name = "Data";
			this.Data.ReadOnly = true;
			// 
			// Liczba1
			// 
			this.Liczba1.HeaderText = "1";
			this.Liczba1.Name = "Liczba1";
			this.Liczba1.ReadOnly = true;
			this.Liczba1.Width = 50;
			// 
			// Liczba2
			// 
			this.Liczba2.HeaderText = "2";
			this.Liczba2.Name = "Liczba2";
			this.Liczba2.ReadOnly = true;
			this.Liczba2.Width = 50;
			// 
			// Liczba3
			// 
			this.Liczba3.HeaderText = "3";
			this.Liczba3.Name = "Liczba3";
			this.Liczba3.Width = 50;
			// 
			// Liczba4
			// 
			this.Liczba4.HeaderText = "4";
			this.Liczba4.Name = "Liczba4";
			this.Liczba4.Width = 50;
			// 
			// Liczba5
			// 
			this.Liczba5.HeaderText = "5";
			this.Liczba5.Name = "Liczba5";
			this.Liczba5.Width = 50;
			// 
			// Liczba6
			// 
			this.Liczba6.HeaderText = "6";
			this.Liczba6.Name = "Liczba6";
			this.Liczba6.Width = 50;
			// 
			// viewDataFromDatabase
			// 
			this.viewDataFromDatabase.Location = new System.Drawing.Point(590, 253);
			this.viewDataFromDatabase.Name = "viewDataFromDatabase";
			this.viewDataFromDatabase.Size = new System.Drawing.Size(113, 23);
			this.viewDataFromDatabase.TabIndex = 11;
			this.viewDataFromDatabase.Text = "Wyświetl";
			this.viewDataFromDatabase.UseVisualStyleBackColor = true;
			this.viewDataFromDatabase.Click += new System.EventHandler(this.viewDataFromDatabase_Click);
			// 
			// sinceDate
			// 
			this.sinceDate.Location = new System.Drawing.Point(503, 56);
			this.sinceDate.MinDate = new System.DateTime(1957, 1, 27, 0, 0, 0, 0);
			this.sinceDate.Name = "sinceDate";
			this.sinceDate.Size = new System.Drawing.Size(200, 20);
			this.sinceDate.TabIndex = 12;
			this.sinceDate.ValueChanged += new System.EventHandler(this.sinceDate_ValueChanged);
			// 
			// toDate
			// 
			this.toDate.Location = new System.Drawing.Point(503, 99);
			this.toDate.Name = "toDate";
			this.toDate.Size = new System.Drawing.Size(200, 20);
			this.toDate.TabIndex = 13;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(503, 158);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(200, 23);
			this.progressBar1.TabIndex = 14;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 310);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.toDate);
			this.Controls.Add(this.sinceDate);
			this.Controls.Add(this.viewDataFromDatabase);
			this.Controls.Add(this.DataGridView);
			this.Controls.Add(this.checkUpdatesButton);
			this.Controls.Add(this.loadFromWeb);
			this.Controls.Add(this.loadFromFile);
			this.Controls.Add(this.drawScores);
			this.Controls.Add(this.lastScores);
			this.Controls.Add(this.lastScoresDate);
			this.Controls.Add(this.lastScoresLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastScoresLabel;
        private System.Windows.Forms.Label lastScoresDate;
        private System.Windows.Forms.Label lastScores;
        private System.Windows.Forms.Button drawScores;
        private System.Windows.Forms.Button loadFromFile;
        private System.Windows.Forms.Button loadFromWeb;
        private System.Windows.Forms.Button checkUpdatesButton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button viewDataFromDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba6;
        private System.Windows.Forms.DateTimePicker sinceDate;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

