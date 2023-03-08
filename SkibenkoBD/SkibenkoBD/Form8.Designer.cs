namespace SkibenkoBD
{
    partial class Form8
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
            System.Windows.Forms.Label код_книгиLabel;
            System.Windows.Forms.Label код_читателяLabel;
            System.Windows.Forms.Label дата_выдачиLabel;
            System.Windows.Forms.Label дата_возвратаLabel;
            System.Windows.Forms.Label отметка_о_возвратеLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.label1 = new System.Windows.Forms.Label();
            this.skibenkoDb = new SkibenkoBD.SkibenkoDb();
            this.выданные_книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выданные_книгиTableAdapter = new SkibenkoBD.SkibenkoDbTableAdapters.Выданные_книгиTableAdapter();
            this.tableAdapterManager = new SkibenkoBD.SkibenkoDbTableAdapters.TableAdapterManager();
            this.выданные_книгиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выданные_книгиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_читателяTextBox = new System.Windows.Forms.TextBox();
            this.дата_выдачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_возвратаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.отметка_о_возвратеTextBox = new System.Windows.Forms.TextBox();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиTableAdapter = new SkibenkoBD.SkibenkoDbTableAdapters.КнигиTableAdapter();
            код_книгиLabel = new System.Windows.Forms.Label();
            код_читателяLabel = new System.Windows.Forms.Label();
            дата_выдачиLabel = new System.Windows.Forms.Label();
            дата_возвратаLabel = new System.Windows.Forms.Label();
            отметка_о_возвратеLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skibenkoDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданные_книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданные_книгиBindingNavigator)).BeginInit();
            this.выданные_книгиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_книгиLabel
            // 
            код_книгиLabel.AutoSize = true;
            код_книгиLabel.Location = new System.Drawing.Point(255, 132);
            код_книгиLabel.Name = "код_книгиLabel";
            код_книгиLabel.Size = new System.Drawing.Size(61, 13);
            код_книгиLabel.TabIndex = 2;
            код_книгиLabel.Text = "Код книги:";
            // 
            // код_читателяLabel
            // 
            код_читателяLabel.AutoSize = true;
            код_читателяLabel.Location = new System.Drawing.Point(239, 158);
            код_читателяLabel.Name = "код_читателяLabel";
            код_читателяLabel.Size = new System.Drawing.Size(77, 13);
            код_читателяLabel.TabIndex = 4;
            код_читателяLabel.Text = "Код читателя:";
            // 
            // дата_выдачиLabel
            // 
            дата_выдачиLabel.AutoSize = true;
            дата_выдачиLabel.Location = new System.Drawing.Point(240, 185);
            дата_выдачиLabel.Name = "дата_выдачиLabel";
            дата_выдачиLabel.Size = new System.Drawing.Size(76, 13);
            дата_выдачиLabel.TabIndex = 6;
            дата_выдачиLabel.Text = "Дата выдачи:";
            // 
            // дата_возвратаLabel
            // 
            дата_возвратаLabel.AutoSize = true;
            дата_возвратаLabel.Location = new System.Drawing.Point(230, 211);
            дата_возвратаLabel.Name = "дата_возвратаLabel";
            дата_возвратаLabel.Size = new System.Drawing.Size(86, 13);
            дата_возвратаLabel.TabIndex = 8;
            дата_возвратаLabel.Text = "Дата возврата:";
            // 
            // отметка_о_возвратеLabel
            // 
            отметка_о_возвратеLabel.AutoSize = true;
            отметка_о_возвратеLabel.Location = new System.Drawing.Point(203, 236);
            отметка_о_возвратеLabel.Name = "отметка_о_возвратеLabel";
            отметка_о_возвратеLabel.Size = new System.Drawing.Size(113, 13);
            отметка_о_возвратеLabel.TabIndex = 10;
            отметка_о_возвратеLabel.Text = "Отметка о возврате:";
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(226, 262);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(90, 13);
            код_сотрудникаLabel.TabIndex = 12;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(300, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Выданные книги\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skibenkoDb
            // 
            this.skibenkoDb.DataSetName = "SkibenkoDb";
            this.skibenkoDb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выданные_книгиBindingSource
            // 
            this.выданные_книгиBindingSource.DataMember = "Выданные книги";
            this.выданные_книгиBindingSource.DataSource = this.skibenkoDb;
            // 
            // выданные_книгиTableAdapter
            // 
            this.выданные_книгиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SkibenkoBD.SkibenkoDbTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выданные_книгиTableAdapter = this.выданные_книгиTableAdapter;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ИздательстваTableAdapter = null;
            this.tableAdapterManager.КнигиTableAdapter = null;
            this.tableAdapterManager.Ошибки_вставкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            // 
            // выданные_книгиBindingNavigator
            // 
            this.выданные_книгиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.выданные_книгиBindingNavigator.BindingSource = this.выданные_книгиBindingSource;
            this.выданные_книгиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.выданные_книгиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.выданные_книгиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.выданные_книгиBindingNavigatorSaveItem});
            this.выданные_книгиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.выданные_книгиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.выданные_книгиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.выданные_книгиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.выданные_книгиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.выданные_книгиBindingNavigator.Name = "выданные_книгиBindingNavigator";
            this.выданные_книгиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.выданные_книгиBindingNavigator.Size = new System.Drawing.Size(790, 25);
            this.выданные_книгиBindingNavigator.TabIndex = 1;
            this.выданные_книгиBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // выданные_книгиBindingNavigatorSaveItem
            // 
            this.выданные_книгиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.выданные_книгиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("выданные_книгиBindingNavigatorSaveItem.Image")));
            this.выданные_книгиBindingNavigatorSaveItem.Name = "выданные_книгиBindingNavigatorSaveItem";
            this.выданные_книгиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.выданные_книгиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.выданные_книгиBindingNavigatorSaveItem.Click += new System.EventHandler(this.выданные_книгиBindingNavigatorSaveItem_Click);
            // 
            // код_читателяTextBox
            // 
            this.код_читателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выданные_книгиBindingSource, "Код читателя", true));
            this.код_читателяTextBox.Location = new System.Drawing.Point(322, 155);
            this.код_читателяTextBox.Name = "код_читателяTextBox";
            this.код_читателяTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_читателяTextBox.TabIndex = 5;
            // 
            // дата_выдачиDateTimePicker
            // 
            this.дата_выдачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.выданные_книгиBindingSource, "Дата выдачи", true));
            this.дата_выдачиDateTimePicker.Location = new System.Drawing.Point(322, 181);
            this.дата_выдачиDateTimePicker.Name = "дата_выдачиDateTimePicker";
            this.дата_выдачиDateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.дата_выдачиDateTimePicker.TabIndex = 7;
            // 
            // дата_возвратаDateTimePicker
            // 
            this.дата_возвратаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.выданные_книгиBindingSource, "Дата возврата", true));
            this.дата_возвратаDateTimePicker.Location = new System.Drawing.Point(322, 207);
            this.дата_возвратаDateTimePicker.Name = "дата_возвратаDateTimePicker";
            this.дата_возвратаDateTimePicker.Size = new System.Drawing.Size(178, 20);
            this.дата_возвратаDateTimePicker.TabIndex = 9;
            // 
            // отметка_о_возвратеTextBox
            // 
            this.отметка_о_возвратеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выданные_книгиBindingSource, "Отметка о возврате", true));
            this.отметка_о_возвратеTextBox.Location = new System.Drawing.Point(322, 233);
            this.отметка_о_возвратеTextBox.Name = "отметка_о_возвратеTextBox";
            this.отметка_о_возвратеTextBox.Size = new System.Drawing.Size(100, 20);
            this.отметка_о_возвратеTextBox.TabIndex = 11;
            this.отметка_о_возвратеTextBox.TextChanged += new System.EventHandler(this.отметка_о_возвратеTextBox_TextChanged);
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выданные_книгиBindingSource, "Код сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(322, 259);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_сотрудникаTextBox.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.книгиBindingSource;
            this.comboBox1.DisplayMember = "Код книги";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "Код книги";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.skibenkoDb;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 408);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(отметка_о_возвратеLabel);
            this.Controls.Add(this.отметка_о_возвратеTextBox);
            this.Controls.Add(дата_возвратаLabel);
            this.Controls.Add(this.дата_возвратаDateTimePicker);
            this.Controls.Add(дата_выдачиLabel);
            this.Controls.Add(this.дата_выдачиDateTimePicker);
            this.Controls.Add(код_читателяLabel);
            this.Controls.Add(this.код_читателяTextBox);
            this.Controls.Add(код_книгиLabel);
            this.Controls.Add(this.выданные_книгиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skibenkoDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданные_книгиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выданные_книгиBindingNavigator)).EndInit();
            this.выданные_книгиBindingNavigator.ResumeLayout(false);
            this.выданные_книгиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SkibenkoDb skibenkoDb;
        private System.Windows.Forms.BindingSource выданные_книгиBindingSource;
        private SkibenkoDbTableAdapters.Выданные_книгиTableAdapter выданные_книгиTableAdapter;
        private SkibenkoDbTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator выданные_книгиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton выданные_книгиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_читателяTextBox;
        private System.Windows.Forms.DateTimePicker дата_выдачиDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_возвратаDateTimePicker;
        private System.Windows.Forms.TextBox отметка_о_возвратеTextBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private SkibenkoDbTableAdapters.КнигиTableAdapter книгиTableAdapter;
    }
}