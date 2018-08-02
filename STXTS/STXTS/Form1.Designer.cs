namespace STXTS
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
            this.user_id = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Label();
            this.attachment = new System.Windows.Forms.Label();
            this.reciever_id = new System.Windows.Forms.Label();
            this.txuser_email = new System.Windows.Forms.TextBox();
            this.txbody = new System.Windows.Forms.TextBox();
            this.txattachment = new System.Windows.Forms.TextBox();
            this.txreciever = new System.Windows.Forms.TextBox();
            this.txpassword = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.subject = new System.Windows.Forms.Label();
            this.txsubject = new System.Windows.Forms.TextBox();
            this.comm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.command_box = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id.Location = new System.Drawing.Point(23, 19);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(120, 20);
            this.user_id.TabIndex = 0;
            this.user_id.Text = "Your E-mail ID :";
            this.user_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(483, 19);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(86, 20);
            this.password.TabIndex = 1;
            this.password.Text = "Password :";
            this.password.Click += new System.EventHandler(this.label2_Click);
            // 
            // body
            // 
            this.body.AutoSize = true;
            this.body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body.Location = new System.Drawing.Point(23, 262);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(53, 20);
            this.body.TabIndex = 2;
            this.body.Text = "Body :";
            this.body.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // attachment
            // 
            this.attachment.AutoSize = true;
            this.attachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachment.Location = new System.Drawing.Point(23, 158);
            this.attachment.Name = "attachment";
            this.attachment.Size = new System.Drawing.Size(100, 20);
            this.attachment.TabIndex = 3;
            this.attachment.Text = "Attachment :";
            // 
            // reciever_id
            // 
            this.reciever_id.AutoSize = true;
            this.reciever_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciever_id.Location = new System.Drawing.Point(23, 88);
            this.reciever_id.Name = "reciever_id";
            this.reciever_id.Size = new System.Drawing.Size(159, 20);
            this.reciever_id.TabIndex = 4;
            this.reciever_id.Text = "Reciever\'s E-mail ID :";
            // 
            // txuser_email
            // 
            this.txuser_email.Location = new System.Drawing.Point(188, 19);
            this.txuser_email.Name = "txuser_email";
            this.txuser_email.Size = new System.Drawing.Size(277, 20);
            this.txuser_email.TabIndex = 5;
            this.txuser_email.TextChanged += new System.EventHandler(this.txuser_email_TextChanged);
            // 
            // txbody
            // 
            this.txbody.Location = new System.Drawing.Point(188, 264);
            this.txbody.Multiline = true;
            this.txbody.Name = "txbody";
            this.txbody.Size = new System.Drawing.Size(588, 178);
            this.txbody.TabIndex = 6;
            // 
            // txattachment
            // 
            this.txattachment.Enabled = false;
            this.txattachment.Location = new System.Drawing.Point(188, 158);
            this.txattachment.Name = "txattachment";
            this.txattachment.Size = new System.Drawing.Size(415, 20);
            this.txattachment.TabIndex = 7;
            // 
            // txreciever
            // 
            this.txreciever.Location = new System.Drawing.Point(188, 88);
            this.txreciever.Name = "txreciever";
            this.txreciever.Size = new System.Drawing.Size(588, 20);
            this.txreciever.TabIndex = 8;
            // 
            // txpassword
            // 
            this.txpassword.Location = new System.Drawing.Point(575, 19);
            this.txpassword.Name = "txpassword";
            this.txpassword.Size = new System.Drawing.Size(201, 20);
            this.txpassword.TabIndex = 9;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(629, 155);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(147, 23);
            this.btnbrowse.TabIndex = 10;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(388, 467);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(147, 23);
            this.btnsend.TabIndex = 11;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.Location = new System.Drawing.Point(23, 212);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(71, 20);
            this.subject.TabIndex = 12;
            this.subject.Text = "Subject :";
            // 
            // txsubject
            // 
            this.txsubject.Location = new System.Drawing.Point(188, 212);
            this.txsubject.Name = "txsubject";
            this.txsubject.Size = new System.Drawing.Size(588, 20);
            this.txsubject.TabIndex = 13;
            // 
            // comm
            // 
            this.comm.Location = new System.Drawing.Point(840, 249);
            this.comm.Name = "comm";
            this.comm.Size = new System.Drawing.Size(377, 33);
            this.comm.TabIndex = 15;
            this.comm.Text = "command";
            this.comm.UseVisualStyleBackColor = true;
            this.comm.Click += new System.EventHandler(this.comm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(904, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "FOR DEBUGGING PURPOSE";
            // 
            // command_box
            // 
            this.command_box.Location = new System.Drawing.Point(840, 52);
            this.command_box.Multiline = true;
            this.command_box.Name = "command_box";
            this.command_box.Size = new System.Drawing.Size(391, 180);
            this.command_box.TabIndex = 18;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1214, 52);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 180);
            this.vScrollBar1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(840, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "start listening email/reciever/body/subject/password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(840, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "stop listening email/reciever/body/subject/password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(840, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "about";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(840, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "send message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 502);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.command_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comm);
            this.Controls.Add(this.txsubject);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.txpassword);
            this.Controls.Add(this.txreciever);
            this.Controls.Add(this.txattachment);
            this.Controls.Add(this.txbody);
            this.Controls.Add(this.txuser_email);
            this.Controls.Add(this.reciever_id);
            this.Controls.Add(this.attachment);
            this.Controls.Add(this.body);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_id);
            this.Name = "Form1";
            this.Text = "G-Mail Over Voice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label body;
        private System.Windows.Forms.Label attachment;
        private System.Windows.Forms.Label reciever_id;
        private System.Windows.Forms.TextBox txuser_email;
        private System.Windows.Forms.TextBox txbody;
        private System.Windows.Forms.TextBox txattachment;
        private System.Windows.Forms.TextBox txreciever;
        private System.Windows.Forms.TextBox txpassword;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.TextBox txsubject;
        private System.Windows.Forms.Button comm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox command_box;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

