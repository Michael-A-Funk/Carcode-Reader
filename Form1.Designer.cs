namespace SS_OpenCV
{
    partial class Histogram
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
            this.graf = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // graf
            // 
            this.graf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graf.Location = new System.Drawing.Point(0, 0);
            this.graf.Name = "graf";
            this.graf.ScrollGrace = 0;
            this.graf.ScrollMaxX = 0;
            this.graf.ScrollMaxY = 0;
            this.graf.ScrollMaxY2 = 0;
            this.graf.ScrollMinX = 0;
            this.graf.ScrollMinY = 0;
            this.graf.ScrollMinY2 = 0;
            this.graf.Size = new System.Drawing.Size(455, 294);
            this.graf.TabIndex = 0;
            this.graf.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 294);
            this.Controls.Add(this.graf);
            this.Name = "Histogram";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl graf;
    }
}