
namespace AsynchronousClientServer
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
            this.btnStartClient = new System.Windows.Forms.Button();
            this.btnStartListener = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.tbClientMessageSent = new System.Windows.Forms.TextBox();
            this.tbClientMessageReceived = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartClient
            // 
            this.btnStartClient.Location = new System.Drawing.Point(637, 395);
            this.btnStartClient.Name = "btnStartClient";
            this.btnStartClient.Size = new System.Drawing.Size(144, 33);
            this.btnStartClient.TabIndex = 0;
            this.btnStartClient.Text = "Start Client";
            this.btnStartClient.UseVisualStyleBackColor = true;
            this.btnStartClient.Click += new System.EventHandler(this.btnStartClient_Click);
            // 
            // btnStartListener
            // 
            this.btnStartListener.Location = new System.Drawing.Point(24, 395);
            this.btnStartListener.Name = "btnStartListener";
            this.btnStartListener.Size = new System.Drawing.Size(122, 33);
            this.btnStartListener.TabIndex = 0;
            this.btnStartListener.Text = "Start Server";
            this.btnStartListener.UseVisualStyleBackColor = true;
            this.btnStartListener.Click += new System.EventHandler(this.btnStartListener_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(637, 338);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(144, 33);
            this.btnSendMessage.TabIndex = 0;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // tbClientMessageSent
            // 
            this.tbClientMessageSent.Location = new System.Drawing.Point(377, 341);
            this.tbClientMessageSent.Name = "tbClientMessageSent";
            this.tbClientMessageSent.Size = new System.Drawing.Size(241, 26);
            this.tbClientMessageSent.TabIndex = 1;
            // 
            // tbClientMessageReceived
            // 
            this.tbClientMessageReceived.Location = new System.Drawing.Point(377, 295);
            this.tbClientMessageReceived.Name = "tbClientMessageReceived";
            this.tbClientMessageReceived.Size = new System.Drawing.Size(241, 26);
            this.tbClientMessageReceived.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbClientMessageReceived);
            this.Controls.Add(this.tbClientMessageSent);
            this.Controls.Add(this.btnStartListener);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.btnStartClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartClient;
        private System.Windows.Forms.Button btnStartListener;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox tbClientMessageSent;
        private System.Windows.Forms.TextBox tbClientMessageReceived;
    }
}

