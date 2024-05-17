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
            this.hurttaBox = new System.Windows.Forms.GroupBox();
            this.hurttaStopBtn = new System.Windows.Forms.Button();
            this.hurttaStartBtn = new System.Windows.Forms.Button();
            this.hurttaStatus = new System.Windows.Forms.Label();
            this.hurttaStatusLabel = new System.Windows.Forms.Label();
            this.trixieBox = new System.Windows.Forms.GroupBox();
            this.trixieStopBtn = new System.Windows.Forms.Button();
            this.trixieStartBtn = new System.Windows.Forms.Button();
            this.trixieStatus = new System.Windows.Forms.Label();
            this.trixieStatusLabel = new System.Windows.Forms.Label();
            this.royalCaninnBox = new System.Windows.Forms.GroupBox();
            this.royalCaninStopBtn = new System.Windows.Forms.Button();
            this.royalCaninStartBtn = new System.Windows.Forms.Button();
            this.royalCaninStatus = new System.Windows.Forms.Label();
            this.royalCaninStatusLabel = new System.Windows.Forms.Label();
            this.consumerSectionBox = new System.Windows.Forms.GroupBox();
            this.vetZooBox = new System.Windows.Forms.GroupBox();
            this.vetZooListbox = new System.Windows.Forms.ListBox();
            this.vetZooStopBtn = new System.Windows.Forms.Button();
            this.vetZooStartBtn = new System.Windows.Forms.Button();
            this.vetZooCheckbox = new System.Windows.Forms.CheckBox();
            this.vetZooStatusLabel = new System.Windows.Forms.Label();
            this.vetZooStatus = new System.Windows.Forms.Label();
            this.bitibaBox = new System.Windows.Forms.GroupBox();
            this.bitibaListBox = new System.Windows.Forms.ListBox();
            this.bitibaStopBtn = new System.Windows.Forms.Button();
            this.bitibaStartBtn = new System.Windows.Forms.Button();
            this.bitibaCheckbox = new System.Windows.Forms.CheckBox();
            this.bitibaStatusLabel = new System.Windows.Forms.Label();
            this.bitibaStatus = new System.Windows.Forms.Label();
            this.arkenZooSectionBox = new System.Windows.Forms.GroupBox();
            this.arkenZooListBox = new System.Windows.Forms.ListBox();
            this.arkenZooStopButton = new System.Windows.Forms.Button();
            this.arkenZooStartBtn = new System.Windows.Forms.Button();
            this.arkenZooCheckbox = new System.Windows.Forms.CheckBox();
            this.arkenZooStatusLabel = new System.Windows.Forms.Label();
            this.arkenZooStatus = new System.Windows.Forms.Label();
            this.storageSectionBox = new System.Windows.Forms.GroupBox();
            this.lblItemsProduced = new System.Windows.Forms.Label();
            this.progressItems = new System.Windows.Forms.ProgressBar();
            this.maxCapacityLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.producerSectionBox.SuspendLayout();
            this.consumerSectionBox.SuspendLayout();
            this.vetZooBox.SuspendLayout();
            this.bitibaBox.SuspendLayout();
            this.arkenZooSectionBox.SuspendLayout();
            this.storageSectionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // producerSectionBox
            // 
            this.producerSectionBox.Controls.Add(this.hurttaBox);
            this.producerSectionBox.Controls.Add(this.trixieBox);
            this.producerSectionBox.Controls.Add(this.royalCaninnBox);
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
            this.hurttaBox.Controls.Add(this.hurttaStopBtn);
            this.hurttaBox.Controls.Add(this.hurttaStartBtn);
            this.hurttaBox.Controls.Add(this.hurttaStatus);
            this.hurttaBox.Controls.Add(this.hurttaStatusLabel);
            this.hurttaBox.Location = new System.Drawing.Point(8, 322);
            this.hurttaBox.Margin = new System.Windows.Forms.Padding(4);
            this.hurttaBox.Name = "hurttaBox";
            this.hurttaBox.Padding = new System.Windows.Forms.Padding(4);
            this.hurttaBox.Size = new System.Drawing.Size(289, 123);
            this.hurttaBox.TabIndex = 2;
            this.hurttaBox.TabStop = false;
            this.hurttaBox.Text = "Hurtta";
            // 
            // bOSCHStopBtn
            // 
            this.hurttaStopBtn.Enabled = false;
            this.hurttaStopBtn.Location = new System.Drawing.Point(199, 73);
            this.hurttaStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.hurttaStopBtn.Name = "hurttaStopBtn";
            this.hurttaStopBtn.Size = new System.Drawing.Size(64, 28);
            this.hurttaStopBtn.TabIndex = 3;
            this.hurttaStopBtn.Text = "Stop";
            this.hurttaStopBtn.UseVisualStyleBackColor = true;
            this.hurttaStopBtn.Click += new System.EventHandler(this.HurttaStopBtn_Click);
            // 
            // bOSCHStartBtn
            // 
            this.hurttaStartBtn.Enabled = false;
            this.hurttaStartBtn.Location = new System.Drawing.Point(39, 73);
            this.hurttaStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.hurttaStartBtn.Name = "hurttaStartBtn";
            this.hurttaStartBtn.Size = new System.Drawing.Size(132, 28);
            this.hurttaStartBtn.TabIndex = 2;
            this.hurttaStartBtn.Text = "Start Producing";
            this.hurttaStartBtn.UseVisualStyleBackColor = true;
            this.hurttaStartBtn.Click += new System.EventHandler(this.HurttaStartBtn_Click);
            // 
            // bOSCHStatus
            // 
            this.hurttaStatus.AutoSize = true;
            this.hurttaStatus.Location = new System.Drawing.Point(107, 38);
            this.hurttaStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hurttaStatus.Name = "hurttaStatus";
            this.hurttaStatus.Size = new System.Drawing.Size(120, 16);
            this.hurttaStatus.TabIndex = 1;
            this.hurttaStatus.Text = "NOT PRODUCING";
            // 
            // bOSCHStatusLabel
            // 
            this.hurttaStatusLabel.AutoSize = true;
            this.hurttaStatusLabel.Location = new System.Drawing.Point(57, 38);
            this.hurttaStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hurttaStatusLabel.Name = "hurttaStatusLabel";
            this.hurttaStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.hurttaStatusLabel.TabIndex = 0;
            this.hurttaStatusLabel.Text = "Status:";
            // 
            // razerBox
            // 
            this.trixieBox.Controls.Add(this.trixieStopBtn);
            this.trixieBox.Controls.Add(this.trixieStartBtn);
            this.trixieBox.Controls.Add(this.trixieStatus);
            this.trixieBox.Controls.Add(this.trixieStatusLabel);
            this.trixieBox.Location = new System.Drawing.Point(8, 171);
            this.trixieBox.Margin = new System.Windows.Forms.Padding(4);
            this.trixieBox.Name = "trixieBox";
            this.trixieBox.Padding = new System.Windows.Forms.Padding(4);
            this.trixieBox.Size = new System.Drawing.Size(289, 123);
            this.trixieBox.TabIndex = 1;
            this.trixieBox.TabStop = false;
            this.trixieBox.Text = "Trixie";
            // 
            // razerStopBtn
            // 
            this.trixieStopBtn.Enabled = false;
            this.trixieStopBtn.Location = new System.Drawing.Point(199, 73);
            this.trixieStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.trixieStopBtn.Name = "trixieStopBtn";
            this.trixieStopBtn.Size = new System.Drawing.Size(64, 28);
            this.trixieStopBtn.TabIndex = 3;
            this.trixieStopBtn.Text = "Stop";
            this.trixieStopBtn.UseVisualStyleBackColor = true;
            this.trixieStopBtn.Click += new System.EventHandler(this.trixieStopBtn_Click);
            // 
            // razerStartBtn
            // 
            this.trixieStartBtn.Enabled = false;
            this.trixieStartBtn.Location = new System.Drawing.Point(39, 73);
            this.trixieStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.trixieStartBtn.Name = "trixieStartBtn";
            this.trixieStartBtn.Size = new System.Drawing.Size(132, 28);
            this.trixieStartBtn.TabIndex = 2;
            this.trixieStartBtn.Text = "Start Producing";
            this.trixieStartBtn.UseVisualStyleBackColor = true;
            this.trixieStartBtn.Click += new System.EventHandler(this.trixieStartBtn_Click);
            // 
            // razerStatus
            // 
            this.trixieStatus.AutoSize = true;
            this.trixieStatus.Location = new System.Drawing.Point(107, 38);
            this.trixieStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trixieStatus.Name = "trixieStatus";
            this.trixieStatus.Size = new System.Drawing.Size(120, 16);
            this.trixieStatus.TabIndex = 1;
            this.trixieStatus.Text = "NOT PRODUCING";
            // 
            // razerStatusLabel
            // 
            this.trixieStatusLabel.AutoSize = true;
            this.trixieStatusLabel.Location = new System.Drawing.Point(57, 38);
            this.trixieStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trixieStatusLabel.Name = "razerStatusLabel";
            this.trixieStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.trixieStatusLabel.TabIndex = 0;
            this.trixieStatusLabel.Text = "Status:";
            // 
            // lantmannenBox
            // 
            this.royalCaninnBox.Controls.Add(this.royalCaninStopBtn);
            this.royalCaninnBox.Controls.Add(this.royalCaninStartBtn);
            this.royalCaninnBox.Controls.Add(this.royalCaninStatus);
            this.royalCaninnBox.Controls.Add(this.royalCaninStatusLabel);
            this.royalCaninnBox.Location = new System.Drawing.Point(8, 23);
            this.royalCaninnBox.Margin = new System.Windows.Forms.Padding(4);
            this.royalCaninnBox.Name = "royalCaninBox";
            this.royalCaninnBox.Padding = new System.Windows.Forms.Padding(4);
            this.royalCaninnBox.Size = new System.Drawing.Size(289, 123);
            this.royalCaninnBox.TabIndex = 0;
            this.royalCaninnBox.TabStop = false;
            this.royalCaninnBox.Text = "Royal Canin";
            // 
            // lantmannenStopBtn
            // 
            this.royalCaninStopBtn.Enabled = false;
            this.royalCaninStopBtn.Location = new System.Drawing.Point(199, 73);
            this.royalCaninStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.royalCaninStopBtn.Name = "granngardenStopBtn";
            this.royalCaninStopBtn.Size = new System.Drawing.Size(64, 28);
            this.royalCaninStopBtn.TabIndex = 3;
            this.royalCaninStopBtn.Text = "Stop";
            this.royalCaninStopBtn.UseVisualStyleBackColor = true;
            this.royalCaninStopBtn.Click += new System.EventHandler(this.RoyalCaninStopBtn_Click);
            // 
            // lantmannenStartBtn
            // 
            this.royalCaninStartBtn.Enabled = false;
            this.royalCaninStartBtn.Location = new System.Drawing.Point(39, 73);
            this.royalCaninStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.royalCaninStartBtn.Name = "royalCaninStartBtn";
            this.royalCaninStartBtn.Size = new System.Drawing.Size(132, 28);
            this.royalCaninStartBtn.TabIndex = 2;
            this.royalCaninStartBtn.Text = "Start Producing";
            this.royalCaninStartBtn.UseVisualStyleBackColor = true;
            this.royalCaninStartBtn.Click += new System.EventHandler(this.RoyalCaninStartBtn_Click);
            // 
            // lantmannenStatus
            // 
            this.royalCaninStatus.AutoSize = true;
            this.royalCaninStatus.Location = new System.Drawing.Point(107, 38);
            this.royalCaninStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.royalCaninStatus.Name = "royalCaninStatus";
            this.royalCaninStatus.Size = new System.Drawing.Size(120, 16);
            this.royalCaninStatus.TabIndex = 1;
            this.royalCaninStatus.Text = "NOT PRODUCING";
            // 
            // lantmannenStatusLabel
            // 
            this.royalCaninStatusLabel.AutoSize = true;
            this.royalCaninStatusLabel.Location = new System.Drawing.Point(57, 38);
            this.royalCaninStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.royalCaninStatusLabel.Name = "royalCaninStatusLabel";
            this.royalCaninStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.royalCaninStatusLabel.TabIndex = 0;
            this.royalCaninStatusLabel.Text = "Status:";
            // 

            // 
            // consumerSectionBox
            // 
            this.consumerSectionBox.Controls.Add(this.vetZooBox);
            this.consumerSectionBox.Controls.Add(this.bitibaBox);
            this.consumerSectionBox.Controls.Add(this.arkenZooSectionBox);
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
            this.bitibaBox.Controls.Add(this.bitibaListBox);
            this.bitibaBox.Controls.Add(this.bitibaStopBtn);
            this.bitibaBox.Controls.Add(this.bitibaStartBtn);
            this.bitibaBox.Controls.Add(this.bitibaCheckbox);
            this.bitibaBox.Controls.Add(this.bitibaStatusLabel);
            this.bitibaBox.Controls.Add(this.bitibaStatus);
            this.bitibaBox.Location = new System.Drawing.Point(25, 171);
            this.bitibaBox.Margin = new System.Windows.Forms.Padding(4);
            this.bitibaBox.Name = "bitibaBox";
            this.bitibaBox.Padding = new System.Windows.Forms.Padding(4);
            this.bitibaBox.Size = new System.Drawing.Size(513, 123);
            this.bitibaBox.TabIndex = 1;
            this.bitibaBox.TabStop = false;
            this.bitibaBox.Text = "Bitiba";
            // 
            // elgigantenListBox
            // 
            this.bitibaListBox.FormattingEnabled = true;
            this.bitibaListBox.ItemHeight = 16;
            this.bitibaListBox.Location = new System.Drawing.Point(208, 31);
            this.bitibaListBox.Margin = new System.Windows.Forms.Padding(4);
            this.bitibaListBox.Name = "bitibaListBox";
            this.bitibaListBox.Size = new System.Drawing.Size(286, 84);
            this.bitibaListBox.TabIndex = 8;
            // 
            // elgigantenStopBtn
            // 
            this.bitibaStopBtn.Enabled = false;
            this.bitibaStopBtn.Location = new System.Drawing.Point(138, 87);
            this.bitibaStopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bitibaStopBtn.Name = "bitibaStopBtn";
            this.bitibaStopBtn.Size = new System.Drawing.Size(53, 28);
            this.bitibaStopBtn.TabIndex = 7;
            this.bitibaStopBtn.Text = "Stop";
            this.bitibaStopBtn.UseVisualStyleBackColor = true;
            this.bitibaStopBtn.Click += new System.EventHandler(this.BitibaStopBtn_Click);
            // 
            // elgigantenStartBtn
            // 
            this.bitibaStartBtn.Enabled = false;
            this.bitibaStartBtn.Location = new System.Drawing.Point(20, 87);
            this.bitibaStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bitibaStartBtn.Name = "bitibaStartBtn";
            this.bitibaStartBtn.Size = new System.Drawing.Size(108, 28);
            this.bitibaStartBtn.TabIndex = 6;
            this.bitibaStartBtn.Text = "Start Loading";
            this.bitibaStartBtn.UseVisualStyleBackColor = true;
            this.bitibaStartBtn.Click += new System.EventHandler(this.BitibaStartBtn_Click);
            // 
            // elgigantenCheckbox
            // 
            this.bitibaCheckbox.AutoSize = true;
            this.bitibaCheckbox.Location = new System.Drawing.Point(20, 56);
            this.bitibaCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.bitibaCheckbox.Name = "bitibaCheckbox";
            this.bitibaCheckbox.Size = new System.Drawing.Size(111, 20);
            this.bitibaCheckbox.TabIndex = 5;
            this.bitibaCheckbox.Text = "Continue load";
            this.bitibaCheckbox.UseVisualStyleBackColor = true;
            // 
            // elgigantenStatusLabel
            // 
            this.bitibaStatusLabel.AutoSize = true;
            this.bitibaStatusLabel.Location = new System.Drawing.Point(9, 28);
            this.bitibaStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitibaStatusLabel.Name = "bitibaStatusLabel";
            this.bitibaStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.bitibaStatusLabel.TabIndex = 4;
            this.bitibaStatusLabel.Text = "Status:";
            // 
            // elgigantenStatus
            // 
            this.bitibaStatus.AutoSize = true;
            this.bitibaStatus.Location = new System.Drawing.Point(58, 28);
            this.bitibaStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitibaStatus.Name = "bitibaStatus";
            this.bitibaStatus.Size = new System.Drawing.Size(121, 16);
            this.bitibaStatus.TabIndex = 3;
            this.bitibaStatus.Text = "NOT CONSUMING";
            // 
            // icaSectionBox
            // 
            this.arkenZooSectionBox.Controls.Add(this.arkenZooListBox);
            this.arkenZooSectionBox.Controls.Add(this.arkenZooStopButton);
            this.arkenZooSectionBox.Controls.Add(this.arkenZooStartBtn);
            this.arkenZooSectionBox.Controls.Add(this.arkenZooCheckbox);
            this.arkenZooSectionBox.Controls.Add(this.arkenZooStatusLabel);
            this.arkenZooSectionBox.Controls.Add(this.arkenZooStatus);
            this.arkenZooSectionBox.Location = new System.Drawing.Point(25, 23);
            this.arkenZooSectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.arkenZooSectionBox.Name = "arkenZooSectionBox";
            this.arkenZooSectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.arkenZooSectionBox.Size = new System.Drawing.Size(513, 123);
            this.arkenZooSectionBox.TabIndex = 0;
            this.arkenZooSectionBox.TabStop = false;
            this.arkenZooSectionBox.Text = "Arken Zoo";
            // 
            // icaListBox
            // 
            this.arkenZooListBox.FormattingEnabled = true;
            this.arkenZooListBox.ItemHeight = 16;
            this.arkenZooListBox.Location = new System.Drawing.Point(208, 23);
            this.arkenZooListBox.Margin = new System.Windows.Forms.Padding(4);
            this.arkenZooListBox.Name = "arkenZooListBox";
            this.arkenZooListBox.Size = new System.Drawing.Size(286, 84);
            this.arkenZooListBox.TabIndex = 8;
            // 
            // icaStopButton
            // 
            this.arkenZooStopButton.Enabled = false;
            this.arkenZooStopButton.Location = new System.Drawing.Point(138, 78);
            this.arkenZooStopButton.Margin = new System.Windows.Forms.Padding(4);
            this.arkenZooStopButton.Name = "arkenZooStopButton";
            this.arkenZooStopButton.Size = new System.Drawing.Size(53, 28);
            this.arkenZooStopButton.TabIndex = 7;
            this.arkenZooStopButton.Text = "Stop";
            this.arkenZooStopButton.UseVisualStyleBackColor = true;
            this.arkenZooStopButton.Click += new System.EventHandler(this.ArkenZooStopBtn_Click);
            // 
            // icaStartBtn
            // 
            this.arkenZooStartBtn.Enabled = false;
            this.arkenZooStartBtn.Location = new System.Drawing.Point(20, 78);
            this.arkenZooStartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.arkenZooStartBtn.Name = "arkenZooStartBtn";
            this.arkenZooStartBtn.Size = new System.Drawing.Size(108, 28);
            this.arkenZooStartBtn.TabIndex = 6;
            this.arkenZooStartBtn.Text = "Start Loading";
            this.arkenZooStartBtn.UseVisualStyleBackColor = true;
            this.arkenZooStartBtn.Click += new System.EventHandler(this.ArkenZooStartBtn_Click);
            // 
            // icaCheckbox
            // 
            this.arkenZooCheckbox.AutoSize = true;
            this.arkenZooCheckbox.Location = new System.Drawing.Point(20, 47);
            this.arkenZooCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.arkenZooCheckbox.Name = "arkenZooCheckbox";
            this.arkenZooCheckbox.Size = new System.Drawing.Size(111, 20);
            this.arkenZooCheckbox.TabIndex = 5;
            this.arkenZooCheckbox.Text = "Continue load";
            this.arkenZooCheckbox.UseVisualStyleBackColor = true;
            // 
            // icaStatusLabel
            // 
            this.arkenZooStatusLabel.AutoSize = true;
            this.arkenZooStatusLabel.Location = new System.Drawing.Point(9, 19);
            this.arkenZooStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arkenZooStatusLabel.Name = "arkenZooStatusLabel";
            this.arkenZooStatusLabel.Size = new System.Drawing.Size(47, 16);
            this.arkenZooStatusLabel.TabIndex = 4;
            this.arkenZooStatusLabel.Text = "Status:";
            // 
            // icaStatus
            // 
            this.arkenZooStatus.AutoSize = true;
            this.arkenZooStatus.Location = new System.Drawing.Point(58, 19);
            this.arkenZooStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arkenZooStatus.Name = "arkenZooStatus";
            this.arkenZooStatus.Size = new System.Drawing.Size(121, 16);
            this.arkenZooStatus.TabIndex = 3;
            this.arkenZooStatus.Text = "NOT CONSUMING";
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
            this.bitibaBox.ResumeLayout(false);
            this.bitibaBox.PerformLayout();
            this.arkenZooSectionBox.ResumeLayout(false);
            this.arkenZooSectionBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox royalCaninnBox;
        private System.Windows.Forms.Button royalCaninStopBtn;
        private System.Windows.Forms.Button royalCaninStartBtn;
        private System.Windows.Forms.Label royalCaninStatusLabel;
        private System.Windows.Forms.Label royalCaninStatus;
        private System.Windows.Forms.GroupBox hurttaBox;
        private System.Windows.Forms.Button hurttaStopBtn;
        private System.Windows.Forms.Button hurttaStartBtn;
        private System.Windows.Forms.Label hurttaStatus;
        private System.Windows.Forms.Label hurttaStatusLabel;
        private System.Windows.Forms.GroupBox trixieBox;
        private System.Windows.Forms.Button trixieStopBtn;
        private System.Windows.Forms.Button trixieStartBtn;
        private System.Windows.Forms.Label trixieStatus;
        private System.Windows.Forms.Label trixieStatusLabel;
        private System.Windows.Forms.GroupBox arkenZooSectionBox;
        private System.Windows.Forms.ListBox arkenZooListBox;
        private System.Windows.Forms.Button arkenZooStopButton;
        private System.Windows.Forms.Button arkenZooStartBtn;
        private System.Windows.Forms.CheckBox arkenZooCheckbox;
        private System.Windows.Forms.Label arkenZooStatusLabel;
        private System.Windows.Forms.Label arkenZooStatus;
        private System.Windows.Forms.GroupBox vetZooBox;
        private System.Windows.Forms.ListBox vetZooListbox;
        private System.Windows.Forms.Button vetZooStopBtn;
        private System.Windows.Forms.Button vetZooStartBtn;
        private System.Windows.Forms.CheckBox vetZooCheckbox;
        private System.Windows.Forms.Label vetZooStatusLabel;
        private System.Windows.Forms.Label vetZooStatus;
        private System.Windows.Forms.GroupBox bitibaBox;
        private System.Windows.Forms.ListBox bitibaListBox;
        private System.Windows.Forms.Button bitibaStopBtn;
        private System.Windows.Forms.Button bitibaStartBtn;
        private System.Windows.Forms.CheckBox bitibaCheckbox;
        private System.Windows.Forms.Label bitibaStatusLabel;
        private System.Windows.Forms.Label bitibaStatus;
        private System.Windows.Forms.Label lblItemsProduced;
        private System.Windows.Forms.Button startBtn;

        public Button StartButton { get { return startBtn; } set { startBtn = value; } }
        public GroupBox ProducerSectionBox { get { return producerSectionBox; } set { producerSectionBox = value; } }
        public GroupBox ConsumerSectionBox { get { return consumerSectionBox; } set { consumerSectionBox = value; } }
        public GroupBox StorageSectionBox { get { return storageSectionBox; } set { storageSectionBox = value; } }
        public ProgressBar ProgressItems { get { return progressItems; } set { progressItems = value; } }
        public Label MaxCapacityLabel { get { return maxCapacityLabel; } set { maxCapacityLabel = value; } }
        public GroupBox RoyalCaninBox { get { return royalCaninnBox; } set { royalCaninnBox = value; } }
        public Button RoyalCaninStopBtn { get { return royalCaninStopBtn; } set { royalCaninStopBtn = value; } }
        public Button RoyalCaninStartBtn { get { return royalCaninStartBtn; } set { royalCaninStartBtn = value; } }
        public Label RoyalCaninStatusLabel { get { return royalCaninStatusLabel; } set { royalCaninStatusLabel = value; } }
        public Label RoyalCaninStatus { get { return royalCaninStatus; } set { royalCaninStatus = value; } }
        public GroupBox HurttaBox { get { return hurttaBox; } set { hurttaBox = value; } }
        public Button HurttaStopBtn { get { return hurttaStopBtn; } set { hurttaStopBtn = value; } }
        public Button HurttaStartBtn { get { return hurttaStartBtn; } set { hurttaStartBtn = value; } }
        public Label HurttaStatus { get { return hurttaStatus; } set { hurttaStatus = value; } }
        public Label HurttaStatusLabel { get { return hurttaStatusLabel; } set { hurttaStatusLabel = value; } }
        public GroupBox BitibaBox { get { return trixieBox; } set { trixieBox = value; } }
        public Button TrixieStopBtn { get { return trixieStopBtn; } set { trixieStopBtn = value; } }
        public Button TrixieStartBtn { get { return trixieStartBtn; } set { trixieStartBtn = value; } }
        public Label TrixieStatus { get { return trixieStatus; } set { trixieStatus = value; } }
        public Label TrixieStatusLabel { get { return trixieStatusLabel; } set { trixieStatusLabel = value; } }
        public GroupBox ArkenZooSectionBox { get { return arkenZooSectionBox; } set { arkenZooSectionBox = value; } }
        public ListBox ArkenZooListBox { get { return arkenZooListBox; } set { arkenZooListBox = value; } }
        public Button ArkenZooStopButton { get { return arkenZooStopButton; } set { arkenZooStopButton = value; } }
        public Button ArkenZooStartBtn { get { return arkenZooStartBtn; } set { arkenZooStartBtn = value; } }
        public CheckBox ArkenZooCheckbox { get { return arkenZooCheckbox; } set { arkenZooCheckbox = value; } }
        public Label ArkenZooStatusLabel { get { return arkenZooStatusLabel; } set { arkenZooStatusLabel = value; } }
        public Label ArkenZooStatus { get { return arkenZooStatus; } set { arkenZooStatus = value; } }
        public GroupBox VetZooBox { get { return vetZooBox; } set { vetZooBox = value; } }
        public ListBox VetZooListbox { get { return vetZooListbox; } set { vetZooListbox = value; } }
        public Button VetZooStopBtn { get { return vetZooStopBtn; } set { vetZooStopBtn = value; } }
        public Button VetZooStartBtn { get { return vetZooStartBtn; } set { vetZooStartBtn = value; } }
        public CheckBox VetZooCheckbox { get { return vetZooCheckbox; } set { vetZooCheckbox = value; } }
        public Label VetZooStatusLabel { get { return vetZooStatusLabel; } set { vetZooStatusLabel = value; } }
        public Label VetZooStatus { get { return vetZooStatus; } set { vetZooStatus = value; } }
        public GroupBox TrixieBox { get { return bitibaBox; } set { bitibaBox = value; } }
        public ListBox BitibaListBox { get { return bitibaListBox; } set { bitibaListBox = value; } }
        public Button BitibaStopBtn { get { return bitibaStopBtn; } set { bitibaStopBtn = value; } }
        public Button BitibaStartBtn { get { return bitibaStartBtn; } set { bitibaStartBtn = value; } }
        public CheckBox BitibaCheckbox { get { return bitibaCheckbox; } set { bitibaCheckbox = value; } }
        public Label BitibaStatusLabel { get { return bitibaStatusLabel; } set { bitibaStatusLabel = value; } }
        public Label BitibaStatus { get { return bitibaStatus; } set { bitibaStatus = value; } }
        public Label LblItemsProduced { get { return lblItemsProduced; } set { lblItemsProduced = value; } }


    }
}

