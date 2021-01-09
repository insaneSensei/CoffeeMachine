namespace Coffee
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label = new System.Windows.Forms.Label();
            this.espressoCheck = new System.Windows.Forms.CheckBox();
            this.coffeeCheck = new System.Windows.Forms.CheckBox();
            this.teaCheck = new System.Windows.Forms.CheckBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.fiveFt = new System.Windows.Forms.Button();
            this.fiftyFt = new System.Windows.Forms.Button();
            this.twentyFt = new System.Windows.Forms.Button();
            this.twohundredFt = new System.Windows.Forms.Button();
            this.hundredFt = new System.Windows.Forms.Button();
            this.tenFt = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.moneyAdd = new System.Windows.Forms.Label();
            this.waterLabel = new System.Windows.Forms.Label();
            this.inputMaterial = new System.Windows.Forms.TextBox();
            this.materialAdd = new System.Windows.Forms.Button();
            this.sugarScroll = new System.Windows.Forms.TrackBar();
            this.sugarAmount = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.ProgressBar();
            this.debug = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.sugarLabel = new System.Windows.Forms.Label();
            this.userInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sugarScroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.ForeColor = System.Drawing.Color.Gold;
            this.label.Location = new System.Drawing.Point(165, 9);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(214, 36);
            this.label.TabIndex = 0;
            this.label.Text = "CoffeeMachine";
            // 
            // espressoCheck
            // 
            this.espressoCheck.AutoSize = true;
            this.espressoCheck.BackColor = System.Drawing.Color.Transparent;
            this.espressoCheck.ForeColor = System.Drawing.Color.White;
            this.espressoCheck.Location = new System.Drawing.Point(16, 74);
            this.espressoCheck.Margin = new System.Windows.Forms.Padding(4);
            this.espressoCheck.Name = "espressoCheck";
            this.espressoCheck.Size = new System.Drawing.Size(89, 21);
            this.espressoCheck.TabIndex = 1;
            this.espressoCheck.Text = "Espresso";
            this.espressoCheck.UseVisualStyleBackColor = false;
            this.espressoCheck.CheckedChanged += new System.EventHandler(this.espressoCheck_CheckedChanged);
            // 
            // coffeeCheck
            // 
            this.coffeeCheck.AutoSize = true;
            this.coffeeCheck.BackColor = System.Drawing.Color.Transparent;
            this.coffeeCheck.ForeColor = System.Drawing.Color.White;
            this.coffeeCheck.Location = new System.Drawing.Point(16, 102);
            this.coffeeCheck.Margin = new System.Windows.Forms.Padding(4);
            this.coffeeCheck.Name = "coffeeCheck";
            this.coffeeCheck.Size = new System.Drawing.Size(71, 21);
            this.coffeeCheck.TabIndex = 2;
            this.coffeeCheck.Text = "Coffee";
            this.coffeeCheck.UseVisualStyleBackColor = false;
            this.coffeeCheck.CheckedChanged += new System.EventHandler(this.coffeeCheck_CheckedChanged);
            // 
            // teaCheck
            // 
            this.teaCheck.AutoSize = true;
            this.teaCheck.BackColor = System.Drawing.Color.Transparent;
            this.teaCheck.ForeColor = System.Drawing.Color.White;
            this.teaCheck.Location = new System.Drawing.Point(16, 130);
            this.teaCheck.Margin = new System.Windows.Forms.Padding(4);
            this.teaCheck.Name = "teaCheck";
            this.teaCheck.Size = new System.Drawing.Size(55, 21);
            this.teaCheck.TabIndex = 3;
            this.teaCheck.Text = "Tea";
            this.teaCheck.UseVisualStyleBackColor = false;
            this.teaCheck.CheckedChanged += new System.EventHandler(this.teaCheck_CheckedChanged);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.ForeColor = System.Drawing.Color.Navy;
            this.startBtn.Location = new System.Drawing.Point(16, 554);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(444, 49);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_ClickAsync);
            // 
            // fiveFt
            // 
            this.fiveFt.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.fiveFt.FlatAppearance.BorderSize = 3;
            this.fiveFt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fiveFt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.fiveFt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fiveFt.Location = new System.Drawing.Point(504, 395);
            this.fiveFt.Margin = new System.Windows.Forms.Padding(4);
            this.fiveFt.Name = "fiveFt";
            this.fiveFt.Size = new System.Drawing.Size(85, 63);
            this.fiveFt.TabIndex = 5;
            this.fiveFt.Text = "5FT";
            this.fiveFt.UseVisualStyleBackColor = true;
            this.fiveFt.Click += new System.EventHandler(this.fiveFt_Click);
            // 
            // fiftyFt
            // 
            this.fiftyFt.Location = new System.Drawing.Point(596, 465);
            this.fiftyFt.Margin = new System.Windows.Forms.Padding(4);
            this.fiftyFt.Name = "fiftyFt";
            this.fiftyFt.Size = new System.Drawing.Size(87, 64);
            this.fiftyFt.TabIndex = 6;
            this.fiftyFt.Text = "50FT";
            this.fiftyFt.UseVisualStyleBackColor = true;
            this.fiftyFt.Click += new System.EventHandler(this.fiftyFt_Click);
            // 
            // twentyFt
            // 
            this.twentyFt.Location = new System.Drawing.Point(504, 465);
            this.twentyFt.Margin = new System.Windows.Forms.Padding(4);
            this.twentyFt.Name = "twentyFt";
            this.twentyFt.Size = new System.Drawing.Size(85, 64);
            this.twentyFt.TabIndex = 7;
            this.twentyFt.Text = "20FT";
            this.twentyFt.UseVisualStyleBackColor = true;
            this.twentyFt.Click += new System.EventHandler(this.twentyFt_Click);
            // 
            // twohundredFt
            // 
            this.twohundredFt.Location = new System.Drawing.Point(596, 537);
            this.twohundredFt.Margin = new System.Windows.Forms.Padding(4);
            this.twohundredFt.Name = "twohundredFt";
            this.twohundredFt.Size = new System.Drawing.Size(87, 66);
            this.twohundredFt.TabIndex = 8;
            this.twohundredFt.Text = "200FT";
            this.twohundredFt.UseVisualStyleBackColor = true;
            this.twohundredFt.Click += new System.EventHandler(this.twohundredFt_Click);
            // 
            // hundredFt
            // 
            this.hundredFt.Location = new System.Drawing.Point(503, 537);
            this.hundredFt.Margin = new System.Windows.Forms.Padding(4);
            this.hundredFt.Name = "hundredFt";
            this.hundredFt.Size = new System.Drawing.Size(87, 66);
            this.hundredFt.TabIndex = 9;
            this.hundredFt.Text = "100FT";
            this.hundredFt.UseVisualStyleBackColor = true;
            this.hundredFt.Click += new System.EventHandler(this.hundredFt_Click);
            // 
            // tenFt
            // 
            this.tenFt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tenFt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.tenFt.Location = new System.Drawing.Point(597, 395);
            this.tenFt.Margin = new System.Windows.Forms.Padding(4);
            this.tenFt.Name = "tenFt";
            this.tenFt.Size = new System.Drawing.Size(85, 63);
            this.tenFt.TabIndex = 10;
            this.tenFt.Text = "10FT";
            this.tenFt.UseVisualStyleBackColor = true;
            this.tenFt.Click += new System.EventHandler(this.tenFt_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(12, 395);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 17);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Price: ";
            // 
            // moneyAdd
            // 
            this.moneyAdd.AutoSize = true;
            this.moneyAdd.BackColor = System.Drawing.Color.Transparent;
            this.moneyAdd.ForeColor = System.Drawing.Color.White;
            this.moneyAdd.Location = new System.Drawing.Point(12, 442);
            this.moneyAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moneyAdd.Name = "moneyAdd";
            this.moneyAdd.Size = new System.Drawing.Size(102, 17);
            this.moneyAdd.TabIndex = 12;
            this.moneyAdd.Text = "Money added: ";
            // 
            // waterLabel
            // 
            this.waterLabel.AutoSize = true;
            this.waterLabel.BackColor = System.Drawing.Color.Transparent;
            this.waterLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.waterLabel.ForeColor = System.Drawing.Color.Aqua;
            this.waterLabel.Location = new System.Drawing.Point(459, 122);
            this.waterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(105, 29);
            this.waterLabel.TabIndex = 14;
            this.waterLabel.Text = "Water: ";
            // 
            // inputMaterial
            // 
            this.inputMaterial.BackColor = System.Drawing.SystemColors.Info;
            this.inputMaterial.Location = new System.Drawing.Point(504, 224);
            this.inputMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.inputMaterial.Name = "inputMaterial";
            this.inputMaterial.Size = new System.Drawing.Size(65, 22);
            this.inputMaterial.TabIndex = 15;
            this.inputMaterial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputWater_MouseClick);
            // 
            // materialAdd
            // 
            this.materialAdd.Location = new System.Drawing.Point(573, 224);
            this.materialAdd.Margin = new System.Windows.Forms.Padding(4);
            this.materialAdd.Name = "materialAdd";
            this.materialAdd.Size = new System.Drawing.Size(58, 22);
            this.materialAdd.TabIndex = 16;
            this.materialAdd.Text = "Add";
            this.materialAdd.UseVisualStyleBackColor = true;
            this.materialAdd.Click += new System.EventHandler(this.waterAdd_Click);
            // 
            // sugarScroll
            // 
            this.sugarScroll.BackColor = System.Drawing.Color.Snow;
            this.sugarScroll.Location = new System.Drawing.Point(16, 300);
            this.sugarScroll.Margin = new System.Windows.Forms.Padding(4);
            this.sugarScroll.Name = "sugarScroll";
            this.sugarScroll.Size = new System.Drawing.Size(139, 56);
            this.sugarScroll.TabIndex = 17;
            this.sugarScroll.Scroll += new System.EventHandler(this.sugarScroll_Scroll);
            // 
            // sugarAmount
            // 
            this.sugarAmount.AutoSize = true;
            this.sugarAmount.BackColor = System.Drawing.Color.Transparent;
            this.sugarAmount.ForeColor = System.Drawing.Color.White;
            this.sugarAmount.Location = new System.Drawing.Point(12, 254);
            this.sugarAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sugarAmount.Name = "sugarAmount";
            this.sugarAmount.Size = new System.Drawing.Size(54, 17);
            this.sugarAmount.TabIndex = 18;
            this.sugarAmount.Text = "Sugar: ";
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loading.ForeColor = System.Drawing.Color.LavenderBlush;
            this.loading.Location = new System.Drawing.Point(16, 501);
            this.loading.Margin = new System.Windows.Forms.Padding(4);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(444, 28);
            this.loading.Step = 100;
            this.loading.TabIndex = 19;
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(503, 300);
            this.debug.Margin = new System.Windows.Forms.Padding(4);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(128, 76);
            this.debug.TabIndex = 20;
            this.debug.TabStop = false;
            this.debug.Text = "Debug";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // sugarLabel
            // 
            this.sugarLabel.AutoSize = true;
            this.sugarLabel.BackColor = System.Drawing.Color.Transparent;
            this.sugarLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sugarLabel.ForeColor = System.Drawing.Color.Crimson;
            this.sugarLabel.Location = new System.Drawing.Point(459, 151);
            this.sugarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sugarLabel.Name = "sugarLabel";
            this.sugarLabel.Size = new System.Drawing.Size(94, 29);
            this.sugarLabel.TabIndex = 21;
            this.sugarLabel.Text = "Sugar:";
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.BackColor = System.Drawing.Color.Transparent;
            this.userInfo.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.userInfo.Location = new System.Drawing.Point(475, 18);
            this.userInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(0, 25);
            this.userInfo.TabIndex = 22;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 618);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.sugarLabel);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.coffeeCheck);
            this.Controls.Add(this.espressoCheck);
            this.Controls.Add(this.teaCheck);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.sugarAmount);
            this.Controls.Add(this.sugarScroll);
            this.Controls.Add(this.materialAdd);
            this.Controls.Add(this.inputMaterial);
            this.Controls.Add(this.waterLabel);
            this.Controls.Add(this.moneyAdd);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.tenFt);
            this.Controls.Add(this.hundredFt);
            this.Controls.Add(this.twohundredFt);
            this.Controls.Add(this.twentyFt);
            this.Controls.Add(this.fiftyFt);
            this.Controls.Add(this.fiveFt);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoffeeMachine";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sugarScroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox espressoCheck;
        private System.Windows.Forms.CheckBox coffeeCheck;
        private System.Windows.Forms.CheckBox teaCheck;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button fiveFt;
        private System.Windows.Forms.Button fiftyFt;
        private System.Windows.Forms.Button twentyFt;
        private System.Windows.Forms.Button twohundredFt;
        private System.Windows.Forms.Button hundredFt;
        private System.Windows.Forms.Button tenFt;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label moneyAdd;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.TextBox inputMaterial;
        private System.Windows.Forms.Button materialAdd;
        private System.Windows.Forms.TrackBar sugarScroll;
        private System.Windows.Forms.Label sugarAmount;
        private System.Windows.Forms.ProgressBar loading;
        private System.Windows.Forms.Button debug;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label sugarLabel;
        private System.Windows.Forms.Label userInfo;
    }
}

