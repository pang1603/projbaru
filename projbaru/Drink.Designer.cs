﻿namespace projbaru
{
    partial class Drink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drink));
            this.button44 = new System.Windows.Forms.Button();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.labelDrinkName = new System.Windows.Forms.Label();
            this.numericUpDownQuantity1 = new System.Windows.Forms.NumericUpDown();
            this.labelPriceValue1 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label44 = new System.Windows.Forms.Label();
            this.pictureBoxDrink = new System.Windows.Forms.PictureBox();
            this.dataSet1 = new projbaru.DataSet1();
            this.menuItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuItemTableAdapter = new projbaru.DataSet1TableAdapters.MenuItemTableAdapter();
            this.tableAdapterManager = new projbaru.DataSet1TableAdapters.TableAdapterManager();
            this.menuItemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.menuItemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemBindingNavigator)).BeginInit();
            this.menuItemBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button44
            // 
            this.button44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button44.Location = new System.Drawing.Point(642, 345);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(105, 58);
            this.button44.TabIndex = 28;
            this.button44.Text = "Checkout";
            this.button44.UseVisualStyleBackColor = true;
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.Location = new System.Drawing.Point(468, 331);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(77, 23);
            this.buttonAdd1.TabIndex = 27;
            this.buttonAdd1.Text = "Add";
            this.buttonAdd1.UseVisualStyleBackColor = true;
            // 
            // labelDrinkName
            // 
            this.labelDrinkName.AutoSize = true;
            this.labelDrinkName.Location = new System.Drawing.Point(55, 306);
            this.labelDrinkName.Name = "labelDrinkName";
            this.labelDrinkName.Size = new System.Drawing.Size(85, 13);
            this.labelDrinkName.TabIndex = 26;
            this.labelDrinkName.Text = "Iced Lemon Tea";
            // 
            // numericUpDownQuantity1
            // 
            this.numericUpDownQuantity1.Location = new System.Drawing.Point(514, 290);
            this.numericUpDownQuantity1.Name = "numericUpDownQuantity1";
            this.numericUpDownQuantity1.Size = new System.Drawing.Size(31, 20);
            this.numericUpDownQuantity1.TabIndex = 25;
            this.numericUpDownQuantity1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPriceValue1
            // 
            this.labelPriceValue1.AutoSize = true;
            this.labelPriceValue1.Location = new System.Drawing.Point(511, 256);
            this.labelPriceValue1.Name = "labelPriceValue1";
            this.labelPriceValue1.Size = new System.Drawing.Size(28, 13);
            this.labelPriceValue1.TabIndex = 24;
            this.labelPriceValue1.Text = "4.00";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(419, 290);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(46, 13);
            this.label33.TabIndex = 23;
            this.label33.Text = "Quantity";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(411, 256);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Price, RM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(529, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Listings";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(260, 331);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(105, 23);
            this.button22.TabIndex = 20;
            this.button22.Text = "Next";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(58, 331);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 23);
            this.button11.TabIndex = 19;
            this.button11.Text = "Previous";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label44.Location = new System.Drawing.Point(54, 48);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(70, 21);
            this.label44.TabIndex = 30;
            this.label44.Text = "Drinks";
            // 
            // pictureBoxDrink
            // 
            this.pictureBoxDrink.Image = global::projbaru.Properties.Resources.limau_ais;
            this.pictureBoxDrink.Location = new System.Drawing.Point(58, 92);
            this.pictureBoxDrink.Name = "pictureBoxDrink";
            this.pictureBoxDrink.Size = new System.Drawing.Size(307, 211);
            this.pictureBoxDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDrink.TabIndex = 18;
            this.pictureBoxDrink.TabStop = false;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuItemBindingSource
            // 
            this.menuItemBindingSource.DataMember = "MenuItem";
            this.menuItemBindingSource.DataSource = this.dataSet1;
            // 
            // menuItemTableAdapter
            // 
            this.menuItemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanksTableAdapter = null;
            this.tableAdapterManager.GuestTableAdapter = null;
            this.tableAdapterManager.MenuItemTableAdapter = this.menuItemTableAdapter;
            this.tableAdapterManager.OrderDetailTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projbaru.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // menuItemBindingNavigator
            // 
            this.menuItemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.menuItemBindingNavigator.BindingSource = this.menuItemBindingSource;
            this.menuItemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.menuItemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.menuItemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.menuItemBindingNavigatorSaveItem});
            this.menuItemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.menuItemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.menuItemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.menuItemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.menuItemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.menuItemBindingNavigator.Name = "menuItemBindingNavigator";
            this.menuItemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.menuItemBindingNavigator.Size = new System.Drawing.Size(111, 25);
            this.menuItemBindingNavigator.TabIndex = 31;
            this.menuItemBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // menuItemBindingNavigatorSaveItem
            // 
            this.menuItemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuItemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("menuItemBindingNavigatorSaveItem.Image")));
            this.menuItemBindingNavigatorSaveItem.Name = "menuItemBindingNavigatorSaveItem";
            this.menuItemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.menuItemBindingNavigatorSaveItem.Text = "Save Data";
            this.menuItemBindingNavigatorSaveItem.Click += new System.EventHandler(this.menuItemBindingNavigatorSaveItem_Click);
            // 
            // Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuItemBindingNavigator);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.buttonAdd1);
            this.Controls.Add(this.labelDrinkName);
            this.Controls.Add(this.numericUpDownQuantity1);
            this.Controls.Add(this.labelPriceValue1);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.pictureBoxDrink);
            this.Controls.Add(this.label44);
            this.Name = "Drink";
            this.Text = "Drink";
            this.Load += new System.EventHandler(this.Drink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemBindingNavigator)).EndInit();
            this.menuItemBindingNavigator.ResumeLayout(false);
            this.menuItemBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.Label labelDrinkName;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity1;
        private System.Windows.Forms.Label labelPriceValue1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.PictureBox pictureBoxDrink;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label44;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource menuItemBindingSource;
        private DataSet1TableAdapters.MenuItemTableAdapter menuItemTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator menuItemBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton menuItemBindingNavigatorSaveItem;
    }
}