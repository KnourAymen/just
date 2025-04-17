namespace management_R_System
{
    partial class Dashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uS_PlaceOrder1 = new management_R_System.AllUserControls.US_PlaceOrder();
            this.uS_ADDItems1 = new management_R_System.AllUserControls.US_ADDItems();
            this.uC_UpdateItems1 = new management_R_System.AllUserControls.UC_UpdateItems();
            this.uC_Reservation1 = new management_R_System.AllUserControls.UC_Reservation();
            this.uC_RemoveItem1 = new management_R_System.AllUserControls.UC_RemoveItem();
            this.uS_Welcome1 = new management_R_System.AllUserControls.US_Welcome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 382);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.uS_PlaceOrder1);
            this.panel2.Controls.Add(this.uS_ADDItems1);
            this.panel2.Controls.Add(this.uC_UpdateItems1);
            this.panel2.Controls.Add(this.uC_Reservation1);
            this.panel2.Controls.Add(this.uC_RemoveItem1);
            this.panel2.Controls.Add(this.uS_Welcome1);
            this.panel2.Location = new System.Drawing.Point(173, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 382);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button5.Image = global::management_R_System.Properties.Resources.Fermer_X_x;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(29, 335);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 33);
            this.button5.TabIndex = 0;
            this.button5.Text = "  Fermer";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::management_R_System.Properties.Resources.Réservation;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 259);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 57);
            this.button6.TabIndex = 4;
            this.button6.Text = " Gestion   \r\n         Réservation";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::management_R_System.Properties.Resources.Supprimer_Articles;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 198);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Supprimer\r\n           Articles";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::management_R_System.Properties.Resources.Modifier_Article;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 132);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modifier\r\n         Articles";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::management_R_System.Properties.Resources.Add_Article;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ajouter     \r\n Articles";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::management_R_System.Properties.Resources.Commander;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestion \r\n          Commandes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uS_PlaceOrder1
            // 
            this.uS_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uS_PlaceOrder1.Margin = new System.Windows.Forms.Padding(2);
            this.uS_PlaceOrder1.Name = "uS_PlaceOrder1";
            this.uS_PlaceOrder1.Size = new System.Drawing.Size(640, 382);
            this.uS_PlaceOrder1.TabIndex = 7;
            // 
            // uS_ADDItems1
            // 
            this.uS_ADDItems1.BackColor = System.Drawing.Color.White;
            this.uS_ADDItems1.Location = new System.Drawing.Point(0, 0);
            this.uS_ADDItems1.Margin = new System.Windows.Forms.Padding(2);
            this.uS_ADDItems1.Name = "uS_ADDItems1";
            this.uS_ADDItems1.Size = new System.Drawing.Size(632, 382);
            this.uS_ADDItems1.TabIndex = 6;
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.BackColor = System.Drawing.Color.White;
            this.uC_UpdateItems1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItems1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(640, 382);
            this.uC_UpdateItems1.TabIndex = 5;
            // 
            // uC_Reservation1
            // 
            this.uC_Reservation1.BackColor = System.Drawing.Color.White;
            this.uC_Reservation1.Location = new System.Drawing.Point(0, 0);
            this.uC_Reservation1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Reservation1.Name = "uC_Reservation1";
            this.uC_Reservation1.Size = new System.Drawing.Size(640, 382);
            this.uC_Reservation1.TabIndex = 4;
            // 
            // uC_RemoveItem1
            // 
            this.uC_RemoveItem1.BackColor = System.Drawing.Color.White;
            this.uC_RemoveItem1.Location = new System.Drawing.Point(-6, 0);
            this.uC_RemoveItem1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_RemoveItem1.Name = "uC_RemoveItem1";
            this.uC_RemoveItem1.Size = new System.Drawing.Size(640, 382);
            this.uC_RemoveItem1.TabIndex = 3;
            // 
            // uS_Welcome1
            // 
            this.uS_Welcome1.Location = new System.Drawing.Point(2, -2);
            this.uS_Welcome1.Margin = new System.Windows.Forms.Padding(2);
            this.uS_Welcome1.Name = "uS_Welcome1";
            this.uS_Welcome1.Size = new System.Drawing.Size(632, 382);
            this.uS_Welcome1.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(805, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private AllUserControls.US_PlaceOrder uS_PlaceOrder1;
        private AllUserControls.US_ADDItems uS_ADDItems1;
        private AllUserControls.UC_UpdateItems uC_UpdateItems1;
        private AllUserControls.UC_Reservation uC_Reservation1;
        private AllUserControls.UC_RemoveItem uC_RemoveItem1;
        private AllUserControls.US_Welcome uS_Welcome1;
    }
}