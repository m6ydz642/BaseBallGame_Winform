
namespace BaseBallGame_Winform
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.key1 = new System.Windows.Forms.Button();
            this.key2 = new System.Windows.Forms.Button();
            this.key3 = new System.Windows.Forms.Button();
            this.key4 = new System.Windows.Forms.Button();
            this.key5 = new System.Windows.Forms.Button();
            this.key6 = new System.Windows.Forms.Button();
            this.key7 = new System.Windows.Forms.Button();
            this.key8 = new System.Windows.Forms.Button();
            this.key9 = new System.Windows.Forms.Button();
            this.buttonRetry = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listViewGameStart = new System.Windows.Forms.ListView();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.textRandomNumber = new System.Windows.Forms.TextBox();
            this.buttonDBConnect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // key1
            // 
            this.key1.Location = new System.Drawing.Point(67, 108);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(35, 23);
            this.key1.TabIndex = 0;
            this.key1.Text = "1";
            this.key1.UseVisualStyleBackColor = true;
            this.key1.Click += new System.EventHandler(this.clickNumber);
            // 
            // key2
            // 
            this.key2.Location = new System.Drawing.Point(117, 108);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(35, 23);
            this.key2.TabIndex = 1;
            this.key2.Text = "2";
            this.key2.UseVisualStyleBackColor = true;
            this.key2.Click += new System.EventHandler(this.clickNumber);
            // 
            // key3
            // 
            this.key3.Location = new System.Drawing.Point(167, 108);
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(35, 23);
            this.key3.TabIndex = 2;
            this.key3.Text = "3";
            this.key3.UseVisualStyleBackColor = true;
            this.key3.Click += new System.EventHandler(this.clickNumber);
            // 
            // key4
            // 
            this.key4.Location = new System.Drawing.Point(67, 146);
            this.key4.Name = "key4";
            this.key4.Size = new System.Drawing.Size(35, 23);
            this.key4.TabIndex = 3;
            this.key4.Text = "4";
            this.key4.UseVisualStyleBackColor = true;
            this.key4.Click += new System.EventHandler(this.clickNumber);
            // 
            // key5
            // 
            this.key5.Location = new System.Drawing.Point(117, 146);
            this.key5.Name = "key5";
            this.key5.Size = new System.Drawing.Size(35, 23);
            this.key5.TabIndex = 4;
            this.key5.Text = "5";
            this.key5.UseVisualStyleBackColor = true;
            this.key5.Click += new System.EventHandler(this.clickNumber);
            // 
            // key6
            // 
            this.key6.Location = new System.Drawing.Point(167, 146);
            this.key6.Name = "key6";
            this.key6.Size = new System.Drawing.Size(35, 23);
            this.key6.TabIndex = 5;
            this.key6.Text = "6";
            this.key6.UseVisualStyleBackColor = true;
            this.key6.Click += new System.EventHandler(this.clickNumber);
            // 
            // key7
            // 
            this.key7.Location = new System.Drawing.Point(67, 186);
            this.key7.Name = "key7";
            this.key7.Size = new System.Drawing.Size(35, 23);
            this.key7.TabIndex = 6;
            this.key7.Text = "7";
            this.key7.UseVisualStyleBackColor = true;
            this.key7.Click += new System.EventHandler(this.clickNumber);
            // 
            // key8
            // 
            this.key8.Location = new System.Drawing.Point(117, 186);
            this.key8.Name = "key8";
            this.key8.Size = new System.Drawing.Size(35, 23);
            this.key8.TabIndex = 7;
            this.key8.Text = "8";
            this.key8.UseVisualStyleBackColor = true;
            this.key8.Click += new System.EventHandler(this.clickNumber);
            // 
            // key9
            // 
            this.key9.Location = new System.Drawing.Point(167, 186);
            this.key9.Name = "key9";
            this.key9.Size = new System.Drawing.Size(35, 23);
            this.key9.TabIndex = 8;
            this.key9.Text = "9";
            this.key9.UseVisualStyleBackColor = true;
            this.key9.Click += new System.EventHandler(this.clickNumber);
            // 
            // buttonRetry
            // 
            this.buttonRetry.Location = new System.Drawing.Point(98, 227);
            this.buttonRetry.Name = "buttonRetry";
            this.buttonRetry.Size = new System.Drawing.Size(77, 23);
            this.buttonRetry.TabIndex = 9;
            this.buttonRetry.Text = "재시작";
            this.buttonRetry.UseVisualStyleBackColor = true;
            this.buttonRetry.Click += new System.EventHandler(this.buttonRetry_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(234, 108);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(49, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "←";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(234, 146);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(49, 23);
            this.buttonClean.TabIndex = 11;
            this.buttonClean.Text = "지우기";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(234, 186);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(49, 23);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "시작";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listViewGameStart
            // 
            this.listViewGameStart.HideSelection = false;
            this.listViewGameStart.Location = new System.Drawing.Point(316, 58);
            this.listViewGameStart.Name = "listViewGameStart";
            this.listViewGameStart.Size = new System.Drawing.Size(228, 230);
            this.listViewGameStart.TabIndex = 13;
            this.listViewGameStart.UseCompatibleStateImageBehavior = false;
            this.listViewGameStart.View = System.Windows.Forms.View.SmallIcon;
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(67, 58);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.ReadOnly = true;
            this.inputNumber.Size = new System.Drawing.Size(135, 21);
            this.inputNumber.TabIndex = 15;
            this.inputNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textRandomNumber
            // 
            this.textRandomNumber.Location = new System.Drawing.Point(98, 267);
            this.textRandomNumber.Name = "textRandomNumber";
            this.textRandomNumber.ReadOnly = true;
            this.textRandomNumber.Size = new System.Drawing.Size(100, 21);
            this.textRandomNumber.TabIndex = 16;
            // 
            // buttonDBConnect
            // 
            this.buttonDBConnect.Location = new System.Drawing.Point(234, 227);
            this.buttonDBConnect.Name = "buttonDBConnect";
            this.buttonDBConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDBConnect.TabIndex = 17;
            this.buttonDBConnect.Text = "DB값 조회";
            this.buttonDBConnect.UseVisualStyleBackColor = true;
            this.buttonDBConnect.Click += new System.EventHandler(this.buttonDBConnect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(570, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 230);
            this.dataGridView1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "DB값 입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDBConnect);
            this.Controls.Add(this.textRandomNumber);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.listViewGameStart);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRetry);
            this.Controls.Add(this.key9);
            this.Controls.Add(this.key8);
            this.Controls.Add(this.key7);
            this.Controls.Add(this.key6);
            this.Controls.Add(this.key5);
            this.Controls.Add(this.key4);
            this.Controls.Add(this.key3);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.key1);
            this.Name = "Form1";
            this.Text = "숫자야구게임";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button key1;
        private System.Windows.Forms.Button key2;
        private System.Windows.Forms.Button key3;
        private System.Windows.Forms.Button key4;
        private System.Windows.Forms.Button key5;
        private System.Windows.Forms.Button key6;
        private System.Windows.Forms.Button key7;
        private System.Windows.Forms.Button key8;
        private System.Windows.Forms.Button key9;
        private System.Windows.Forms.Button buttonRetry;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListView listViewGameStart;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.TextBox textRandomNumber;
        private System.Windows.Forms.Button buttonDBConnect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

