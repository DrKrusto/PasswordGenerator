
namespace PasswordGenerator
{
    partial class f_options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_options));
            this.lbl_partOfPassword = new System.Windows.Forms.Label();
            this.lbl_specialChar = new System.Windows.Forms.Label();
            this.tb_partOfPassword = new System.Windows.Forms.TextBox();
            this.tb_specialChar = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_typeOfGeneration = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_partOfPassword
            // 
            this.lbl_partOfPassword.AutoSize = true;
            this.lbl_partOfPassword.Location = new System.Drawing.Point(12, 96);
            this.lbl_partOfPassword.Name = "lbl_partOfPassword";
            this.lbl_partOfPassword.Size = new System.Drawing.Size(242, 20);
            this.lbl_partOfPassword.TabIndex = 0;
            this.lbl_partOfPassword.Text = "Première partie du mot de passe:";
            // 
            // lbl_specialChar
            // 
            this.lbl_specialChar.AutoSize = true;
            this.lbl_specialChar.Location = new System.Drawing.Point(12, 143);
            this.lbl_specialChar.Name = "lbl_specialChar";
            this.lbl_specialChar.Size = new System.Drawing.Size(198, 20);
            this.lbl_specialChar.TabIndex = 1;
            this.lbl_specialChar.Text = "Caractère spécial à utiliser:";
            // 
            // tb_partOfPassword
            // 
            this.tb_partOfPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_partOfPassword.Location = new System.Drawing.Point(260, 93);
            this.tb_partOfPassword.Name = "tb_partOfPassword";
            this.tb_partOfPassword.PasswordChar = '*';
            this.tb_partOfPassword.Size = new System.Drawing.Size(325, 26);
            this.tb_partOfPassword.TabIndex = 2;
            // 
            // tb_specialChar
            // 
            this.tb_specialChar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_specialChar.Location = new System.Drawing.Point(216, 140);
            this.tb_specialChar.MaxLength = 1;
            this.tb_specialChar.Name = "tb_specialChar";
            this.tb_specialChar.PasswordChar = '*';
            this.tb_specialChar.Size = new System.Drawing.Size(369, 26);
            this.tb_specialChar.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(84, 180);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(432, 43);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Sauvegarder changements";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_typeOfGeneration
            // 
            this.lb_typeOfGeneration.FormattingEnabled = true;
            this.lb_typeOfGeneration.ItemHeight = 20;
            this.lb_typeOfGeneration.Location = new System.Drawing.Point(12, 12);
            this.lb_typeOfGeneration.Name = "lb_typeOfGeneration";
            this.lb_typeOfGeneration.Size = new System.Drawing.Size(573, 64);
            this.lb_typeOfGeneration.TabIndex = 5;
            this.lb_typeOfGeneration.SelectedIndexChanged += new System.EventHandler(this.lb_typeOfGeneration_SelectedIndexChanged);
            // 
            // f_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 239);
            this.Controls.Add(this.lb_typeOfGeneration);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_specialChar);
            this.Controls.Add(this.tb_partOfPassword);
            this.Controls.Add(this.lbl_specialChar);
            this.Controls.Add(this.lbl_partOfPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(482, 226);
            this.Name = "f_options";
            this.Text = "PasswordGenerator - Paramètres de génération";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_partOfPassword;
        private System.Windows.Forms.Label lbl_specialChar;
        private System.Windows.Forms.TextBox tb_partOfPassword;
        private System.Windows.Forms.TextBox tb_specialChar;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ListBox lb_typeOfGeneration;
    }
}