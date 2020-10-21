namespace WindowsFormsApp1
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
            this.bilingAmount = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.currentReading = new System.Windows.Forms.TextBox();
            this.phoneNo = new System.Windows.Forms.Label();
            this.meterNo = new System.Windows.Forms.TextBox();
            this.clientID = new System.Windows.Forms.Label();
            this.previousReading = new System.Windows.Forms.TextBox();
            this.meterN = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bilingAmount
            // 
            this.bilingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilingAmount.Location = new System.Drawing.Point(199, 153);
            this.bilingAmount.Name = "bilingAmount";
            this.bilingAmount.Size = new System.Drawing.Size(154, 23);
            this.bilingAmount.TabIndex = 14;
            // 
            // address
            // 
            this.address.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(106, 153);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(60, 17);
            this.address.TabIndex = 20;
            this.address.Text = "Address";
            // 
            // currentReading
            // 
            this.currentReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentReading.Location = new System.Drawing.Point(199, 113);
            this.currentReading.Name = "currentReading";
            this.currentReading.Size = new System.Drawing.Size(154, 23);
            this.currentReading.TabIndex = 13;
            // 
            // phoneNo
            // 
            this.phoneNo.AutoSize = true;
            this.phoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNo.Location = new System.Drawing.Point(106, 113);
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(74, 17);
            this.phoneNo.TabIndex = 19;
            this.phoneNo.Text = "Phone NO";
            // 
            // meterNo
            // 
            this.meterNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meterNo.Location = new System.Drawing.Point(199, 35);
            this.meterNo.Name = "meterNo";
            this.meterNo.Size = new System.Drawing.Size(154, 23);
            this.meterNo.TabIndex = 11;
            // 
            // clientID
            // 
            this.clientID.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.clientID.AutoSize = true;
            this.clientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientID.Location = new System.Drawing.Point(106, 35);
            this.clientID.Name = "clientID";
            this.clientID.Size = new System.Drawing.Size(60, 17);
            this.clientID.TabIndex = 15;
            this.clientID.Text = "Client ID";
            this.clientID.Click += new System.EventHandler(this.clientID_Click);
            // 
            // previousReading
            // 
            this.previousReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousReading.Location = new System.Drawing.Point(199, 74);
            this.previousReading.Name = "previousReading";
            this.previousReading.Size = new System.Drawing.Size(154, 23);
            this.previousReading.TabIndex = 12;
            // 
            // meterN
            // 
            this.meterN.AutoSize = true;
            this.meterN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meterN.Location = new System.Drawing.Point(106, 74);
            this.meterN.Name = "meterN";
            this.meterN.Size = new System.Drawing.Size(66, 17);
            this.meterN.TabIndex = 17;
            this.meterN.Text = "Meter No";
            this.meterN.Click += new System.EventHandler(this.meterN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(124, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(199, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 23);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 341);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bilingAmount);
            this.Controls.Add(this.address);
            this.Controls.Add(this.currentReading);
            this.Controls.Add(this.phoneNo);
            this.Controls.Add(this.meterNo);
            this.Controls.Add(this.clientID);
            this.Controls.Add(this.previousReading);
            this.Controls.Add(this.meterN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bilingAmount;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox currentReading;
        private System.Windows.Forms.Label phoneNo;
        private System.Windows.Forms.TextBox meterNo;
        private System.Windows.Forms.Label clientID;
        private System.Windows.Forms.TextBox previousReading;
        private System.Windows.Forms.Label meterN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}