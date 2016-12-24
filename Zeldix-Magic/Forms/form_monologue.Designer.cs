namespace Zeldix.Forms
{
    partial class form_monologue
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.button_set = new System.Windows.Forms.Button();
            this.radioButton_edit_text = new System.Windows.Forms.RadioButton();
            this.radioButton_edit_dictionary = new System.Windows.Forms.RadioButton();
            this.button_dump = new System.Windows.Forms.Button();
            this.button_values = new System.Windows.Forms.Button();
            this.richTextBox_selected = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_txt = new System.Windows.Forms.RadioButton();
            this.radioButton_hex = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_1 = new System.Windows.Forms.RadioButton();
            this.radioButton_2 = new System.Windows.Forms.RadioButton();
            this.radioButton_custom = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_size = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 80);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(172, 134);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(276, 217);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(75, 23);
            this.button_set.TabIndex = 1;
            this.button_set.Text = "Commit edit";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // radioButton_edit_text
            // 
            this.radioButton_edit_text.AutoSize = true;
            this.radioButton_edit_text.Checked = true;
            this.radioButton_edit_text.Location = new System.Drawing.Point(3, 3);
            this.radioButton_edit_text.Name = "radioButton_edit_text";
            this.radioButton_edit_text.Size = new System.Drawing.Size(67, 17);
            this.radioButton_edit_text.TabIndex = 2;
            this.radioButton_edit_text.TabStop = true;
            this.radioButton_edit_text.Text = "Edit Text";
            this.radioButton_edit_text.UseVisualStyleBackColor = true;
            // 
            // radioButton_edit_dictionary
            // 
            this.radioButton_edit_dictionary.AutoSize = true;
            this.radioButton_edit_dictionary.Enabled = false;
            this.radioButton_edit_dictionary.Location = new System.Drawing.Point(76, 3);
            this.radioButton_edit_dictionary.Name = "radioButton_edit_dictionary";
            this.radioButton_edit_dictionary.Size = new System.Drawing.Size(93, 17);
            this.radioButton_edit_dictionary.TabIndex = 3;
            this.radioButton_edit_dictionary.Text = "Edit Dictionary";
            this.radioButton_edit_dictionary.UseVisualStyleBackColor = true;
            // 
            // button_dump
            // 
            this.button_dump.Location = new System.Drawing.Point(12, 252);
            this.button_dump.Name = "button_dump";
            this.button_dump.Size = new System.Drawing.Size(73, 23);
            this.button_dump.TabIndex = 4;
            this.button_dump.Text = "Dump Script";
            this.button_dump.UseVisualStyleBackColor = true;
            this.button_dump.Click += new System.EventHandler(this.button_dump_Click);
            // 
            // button_values
            // 
            this.button_values.Location = new System.Drawing.Point(340, 278);
            this.button_values.Name = "button_values";
            this.button_values.Size = new System.Drawing.Size(99, 23);
            this.button_values.TabIndex = 6;
            this.button_values.Text = "View value table";
            this.button_values.UseVisualStyleBackColor = true;
            this.button_values.Click += new System.EventHandler(this.button_values_Click);
            // 
            // richTextBox_selected
            // 
            this.richTextBox_selected.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_selected.Location = new System.Drawing.Point(194, 80);
            this.richTextBox_selected.Name = "richTextBox_selected";
            this.richTextBox_selected.Size = new System.Drawing.Size(410, 134);
            this.richTextBox_selected.TabIndex = 7;
            this.richTextBox_selected.Text = "";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Import script";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_import_Click);
            // 
            // radioButton_txt
            // 
            this.radioButton_txt.AutoSize = true;
            this.radioButton_txt.Checked = true;
            this.radioButton_txt.Location = new System.Drawing.Point(3, 3);
            this.radioButton_txt.Name = "radioButton_txt";
            this.radioButton_txt.Size = new System.Drawing.Size(46, 17);
            this.radioButton_txt.TabIndex = 9;
            this.radioButton_txt.TabStop = true;
            this.radioButton_txt.Text = "Text";
            this.radioButton_txt.UseVisualStyleBackColor = true;
            // 
            // radioButton_hex
            // 
            this.radioButton_hex.AutoSize = true;
            this.radioButton_hex.Location = new System.Drawing.Point(55, 3);
            this.radioButton_hex.Name = "radioButton_hex";
            this.radioButton_hex.Size = new System.Drawing.Size(44, 17);
            this.radioButton_hex.TabIndex = 10;
            this.radioButton_hex.Text = "Hex";
            this.radioButton_hex.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.radioButton_txt);
            this.flowLayoutPanel1.Controls.Add(this.radioButton_hex);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(91, 252);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(104, 23);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radioButton_edit_text);
            this.flowLayoutPanel2.Controls.Add(this.radioButton_edit_dictionary);
            this.flowLayoutPanel2.Enabled = false;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 217);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(172, 23);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Submit query";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.radioButton_1);
            this.flowLayoutPanel3.Controls.Add(this.radioButton_2);
            this.flowLayoutPanel3.Controls.Add(this.radioButton_custom);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(152, 70);
            this.flowLayoutPanel3.TabIndex = 15;
            // 
            // radioButton_1
            // 
            this.radioButton_1.AutoSize = true;
            this.radioButton_1.Location = new System.Drawing.Point(3, 3);
            this.radioButton_1.Name = "radioButton_1";
            this.radioButton_1.Size = new System.Drawing.Size(132, 17);
            this.radioButton_1.TabIndex = 0;
            this.radioButton_1.TabStop = true;
            this.radioButton_1.Text = "0xE0000 (Size: $8000)";
            this.radioButton_1.UseVisualStyleBackColor = true;
            this.radioButton_1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_2
            // 
            this.radioButton_2.AutoSize = true;
            this.radioButton_2.Location = new System.Drawing.Point(3, 26);
            this.radioButton_2.Name = "radioButton_2";
            this.radioButton_2.Size = new System.Drawing.Size(132, 17);
            this.radioButton_2.TabIndex = 1;
            this.radioButton_2.TabStop = true;
            this.radioButton_2.Text = "0x75F40 (Size: $14C0)";
            this.radioButton_2.UseVisualStyleBackColor = true;
            this.radioButton_2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton_custom
            // 
            this.radioButton_custom.AutoSize = true;
            this.radioButton_custom.Location = new System.Drawing.Point(3, 49);
            this.radioButton_custom.Name = "radioButton_custom";
            this.radioButton_custom.Size = new System.Drawing.Size(86, 17);
            this.radioButton_custom.TabIndex = 2;
            this.radioButton_custom.TabStop = true;
            this.radioButton_custom.Text = "Custom input";
            this.radioButton_custom.UseVisualStyleBackColor = true;
            this.radioButton_custom.CheckedChanged += new System.EventHandler(this.radioButton_custom_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Starting address: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Size: ";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(286, 1);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(100, 20);
            this.textBox_address.TabIndex = 18;
            // 
            // textBox_size
            // 
            this.textBox_size.Location = new System.Drawing.Point(286, 26);
            this.textBox_size.Name = "textBox_size";
            this.textBox_size.Size = new System.Drawing.Size(100, 20);
            this.textBox_size.TabIndex = 19;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(230, 269);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 20;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // form_monologue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 304);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_size);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox_selected);
            this.Controls.Add(this.button_values);
            this.Controls.Add(this.button_dump);
            this.Controls.Add(this.button_set);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.HelpButton = true;
            this.Name = "form_monologue";
            this.Opacity = 0.9D;
            this.Text = "Text";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.RadioButton radioButton_edit_text;
        private System.Windows.Forms.RadioButton radioButton_edit_dictionary;
        private System.Windows.Forms.Button button_dump;
        private System.Windows.Forms.Button button_values;
        private System.Windows.Forms.RichTextBox richTextBox_selected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_txt;
        private System.Windows.Forms.RadioButton radioButton_hex;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton radioButton_1;
        private System.Windows.Forms.RadioButton radioButton_2;
        private System.Windows.Forms.RadioButton radioButton_custom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.Button button_save;
    }
}