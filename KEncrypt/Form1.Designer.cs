
namespace KEncrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.encryptListBox = new System.Windows.Forms.ListView();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.EncryptClearList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptBrowse = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.encryptKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.decryptListBox = new System.Windows.Forms.ListView();
            this.btnClearList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.decryptKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 232);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.encryptListBox);
            this.tabPage1.Controls.Add(this.btnGenerateKey);
            this.tabPage1.Controls.Add(this.EncryptClearList);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.encryptBrowse);
            this.tabPage1.Controls.Add(this.btnEncrypt);
            this.tabPage1.Controls.Add(this.encryptKey);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 206);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // encryptListBox
            // 
            this.encryptListBox.HideSelection = false;
            this.encryptListBox.Location = new System.Drawing.Point(9, 35);
            this.encryptListBox.Name = "encryptListBox";
            this.encryptListBox.Size = new System.Drawing.Size(355, 111);
            this.encryptListBox.TabIndex = 19;
            this.encryptListBox.UseCompatibleStateImageBehavior = false;
            this.encryptListBox.View = System.Windows.Forms.View.List;
            this.encryptListBox.SelectedIndexChanged += new System.EventHandler(this.encryptListBox_SelectedIndexChanged);
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(370, 63);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(84, 23);
            this.btnGenerateKey.TabIndex = 18;
            this.btnGenerateKey.Text = "Generate Key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // EncryptClearList
            // 
            this.EncryptClearList.Location = new System.Drawing.Point(370, 35);
            this.EncryptClearList.Name = "EncryptClearList";
            this.EncryptClearList.Size = new System.Drawing.Size(84, 23);
            this.EncryptClearList.TabIndex = 17;
            this.EncryptClearList.Text = "Clear List";
            this.EncryptClearList.UseVisualStyleBackColor = true;
            this.EncryptClearList.Click += new System.EventHandler(this.EncryptClearList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Files Chosen: None";
            // 
            // encryptBrowse
            // 
            this.encryptBrowse.Location = new System.Drawing.Point(289, 6);
            this.encryptBrowse.Name = "encryptBrowse";
            this.encryptBrowse.Size = new System.Drawing.Size(75, 23);
            this.encryptBrowse.TabIndex = 12;
            this.encryptBrowse.Text = "Browse";
            this.encryptBrowse.UseMnemonic = false;
            this.encryptBrowse.UseVisualStyleBackColor = true;
            this.encryptBrowse.Click += new System.EventHandler(this.encryptBrowse_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(9, 178);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(436, 23);
            this.btnEncrypt.TabIndex = 11;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // encryptKey
            // 
            this.encryptKey.Location = new System.Drawing.Point(34, 152);
            this.encryptKey.Name = "encryptKey";
            this.encryptKey.Size = new System.Drawing.Size(411, 20);
            this.encryptKey.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Key: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.decryptListBox);
            this.tabPage2.Controls.Add(this.btnClearList);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnBrowse);
            this.tabPage2.Controls.Add(this.btnDecrypt);
            this.tabPage2.Controls.Add(this.decryptKey);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 206);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // decryptListBox
            // 
            this.decryptListBox.HideSelection = false;
            this.decryptListBox.Location = new System.Drawing.Point(9, 34);
            this.decryptListBox.Name = "decryptListBox";
            this.decryptListBox.Size = new System.Drawing.Size(355, 111);
            this.decryptListBox.TabIndex = 9;
            this.decryptListBox.UseCompatibleStateImageBehavior = false;
            this.decryptListBox.View = System.Windows.Forms.View.Tile;
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(370, 34);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(84, 23);
            this.btnClearList.TabIndex = 8;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Files Chosen: None";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(289, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseMnemonic = false;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(9, 177);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(436, 23);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // decryptKey
            // 
            this.decryptKey.Location = new System.Drawing.Point(34, 151);
            this.decryptKey.Name = "decryptKey";
            this.decryptKey.Size = new System.Drawing.Size(411, 20);
            this.decryptKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(492, 259);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kencrypt";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox decryptKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button EncryptClearList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button encryptBrowse;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox encryptKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.ListView encryptListBox;
        private System.Windows.Forms.ListView decryptListBox;
    }
}

