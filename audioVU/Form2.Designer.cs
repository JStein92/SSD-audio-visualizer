namespace audioVU
{
    partial class LeftMeter
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
            ProgBar.cBlendItems cBlendItems1 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints1 = new ProgBar.cFocalPoints();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeftMeter));
            this.progressBarLeft = new ProgBar.ProgBarPlus();
            this.SuspendLayout();
            // 
            // progressBarLeft
            // 
            this.progressBarLeft.BarBackColor = System.Drawing.Color.Transparent;
            cBlendItems1.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Blue};
            cBlendItems1.iPoint = new float[] {
        0F,
        0.9889299F,
        0.9963099F,
        1F};
            this.progressBarLeft.BarColorBlend = cBlendItems1;
            this.progressBarLeft.BarColorSolid = System.Drawing.Color.Blue;
            this.progressBarLeft.BarColorSolidB = System.Drawing.Color.White;
            this.progressBarLeft.BarLengthValue = ((short)(100));
            this.progressBarLeft.BarPadding = new System.Windows.Forms.Padding(0);
            this.progressBarLeft.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.progressBarLeft.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.progressBarLeft.BarStyleTexture = null;
            this.progressBarLeft.BorderColor = System.Drawing.Color.Transparent;
            this.progressBarLeft.BorderWidth = ((short)(1));
            this.progressBarLeft.Corners.All = ((short)(0));
            this.progressBarLeft.Corners.LowerLeft = ((short)(0));
            this.progressBarLeft.Corners.LowerRight = ((short)(0));
            this.progressBarLeft.Corners.UpperLeft = ((short)(0));
            this.progressBarLeft.Corners.UpperRight = ((short)(0));
            this.progressBarLeft.CylonInterval = ((short)(1));
            this.progressBarLeft.CylonMove = 5F;
            this.progressBarLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            cFocalPoints1.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints1.CenterPoint")));
            cFocalPoints1.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints1.FocusScales")));
            this.progressBarLeft.FocalPoints = cFocalPoints1;
            this.progressBarLeft.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBarLeft.Location = new System.Drawing.Point(0, 0);
            this.progressBarLeft.Name = "progressBarLeft";
            this.progressBarLeft.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progressBarLeft.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progressBarLeft.Size = new System.Drawing.Size(116, 283);
            this.progressBarLeft.TabIndex = 6;
            this.progressBarLeft.TextFormat = "Process {1}% Done";
            this.progressBarLeft.TextPlacement = ProgBar.ProgBarPlus.eTextPlacement.OnBar;
            this.progressBarLeft.TextShadow = true;
            this.progressBarLeft.TextShadowColor = System.Drawing.Color.Black;
            this.progressBarLeft.TextShow = ProgBar.ProgBarPlus.eTextShow.Percent;
            this.progressBarLeft.Value = 0;
            // 
            // LeftMeter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(116, 283);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarLeft);
            this.Name = "LeftMeter";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "LeftMeter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LeftMeter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public ProgBar.ProgBarPlus progressBarLeft;
    }
}