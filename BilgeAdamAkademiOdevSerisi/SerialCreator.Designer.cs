﻿namespace BilgeAdamAkademiOdevSerisi
{
    partial class SerialCreator
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.htmlLabel6 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel5 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.nmrKarakterSayisi = new System.Windows.Forms.NumericUpDown();
            this.nmrHaneSayisi = new System.Windows.Forms.NumericUpDown();
            this.txtSerial = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtSayisal = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtMetinsel = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnSerial = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKarakterSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHaneSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(101, 248);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(742, 46);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Text = "Serial Üret";
            this.metroButton1.UseSelectable = true;
            // 
            // htmlLabel6
            // 
            this.htmlLabel6.AutoScroll = true;
            this.htmlLabel6.AutoScrollMinSize = new System.Drawing.Size(94, 23);
            this.htmlLabel6.AutoSize = false;
            this.htmlLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel6.Location = new System.Drawing.Point(348, 222);
            this.htmlLabel6.Name = "htmlLabel6";
            this.htmlLabel6.Size = new System.Drawing.Size(95, 23);
            this.htmlLabel6.TabIndex = 15;
            this.htmlLabel6.Text = "Karakter Sayısı : ";
            // 
            // htmlLabel5
            // 
            this.htmlLabel5.AutoScroll = true;
            this.htmlLabel5.AutoScrollMinSize = new System.Drawing.Size(78, 23);
            this.htmlLabel5.AutoSize = false;
            this.htmlLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel5.Location = new System.Drawing.Point(4, 222);
            this.htmlLabel5.Name = "htmlLabel5";
            this.htmlLabel5.Size = new System.Drawing.Size(91, 23);
            this.htmlLabel5.TabIndex = 16;
            this.htmlLabel5.Text = "Hane Sayısı : ";
            // 
            // nmrKarakterSayisi
            // 
            this.nmrKarakterSayisi.Location = new System.Drawing.Point(449, 222);
            this.nmrKarakterSayisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrKarakterSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrKarakterSayisi.Name = "nmrKarakterSayisi";
            this.nmrKarakterSayisi.Size = new System.Drawing.Size(189, 20);
            this.nmrKarakterSayisi.TabIndex = 18;
            this.nmrKarakterSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmrHaneSayisi
            // 
            this.nmrHaneSayisi.Location = new System.Drawing.Point(101, 222);
            this.nmrHaneSayisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrHaneSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrHaneSayisi.Name = "nmrHaneSayisi";
            this.nmrHaneSayisi.Size = new System.Drawing.Size(189, 20);
            this.nmrHaneSayisi.TabIndex = 19;
            this.nmrHaneSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSerial
            // 
            // 
            // 
            // 
            this.txtSerial.CustomButton.Image = null;
            this.txtSerial.CustomButton.Location = new System.Drawing.Point(720, 1);
            this.txtSerial.CustomButton.Name = "";
            this.txtSerial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSerial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSerial.CustomButton.TabIndex = 1;
            this.txtSerial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSerial.CustomButton.UseSelectable = true;
            this.txtSerial.CustomButton.Visible = false;
            this.txtSerial.Lines = new string[0];
            this.txtSerial.Location = new System.Drawing.Point(101, 193);
            this.txtSerial.MaxLength = 32767;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.PasswordChar = '\0';
            this.txtSerial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSerial.SelectedText = "";
            this.txtSerial.SelectionLength = 0;
            this.txtSerial.SelectionStart = 0;
            this.txtSerial.ShortcutsEnabled = true;
            this.txtSerial.Size = new System.Drawing.Size(742, 23);
            this.txtSerial.TabIndex = 17;
            this.txtSerial.UseSelectable = true;
            this.txtSerial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSerial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(48, 23);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Location = new System.Drawing.Point(4, 193);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel4.TabIndex = 14;
            this.htmlLabel4.Text = "Serial : ";
            // 
            // txtSayisal
            // 
            // 
            // 
            // 
            this.txtSayisal.CustomButton.Image = null;
            this.txtSayisal.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtSayisal.CustomButton.Name = "";
            this.txtSayisal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSayisal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSayisal.CustomButton.TabIndex = 1;
            this.txtSayisal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSayisal.CustomButton.UseSelectable = true;
            this.txtSayisal.CustomButton.Visible = false;
            this.txtSayisal.Lines = new string[0];
            this.txtSayisal.Location = new System.Drawing.Point(580, 164);
            this.txtSayisal.MaxLength = 32767;
            this.txtSayisal.Name = "txtSayisal";
            this.txtSayisal.PasswordChar = '\0';
            this.txtSayisal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSayisal.SelectedText = "";
            this.txtSayisal.SelectionLength = 0;
            this.txtSayisal.SelectionStart = 0;
            this.txtSayisal.ShortcutsEnabled = true;
            this.txtSayisal.Size = new System.Drawing.Size(263, 23);
            this.txtSayisal.TabIndex = 12;
            this.txtSayisal.UseSelectable = true;
            this.txtSayisal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSayisal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(87, 23);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(479, 164);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(95, 23);
            this.htmlLabel3.TabIndex = 10;
            this.htmlLabel3.Text = "Sayısal Serial : ";
            // 
            // txtMetinsel
            // 
            // 
            // 
            // 
            this.txtMetinsel.CustomButton.Image = null;
            this.txtMetinsel.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtMetinsel.CustomButton.Name = "";
            this.txtMetinsel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMetinsel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMetinsel.CustomButton.TabIndex = 1;
            this.txtMetinsel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMetinsel.CustomButton.UseSelectable = true;
            this.txtMetinsel.CustomButton.Visible = false;
            this.txtMetinsel.Lines = new string[0];
            this.txtMetinsel.Location = new System.Drawing.Point(101, 164);
            this.txtMetinsel.MaxLength = 32767;
            this.txtMetinsel.Name = "txtMetinsel";
            this.txtMetinsel.PasswordChar = '\0';
            this.txtMetinsel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMetinsel.SelectedText = "";
            this.txtMetinsel.SelectionLength = 0;
            this.txtMetinsel.SelectionStart = 0;
            this.txtMetinsel.ShortcutsEnabled = true;
            this.txtMetinsel.Size = new System.Drawing.Size(240, 23);
            this.txtMetinsel.TabIndex = 13;
            this.txtMetinsel.UseSelectable = true;
            this.txtMetinsel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMetinsel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(93, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(4, 164);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(115, 23);
            this.htmlLabel2.TabIndex = 11;
            this.htmlLabel2.Text = "Metinsel Serial : ";
            // 
            // btnSerial
            // 
            // 
            // 
            // 
            this.btnSerial.CustomButton.Image = null;
            this.btnSerial.CustomButton.Location = new System.Drawing.Point(720, 1);
            this.btnSerial.CustomButton.Name = "";
            this.btnSerial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.btnSerial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSerial.CustomButton.TabIndex = 1;
            this.btnSerial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSerial.CustomButton.UseSelectable = true;
            this.btnSerial.CustomButton.Visible = false;
            this.btnSerial.Lines = new string[0];
            this.btnSerial.Location = new System.Drawing.Point(101, 135);
            this.btnSerial.MaxLength = 32767;
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.PasswordChar = '\0';
            this.btnSerial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.btnSerial.SelectedText = "";
            this.btnSerial.SelectionLength = 0;
            this.btnSerial.SelectionStart = 0;
            this.btnSerial.ShortcutsEnabled = true;
            this.btnSerial.Size = new System.Drawing.Size(742, 23);
            this.btnSerial.TabIndex = 9;
            this.btnSerial.UseSelectable = true;
            this.btnSerial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnSerial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(47, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(4, 135);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 8;
            this.htmlLabel1.Text = "GUID : ";
            // 
            // SerialCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 335);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.htmlLabel6);
            this.Controls.Add(this.htmlLabel5);
            this.Controls.Add(this.nmrKarakterSayisi);
            this.Controls.Add(this.nmrHaneSayisi);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.htmlLabel4);
            this.Controls.Add(this.txtSayisal);
            this.Controls.Add(this.htmlLabel3);
            this.Controls.Add(this.txtMetinsel);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.btnSerial);
            this.Controls.Add(this.htmlLabel1);
            this.Name = "SerialCreator";
            this.Text = "SerialCreator";
            ((System.ComponentModel.ISupportInitialize)(this.nmrKarakterSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHaneSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel6;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel5;
        private System.Windows.Forms.NumericUpDown nmrKarakterSayisi;
        private System.Windows.Forms.NumericUpDown nmrHaneSayisi;
        private MetroFramework.Controls.MetroTextBox txtSerial;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Controls.MetroTextBox txtSayisal;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroTextBox txtMetinsel;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroTextBox btnSerial;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
    }
}