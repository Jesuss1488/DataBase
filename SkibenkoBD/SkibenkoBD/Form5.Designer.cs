namespace SkibenkoBD
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label код_жанраLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label описаниеLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.skibenkoDb = new SkibenkoBD.SkibenkoDb();
            this.жанрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.жанрыTableAdapter = new SkibenkoBD.SkibenkoDbTableAdapters.ЖанрыTableAdapter();
            this.tableAdapterManager = new SkibenkoBD.SkibenkoDbTableAdapters.TableAdapterManager();
            this.жанрыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.жанрыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_жанраTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            код_жанраLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skibenkoDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingNavigator)).BeginInit();
            this.жанрыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Жанры\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skibenkoDb
            // 
            this.skibenkoDb.DataSetName = "SkibenkoDb";
            this.skibenkoDb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // жанрыBindingSource
            // 
            this.жанрыBindingSource.DataMember = "Жанры";
            this.жанрыBindingSource.DataSource = this.skibenkoDb;
            // 
            // жанрыTableAdapter
            // 
            this.жанрыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SkibenkoBD.SkibenkoDbTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выданные_книгиTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = this.жанрыTableAdapter;
            this.tableAdapterManager.ИздательстваTableAdapter = null;
            this.tableAdapterManager.КнигиTableAdapter = null;
            this.tableAdapterManager.Ошибки_вставкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            // 
            // жанрыBindingNavigator
            // 
            this.жанрыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.жанрыBindingNavigator.BindingSource = this.жанрыBindingSource;
            this.жанрыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.жанрыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.жанрыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.жанрыBindingNavigatorSaveItem});
            this.жанрыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.жанрыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.жанрыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.жанрыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.жанрыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.жанрыBindingNavigator.Name = "жанрыBindingNavigator";
            this.жанрыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.жанрыBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.жанрыBindingNavigator.TabIndex = 1;
            this.жанрыBindingNavigator.Text = "bindingNavigator1";
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
            // жанрыBindingNavigatorSaveItem
            // 
            this.жанрыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.жанрыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("жанрыBindingNavigatorSaveItem.Image")));
            this.жанрыBindingNavigatorSaveItem.Name = "жанрыBindingNavigatorSaveItem";
            this.жанрыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.жанрыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.жанрыBindingNavigatorSaveItem.Click += new System.EventHandler(this.жанрыBindingNavigatorSaveItem_Click);
            // 
            // код_жанраLabel
            // 
            код_жанраLabel.AutoSize = true;
            код_жанраLabel.Location = new System.Drawing.Point(220, 94);
            код_жанраLabel.Name = "код_жанраLabel";
            код_жанраLabel.Size = new System.Drawing.Size(64, 13);
            код_жанраLabel.TabIndex = 2;
            код_жанраLabel.Text = "Код жанра:";
            // 
            // код_жанраTextBox
            // 
            this.код_жанраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.жанрыBindingSource, "Код жанра", true));
            this.код_жанраTextBox.Location = new System.Drawing.Point(290, 91);
            this.код_жанраTextBox.Name = "код_жанраTextBox";
            this.код_жанраTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_жанраTextBox.TabIndex = 3;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(198, 120);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 4;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.жанрыBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(290, 117);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 5;
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(224, 146);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(60, 13);
            описаниеLabel.TabIndex = 6;
            описаниеLabel.Text = "Описание:";
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.жанрыBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(290, 143);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(100, 20);
            this.описаниеTextBox.TabIndex = 7;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_жанраLabel);
            this.Controls.Add(this.код_жанраTextBox);
            this.Controls.Add(this.жанрыBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skibenkoDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрыBindingNavigator)).EndInit();
            this.жанрыBindingNavigator.ResumeLayout(false);
            this.жанрыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SkibenkoDb skibenkoDb;
        private System.Windows.Forms.BindingSource жанрыBindingSource;
        private SkibenkoDbTableAdapters.ЖанрыTableAdapter жанрыTableAdapter;
        private SkibenkoDbTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator жанрыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton жанрыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_жанраTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
    }
}