namespace GUI_BattleshipServer
{
    partial class FRM_Server
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TLP_Form = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_StartStop = new System.Windows.Forms.Button();
            this.RTB_Logs = new System.Windows.Forms.RichTextBox();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBX_Parties = new System.Windows.Forms.ListBox();
            this.TLP_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_Form
            // 
            this.TLP_Form.ColumnCount = 8;
            this.TLP_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TLP_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TLP_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Form.Controls.Add(this.BTN_StartStop, 2, 1);
            this.TLP_Form.Controls.Add(this.RTB_Logs, 2, 3);
            this.TLP_Form.Controls.Add(this.LBL_Title, 4, 1);
            this.TLP_Form.Controls.Add(this.LBX_Parties, 6, 1);
            this.TLP_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Form.Location = new System.Drawing.Point(0, 0);
            this.TLP_Form.Name = "TLP_Form";
            this.TLP_Form.RowCount = 7;
            this.TLP_Form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_Form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TLP_Form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Form.Size = new System.Drawing.Size(903, 511);
            this.TLP_Form.TabIndex = 0;
            // 
            // BTN_StartStop
            // 
            this.BTN_StartStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_StartStop.Location = new System.Drawing.Point(20, 10);
            this.BTN_StartStop.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_StartStop.Name = "BTN_StartStop";
            this.BTN_StartStop.Size = new System.Drawing.Size(200, 50);
            this.BTN_StartStop.TabIndex = 0;
            this.BTN_StartStop.Text = "START";
            this.BTN_StartStop.UseVisualStyleBackColor = true;
            this.BTN_StartStop.Click += new System.EventHandler(this.BTN_StartStop_Click);
            // 
            // RTB_Logs
            // 
            this.TLP_Form.SetColumnSpan(this.RTB_Logs, 3);
            this.RTB_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Logs.Location = new System.Drawing.Point(20, 70);
            this.RTB_Logs.Margin = new System.Windows.Forms.Padding(0);
            this.RTB_Logs.Name = "RTB_Logs";
            this.TLP_Form.SetRowSpan(this.RTB_Logs, 3);
            this.RTB_Logs.Size = new System.Drawing.Size(663, 431);
            this.RTB_Logs.TabIndex = 1;
            this.RTB_Logs.Text = "";
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold);
            this.LBL_Title.Location = new System.Drawing.Point(230, 10);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(453, 50);
            this.LBL_Title.TabIndex = 2;
            this.LBL_Title.Text = "SERVER";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBX_Parties
            // 
            this.LBX_Parties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBX_Parties.FormattingEnabled = true;
            this.LBX_Parties.Location = new System.Drawing.Point(693, 10);
            this.LBX_Parties.Margin = new System.Windows.Forms.Padding(0);
            this.LBX_Parties.Name = "LBX_Parties";
            this.TLP_Form.SetRowSpan(this.LBX_Parties, 3);
            this.LBX_Parties.Size = new System.Drawing.Size(200, 281);
            this.LBX_Parties.TabIndex = 3;
            // 
            // FRM_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 511);
            this.Controls.Add(this.TLP_Form);
            this.Name = "FRM_Server";
            this.Text = "Form1";
            this.TLP_Form.ResumeLayout(false);
            this.TLP_Form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_Form;
        private System.Windows.Forms.Button BTN_StartStop;
        private System.Windows.Forms.RichTextBox RTB_Logs;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.ListBox LBX_Parties;
    }
}

