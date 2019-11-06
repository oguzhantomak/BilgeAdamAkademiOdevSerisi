namespace BilgeAdamAkademiOdevSerisi
{
    partial class SayisalLotoCekilis
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Enabled = false;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(24, 64);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(87, 88);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "0";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(117, 63);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(87, 88);
            this.txt2.TabIndex = 0;
            this.txt2.Text = "0";
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3
            // 
            this.txt3.Enabled = false;
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(210, 64);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(87, 88);
            this.txt3.TabIndex = 0;
            this.txt3.Text = "0";
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4
            // 
            this.txt4.Enabled = false;
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt4.Location = new System.Drawing.Point(303, 64);
            this.txt4.Multiline = true;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(87, 88);
            this.txt4.TabIndex = 0;
            this.txt4.Text = "0";
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt5
            // 
            this.txt5.Enabled = false;
            this.txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt5.Location = new System.Drawing.Point(396, 64);
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(87, 88);
            this.txt5.TabIndex = 0;
            this.txt5.Text = "0";
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt6
            // 
            this.txt6.Enabled = false;
            this.txt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt6.Location = new System.Drawing.Point(489, 64);
            this.txt6.Multiline = true;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(87, 88);
            this.txt6.TabIndex = 0;
            this.txt6.Text = "0";
            this.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(24, 169);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(552, 46);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "ÇEKİLİŞ YAP";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SayisalLotoCekilis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 262);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "SayisalLotoCekilis";
            this.Load += new System.EventHandler(this.SayisalLotoCekilis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Timer timer1;
    }
}

