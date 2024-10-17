namespace upravlenie_podkluchen_ustroystv
{
    partial class Form1
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
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.textBoxDeviceInfo = new System.Windows.Forms.TextBox();
            this.labelDeviceInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.Location = new System.Drawing.Point(0, 0);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(624, 95);
            this.listBoxDevices.TabIndex = 0;
            this.listBoxDevices.SelectedIndexChanged += new System.EventHandler(this.listBoxDevices_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(35, 154);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(209, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "обновления списка устройств";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // buttonDisable
            // 
            this.buttonDisable.Location = new System.Drawing.Point(336, 154);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(209, 23);
            this.buttonDisable.TabIndex = 2;
            this.buttonDisable.Text = "отключения выбранного устройства";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // textBoxDeviceInfo
            // 
            this.textBoxDeviceInfo.Location = new System.Drawing.Point(0, 287);
            this.textBoxDeviceInfo.Name = "textBoxDeviceInfo";
            this.textBoxDeviceInfo.Size = new System.Drawing.Size(624, 20);
            this.textBoxDeviceInfo.TabIndex = 3;
            // 
            // labelDeviceInfo
            // 
            this.labelDeviceInfo.AutoSize = true;
            this.labelDeviceInfo.Location = new System.Drawing.Point(32, 258);
            this.labelDeviceInfo.Name = "labelDeviceInfo";
            this.labelDeviceInfo.Size = new System.Drawing.Size(351, 13);
            this.labelDeviceInfo.TabIndex = 4;
            this.labelDeviceInfo.Text = "для отображения заголовка для получения подробной информации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDeviceInfo);
            this.Controls.Add(this.textBoxDeviceInfo);
            this.Controls.Add(this.buttonDisable);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listBoxDevices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDisable;
        private System.Windows.Forms.TextBox textBoxDeviceInfo;
        private System.Windows.Forms.Label labelDeviceInfo;
    }
}

