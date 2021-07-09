
namespace PasswordGenerator
{
    partial class f_mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_mainWindow));
            this.lbl_appName = new System.Windows.Forms.Label();
            this.tb_appName = new System.Windows.Forms.TextBox();
            this.btn_generatePassword = new System.Windows.Forms.Button();
            this.btn_options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_appName
            // 
            this.lbl_appName.AutoSize = true;
            this.lbl_appName.Location = new System.Drawing.Point(13, 14);
            this.lbl_appName.Name = "lbl_appName";
            this.lbl_appName.Size = new System.Drawing.Size(150, 20);
            this.lbl_appName.TabIndex = 0;
            this.lbl_appName.Text = "Nom de l\'application";
            // 
            // tb_appName
            // 
            this.tb_appName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_appName.Location = new System.Drawing.Point(168, 12);
            this.tb_appName.Name = "tb_appName";
            this.tb_appName.Size = new System.Drawing.Size(304, 26);
            this.tb_appName.TabIndex = 1;
            // 
            // btn_generatePassword
            // 
            this.btn_generatePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_generatePassword.Enabled = false;
            this.btn_generatePassword.Location = new System.Drawing.Point(12, 56);
            this.btn_generatePassword.Name = "btn_generatePassword";
            this.btn_generatePassword.Size = new System.Drawing.Size(165, 43);
            this.btn_generatePassword.TabIndex = 2;
            this.btn_generatePassword.Text = "Générer";
            this.btn_generatePassword.UseVisualStyleBackColor = true;
            this.btn_generatePassword.Click += new System.EventHandler(this.btn_generatePassword_Click);
            // 
            // btn_options
            // 
            this.btn_options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_options.Location = new System.Drawing.Point(307, 56);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(165, 43);
            this.btn_options.TabIndex = 3;
            this.btn_options.Text = "Paramètres";
            this.btn_options.UseVisualStyleBackColor = true;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // f_mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 108);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.btn_generatePassword);
            this.Controls.Add(this.tb_appName);
            this.Controls.Add(this.lbl_appName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(385, 159);
            this.Name = "f_mainWindow";
            this.Text = "PasswordGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_appName;
        private System.Windows.Forms.TextBox tb_appName;
        private System.Windows.Forms.Button btn_generatePassword;
        private System.Windows.Forms.Button btn_options;
    }
}

