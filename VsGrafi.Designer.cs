﻿namespace Dijkstra
{
    partial class VsGrafi
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
            this.components = new System.ComponentModel.Container();
            this.cmbDestinazione = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrafo = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrafo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDestinazione
            // 
            this.cmbDestinazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestinazione.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbDestinazione.FormattingEnabled = true;
            this.cmbDestinazione.Location = new System.Drawing.Point(313, 68);
            this.cmbDestinazione.Name = "cmbDestinazione";
            this.cmbDestinazione.Size = new System.Drawing.Size(151, 32);
            this.cmbDestinazione.Sorted = true;
            this.cmbDestinazione.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(209, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "Annulla";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVisualizza.Location = new System.Drawing.Point(347, 152);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(98, 39);
            this.btnVisualizza.TabIndex = 13;
            this.btnVisualizza.Text = "OK";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Imposta il nodo destinazione:";
            // 
            // dataGrafo
            // 
            this.dataGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrafo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1});
            this.dataGrafo.Location = new System.Drawing.Point(507, 68);
            this.dataGrafo.Name = "dataGrafo";
            this.dataGrafo.Size = new System.Drawing.Size(668, 491);
            this.dataGrafo.TabIndex = 16;
            // 
            // Column0
            // 
            this.Column0.DataPropertyName = "Text";
            this.Column0.HeaderText = "Etichetta";
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Text";
            this.Column1.HeaderText = "Peso";
            this.Column1.Name = "Column1";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Dijkstra.Form1);
            // 
            // VsGrafi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 630);
            this.Controls.Add(this.dataGrafo);
            this.Controls.Add(this.cmbDestinazione);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.label1);
            this.Name = "VsGrafi";
            this.Text = "VsGrafi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrafo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbDestinazione;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        public System.Windows.Forms.DataGridView dataGrafo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}