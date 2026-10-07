namespace ChenAmazon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPID = new TextBox();
            textBoxPN = new TextBox();
            textBoxPD = new TextBox();
            listView1 = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonClear = new Button();
            buttonCount = new Button();
            buttonExit = new Button();
            lblCount = new Label();
            buttonPartial = new Button();
            buttonFull = new Button();
            textBoxTracking = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxPID
            // 
            textBoxPID.Location = new Point(209, 82);
            textBoxPID.Name = "textBoxPID";
            textBoxPID.Size = new Size(100, 23);
            textBoxPID.TabIndex = 0;
            // 
            // textBoxPN
            // 
            textBoxPN.Location = new Point(209, 111);
            textBoxPN.Name = "textBoxPN";
            textBoxPN.Size = new Size(100, 23);
            textBoxPN.TabIndex = 1;
            // 
            // textBoxPD
            // 
            textBoxPD.Location = new Point(209, 140);
            textBoxPD.Name = "textBoxPD";
            textBoxPD.Size = new Size(100, 23);
            textBoxPD.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Location = new Point(357, 82);
            listView1.Name = "listView1";
            listView1.Size = new Size(663, 215);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 85);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 4;
            label1.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 114);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 5;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 143);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 6;
            label3.Text = "Description";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(114, 274);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(195, 274);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 8;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(276, 274);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonCount
            // 
            buttonCount.Location = new Point(159, 305);
            buttonCount.Name = "buttonCount";
            buttonCount.Size = new Size(75, 23);
            buttonCount.TabIndex = 10;
            buttonCount.Text = "Count";
            buttonCount.UseVisualStyleBackColor = true;
            buttonCount.Click += buttonCount_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(240, 305);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(315, 229);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 17);
            lblCount.TabIndex = 12;
            // 
            // buttonPartial
            // 
            buttonPartial.Location = new Point(175, 334);
            buttonPartial.Name = "buttonPartial";
            buttonPartial.Size = new Size(117, 23);
            buttonPartial.TabIndex = 13;
            buttonPartial.Text = "Add Partial";
            buttonPartial.UseVisualStyleBackColor = true;
            buttonPartial.Click += buttonPartial_Click;
            // 
            // buttonFull
            // 
            buttonFull.Location = new Point(175, 363);
            buttonFull.Name = "buttonFull";
            buttonFull.Size = new Size(117, 23);
            buttonFull.TabIndex = 14;
            buttonFull.Text = "Add Full";
            buttonFull.UseVisualStyleBackColor = true;
            buttonFull.Click += buttonFull_Click;
            // 
            // textBoxTracking
            // 
            textBoxTracking.Location = new Point(209, 169);
            textBoxTracking.Name = "textBoxTracking";
            textBoxTracking.Size = new Size(100, 23);
            textBoxTracking.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 172);
            label4.Name = "label4";
            label4.Size = new Size(110, 17);
            label4.TabIndex = 16;
            label4.Text = "Tracking Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 450);
            Controls.Add(label4);
            Controls.Add(textBoxTracking);
            Controls.Add(buttonFull);
            Controls.Add(buttonPartial);
            Controls.Add(lblCount);
            Controls.Add(buttonExit);
            Controls.Add(buttonCount);
            Controls.Add(buttonClear);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(textBoxPD);
            Controls.Add(textBoxPN);
            Controls.Add(textBoxPID);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPID;
        private TextBox textBoxPN;
        private TextBox textBoxPD;
        private ListView listView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonClear;
        private Button buttonCount;
        private Button buttonExit;
        private Label lblCount;
        private Button buttonPartial;
        private Button buttonFull;
        private TextBox textBoxTracking;
        private Label label4;
    }
}
