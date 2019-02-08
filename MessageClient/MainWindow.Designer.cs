namespace MessageClient
{
    partial class MainWindow
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textTags = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.textSender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Sender,
            this.Tags,
            this.Content,
            this.Date});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(719, 552);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            // 
            // Sender
            // 
            this.Sender.Text = "Sender";
            // 
            // Tags
            // 
            this.Tags.Text = "Tags";
            // 
            // Content
            // 
            this.Content.Text = "Content";
            this.Content.Width = 204;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(12, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(121, 24);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "GabenNewel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(789, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Заголовок";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(868, 31);
            this.textTitle.MaxLength = 50;
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(100, 20);
            this.textTitle.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1241, 9);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // textTags
            // 
            this.textTags.Location = new System.Drawing.Point(1072, 24);
            this.textTags.MaxLength = 3600;
            this.textTags.Multiline = true;
            this.textTags.Name = "textTags";
            this.textTags.Size = new System.Drawing.Size(101, 147);
            this.textTags.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1035, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тэги";
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(792, 183);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(613, 405);
            this.textMessage.TabIndex = 10;
            // 
            // textSender
            // 
            this.textSender.Location = new System.Drawing.Point(868, 76);
            this.textSender.MaxLength = 10;
            this.textSender.Name = "textSender";
            this.textSender.Size = new System.Drawing.Size(100, 20);
            this.textSender.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(789, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отправитель";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(792, 133);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(176, 38);
            this.ButtonAdd.TabIndex = 13;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(656, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 601);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.textSender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTags);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.listView1);
            this.Name = "MainWindow";
            this.Text = "Message Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader Tags;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textTags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.TextBox textSender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button buttonDelete;
    }
}