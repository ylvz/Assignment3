using Assignment3;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        private LogisticManager logisticManager;
        private Storage<Product> storage;

        public Form1()
        {
            InitializeComponent();
            logisticManager = new LogisticManager(this);
            storage = logisticManager.Storage;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.Start();
            logisticManager.managerThread.Start();
            trixieStartBtn.Enabled = true;
            royalCaninStartBtn.Enabled = true;
            vetZooStartBtn.Enabled = true;
            razerStartBtn.Enabled = true;
            BOSCHStartBtn.Enabled = true;
            lantmannenStartBtn.Enabled = true;
        }

        private void LantmannenStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartProducer(Product.CategoryType.Food);
            lantmannenStatus.Text = ConstStrings.PRODUCING;
            lantmannenStartBtn.Enabled = false;
            lantmannenStopBtn.Enabled = true;
        }

        private void LantmannenStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopProducer(Product.CategoryType.Food);
            lantmannenStatus.Text = ConstStrings.NOT_PRODUCING;
            lantmannenStartBtn.Enabled = true;
            lantmannenStopBtn.Enabled = false;
        }

        private void RazerStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartProducer(Product.CategoryType.Toys);
            razerStatus.Text = ConstStrings.PRODUCING;
            razerStartBtn.Enabled = false;
            razerStopBtn.Enabled = true;
        }

        private void RazerStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopProducer(Product.CategoryType.Toys);
            razerStatus.Text = ConstStrings.NOT_PRODUCING;
            razerStartBtn.Enabled = true;
            razerStopBtn.Enabled = false;
        }

        private void BOSCHStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartProducer(Product.CategoryType.Accessories);
            bOSCHStatus.Text = ConstStrings.PRODUCING;
            bOSCHStartBtn.Enabled = false;
            bOSCHStopBtn.Enabled = true;
        }

        private void BOSCHStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopProducer(Product.CategoryType.Accessories);
            bOSCHStatus.Text = ConstStrings.NOT_PRODUCING;
            bOSCHStartBtn.Enabled = true;
            bOSCHStopBtn.Enabled = false;
        }

        private void TrixieStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartConsumer(Product.CategoryType.Toys);
            trixieStatus.Text = ConstStrings.CONSUMING;
            trixieStartBtn.Enabled = false;
            trixieStopBtn.Enabled = true;
        }

        private void TrixieStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopConsumer(Product.CategoryType.Toys);
            trixieStatus.Text = ConstStrings.NOT_CONSUMING;
            trixieStartBtn.Enabled = true;
            trixieStopBtn.Enabled = false;
        }

        private void RoyalCaninStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartConsumer(Product.CategoryType.Food);
            royalCaninStatus.Text = ConstStrings.CONSUMING;
            royalCaninStartBtn.Enabled = false;
            royalCaninStopButton.Enabled = true;
        }

        private void RoyalCaninStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopConsumer(Product.CategoryType.Food);
            royalCaninStatus.Text = ConstStrings.NOT_CONSUMING;
            royalCaninStartBtn.Enabled = true;
            royalCaninStopButton.Enabled = false;
        }

        private void VetZooStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartConsumer(Product.CategoryType.Accessories);
            vetZooStatus.Text = ConstStrings.CONSUMING;
            vetZooStartBtn.Enabled = false;
            vetZooStopBtn.Enabled = true;
        }

        private void VetZooStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopConsumer(Product.CategoryType.Accessories);
            vetZooStatus.Text = ConstStrings.NOT_CONSUMING;
            vetZooStartBtn.Enabled = true;
            vetZooStopBtn.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void UpdateTrixieProducts(string item)
        {

            if (TrixieListBox.InvokeRequired)
            {
                TrixieListBox.Invoke(new Action<string>(UpdateTrixieProducts), item);
            }
            else
            {
                TrixieListBox.Items.Add(item);
            }
        }

        public void UpdateRoyalCaninProducts(string item)
        {
            if (RoyalCaninListBox.InvokeRequired)
            {
                RoyalCaninListBox.Invoke(new Action<string>(UpdateRoyalCaninProducts), item);
            }
            else
            {
                RoyalCaninListBox.Items.Add(item);
            }
        }
        public void UpdateVetZooProducts(string item)
        {
            if (VetZooListbox.InvokeRequired)
            {
                VetZooListbox.Invoke(new Action<string>(UpdateVetZooProducts), item);
            }
            else
            {
                VetZooListbox.Items.Add(item);
            }
        }

        public void UpdateProgressBar(int value)
        {
            if (ProgressItems.InvokeRequired)
            {
                ProgressItems.Invoke(new Action<int>(UpdateProgressBar), value);
            }
            else
            {
                ProgressItems.Value = value;
            }
        }
        public void UpdateTrixieStatus(bool state)
        {
            if (TrixieStatus.InvokeRequired)
            {
                TrixieStatus.Invoke(new Action<bool>(UpdateTrixieStatus), state);
            }
            else
            {
                if (state)
                {
                    TrixieStatus.Text = ConstStrings.CONSUMING;
                }
                else
                {
                    TrixieStatus.Text = ConstStrings.WAITING;
                }
            }
        }
        public void UpdateRoyalCaninStatus(bool state)
        {
            if (RoyalCaninStatus.InvokeRequired)
            {
                RoyalCaninStatus.Invoke(new Action<bool>(UpdateRoyalCaninStatus), state);
            }
            else
            {
                if (state)
                {
                    RoyalCaninStatus.Text = ConstStrings.CONSUMING;
                }
                else
                {
                    RoyalCaninStatus.Text = ConstStrings.WAITING;
                }
            }
        }
        public void UpdateVetZooStatus(bool state)
        {
            if (VetZooStatus.InvokeRequired)
            {
                VetZooStatus.Invoke(new Action<bool>(UpdateVetZooStatus), state);
            }
            else
            {
                if (state)
                {
                    VetZooStatus.Text = ConstStrings.CONSUMING;
                }
                else
                {
                    VetZooStatus.Text = ConstStrings.WAITING;
                }
            }
        }
    }
}