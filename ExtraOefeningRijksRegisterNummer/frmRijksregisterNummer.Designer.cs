﻿
namespace ExtraOefeningRijksRegisterNummer
{
    partial class frmRijksregisterNummer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtRijksregisternummer = new System.Windows.Forms.TextBox();
            this.epRijksregisternummer = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnValidate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epRijksregisternummer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRijksregisternummer
            // 
            this.txtRijksregisternummer.Location = new System.Drawing.Point(70, 69);
            this.txtRijksregisternummer.Name = "txtRijksregisternummer";
            this.txtRijksregisternummer.Size = new System.Drawing.Size(288, 31);
            this.txtRijksregisternummer.TabIndex = 0;
            this.txtRijksregisternummer.TextChanged += new System.EventHandler(this.txtRijksregisternummer_TextChanged);
            this.txtRijksregisternummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRijksregisternummer_KeyPress);
            this.txtRijksregisternummer.Validating += new System.ComponentModel.CancelEventHandler(this.txtRijksregisternummer_Validating);
            // 
            // epRijksregisternummer
            // 
            this.epRijksregisternummer.ContainerControl = this;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(161, 122);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(112, 34);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // frmRijksregisterNummer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 177);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtRijksregisternummer);
            this.Name = "frmRijksregisterNummer";
            this.Text = "Rijksregisternummer";
            ((System.ComponentModel.ISupportInitialize)(this.epRijksregisternummer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRijksregisternummer;
        private System.Windows.Forms.ErrorProvider epRijksregisternummer;
        private System.Windows.Forms.Button btnValidate;
    }
}

