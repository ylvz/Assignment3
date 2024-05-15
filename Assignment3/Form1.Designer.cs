using System.Windows.Forms;

namespace Assignment3
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
            this.producerSectionBox = new System.Windows.Forms.GroupBox();
            this.bOSCHBox = new System.Windows.Forms.GroupBox();
            this.bOSCHStopBtn = new System.Windows.Forms.Button();
            this.bOSCHStartBtn = new System.Windows.Forms.Button();
            this.bOSCHStatus = new System.Windows.Forms.Label();
            this.bOSCHStatusLabel = new System.Windows.Forms.Label();
            this.razerBox = new System.Windows.Forms.GroupBox();
            this.razerStopBtn = new System.Windows.Forms.Button();
            this.razerStartBtn = new System.Windows.Forms.Button();
            this.razerStatus = new System.Windows.Forms.Label();
            this.razerStatusLabel = new System.Windows.Forms.Label();
            this.lantmannenBox = new System.Windows.Forms.GroupBox();
            this.lantmannenStopBtn = new System.Windows.Forms.Button();
            this.lantmannenStartBtn = new System.Windows.Forms.Button();
            this.lantmannenStatus = new System.Windows.Forms.Label();
            this.lantmannenStatusLabel = new System.Windows.Forms.Label();
            this.consumerSectionBox = new System.Windows.Forms.GroupBox();
            this.vetZooBox = new System.Windows.Forms.GroupBox();
            this.vetZooListbox = new System.Windows.Forms.ListBox();
            this.vetZooStopBtn = new System.Windows.Forms.Button();
            this.vetZooStartBtn = new System.Windows.Forms.Button();
            this.vetZooCheckbox = new System.Windows.Forms.CheckBox();
            this.vetZooStatusLabel = new System.Windows.Forms.Label();
            this.vetZooStatus = new System.Windows.Forms.Label();
            this.trixieBox = new System.Windows.Forms.GroupBox();
            this.trixieListBox = new System.Windows.Forms.ListBox();
            this.trixieStopBtn = new System.Windows.Forms.Button();
            this.trixieStartBtn = new System.Windows.Forms.Button();
            this.trixieCheckbox = new System.Windows.Forms.CheckBox();
            this.trixieStatusLabel = new System.Windows.Forms.Label();
            this.trixieStatus = new System.Windows.Forms.Label();
            this.royalCaninSectionBox = new System.Windows.Forms.GroupBox();
            this.royalCaninListBox = new System.Windows.Forms.ListBox();
            this.royalCaninStopButton = new System.Windows.Forms.Button();
            this.royalCaninStartBtn = new System.Windows.Forms.Button();
            this.royalCaninCheckbox = new System.Windows.Forms.CheckBox();
            this.royalCaninStatusLabel = new System.Windows.Forms.Label();
            this.royalCaninStatus = new System.Windows.Forms.Label();
            this.storageSectionBox = new System.Windows.Forms.GroupBox();
            this.lblItemsProduced = new System.Windows.Forms.Label();
            this.progressItems = new System.Windows.Forms.ProgressBar();
            this.maxCapacityLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.producerSectionBox.SuspendLayout();
            this.consumerSectionBox.SuspendLayout();
            this.vetZooBox.SuspendLayout();
            this.trixieBox.SuspendLayout();
            this.royalCaninSectionBox.SuspendLayout();
            this.storageSectionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // producerSectionBox
            // 
            this.producerSectionBox.Controls.Add(this.bOSCHBox);
            this.producerSectionBox.Controls.Add(this.razerBox);
            this.producerSectionBox.Controls.Add(this.lantmannenBox);
            this.producerSectionBox.Location = new System.Drawing.Point(17, 16);
            this.producerSectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.producerSectionBox.Name = "producerSectionBox";
            this.producerSectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.producerSectionBox.Size = new System.Drawing.Size(305, 466);
            this.producerSectionBox.TabIndex = 0;
            this.producerSectionBox.TabStop = false;
            this.producerSectionBox.Text = "Producers";

            // bOSCHBox
            // 
            this.bOSCHBox.Controls.Add(this.bOSCHStopBtn);
            this.bOSCHBox.Controls.Add(this.bOSCHStartBtn);
            this.bOSCHBox.Controls.Add(this.bOSCHStatus);
            this.bOSCHBox.Controls.Add(this.bOSCHStatusLabel);
            this.bOSCHBox.Location = new System.Drawing.Point(8, 322);
            this.bOSCHBox.Margin = new System.Windows.Forms.Padding(4);
            this.bOSCHBox.Name = "bOSCHBox";
            this.bOSCHBox.Padding = new System.Windows.Forms.Padding(4);
            this.bOSCHBox.Size = new System.Drawing.Size(289, 123);
            this.bOSCHBox.TabIndex = 2;
            this.bOSCHBox.TabStop = false;
            this.bOSCHBox.Text = "BOSCH";
            // 
            // bOSCHStopBtn
            // 
            this.bOSCHStopBtn.Enabled = false;
            this.bOSCHStopBtn.Location = new System.Drawing.Point(199, 73);
            this.bOSCHStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bOSCHStopBtn.Name = "bOSCHStopBtn";
            this.bOSCHStopBtn.Size = new System.Drawing.Size(64, 28);
            this.bOSCHStopBtn.TabIndex = 3;
            this.bOSCHStopBtn.Text = "Stop";
            this.bOSCHStopBtn.UseVisualStyleBackColor = true;
            this.bOSCHStopBtn.Click += new System.EventHandler(this.BOSCHStopBtn_Click);
            // 
            // bOSCHStartBtn
            // 
            this.bOSCHStartBtn.Enabled = false;
            this.bOSCHStartBtn.Location = new System.Drawing.Point(39, 73);
            this.bOSCHStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bOSCHStartBtn.Name = "bOSCHStartBtn";
            this.bOSCHStartBtn.Size = new System.Drawing.Size(132, 28);
            this.bOSCHStartBtn.TabIndex = 2;
            this.bOSCHStartBtn.Text = "Start Producing";
            this.bOSCHStartBtn.UseVisualStyleBackColor = true;
            this.bOSCHStartBtn.Click += new System.EventHandler(this.BOSCHStartBtn_Click);
            // 
            // bOSCHStatus
            // 
            this.bOSCHStatus.AutoSize = true;
            this.bOSCHStatus.Location = new System.Drawing.Point(107, 38);
            this.bOSCHStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bOSCHStatus.Name = "bOSCHStatus";
            this.bOSCHStatus.Size = new System.Drawing.Size(120, 16);
            this.bOSCHStatus.TabIndex = 1;
            this.bOSCHStatus.Text = "NOT PRODUCING";
            // 
            // bOSCHStatusLabel
            // 
            this.bOSCHStatusLabel.AutoSize = true;
            this.bOSCHStatusLabel.Location = new System.Drawing.Point(57, 38);
            this.bOSCHStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bOSCHStatusLabel.Name = "bOSCHStatusLabel";
            this.bOSCHStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.bOSCHStatusLabel.TabIndex = 0;
            this.bOSCHStatusLabel.Text = "Status:";
            // 
            // razerBox
            // 
            this.razerBox.Controls.Add(this.razerStopBtn);
            this.razerBox.Controls.Add(this.razerStartBtn);
            this.razerBox.Controls.Add(this.razerStatus);
            this.razerBox.Controls.Add(this.razerStatusLabel);
            this.razerBox.Location = new System.Drawing.Point(8, 171);
            this.razerBox.Margin = new System.Windows.Forms.Padding(4);
            this.razerBox.Name = "razerBox";
            this.razerBox.Padding = new System.Windows.Forms.Padding(4);
            this.razerBox.Size = new System.Drawing.Size(289, 123);
            this.razerBox.TabIndex = 1;
            this.razerBox.TabStop = false;
            this.razerBox.Text = "Razer";
            // 
            // razerStopBtn
            // 
            this.razerStopBtn.Enabled = false;
            this.razerStopBtn.Location = new System.Drawing.Point(199, 73);
            this.razerStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.razerStopBtn.Name = "razerStopBtn";
            this.razerStopBtn.Size = new System.Drawing.Size(64, 28);
            this.razerStopBtn.TabIndex = 3;
            this.razerStopBtn.Text = "Stop";
            this.razerStopBtn.UseVisualStyleBackColor = true;
            this.razerStopBtn.Click += new System.EventHandler(this.RazerStopBtn_Click);
            // 
            // razerStartBtn
            // 
            this.razerStartBtn.Enabled = false;
            this.razerStartBtn.Location = new System.Drawing.Point(39, 73);
            this.razerStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.razerStartBtn.Name = "razerStartBtn";
            this.razerStartBtn.Size = new System.Drawing.Size(132, 28);
            this.razerStartBtn.TabIndex = 2;
            this.razerStartBtn.Text = "Start Producing";
            this.razerStartBtn.UseVisualStyleBackColor = true;
            this.razerStartBtn.Click += new System.EventHandler(this.RazerStartBtn_Click);
            // 
            // razerStatus
            // 
            this.razerStatus.AutoSize = true;
            this.razerStatus.Location = new System.Drawing.Point(107, 38);
            this.razerStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.razerStatus.Name = "razerStatus";
            this.razerStatus.Size = new System.Drawing.Size(120, 16);
            this.razerStatus.TabIndex = 1;
            this.razerStatus.Text = "NOT PRODUCING";
            // 
            // razerStatusLabel
            // 
            this.razerStatusLabel.AutoSize = true;
            this.razerStatusLabel.Location = new System.Drawing.Point(57, 38);
            this.razerStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.razerStatusLabel.Name = "razerStatusLabel";
            this.razerStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.razerStatusLabel.TabIndex = 0;
            this.razerStatusLabel.Text = "Status:";
            // 
            // lantmannenBox
            // 
            this.lantmannenBox.Controls.Add(this.lantmannenStopBtn);
            this.lantmannenBox.Controls.Add(this.lantmannenStartBtn);
            this.lantmannenBox.Controls.Add(this.lantmannenStatus);
            this.lantmannenBox.Controls.Add(this.lantmannenStatusLabel);
            this.lantmannenBox.Location = new System.Drawing.Point(8, 23);
            this.lantmannenBox.Margin = new System.Windows.Forms.Padding(4);
            this.lantmannenBox.Name = "lantmannenBox";
            this.lantmannenBox.Padding = new System.Windows.Forms.Padding(4);
            this.lantmannenBox.Size = new System.Drawing.Size(289, 123);
            this.lantmannenBox.TabIndex = 0;
            this.lantmannenBox.TabStop = false;
            this.lantmannenBox.Text = "Lantmännen";
            // 
            // lantmannenStopBtn
            // 
            this.lantmannenStopBtn.Enabled = false;
            this.lantmannenStopBtn.Location = new System.Drawing.Point(199, 73);
            this.lantmannenStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.lantmannenStopBtn.Name = "lantmannenStopBtn";
            this.lantmannenStopBtn.Size = new System.Drawing.Size(64, 28);
            this.lantmannenStopBtn.TabIndex = 3;
            this.lantmannenStopBtn.Text = "Stop";
            this.lantmannenStopBtn.UseVisualStyleBackColor = true;
            this.lantmannenStopBtn.Click += new System.EventHandler(this.LantmannenStopBtn_Click);
            // 
            // lantmannenStartBtn
            // 
            this.lantmannenStartBtn.Enabled = false;
            this.lantmannenStartBtn.Location = new System.Drawing.Point(39, 73);
            this.lantmannenStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.lantmannenStartBtn.Name = "lantmannenStartBtn";
            this.lantmannenStartBtn.Size = new System.Drawing.Size(132, 28);
            this.lantmannenStartBtn.TabIndex = 2;
            this.lantmannenStartBtn.Text = "Start Producing";
            this.lantmannenStartBtn.UseVisualStyleBackColor = true;
            this.lantmannenStartBtn.Click += new System.EventHandler(this.LantmannenStartBtn_Click);
            // 
            // lantmannenStatus
            // 
            this.lantmannenStatus.AutoSize = true;
            this.lantmannenStatus.Location = new System.Drawing.Point(107, 38);
            this.lantmannenStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lantmannenStatus.Name = "lantmannenStatus";
            this.lantmannenStatus.Size = new System.Drawing.Size(120, 16);
            this.lantmannenStatus.TabIndex = 1;
            this.lantmannenStatus.Text = "NOT PRODUCING";
            // 
            // lantmannenStatusLabel
            // 
            this.lantmannenStatusLabel.AutoSize = true;
            this.lantmannenStatusLabel.Location = new System.Drawing.Point(57, 38);
            this.lantmannenStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lantmannenStatusLabel.Name = "lantmannenStatusLabel";
            this.lantmannenStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.lantmannenStatusLabel.TabIndex = 0;
            this.lantmannenStatusLabel.Text = "Status:";
            // 

            // 
            // consumerSectionBox
            // 
            this.consumerSectionBox.Controls.Add(this.vetZooBox);
            this.consumerSectionBox.Controls.Add(this.trixieBox);
            this.consumerSectionBox.Controls.Add(this.royalCaninSectionBox);
            this.consumerSectionBox.Location = new System.Drawing.Point(355, 16);
            this.consumerSectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.consumerSectionBox.Name = "consumerSectionBox";
            this.consumerSectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.consumerSectionBox.Size = new System.Drawing.Size(547, 466);
            this.consumerSectionBox.TabIndex = 1;
            this.consumerSectionBox.TabStop = false;
            this.consumerSectionBox.Text = "Consumers";
            // 
            // clasOhlsonBox
            // 
            this.vetZooBox.Controls.Add(this.vetZooListbox);
            this.vetZooBox.Controls.Add(this.vetZooStopBtn);
            this.vetZooBox.Controls.Add(this.vetZooStartBtn);
            this.vetZooBox.Controls.Add(this.vetZooCheckbox);
            this.vetZooBox.Controls.Add(this.vetZooStatusLabel);
            this.vetZooBox.Controls.Add(this.vetZooStatus);
            this.vetZooBox.Location = new System.Drawing.Point(25, 322);
            this.vetZooBox.Margin = new System.Windows.Forms.Padding(4);
            this.vetZooBox.Name = "vetZooBox";
            this.vetZooBox.Padding = new System.Windows.Forms.Padding(4);
            this.vetZooBox.Size = new System.Drawing.Size(513, 123);
            this.vetZooBox.TabIndex = 2;
            this.vetZooBox.TabStop = false;
            this.vetZooBox.Text = "Vet Zoo";
            // 
            // clasOhlsonListbox
            // 
            this.vetZooListbox.FormattingEnabled = true;
            this.vetZooListbox.ItemHeight = 16;
            this.vetZooListbox.Location = new System.Drawing.Point(208, 28);
            this.vetZooListbox.Margin = new System.Windows.Forms.Padding(4);
            this.vetZooListbox.Name = "vetZooListbox";
            this.vetZooListbox.Size = new System.Drawing.Size(286, 84);
            this.vetZooListbox.TabIndex = 8;
            // 
            // clasOhlsonStopBtn
            // 
            this.vetZooStopBtn.Enabled = false;
            this.vetZooStopBtn.Location = new System.Drawing.Point(138, 87);
            this.vetZooStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.vetZooStopBtn.Name = "vetZooStopBtn";
            this.vetZooStopBtn.Size = new System.Drawing.Size(53, 28);
            this.vetZooStopBtn.TabIndex = 7;
            this.vetZooStopBtn.Text = "Stop";
            this.vetZooStopBtn.UseVisualStyleBackColor = true;
            this.vetZooStopBtn.Click += new System.EventHandler(this.VetZooStopBtn_Click);
            // 
            // clasOhlsonStartBtn
            // 
            this.vetZooStartBtn.Enabled = false;
            this.vetZooStartBtn.Location = new System.Drawing.Point(20, 84);
            this.vetZooStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.vetZooStartBtn.Name = "vetZooStartBtn";
            this.vetZooStartBtn.Size = new System.Drawing.Size(108, 28);
            this.vetZooStartBtn.TabIndex = 6;
            this.vetZooStartBtn.Text = "Start Loading";
            this.vetZooStartBtn.UseVisualStyleBackColor = true;
            this.vetZooStartBtn.Click += new System.EventHandler(this.VetZooStartBtn_Click);
            // 
            // clasOhlsonCheckbox
            // 
            this.vetZooCheckbox.AutoSize = true;
            this.vetZooCheckbox.Location = new System.Drawing.Point(20, 56);
            this.vetZooCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.vetZooCheckbox.Name = "vetZooCheckbox";
            this.vetZooCheckbox.Size = new System.Drawing.Size(111, 20);
            this.vetZooCheckbox.TabIndex = 5;
            this.vetZooCheckbox.Text = "Continue load";
            this.vetZooCheckbox.UseVisualStyleBackColor = true;
            // 
            // clasOhlsonStatusLabel
            // 
            this.vetZooStatusLabel.AutoSize = true;
            this.vetZooStatusLabel.Location = new System.Drawing.Point(9, 28);
            this.vetZooStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vetZooStatusLabel.Name = "vetZooLabel";
            this.vetZooStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.vetZooStatusLabel.TabIndex = 4;
            this.vetZooStatusLabel.Text = "Status:";
            // 
            // clasOhlsonStatus
            // 
            this.vetZooStatus.AutoSize = true;
            this.vetZooStatus.Location = new System.Drawing.Point(58, 28);
            this.vetZooStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vetZooStatus.Name = "vetZooStatus";
            this.vetZooStatus.Size = new System.Drawing.Size(121, 16);
            this.vetZooStatus.TabIndex = 3;
            this.vetZooStatus.Text = "NOT CONSUMING";
            // 
            // elgigantenBox
            // 
            this.trixieBox.Controls.Add(this.trixieListBox);
            this.trixieBox.Controls.Add(this.trixieStopBtn);
            this.trixieBox.Controls.Add(this.trixieStartBtn);
            this.trixieBox.Controls.Add(this.trixieCheckbox);
            this.trixieBox.Controls.Add(this.trixieStatusLabel);
            this.trixieBox.Controls.Add(this.trixieStatus);
            this.trixieBox.Location = new System.Drawing.Point(25, 171);
            this.trixieBox.Margin = new System.Windows.Forms.Padding(4);
            this.trixieBox.Name = "trixieBox";
            this.trixieBox.Padding = new System.Windows.Forms.Padding(4);
            this.trixieBox.Size = new System.Drawing.Size(513, 123);
            this.trixieBox.TabIndex = 1;
            this.trixieBox.TabStop = false;
            this.trixieBox.Text = "Trixie";
            // 
            // elgigantenListBox
            // 
            this.trixieListBox.FormattingEnabled = true;
            this.trixieListBox.ItemHeight = 16;
            this.trixieListBox.Location = new System.Drawing.Point(208, 31);
            this.trixieListBox.Margin = new System.Windows.Forms.Padding(4);
            this.trixieListBox.Name = "trixieListBox";
            this.trixieListBox.Size = new System.Drawing.Size(286, 84);
            this.trixieListBox.TabIndex = 8;
            // 
            // elgigantenStopBtn
            // 
            this.trixieStopBtn.Enabled = false;
            this.trixieStopBtn.Location = new System.Drawing.Point(138, 87);
            this.trixieStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.trixieStopBtn.Name = "trixieStopBtn";
            this.trixieStopBtn.Size = new System.Drawing.Size(53, 28);
            this.trixieStopBtn.TabIndex = 7;
            this.trixieStopBtn.Text = "Stop";
            this.trixieStopBtn.UseVisualStyleBackColor = true;
            this.trixieStopBtn.Click += new System.EventHandler(this.TrixieStopBtn_Click);
            // 
            // elgigantenStartBtn
            // 
            this.trixieStartBtn.Enabled = false;
            this.trixieStartBtn.Location = new System.Drawing.Point(20, 87);
            this.trixieStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.trixieStartBtn.Name = "trixieStartBtn";
            this.trixieStartBtn.Size = new System.Drawing.Size(108, 28);
            this.trixieStartBtn.TabIndex = 6;
            this.trixieStartBtn.Text = "Start Loading";
            this.trixieStartBtn.UseVisualStyleBackColor = true;
            this.trixieStartBtn.Click += new System.EventHandler(this.TrixieStartBtn_Click);
            // 
            // elgigantenCheckbox
            // 
            this.trixieCheckbox.AutoSize = true;
            this.trixieCheckbox.Location = new System.Drawing.Point(20, 56);
            this.trixieCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.trixieCheckbox.Name = "trixieCheckbox";
            this.trixieCheckbox.Size = new System.Drawing.Size(111, 20);
            this.trixieCheckbox.TabIndex = 5;
            this.trixieCheckbox.Text = "Continue load";
            this.trixieCheckbox.UseVisualStyleBackColor = true;
            // 
            // elgigantenStatusLabel
            // 
            this.trixieStatusLabel.AutoSize = true;
            this.trixieStatusLabel.Location = new System.Drawing.Point(9, 28);
            this.trixieStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trixieStatusLabel.Name = "trixieStatusLabel";
            this.trixieStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.trixieStatusLabel.TabIndex = 4;
            this.trixieStatusLabel.Text = "Status:";
            // 
            // elgigantenStatus
            // 
            this.trixieStatus.AutoSize = true;
            this.trixieStatus.Location = new System.Drawing.Point(58, 28);
            this.trixieStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trixieStatus.Name = "trixieStatus";
            this.trixieStatus.Size = new System.Drawing.Size(121, 16);
            this.trixieStatus.TabIndex = 3;
            this.trixieStatus.Text = "NOT CONSUMING";
            // 
            // icaSectionBox
            // 
            this.royalCaninSectionBox.Controls.Add(this.royalCaninListBox);
            this.royalCaninSectionBox.Controls.Add(this.royalCaninStopButton);
            this.royalCaninSectionBox.Controls.Add(this.royalCaninStartBtn);
            this.royalCaninSectionBox.Controls.Add(this.royalCaninCheckbox);
            this.royalCaninSectionBox.Controls.Add(this.royalCaninStatusLabel);
            this.royalCaninSectionBox.Controls.Add(this.royalCaninStatus);
            this.royalCaninSectionBox.Location = new System.Drawing.Point(25, 23);
            this.royalCaninSectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.royalCaninSectionBox.Name = "royalCaninSectionBox";
            this.royalCaninSectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.royalCaninSectionBox.Size = new System.Drawing.Size(513, 123);
            this.royalCaninSectionBox.TabIndex = 0;
            this.royalCaninSectionBox.TabStop = false;
            this.royalCaninSectionBox.Text = "Royal Canin";
            // 
            // icaListBox
            // 
            this.royalCaninListBox.FormattingEnabled = true;
            this.royalCaninListBox.ItemHeight = 16;
            this.royalCaninListBox.Location = new System.Drawing.Point(208, 23);
            this.royalCaninListBox.Margin = new System.Windows.Forms.Padding(4);
            this.royalCaninListBox.Name = "royalCaninListBox";
            this.royalCaninListBox.Size = new System.Drawing.Size(286, 84);
            this.royalCaninListBox.TabIndex = 8;
            // 
            // icaStopButton
            // 
            this.royalCaninStopButton.Enabled = false;
            this.royalCaninStopButton.Location = new System.Drawing.Point(138, 78);
            this.royalCaninStopButton.Margin = new System.Windows.Forms.Padding(4);
            this.royalCaninStopButton.Name = "royalCaninStopButton";
            this.royalCaninStopButton.Size = new System.Drawing.Size(53, 28);
            this.royalCaninStopButton.TabIndex = 7;
            this.royalCaninStopButton.Text = "Stop";
            this.royalCaninStopButton.UseVisualStyleBackColor = true;
            this.royalCaninStopButton.Click += new System.EventHandler(this.RoyalCaninStopBtn_Click);
            // 
            // icaStartBtn
            // 
            this.royalCaninStartBtn.Enabled = false;
            this.royalCaninStartBtn.Location = new System.Drawing.Point(20, 78);
            this.royalCaninStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.royalCaninStartBtn.Name = "royalCaninStartBtn";
            this.royalCaninStartBtn.Size = new System.Drawing.Size(108, 28);
            this.royalCaninStartBtn.TabIndex = 6;
            this.royalCaninStartBtn.Text = "Start Loading";
            this.royalCaninStartBtn.UseVisualStyleBackColor = true;
            this.royalCaninStartBtn.Click += new System.EventHandler(this.RoyalCaninStartBtn_Click);
            // 
            // icaCheckbox
            // 
            this.royalCaninCheckbox.AutoSize = true;
            this.royalCaninCheckbox.Location = new System.Drawing.Point(20, 47);
            this.royalCaninCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.royalCaninCheckbox.Name = "royalCaninCheckbox";
            this.royalCaninCheckbox.Size = new System.Drawing.Size(111, 20);
            this.royalCaninCheckbox.TabIndex = 5;
            this.royalCaninCheckbox.Text = "Continue load";
            this.royalCaninCheckbox.UseVisualStyleBackColor = true;
            // 
            // icaStatusLabel
            // 
            this.royalCaninStatusLabel.AutoSize = true;
            this.royalCaninStatusLabel.Location = new System.Drawing.Point(9, 19);
            this.royalCaninStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.royalCaninStatusLabel.Name = "royalCaninStatusLabel";
            this.royalCaninStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.royalCaninStatusLabel.TabIndex = 4;
            this.royalCaninStatusLabel.Text = "Status:";
            // 
            // icaStatus
            // 
            this.royalCaninStatus.AutoSize = true;
            this.royalCaninStatus.Location = new System.Drawing.Point(58, 19);
            this.royalCaninStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.royalCaninStatus.Name = "royalCaninStatus";
            this.royalCaninStatus.Size = new System.Drawing.Size(121, 16);
            this.royalCaninStatus.TabIndex = 3;
            this.royalCaninStatus.Text = "NOT CONSUMING";
            // 
            // storageSectionBox
            // 
            this.storageSectionBox.Controls.Add(this.lblItemsProduced);
            this.storageSectionBox.Controls.Add(this.progressItems);
            this.storageSectionBox.Controls.Add(this.maxCapacityLabel);
            this.storageSectionBox.Location = new System.Drawing.Point(135, 490);
            this.storageSectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.storageSectionBox.Name = "storageSectionBox";
            this.storageSectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.storageSectionBox.Size = new System.Drawing.Size(767, 101);
            this.storageSectionBox.TabIndex = 2;
            this.storageSectionBox.TabStop = false;
            this.storageSectionBox.Text = "Storage";
            // 
            // lblItemsProduced
            // 
            this.lblItemsProduced.AutoSize = true;
            this.lblItemsProduced.Location = new System.Drawing.Point(672, 19);
            this.lblItemsProduced.Name = "lblItemsProduced";
            this.lblItemsProduced.Size = new System.Drawing.Size(67, 16);
            this.lblItemsProduced.TabIndex = 9;
            this.lblItemsProduced.Text = "Max items";
            this.lblItemsProduced.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressItems
            // 
            this.progressItems.ForeColor = System.Drawing.Color.Blue;
            this.progressItems.Location = new System.Drawing.Point(207, 46);
            this.progressItems.Margin = new System.Windows.Forms.Padding(4);
            this.progressItems.Maximum = 20;
            this.progressItems.Name = "progressItems";
            this.progressItems.Size = new System.Drawing.Size(532, 28);
            this.progressItems.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressItems.TabIndex = 2;
            // 
            // maxCapacityLabel
            // 
            this.maxCapacityLabel.AutoSize = true;
            this.maxCapacityLabel.Location = new System.Drawing.Point(8, 52);
            this.maxCapacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxCapacityLabel.Name = "maxCapacityLabel";
            this.maxCapacityLabel.Size = new System.Drawing.Size(132, 16);
            this.maxCapacityLabel.TabIndex = 1;
            this.maxCapacityLabel.Text = "Max capacity (items):";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 502);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(117, 74);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start System";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 599);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.storageSectionBox);
            this.Controls.Add(this.consumerSectionBox);
            this.Controls.Add(this.producerSectionBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logistics Management System";
            this.producerSectionBox.ResumeLayout(false);
            this.consumerSectionBox.ResumeLayout(false);
            this.vetZooBox.ResumeLayout(false);
            this.vetZooBox.PerformLayout();
            this.trixieBox.ResumeLayout(false);
            this.trixieBox.PerformLayout();
            this.royalCaninSectionBox.ResumeLayout(false);
            this.royalCaninSectionBox.PerformLayout();
            this.storageSectionBox.ResumeLayout(false);
            this.storageSectionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox producerSectionBox;
        private System.Windows.Forms.GroupBox consumerSectionBox;
        private System.Windows.Forms.GroupBox storageSectionBox;
        private System.Windows.Forms.ProgressBar progressItems;
        private System.Windows.Forms.Label maxCapacityLabel;
        private System.Windows.Forms.GroupBox lantmannenBox;
        private System.Windows.Forms.Button lantmannenStopBtn;
        private System.Windows.Forms.Button lantmannenStartBtn;
        private System.Windows.Forms.Label lantmannenStatusLabel;
        private System.Windows.Forms.Label lantmannenStatus;
        private System.Windows.Forms.GroupBox bOSCHBox;
        private System.Windows.Forms.Button bOSCHStopBtn;
        private System.Windows.Forms.Button bOSCHStartBtn;
        private System.Windows.Forms.Label bOSCHStatus;
        private System.Windows.Forms.Label bOSCHStatusLabel;
        private System.Windows.Forms.GroupBox razerBox;
        private System.Windows.Forms.Button razerStopBtn;
        private System.Windows.Forms.Button razerStartBtn;
        private System.Windows.Forms.Label razerStatus;
        private System.Windows.Forms.Label razerStatusLabel;
        private System.Windows.Forms.GroupBox royalCaninSectionBox;
        private System.Windows.Forms.ListBox royalCaninListBox;
        private System.Windows.Forms.Button royalCaninStopButton;
        private System.Windows.Forms.Button royalCaninStartBtn;
        private System.Windows.Forms.CheckBox royalCaninCheckbox;
        private System.Windows.Forms.Label royalCaninStatusLabel;
        private System.Windows.Forms.Label royalCaninStatus;
        private System.Windows.Forms.GroupBox vetZooBox;
        private System.Windows.Forms.ListBox vetZooListbox;
        private System.Windows.Forms.Button vetZooStopBtn;
        private System.Windows.Forms.Button vetZooStartBtn;
        private System.Windows.Forms.CheckBox vetZooCheckbox;
        private System.Windows.Forms.Label vetZooStatusLabel;
        private System.Windows.Forms.Label vetZooStatus;
        private System.Windows.Forms.GroupBox trixieBox;
        private System.Windows.Forms.ListBox trixieListBox;
        private System.Windows.Forms.Button trixieStopBtn;
        private System.Windows.Forms.Button trixieStartBtn;
        private System.Windows.Forms.CheckBox trixieCheckbox;
        private System.Windows.Forms.Label trixieStatusLabel;
        private System.Windows.Forms.Label trixieStatus;
        private System.Windows.Forms.Label lblItemsProduced;
        private System.Windows.Forms.Button startBtn;

        public Button StartButton { get { return startBtn; } set { startBtn = value; } }
        public GroupBox ProducerSectionBox { get { return producerSectionBox; } set { producerSectionBox = value; } }
        public GroupBox ConsumerSectionBox { get { return consumerSectionBox; } set { consumerSectionBox = value; } }
        public GroupBox StorageSectionBox { get { return storageSectionBox; } set { storageSectionBox = value; } }
        public ProgressBar ProgressItems { get { return progressItems; } set { progressItems = value; } }
        public Label MaxCapacityLabel { get { return maxCapacityLabel; } set { maxCapacityLabel = value; } }
        public GroupBox LantmannenBox { get { return lantmannenBox; } set { lantmannenBox = value; } }
        public Button LantmannenStopBtn { get { return lantmannenStopBtn; } set { lantmannenStopBtn = value; } }
        public Button LantmannenStartBtn { get { return lantmannenStartBtn; } set { lantmannenStartBtn = value; } }
        public Label LantmannenStatusLabel { get { return lantmannenStatusLabel; } set { lantmannenStatusLabel = value; } }
        public Label LantmannenStatus { get { return lantmannenStatus; } set { lantmannenStatus = value; } }
        public GroupBox BOSCHBox { get { return bOSCHBox; } set { bOSCHBox = value; } }
        public Button BOSCHStopBtn { get { return bOSCHStopBtn; } set { bOSCHStopBtn = value; } }
        public Button BOSCHStartBtn { get { return bOSCHStartBtn; } set { bOSCHStartBtn = value; } }
        public Label BOSCHStatus { get { return bOSCHStatus; } set { bOSCHStatus = value; } }
        public Label BOSCHStatusLabel { get { return bOSCHStatusLabel; } set { bOSCHStatusLabel = value; } }
        public GroupBox RazerBox { get { return razerBox; } set { razerBox = value; } }
        public Button RazerStopBtn { get { return razerStopBtn; } set { razerStopBtn = value; } }
        public Button RazerStartBtn { get { return razerStartBtn; } set { razerStartBtn = value; } }
        public Label RazerStatus { get { return razerStatus; } set { razerStatus = value; } }
        public Label RazerStatusLabel { get { return razerStatusLabel; } set { razerStatusLabel = value; } }
        public GroupBox RoyalCaninSectionBox { get { return royalCaninSectionBox; } set { royalCaninSectionBox = value; } }
        public ListBox RoyalCaninListBox { get { return royalCaninListBox; } set { royalCaninListBox = value; } }
        public Button RoyalCaninStopButton { get { return royalCaninStopButton; } set { royalCaninStopButton = value; } }
        public Button RoyalCaninStartBtn { get { return royalCaninStartBtn; } set { royalCaninStartBtn = value; } }
        public CheckBox RoyalCaninCheckbox { get { return royalCaninCheckbox; } set { royalCaninCheckbox = value; } }
        public Label RoyalCaninStatusLabel { get { return royalCaninStatusLabel; } set { royalCaninStatusLabel = value; } }
        public Label RoyalCaninStatus { get { return royalCaninStatus; } set { royalCaninStatus = value; } }
        public GroupBox VetZooBox { get { return vetZooBox; } set { vetZooBox = value; } }
        public ListBox VetZooListbox { get { return vetZooListbox; } set { vetZooListbox = value; } }
        public Button VetZooStopBtn { get { return vetZooStopBtn; } set { vetZooStopBtn = value; } }
        public Button VetZooStartBtn { get { return vetZooStartBtn; } set { vetZooStartBtn = value; } }
        public CheckBox VetZooCheckbox { get { return vetZooCheckbox; } set { vetZooCheckbox = value; } }
        public Label VetZooStatusLabel { get { return vetZooStatusLabel; } set { vetZooStatusLabel = value; } }
        public Label VetZooStatus { get { return vetZooStatus; } set { vetZooStatus = value; } }
        public GroupBox TrixieBox { get { return trixieBox; } set { trixieBox = value; } }
        public ListBox TrixieListBox { get { return trixieListBox; } set { trixieListBox = value; } }
        public Button TrixieStopBtn { get { return trixieStopBtn; } set { trixieStopBtn = value; } }
        public Button TrixieStartBtn { get { return trixieStartBtn; } set { trixieStartBtn = value; } }
        public CheckBox TrixieCheckbox { get { return trixieCheckbox; } set { trixieCheckbox = value; } }
        public Label TrixieStatusLabel { get { return trixieStatusLabel; } set { trixieStatusLabel = value; } }
        public Label TrixieStatus { get { return trixieStatus; } set { trixieStatus = value; } }
        public Label LblItemsProduced { get { return lblItemsProduced; } set { lblItemsProduced = value; } }


    }
}

