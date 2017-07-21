namespace audioVU
{
    partial class RightMeter
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
            ProgBar.cBlendItems cBlendItems5 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints5 = new ProgBar.cFocalPoints();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RightMeter));
            this.progressBarRight = new ProgBar.ProgBarPlus();
            this.SuspendLayout();
            // 
            // progressBarRight
            // 
            this.progressBarRight.BarBackColor = System.Drawing.Color.Transparent;
            cBlendItems5.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Blue};
            cBlendItems5.iPoint = new float[] {
        0F,
        0.9889299F,
        0.9963099F,
        1F};
            this.progressBarRight.BarColorBlend = cBlendItems5;
            this.progressBarRight.BarColorSolid = System.Drawing.Color.Blue;
            this.progressBarRight.BarColorSolidB = System.Drawing.Color.White;
            this.progressBarRight.BarLengthValue = ((short)(100));
            this.progressBarRight.BarPadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.progressBarRight.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.progressBarRight.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.progressBarRight.BarStyleTexture = null;
            this.progressBarRight.BorderColor = System.Drawing.Color.Transparent;
            this.progressBarRight.BorderWidth = ((short)(1));
            this.progressBarRight.Corners.All = ((short)(0));
            this.progressBarRight.Corners.LowerLeft = ((short)(0));
            this.progressBarRight.Corners.LowerRight = ((short)(0));
            this.progressBarRight.Corners.UpperLeft = ((short)(0));
            this.progressBarRight.Corners.UpperRight = ((short)(0));
            this.progressBarRight.CylonInterval = ((short)(1));
            this.progressBarRight.CylonMove = 5F;
            this.progressBarRight.Dock = System.Windows.Forms.DockStyle.Fill;
            cFocalPoints5.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints5.CenterPoint")));
            cFocalPoints5.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints5.FocusScales")));
            this.progressBarRight.FocalPoints = cFocalPoints5;
            this.progressBarRight.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBarRight.Location = new System.Drawing.Point(0, 0);
            this.progressBarRight.Name = "progressBarRight";
            this.progressBarRight.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.progressBarRight.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.progressBarRight.Size = new System.Drawing.Size(116, 283);
            this.progressBarRight.TabIndex = 5;
            this.progressBarRight.TextFormat = "Process {1}% Done";
            this.progressBarRight.TextPlacement = ProgBar.ProgBarPlus.eTextPlacement.OnBar;
            this.progressBarRight.TextShadow = true;
            this.progressBarRight.TextShadowColor = System.Drawing.Color.Black;
            this.progressBarRight.TextShow = ProgBar.ProgBarPlus.eTextShow.Percent;
            this.progressBarRight.Value = 0;
            // 
            // RightMeter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(116, 283);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarRight);
            this.Name = "RightMeter";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "RightMeter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RightMeter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public ProgBar.ProgBarPlus progressBarRight;
    }
}