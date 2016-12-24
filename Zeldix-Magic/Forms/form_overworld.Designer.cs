namespace Zeldix.Forms
{
    partial class form_overworld
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_map = new System.Windows.Forms.Label();
            this.textBox_room_id = new System.Windows.Forms.TextBox();
            this.label_room_id = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(55, 55);
            this.flowLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(11, 11);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(288, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(110, 256);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "32x32 Blocks go here";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoScrollMargin = new System.Drawing.Size(55, 55);
            this.flowLayoutPanel2.AutoScrollMinSize = new System.Drawing.Size(11, 11);
            this.flowLayoutPanel2.Controls.Add(this.label_map);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 115);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(256, 256);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label_map
            // 
            this.label_map.AutoSize = true;
            this.label_map.Location = new System.Drawing.Point(3, 0);
            this.label_map.Name = "label_map";
            this.label_map.Size = new System.Drawing.Size(78, 13);
            this.label_map.TabIndex = 4;
            this.label_map.Text = "Map goes here";
            // 
            // textBox_room_id
            // 
            this.textBox_room_id.Location = new System.Drawing.Point(67, 13);
            this.textBox_room_id.MaxLength = 2;
            this.textBox_room_id.Name = "textBox_room_id";
            this.textBox_room_id.Size = new System.Drawing.Size(26, 20);
            this.textBox_room_id.TabIndex = 2;
            this.textBox_room_id.TextChanged += new System.EventHandler(this.textBox_room_id_TextChanged);
            // 
            // label_room_id
            // 
            this.label_room_id.AutoSize = true;
            this.label_room_id.Location = new System.Drawing.Point(9, 16);
            this.label_room_id.Name = "label_room_id";
            this.label_room_id.Size = new System.Drawing.Size(52, 13);
            this.label_room_id.TabIndex = 3;
            this.label_room_id.Text = "Room ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_overworld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_room_id);
            this.Controls.Add(this.textBox_room_id);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "form_overworld";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overworld";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label_map;
        private System.Windows.Forms.TextBox textBox_room_id;
        private System.Windows.Forms.Label label_room_id;
        private System.Windows.Forms.Button button1;
    }
}