
namespace CurrencyConverter
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
            this.components = new System.ComponentModel.Container();
            this.convertButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.currencyFromBox = new System.Windows.Forms.ComboBox();
            this.convertText = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.currencyToBox = new System.Windows.Forms.ComboBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.roundUp = new System.Windows.Forms.Button();
            this.overlay = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.convertFromLabel = new System.Windows.Forms.Label();
            this.convertAmountLabel = new System.Windows.Forms.Label();
            this.convertToLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(148, 256);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(78, 55);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.toolTip1.SetToolTip(this.convertButton, "Click Here to convert your sum!\r\nEnsure that all 3 entry fields above are filled " +
        "in first.");
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // currencyFromBox
            // 
            this.currencyFromBox.FormattingEnabled = true;
            this.currencyFromBox.Items.AddRange(new object[] {
            "AED",
            "AFN",
            "ALL",
            "AMD",
            "ANG",
            "AOA",
            "ARS",
            "AUD",
            "AWG",
            "AZN",
            "BAM",
            "BBD",
            "BDT",
            "BGN",
            "BHD",
            "BIF",
            "BMD",
            "BND",
            "BOB",
            "BOV",
            "BRL",
            "BSD",
            "BTN",
            "BWP",
            "BYN",
            "BZD",
            "CAD",
            "CDF",
            "CHE",
            "CHF",
            "CHW",
            "CLF",
            "CLP",
            "CNY",
            "COP",
            "COU",
            "CRC",
            "CUC",
            "CUP",
            "CVE",
            "CZK",
            "DJF",
            "DKK",
            "DOP",
            "DZD",
            "EGP",
            "ERN",
            "ETB",
            "EUR",
            "FJD",
            "FKP",
            "GBP",
            "GEL",
            "GHS",
            "GIP",
            "GMD",
            "GNF",
            "GTQ",
            "GYD",
            "HKD",
            "HNL",
            "HRK",
            "HTG",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "IQD",
            "IRR",
            "ISK",
            "JMD",
            "JOD",
            "JPY",
            "KES",
            "KGS",
            "KHR",
            "KMF",
            "KPW",
            "KRW",
            "KWD",
            "KYD",
            "KZT",
            "LAK",
            "LBP",
            "LKR",
            "LRD",
            "LSL",
            "LYD",
            "MAD",
            "MDL",
            "MGA",
            "MKD",
            "MMK",
            "MNT",
            "MOP",
            "MRU",
            "MUR",
            "MVR",
            "MWK",
            "MXN",
            "MXV",
            "MYR",
            "MZN",
            "NAD",
            "NGN",
            "NIO",
            "NOK",
            "NPR",
            "NZD",
            "OMR",
            "PAB",
            "PEN",
            "PGK",
            "PHP",
            "PKR",
            "PLN",
            "PYG",
            "QAR",
            "RON",
            "RSD",
            "RUB",
            "RWF",
            "SAR",
            "SBD",
            "SCR",
            "SDG",
            "SEK",
            "SGD",
            "SHP",
            "SLL",
            "SOS",
            "SRD",
            "SSP",
            "STN",
            "SVC",
            "SYP",
            "SZL",
            "THB",
            "TJS",
            "TMT",
            "TND",
            "TOP",
            "TRY",
            "TTD",
            "TWD",
            "TZS",
            "UAH",
            "UGX",
            "USD",
            "USN",
            "UYI",
            "UYU",
            "UYW",
            "UZS",
            "VES",
            "VND",
            "VUV",
            "WST",
            "XAF",
            "XCD",
            "XDR",
            "XOF",
            "XPF",
            "XSU",
            "XUA",
            "YER",
            "ZAR",
            "ZMW",
            "ZWL"});
            this.currencyFromBox.Location = new System.Drawing.Point(314, 121);
            this.currencyFromBox.Name = "currencyFromBox";
            this.currencyFromBox.Size = new System.Drawing.Size(133, 21);
            this.currencyFromBox.Sorted = true;
            this.currencyFromBox.TabIndex = 3;
            // 
            // convertText
            // 
            this.convertText.Location = new System.Drawing.Point(148, 121);
            this.convertText.Name = "convertText";
            this.convertText.Size = new System.Drawing.Size(146, 20);
            this.convertText.TabIndex = 4;
            this.convertText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.convertText.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.LightSalmon;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.output.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.output.Location = new System.Drawing.Point(259, 176);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(339, 43);
            this.output.TabIndex = 5;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // currencyToBox
            // 
            this.currencyToBox.FormattingEnabled = true;
            this.currencyToBox.Items.AddRange(new object[] {
            "AED",
            "AFN",
            "ALL",
            "AMD",
            "ANG",
            "AOA",
            "ARS",
            "AUD",
            "AWG",
            "AZN",
            "BAM",
            "BBD",
            "BDT",
            "BGN",
            "BHD",
            "BIF",
            "BMD",
            "BND",
            "BOB",
            "BOV",
            "BRL",
            "BSD",
            "BTN",
            "BWP",
            "BYN",
            "BZD",
            "CAD",
            "CDF",
            "CHE",
            "CHF",
            "CHW",
            "CLF",
            "CLP",
            "CNY",
            "COP",
            "COU",
            "CRC",
            "CUC",
            "CUP",
            "CVE",
            "CZK",
            "DJF",
            "DKK",
            "DOP",
            "DZD",
            "EGP",
            "ERN",
            "ETB",
            "EUR",
            "FJD",
            "FKP",
            "GBP",
            "GEL",
            "GHS",
            "GIP",
            "GMD",
            "GNF",
            "GTQ",
            "GYD",
            "HKD",
            "HNL",
            "HRK",
            "HTG",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "IQD",
            "IRR",
            "ISK",
            "JMD",
            "JOD",
            "JPY",
            "KES",
            "KGS",
            "KHR",
            "KMF",
            "KPW",
            "KRW",
            "KWD",
            "KYD",
            "KZT",
            "LAK",
            "LBP",
            "LKR",
            "LRD",
            "LSL",
            "LYD",
            "MAD",
            "MDL",
            "MGA",
            "MKD",
            "MMK",
            "MNT",
            "MOP",
            "MRU",
            "MUR",
            "MVR",
            "MWK",
            "MXN",
            "MXV",
            "MYR",
            "MZN",
            "NAD",
            "NGN",
            "NIO",
            "NOK",
            "NPR",
            "NZD",
            "OMR",
            "PAB",
            "PEN",
            "PGK",
            "PHP",
            "PKR",
            "PLN",
            "PYG",
            "QAR",
            "RON",
            "RSD",
            "RUB",
            "RWF",
            "SAR",
            "SBD",
            "SCR",
            "SDG",
            "SEK",
            "SGD",
            "SHP",
            "SLL",
            "SOS",
            "SRD",
            "SSP",
            "STN",
            "SVC",
            "SYP",
            "SZL",
            "THB",
            "TJS",
            "TMT",
            "TND",
            "TOP",
            "TRY",
            "TTD",
            "TWD",
            "TZS",
            "UAH",
            "UGX",
            "USD",
            "USN",
            "UYI",
            "UYU",
            "UYW",
            "UZS",
            "VES",
            "VND",
            "VUV",
            "WST",
            "XAF",
            "XCD",
            "XDR",
            "XOF",
            "XPF",
            "XSU",
            "XUA",
            "YER",
            "ZAR",
            "ZMW",
            "ZWL"});
            this.currencyToBox.Location = new System.Drawing.Point(465, 121);
            this.currencyToBox.Name = "currencyToBox";
            this.currencyToBox.Size = new System.Drawing.Size(133, 21);
            this.currencyToBox.Sorted = true;
            this.currencyToBox.TabIndex = 7;
            this.currencyToBox.SelectedIndexChanged += new System.EventHandler(this.currencyBoxTo_SelectedIndexChanged);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(520, 256);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(78, 55);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // roundUp
            // 
            this.roundUp.Location = new System.Drawing.Point(259, 271);
            this.roundUp.Name = "roundUp";
            this.roundUp.Size = new System.Drawing.Size(231, 25);
            this.roundUp.TabIndex = 8;
            this.roundUp.Text = "Round up";
            this.roundUp.UseVisualStyleBackColor = true;
            this.roundUp.Visible = false;
            this.roundUp.Click += new System.EventHandler(this.roundUp_Click);
            // 
            // overlay
            // 
            this.overlay.BackColor = System.Drawing.Color.LightSalmon;
            this.overlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.overlay.Location = new System.Drawing.Point(123, 29);
            this.overlay.Name = "overlay";
            this.overlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.overlay.Size = new System.Drawing.Size(498, 291);
            this.overlay.TabIndex = 1;
            this.overlay.Text = "Currency Converter\r\n\r\nFollow These Steps:\r\n1) Enter the Sum to Convert.\r\n2) Enter" +
    " the Currency to Convert from.\r\n3) Enter the Currency to Convert to.\r\n4) Click t" +
    "he Convert Button\r\n\r\nClick To Begin";
            this.overlay.UseVisualStyleBackColor = false;
            this.overlay.Click += new System.EventHandler(this.overlay_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(129, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 291);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(259, 271);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(231, 25);
            this.goBack.TabIndex = 10;
            this.goBack.Text = "Go Back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Visible = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // convertFromLabel
            // 
            this.convertFromLabel.AutoSize = true;
            this.convertFromLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.convertFromLabel.Location = new System.Drawing.Point(311, 93);
            this.convertFromLabel.Name = "convertFromLabel";
            this.convertFromLabel.Size = new System.Drawing.Size(101, 13);
            this.convertFromLabel.TabIndex = 11;
            this.convertFromLabel.Text = "From This Currency:";
            this.convertFromLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // convertAmountLabel
            // 
            this.convertAmountLabel.AutoSize = true;
            this.convertAmountLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.convertAmountLabel.Location = new System.Drawing.Point(145, 93);
            this.convertAmountLabel.Name = "convertAmountLabel";
            this.convertAmountLabel.Size = new System.Drawing.Size(109, 13);
            this.convertAmountLabel.TabIndex = 12;
            this.convertAmountLabel.Text = "Convert This Amount:";
            // 
            // convertToLabel
            // 
            this.convertToLabel.AutoSize = true;
            this.convertToLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.convertToLabel.Location = new System.Drawing.Point(462, 93);
            this.convertToLabel.Name = "convertToLabel";
            this.convertToLabel.Size = new System.Drawing.Size(91, 13);
            this.convertToLabel.TabIndex = 13;
            this.convertToLabel.Text = "To This Currency:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.LightSalmon;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(148, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(270, 33);
            this.title.TabIndex = 14;
            this.title.Text = "Currency Converter";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Black;
            this.resultLabel.Location = new System.Drawing.Point(149, 179);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(81, 29);
            this.resultLabel.TabIndex = 15;
            this.resultLabel.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 362);
            this.Controls.Add(this.overlay);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.convertToLabel);
            this.Controls.Add(this.convertAmountLabel);
            this.Controls.Add(this.convertFromLabel);
            this.Controls.Add(this.roundUp);
            this.Controls.Add(this.currencyToBox);
            this.Controls.Add(this.output);
            this.Controls.Add(this.convertText);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.currencyFromBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox currencyFromBox;
        private System.Windows.Forms.TextBox convertText;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.ComboBox currencyToBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button roundUp;
        private System.Windows.Forms.Button overlay;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label convertFromLabel;
        private System.Windows.Forms.Label convertAmountLabel;
        private System.Windows.Forms.Label convertToLabel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

