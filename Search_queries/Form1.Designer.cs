namespace Poisk
{
    partial class FormInformationSearch
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchEngine = new System.Windows.Forms.Label();
            this.textBoxQueryString = new System.Windows.Forms.TextBox();
            this.labelQueryString = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.labelNameSearchEngine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(933, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(232, 105);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // labelSearchEngine
            // 
            this.labelSearchEngine.Location = new System.Drawing.Point(13, 13);
            this.labelSearchEngine.Name = "labelSearchEngine";
            this.labelSearchEngine.Size = new System.Drawing.Size(307, 46);
            this.labelSearchEngine.TabIndex = 2;
            this.labelSearchEngine.Text = "Поисковая система";
            // 
            // textBoxQueryString
            // 
            this.textBoxQueryString.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQueryString.Location = new System.Drawing.Point(326, 62);
            this.textBoxQueryString.Name = "textBoxQueryString";
            this.textBoxQueryString.Size = new System.Drawing.Size(573, 56);
            this.textBoxQueryString.TabIndex = 4;
            // 
            // labelQueryString
            // 
            this.labelQueryString.Location = new System.Drawing.Point(346, 13);
            this.labelQueryString.Name = "labelQueryString";
            this.labelQueryString.Size = new System.Drawing.Size(514, 25);
            this.labelQueryString.TabIndex = 5;
            this.labelQueryString.Text = "Введите запросс для поиска";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 25;
            this.listBoxResult.Location = new System.Drawing.Point(18, 133);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(1618, 404);
            this.listBoxResult.Sorted = true;
            this.listBoxResult.TabIndex = 6;
            // 
            // labelNameSearchEngine
            // 
            this.labelNameSearchEngine.Location = new System.Drawing.Point(12, 59);
            this.labelNameSearchEngine.Name = "labelNameSearchEngine";
            this.labelNameSearchEngine.Size = new System.Drawing.Size(282, 46);
            this.labelNameSearchEngine.TabIndex = 7;
            this.labelNameSearchEngine.Text = "гугл";
            this.labelNameSearchEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInformationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 551);
            this.Controls.Add(this.labelNameSearchEngine);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.labelQueryString);
            this.Controls.Add(this.textBoxQueryString);
            this.Controls.Add(this.labelSearchEngine);
            this.Controls.Add(this.buttonSearch);
            this.Name = "FormInformationSearch";
            this.Text = "Поиск инфации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchEngine;
        private System.Windows.Forms.TextBox textBoxQueryString;
        private System.Windows.Forms.Label labelQueryString;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label labelNameSearchEngine;
    }
}

