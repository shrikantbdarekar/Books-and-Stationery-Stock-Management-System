
namespace WinBookStationaryStock19
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDesignedDevelopedBy = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLoginId = new System.Windows.Forms.TextBox();
            this.labelLoginId = new System.Windows.Forms.Label();
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelLine);
            this.panel1.Controls.Add(this.labelDesignedDevelopedBy);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.textBoxLoginId);
            this.panel1.Controls.Add(this.labelLoginId);
            this.panel1.Controls.Add(this.labelHeading);
            this.panel1.Location = new System.Drawing.Point(18, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 362);
            this.panel1.TabIndex = 0;
            // 
            // labelDesignedDevelopedBy
            // 
            this.labelDesignedDevelopedBy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDesignedDevelopedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesignedDevelopedBy.Location = new System.Drawing.Point(0, 245);
            this.labelDesignedDevelopedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesignedDevelopedBy.Name = "labelDesignedDevelopedBy";
            this.labelDesignedDevelopedBy.Size = new System.Drawing.Size(389, 117);
            this.labelDesignedDevelopedBy.TabIndex = 7;
            this.labelDesignedDevelopedBy.Text = "Designed and Developed By\r\n";
            this.labelDesignedDevelopedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(232, 192);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 27);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(151, 192);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 27);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(151, 152);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '#';
            this.textBoxPassword.Size = new System.Drawing.Size(179, 24);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "admin";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(63, 155);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 18);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxLoginId
            // 
            this.textBoxLoginId.Location = new System.Drawing.Point(151, 122);
            this.textBoxLoginId.Name = "textBoxLoginId";
            this.textBoxLoginId.Size = new System.Drawing.Size(179, 24);
            this.textBoxLoginId.TabIndex = 2;
            this.textBoxLoginId.Text = "admin";
            // 
            // labelLoginId
            // 
            this.labelLoginId.AutoSize = true;
            this.labelLoginId.Location = new System.Drawing.Point(63, 125);
            this.labelLoginId.Name = "labelLoginId";
            this.labelLoginId.Size = new System.Drawing.Size(59, 18);
            this.labelLoginId.TabIndex = 1;
            this.labelLoginId.Text = "Login Id";
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.Location = new System.Drawing.Point(0, 0);
            this.labelHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(389, 100);
            this.labelHeading.TabIndex = 0;
            this.labelHeading.Text = "Book and Stationary\r\nStock Management System";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLine
            // 
            this.labelLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine.Location = new System.Drawing.Point(0, 242);
            this.labelLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(389, 3);
            this.labelLine.TabIndex = 8;
            this.labelLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 392);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLoginId;
        private System.Windows.Forms.Label labelLoginId;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelDesignedDevelopedBy;
        private System.Windows.Forms.Label labelLine;
    }
}

