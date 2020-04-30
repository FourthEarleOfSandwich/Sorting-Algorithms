namespace SearchSortAlgorithm
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
            this.button_MergeSort = new System.Windows.Forms.Button();
            this.label_Output = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_InsertionSort = new System.Windows.Forms.Button();
            this.button_SelectionSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_MergeSort
            // 
            this.button_MergeSort.Location = new System.Drawing.Point(62, 106);
            this.button_MergeSort.Name = "button_MergeSort";
            this.button_MergeSort.Size = new System.Drawing.Size(190, 65);
            this.button_MergeSort.TabIndex = 0;
            this.button_MergeSort.Text = "Merge Sort";
            this.button_MergeSort.UseVisualStyleBackColor = true;
            this.button_MergeSort.Click += new System.EventHandler(this.button_MergeSort_Click);
            // 
            // label_Output
            // 
            this.label_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Output.Location = new System.Drawing.Point(62, 210);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(515, 160);
            this.label_Output.TabIndex = 1;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(62, 25);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(126, 65);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Binary Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_InsertionSort
            // 
            this.button_InsertionSort.Location = new System.Drawing.Point(359, 36);
            this.button_InsertionSort.Name = "button_InsertionSort";
            this.button_InsertionSort.Size = new System.Drawing.Size(141, 64);
            this.button_InsertionSort.TabIndex = 3;
            this.button_InsertionSort.Text = "InsertionSort";
            this.button_InsertionSort.UseVisualStyleBackColor = true;
            this.button_InsertionSort.Click += new System.EventHandler(this.button_InsertionSort_Click);
            // 
            // button_SelectionSort
            // 
            this.button_SelectionSort.Location = new System.Drawing.Point(345, 127);
            this.button_SelectionSort.Name = "button_SelectionSort";
            this.button_SelectionSort.Size = new System.Drawing.Size(176, 44);
            this.button_SelectionSort.TabIndex = 4;
            this.button_SelectionSort.Text = "Selection Sort";
            this.button_SelectionSort.UseVisualStyleBackColor = true;
            this.button_SelectionSort.Click += new System.EventHandler(this.button_SelectionSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 659);
            this.Controls.Add(this.button_SelectionSort);
            this.Controls.Add(this.button_InsertionSort);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.button_MergeSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_MergeSort;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_InsertionSort;
        private System.Windows.Forms.Button button_SelectionSort;
    }
}

