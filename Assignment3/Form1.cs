using Assignment3;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        private Manager logisticManager;
        private Buffer<Product> storage;

        public Form1()
        {
            InitializeComponent();
            logisticManager = new Manager(this);
            storage = logisticManager.buffer;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.Start();
            logisticManager.managerThread.Start();
            bitibaStartBtn.Enabled = true;
            arkenZooStartBtn.Enabled = true;
            vetZooStartBtn.Enabled = true;
            trixieStartBtn.Enabled = true;
            HurttaStartBtn.Enabled = true;
            royalCaninStartBtn.Enabled = true;
        }

        private void RoyalCaninStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartProducer(Product.CategoryType.Food);
            royalCaninStatus.Text = Strings.PRODUCINGFOOD;
            royalCaninStartBtn.Enabled = false;
            royalCaninStopBtn.Enabled = true;
        }

        private void RoyalCaninStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopProducer(Product.CategoryType.Food);
            royalCaninStatus.Text = Strings.NOT_PRODUCING;
            royalCaninStartBtn.Enabled = true;
            royalCaninStopBtn.Enabled = false;
        }

        private void trixieStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartProducer(Product.CategoryType.Toys);
            trixieStatus.Text = Strings.PRODUCINGTOYS;
            trixieStartBtn.Enabled = false;
            trixieStopBtn.Enabled = true;
        }

        private void trixieStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopProducer(Product.CategoryType.Toys);
            trixieStatus.Text = Strings.NOT_PRODUCING;
            trixieStartBtn.Enabled = true;
            trixieStopBtn.Enabled = false;
        }

        private void HurttaStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartProducer(Product.CategoryType.Accessories);
            hurttaStatus.Text = Strings.PRODUCINGACCESSORIES;
            hurttaStartBtn.Enabled = false;
            hurttaStopBtn.Enabled = true;
        }

        private void HurttaStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopProducer(Product.CategoryType.Accessories);
            hurttaStatus.Text = Strings.NOT_PRODUCING;
            hurttaStartBtn.Enabled = true;
            hurttaStopBtn.Enabled = false;
        }

        private void BitibaStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartConsumer(Product.CategoryType.Toys);
            bitibaStatus.Text = Strings.CONSUMING;
            bitibaStartBtn.Enabled = false;
            bitibaStopBtn.Enabled = true;
        }

        private void BitibaStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopConsumer(Product.CategoryType.Toys);
            bitibaStatus.Text = Strings.NOT_CONSUMING;
            bitibaStartBtn.Enabled = true;
            bitibaStopBtn.Enabled = false;
        }

        private void ArkenZooStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartConsumer(Product.CategoryType.Food);
            arkenZooStatus.Text = Strings.CONSUMING;
            arkenZooStartBtn.Enabled = false;
            arkenZooStopButton.Enabled = true;
        }

        private void ArkenZooStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopConsumer(Product.CategoryType.Food);
            arkenZooStatus.Text = Strings.NOT_CONSUMING;
            arkenZooStartBtn.Enabled = true;
            arkenZooStopButton.Enabled = false;
        }

        private void VetZooStartBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StartConsumer(Product.CategoryType.Accessories);
            vetZooStatus.Text = Strings.CONSUMING;
            vetZooStartBtn.Enabled = false;
            vetZooStopBtn.Enabled = true;
        }

        private void VetZooStopBtn_Click(object sender, EventArgs e)
        {
            logisticManager.StopConsumer(Product.CategoryType.Accessories);
            vetZooStatus.Text = Strings.NOT_CONSUMING;
            vetZooStartBtn.Enabled = true;
            vetZooStopBtn.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void UpdateBitibaProducts(string item)
        {

            if (BitibaListBox.InvokeRequired)
            {
                BitibaListBox.Invoke(new Action<string>(UpdateBitibaProducts), item);
            }
            else
            {
                BitibaListBox.Items.Add(item);
            }
        }

        public void UpdateArkenZooProducts(string item)
        {
            if (ArkenZooListBox.InvokeRequired)
            {
                ArkenZooListBox.Invoke(new Action<string>(UpdateArkenZooProducts), item);
            }
            else
            {
                ArkenZooListBox.Items.Add(item);
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
        public void UpdateBitibaStatus(bool state)
        {
            if (BitibaStatus.InvokeRequired)
            {
                BitibaStatus.Invoke(new Action<bool>(UpdateBitibaStatus), state);
            }
            else
            {
                if (state)
                {
                    BitibaStatus.Text = Strings.CONSUMING;
                }
                else
                {
                    BitibaStatus.Text = Strings.WAITING;
                }
            }
        }
        public void UpdateArkenZooStatus(bool state)
        {
            if (ArkenZooStatus.InvokeRequired)
            {
                ArkenZooStatus.Invoke(new Action<bool>(UpdateArkenZooStatus), state);
            }
            else
            {
                if (state)
                {
                    ArkenZooStatus.Text = Strings.CONSUMING;
                }
                else
                {
                    ArkenZooStatus.Text = Strings.WAITING;
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
                    VetZooStatus.Text = Strings.CONSUMING;
                }
                else
                {
                    VetZooStatus.Text = Strings.WAITING;
                }
            }
        }
    }
}