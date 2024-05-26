using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TicTacToeNew
{
    partial class VideoScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLocal;
        private System.Windows.Forms.Panel panelRemote;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.TextBox txtChannelName;

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
            panelLocal = new Panel();
            panelRemote = new Panel();
            btnJoin = new Button();
            btnLeave = new Button();
            txtChannelName = new TextBox();
            SuspendLayout();
            // 
            // panelLocal
            // 
            panelLocal.BackColor = SystemColors.ControlDark;
            panelLocal.Location = new Point(12, 12);
            panelLocal.Name = "panelLocal";
            panelLocal.Size = new Size(320, 240);
            panelLocal.TabIndex = 0;
            // 
            // panelRemote
            // 
            panelRemote.BackColor = SystemColors.ControlDark;
            panelRemote.Location = new Point(348, 12);
            panelRemote.Name = "panelRemote";
            panelRemote.Size = new Size(320, 240);
            panelRemote.TabIndex = 1;
            // 
            // btnJoin
            // 
            btnJoin.Location = new Point(348, 266);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(75, 23);
            btnJoin.TabIndex = 2;
            btnJoin.Text = "Join";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // btnLeave
            // 
            btnLeave.Location = new Point(593, 266);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(75, 23);
            btnLeave.TabIndex = 3;
            btnLeave.Text = "Leave";
            btnLeave.UseVisualStyleBackColor = true;
            btnLeave.Click += btnLeave_Click;
            // 
            // txtChannelName
            // 
            txtChannelName.Location = new Point(12, 266);
            txtChannelName.Name = "txtChannelName";
            txtChannelName.Size = new Size(319, 23);
            txtChannelName.TabIndex = 4;
            // 
            // VideoForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(txtChannelName);
            Controls.Add(btnLeave);
            Controls.Add(btnJoin);
            Controls.Add(panelRemote);
            Controls.Add(panelLocal);
            Name = "VideoForm";
            Text = "Agora Video Call";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }

}