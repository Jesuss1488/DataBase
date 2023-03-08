namespace SkibenkoBD
{
    partial class Form6
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
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label авторLabel;
            System.Windows.Forms.Label код_издательстваLabel;
            System.Windows.Forms.Label год_изданияLabel;
            System.Windows.Forms.Label код_жанраLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.skibenkoDb = new SkibenkoBD.SkibenkoDb();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгиTableAdapter = new SkibenkoBD.SkibenkoDbTableAdapters.КнигиTableAdapter();
            this.tableAdapterManager = new SkibenkoBD.SkibenkoDbTableAdapters.TableAdapterManager();
            this.книгиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.книгиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.авторTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.код_книгиTextBox = new System.Windows.Forms.TextBox();
            this.код_издательстваTextBox = new System.Windows.Forms.TextBox();
            this.год_изданияTextBox = new System.Windows.Forms.TextBox();
            this.код_жанраTextBox = new System.Windows.Forms.TextBox();
            код_книгиLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            авторLabel = new System.Windows.Forms.Label();
            код_издательстваLabel = new System.Windows.Forms.Label();
            год_изданияLabel = new System.Windows.Forms.Label();
            код_жанраLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skibenkoDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingNavigator)).BeginInit();
            this.книгиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_книгиLabel
            // 
            код_книгиLabel.AutoSize = true;
            код_книгиLabel.Location = new System.Drawing.Point(251, 112);
            код_книгиLabel.Name = "код_книгиLabel";
            код_книгиLabel.Size = new System.Drawing.Size(61, 13);
            код_книгиLabel.TabIndex = 2;
            код_книгиLabel.Text = "Код книги:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(226, 138);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 4;
            наименованиеLabel.Text = "Наименование:";
            // 
            // авторLabel
            // 
            авторLabel.AutoSize = true;
            авторLabel.Location = new System.Drawing.Point(272, 164);
            авторLabel.Name = "авторLabel";
            авторLabel.Size = new System.Drawing.Size(40, 13);
            авторLabel.TabIndex = 6;
            авторLabel.Text = "Автор:";
            // 
            // код_издательстваLabel
            // 
            код_издательстваLabel.AutoSize = true;
            код_издательстваLabel.Location = new System.Drawing.Point(210, 190);
            код_издательстваLabel.Name = "код_издательстваLabel";
            код_издательстваLabel.Size = new System.Drawing.Size(102, 13);
            код_издательстваLabel.TabIndex = 8;
            код_издательстваLabel.Text = "Код издательства:";
            // 
            // год_изданияLabel
            // 
            год_изданияLabel.AutoSize = true;
            год_изданияLabel.Location = new System.Drawing.Point(239, 216);
            год_изданияLabel.Name = "год_изданияLabel";
            год_изданияLabel.Size = new System.Drawing.Size(73, 13);
            год_изданияLabel.TabIndex = 10;
            год_изданияLabel.Text = "Год издания:";
            // 
            // код_жанраLabel
            // 
            код_жанраLabel.AutoSize = true;
            код_жанраLabel.Location = new System.Drawing.Point(248, 242);
            код_жанраLabel.Name = "код_жанраLabel";
            код_жанраLabel.Size = new System.Drawing.Size(64, 13);
            код_жанраLabel.TabIndex = 12;
            код_жанраLabel.Text = "Код жанра:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(297, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Книги\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skibenkoDb
            // 
            this.skibenkoDb.DataSetName = "SkibenkoDb";
            this.skibenkoDb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SkibenkoBD.SkibenkoDbTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выданные_книгиTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ИздательстваTableAdapter = null;
            this.tableAdapterManager.КнигиTableAdapter = this.книгиTableAdapter;
            this.tableAdapterManager.Ошибки_вставкиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ЧитателиTableAdapter = null;
            // 
            // книгиBindingNavigator
            // 
            this.книгиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.книгиBindingNavigator.BindingSource = this.книгиBindingSource;
            this.книгиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.книгиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.книгиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.книгиBindingNavigatorSaveItem});
            this.книгиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.книгиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.книгиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.книгиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.книгиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.книгиBindingNavigator.Name = "книгиBindingNavigator";
            this.книгиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.книгиBindingNavigator.Size = new System.Drawing.Size(824, 25);
            this.книгиBindingNavigator.TabIndex = 1;
            this.книгиBindingNavigator.Text = "bindingNavigator1";
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
            // книгиBindingNavigatorSaveItem
            // 
            this.книгиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.книгиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("книгиBindingNavigatorSaveItem.Image")));
            this.книгиBindingNavigatorSaveItem.Name = "книгиBindingNavigatorSaveItem";
            this.книгиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.книгиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.книгиBindingNavigatorSaveItem.Click += new System.EventHandler(this.книгиBindingNavigatorSaveItem_Click);
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(318, 135);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 5;
            // 
            // авторTextBox
            // 
            this.авторTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Автор", true));
            this.авторTextBox.Location = new System.Drawing.Point(318, 161);
            this.авторTextBox.Name = "авторTextBox";
            this.авторTextBox.Size = new System.Drawing.Size(100, 20);
            this.авторTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(219, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(325, 327);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(429, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(219, 366);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(429, 366);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 23);
            this.button8.TabIndex = 25;
            this.button8.Text = "Табличный вид";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // код_книгиTextBox
            // 
            this.код_книгиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Код книги", true));
            this.код_книгиTextBox.Location = new System.Drawing.Point(318, 109);
            this.код_книгиTextBox.Name = "код_книгиTextBox";
            this.код_книгиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_книгиTextBox.TabIndex = 26;
            // 
            // код_издательстваTextBox
            // 
            this.код_издательстваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Код издательства", true));
            this.код_издательстваTextBox.Location = new System.Drawing.Point(318, 187);
            this.код_издательстваTextBox.Name = "код_издательстваTextBox";
            this.код_издательстваTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_издательстваTextBox.TabIndex = 27;
            // 
            // год_изданияTextBox
            // 
            this.год_изданияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Год издания", true));
            this.год_изданияTextBox.Location = new System.Drawing.Point(318, 213);
            this.год_изданияTextBox.Name = "год_изданияTextBox";
            this.год_изданияTextBox.Size = new System.Drawing.Size(100, 20);
            this.год_изданияTextBox.TabIndex = 28;
            // 
            // код_жанраTextBox
            // 
            this.код_жанраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгиBindingSource, "Код жанра", true));
            this.код_жанраTextBox.Location = new System.Drawing.Point(318, 239);
            this.код_жанраTextBox.Name = "код_жанраTextBox";
            this.код_жанраTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_жанраTextBox.TabIndex = 29;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.код_жанраTextBox);
            this.Controls.Add(this.год_изданияTextBox);
            this.Controls.Add(this.код_издательстваTextBox);
            this.Controls.Add(this.код_книгиTextBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_жанраLabel);
            this.Controls.Add(год_изданияLabel);
            this.Controls.Add(код_издательстваLabel);
            this.Controls.Add(авторLabel);
            this.Controls.Add(this.авторTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_книгиLabel);
            this.Controls.Add(this.книгиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skibenkoDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingNavigator)).EndInit();
            this.книгиBindingNavigator.ResumeLayout(false);
            this.книгиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SkibenkoDb skibenkoDb;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private SkibenkoDbTableAdapters.КнигиTableAdapter книгиTableAdapter;
        private SkibenkoDbTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator книгиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton книгиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox авторTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox код_книгиTextBox;
        private System.Windows.Forms.TextBox код_издательстваTextBox;
        private System.Windows.Forms.TextBox год_изданияTextBox;
        private System.Windows.Forms.TextBox код_жанраTextBox;
    }
}