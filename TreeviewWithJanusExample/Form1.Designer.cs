namespace TreeviewWithJanusExample
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
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEX1.Location = new System.Drawing.Point(0, 0);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.Size = new System.Drawing.Size(577, 464);
            this.gridEX1.TabIndex = 0;
            this.gridEX1.EditingCell += new Janus.Windows.GridEX.EditingCellEventHandler(this.gridEX1_EditingCell);
            this.gridEX1.UpdatingCell += new Janus.Windows.GridEX.UpdatingCellEventHandler(this.gridEX1_UpdatingCell);
            this.gridEX1.InitCustomEdit += new Janus.Windows.GridEX.InitCustomEditEventHandler(this.gridEX1_InitCustomEdit);
            this.gridEX1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridEX1_KeyDown);
            this.gridEX1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridEX1_KeyUp);
            this.gridEX1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridEX1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 464);
            this.Controls.Add(this.gridEX1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
    }
}

