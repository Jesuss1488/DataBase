namespace SkibenkoBD
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label код_издательстваLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label городLabel;
            System.Windows.Forms.Label адресLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.skibenkoDb = new SkibenkoBD.SkibenkoDb();
            this.издательстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательстваTableAdapter = new SkibenkoBD.SkibenkoDbTableAdapters.ИздательстваTableAdapter();
            this.tableAdapterManager = new SkibenkoBD.SkibenkoDbTableAdapters.TableAdapterManager();
            this.издательстваBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.издательстваBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_издательстваTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.городTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            код_издательстваLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            городLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skibenkoDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательстваBindingNavigator)).BeginInit();
            this.издательстваBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Издательства\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skibenkoDb
            // 
            this.skibenkoDb.DataSetName = "SkibenkoDb";
            this.skibenkoDb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // издательстваBindingSource
            // 
            this.издательстваBindingSource.DataMember = "Издательства";
            this.издательстваBindingSource.DataSource = this.skibenkoDb;
            // 
            // издательстваTableAdapter
            // 
            this.издательстваTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SkibenkoBD.SkibenkoDbTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выданные_книгиTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ИздательстваTableAdapter = this.издательстваTableAdapter;
            this.tableAdapterManager.КнигиTableAdapter = null;
            this.tableAdapterManager.Ошибки_вставкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            // 
            // издательстваBindingNavigator
            // 
            this.издательстваBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.издательстваBindingNavigator.BindingSource = this.издательстваBindingSource;
            this.издательстваBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.издательстваBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.издательстваBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.издательстваBindingNavigatorSaveItem});
            this.издательстваBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.издательстваBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.издательстваBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.издательстваBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.издательстваBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.издательстваBindingNavigator.Name = "издательстваBindingNavigator";
            this.издательстваBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.издательстваBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.издательстваBindingNavigator.TabIndex = 1;
            this.издательстваBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // издательстваBindingNavigatorSaveItem
            // 
            this.издательстваBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.издательстваBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("издательстваBindingNavigatorSaveItem.Image")));
            this.издательстваBindingNavigatorSaveItem.Name = "издательстваBindingNavigatorSaveItem";
            this.издательстваBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.издательстваBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.издательстваBindingNavigatorSaveItem.Click += new System.EventHandler(this.издательстваBindingNavigatorSaveItem_Click);
            // 
            // код_издательстваLabel
            // 
            код_издательстваLabel.AutoSize = true;
            код_издательстваLabel.Location = new System.Drawing.Point(186, 95);
            код_издательстваLabel.Name = "код_издательстваLabel";
            код_издательстваLabel.Size = new System.Drawing.Size(102, 13);
            код_издательстваLabel.TabIndex = 2;
            код_издательстваLabel.Text = "Код издательства:";
            // 
            // код_издательстваTextBox
            // 
            this.код_издательстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.издательстваBindingSource, "Код издательства", true));
            this.код_издательстваTextBox.Location = new System.Drawing.Point(294, 92);
            this.код_издательстваTextBox.Name = "код_издательстваTextBox";
            this.код_издательстваTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_издательстваTextBox.TabIndex = 3;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(202, 121);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 4;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.издательстваBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(294, 118);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 5;
            // 
            // городLabel
            // 
            городLabel.AutoSize = true;
            городLabel.Location = new System.Drawing.Point(248, 147);
            городLabel.Name = "городLabel";
            городLabel.Size = new System.Drawing.Size(40, 13);
            городLabel.TabIndex = 6;
            городLabel.Text = "Город:";
            // 
            // городTextBox
            // 
            this.городTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.издательстваBindingSource, "Город", true));
            this.городTextBox.Location = new System.Drawing.Point(294, 144);
            this.городTextBox.Name = "городTextBox";
            this.городTextBox.Size = new System.Drawing.Size(100, 20);
            this.городTextBox.TabIndex = 7;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(247, 173);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 8;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.издательстваBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(294, 170);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 20);
            this.адресTextBox.TabIndex = 9;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(городLabel);
            this.Controls.Add(this.городTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_издательстваLabel);
            this.Controls.Add(this.код_издательстваTextBox);
            this.Controls.Add(this.издательстваBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skibenkoDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательстваBindingNavigator)).EndInit();
            this.издательстваBindingNavigator.ResumeLayout(false);
            this.издательстваBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SkibenkoDb skibenkoDb;
        private System.Windows.Forms.BindingSource издательстваBindingSource;
        private SkibenkoDbTableAdapters.ИздательстваTableAdapter издательстваTableAdapter;
        private SkibenkoDbTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator издательстваBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton издательстваBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_издательстваTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox городTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
    }
}