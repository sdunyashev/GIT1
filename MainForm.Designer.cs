namespace Ocenki
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new System.Windows.Forms.TabControl();
            this.groupsPanel = new System.Windows.Forms.TabPage();
            this.groupsTabControl = new System.Windows.Forms.TabControl();
            this.groupsEditPanel = new System.Windows.Forms.TabPage();
            this.groupsSaveBTN = new System.Windows.Forms.Button();
            this.groupEProfessionCB = new System.Windows.Forms.ComboBox();
            this.группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new Ocenki.dbDataSet();
            this.groupEProfessionLBL = new System.Windows.Forms.Label();
            this.groupEDateTP = new System.Windows.Forms.DateTimePicker();
            this.groupEDateLBL = new System.Windows.Forms.Label();
            this.groupECourseNUD = new System.Windows.Forms.NumericUpDown();
            this.groupECourseLBL = new System.Windows.Forms.Label();
            this.groupENameTB = new System.Windows.Forms.TextBox();
            this.groupENameLBL = new System.Windows.Forms.Label();
            this.groupsAddPanel = new System.Windows.Forms.TabPage();
            this.groupsAddBTN = new System.Windows.Forms.Button();
            this.groupAProfessionCB = new System.Windows.Forms.ComboBox();
            this.groupAProfessionLBL = new System.Windows.Forms.Label();
            this.groupADateTP = new System.Windows.Forms.DateTimePicker();
            this.groupADateLBL = new System.Windows.Forms.Label();
            this.groupACourseNUD = new System.Windows.Forms.NumericUpDown();
            this.groupACourseLBL = new System.Windows.Forms.Label();
            this.groupANameTB = new System.Windows.Forms.TextBox();
            this.groupANameLBL = new System.Windows.Forms.Label();
            this.groupsFilterPanel = new System.Windows.Forms.GroupBox();
            this.filterGroupsApplyBTN = new System.Windows.Forms.Button();
            this.filterGroupDateDL = new System.Windows.Forms.ComboBox();
            this.filterGroupCourseDL = new System.Windows.Forms.ComboBox();
            this.filterGroupDateCHB = new System.Windows.Forms.CheckBox();
            this.filterGroupDateTP = new System.Windows.Forms.DateTimePicker();
            this.filterGroupProfessionCHB = new System.Windows.Forms.CheckBox();
            this.filterGroupProfessionCB = new System.Windows.Forms.ComboBox();
            this.filterGroupCourseNUD = new System.Windows.Forms.NumericUpDown();
            this.filterGroupNameTB = new System.Windows.Forms.TextBox();
            this.filterGroupNameCHB = new System.Windows.Forms.CheckBox();
            this.filterGroupCourseCHB = new System.Windows.Forms.CheckBox();
            this.groupsList = new System.Windows.Forms.DataGridView();
            this.названиегруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодгруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.курсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаоснованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportGroupBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteGroupBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsPanel = new System.Windows.Forms.TabPage();
            this.studentsTabControl = new System.Windows.Forms.TabControl();
            this.studentsEditPanel = new System.Windows.Forms.TabPage();
            this.studentsEAddressTB = new System.Windows.Forms.TextBox();
            this.группыУчащиесяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsEAddressLBL = new System.Windows.Forms.Label();
            this.studentsSaveBTN = new System.Windows.Forms.Button();
            this.studentsENameTB = new System.Windows.Forms.TextBox();
            this.studentsENameLBL = new System.Windows.Forms.Label();
            this.studentsAddPanel = new System.Windows.Forms.TabPage();
            this.studentsAAddressTB = new System.Windows.Forms.TextBox();
            this.studentsAAddressLBL = new System.Windows.Forms.Label();
            this.studentsAddBTN = new System.Windows.Forms.Button();
            this.studentsANameTB = new System.Windows.Forms.TextBox();
            this.studentsANameLBL = new System.Windows.Forms.Label();
            this.studentsFilterPanel = new System.Windows.Forms.GroupBox();
            this.filterStudentsApplyBTN = new System.Windows.Forms.Button();
            this.filterStudentsAddressCHB = new System.Windows.Forms.CheckBox();
            this.filterStudentsAddressTB = new System.Windows.Forms.TextBox();
            this.filterStudentsNameTB = new System.Windows.Forms.TextBox();
            this.filterStudentsNameCHB = new System.Windows.Forms.CheckBox();
            this.studentsGroupsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsList = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодучащегосяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодгруппыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportStudentBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.marksPanel = new System.Windows.Forms.TabPage();
            this.marksTabControl = new System.Windows.Forms.TabControl();
            this.marksEditPanel = new System.Windows.Forms.TabPage();
            this.marksSaveBTN = new System.Windows.Forms.Button();
            this.marksELessonCB = new System.Windows.Forms.ComboBox();
            this.учащиесяОценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыУчащиесяBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.группыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.marksELessonLBL = new System.Windows.Forms.Label();
            this.marksEDateTP = new System.Windows.Forms.DateTimePicker();
            this.marksEDateLBL = new System.Windows.Forms.Label();
            this.marksEValueNUD = new System.Windows.Forms.NumericUpDown();
            this.marksEValueLBL = new System.Windows.Forms.Label();
            this.marksAddPanel = new System.Windows.Forms.TabPage();
            this.marksAddBTN = new System.Windows.Forms.Button();
            this.marksALessonCB = new System.Windows.Forms.ComboBox();
            this.marksALessonLBL = new System.Windows.Forms.Label();
            this.marksADateTP = new System.Windows.Forms.DateTimePicker();
            this.marksADateLBL = new System.Windows.Forms.Label();
            this.marksAValueNUD = new System.Windows.Forms.NumericUpDown();
            this.marksAValueLBL = new System.Windows.Forms.Label();
            this.marksFilterPanel = new System.Windows.Forms.GroupBox();
            this.filterMarksApplyBTN = new System.Windows.Forms.Button();
            this.filterMarksDateDL = new System.Windows.Forms.ComboBox();
            this.filterMarksValueDL = new System.Windows.Forms.ComboBox();
            this.filterMarksDateCHB = new System.Windows.Forms.CheckBox();
            this.filterMarksLessonCHB = new System.Windows.Forms.CheckBox();
            this.filterMarksLessonTB = new System.Windows.Forms.ComboBox();
            this.filterMarksValueNUD = new System.Windows.Forms.NumericUpDown();
            this.filterMarksValueCHB = new System.Windows.Forms.CheckBox();
            this.filterMarksDateTP = new System.Windows.Forms.DateTimePicker();
            this.marksStudentsList = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодучащегосяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодгруппыDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksList = new System.Windows.Forms.DataGridView();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодоценкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодучащегосяDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.marksAvgBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteMarkBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.marksGroupsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skipsPanel = new System.Windows.Forms.TabPage();
            this.skipsTabControl = new System.Windows.Forms.TabControl();
            this.skipsEditPanel = new System.Windows.Forms.TabPage();
            this.skipsEReasonCHB = new System.Windows.Forms.CheckBox();
            this.учащиесяПропускиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыУчащиесяBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.группыBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.skipsSaveBTN = new System.Windows.Forms.Button();
            this.skipsELessonCB = new System.Windows.Forms.ComboBox();
            this.skipsELessonLBL = new System.Windows.Forms.Label();
            this.skipsEDateTP = new System.Windows.Forms.DateTimePicker();
            this.skipsEDateLBL = new System.Windows.Forms.Label();
            this.skipsAddPanel = new System.Windows.Forms.TabPage();
            this.skipsAReasonCHB = new System.Windows.Forms.CheckBox();
            this.skipsAddBTN = new System.Windows.Forms.Button();
            this.skipsALessonCB = new System.Windows.Forms.ComboBox();
            this.skipsALessonLBL = new System.Windows.Forms.Label();
            this.skipsADateTP = new System.Windows.Forms.DateTimePicker();
            this.skipsADateLBL = new System.Windows.Forms.Label();
            this.skipsFilterPanel = new System.Windows.Forms.GroupBox();
            this.filterSkipsApplyBTN = new System.Windows.Forms.Button();
            this.filterSkipsDateDL = new System.Windows.Forms.ComboBox();
            this.filterSkipsLessonCHB = new System.Windows.Forms.CheckBox();
            this.filterSkipsDateCHB = new System.Windows.Forms.CheckBox();
            this.filterSkipsDateTP = new System.Windows.Forms.DateTimePicker();
            this.filterSkipsLessonCB = new System.Windows.Forms.ComboBox();
            this.skipsGroupsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skipsStudentsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skipsList = new System.Windows.Forms.DataGridView();
            this.поуважительнойDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.кодпропускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодучащегосяDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skipsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSkipBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanel = new System.Windows.Forms.TabPage();
            this.infoFilterPanel = new System.Windows.Forms.GroupBox();
            this.filterInfoAvrDL = new System.Windows.Forms.ComboBox();
            this.filterInfoAvrNUD = new System.Windows.Forms.NumericUpDown();
            this.filterInfoBSkipsDL = new System.Windows.Forms.ComboBox();
            this.filterInfoBSkipsNUD = new System.Windows.Forms.NumericUpDown();
            this.filterInfoBSkipsCHB = new System.Windows.Forms.CheckBox();
            this.filterInfoGSkipsDL = new System.Windows.Forms.ComboBox();
            this.filterInfoGSkipsNUD = new System.Windows.Forms.NumericUpDown();
            this.filterInfoGSkipsCHB = new System.Windows.Forms.CheckBox();
            this.filterInfoSkipsDL = new System.Windows.Forms.ComboBox();
            this.filterInfoSkipsNUD = new System.Windows.Forms.NumericUpDown();
            this.filterInfoSkipsCHB = new System.Windows.Forms.CheckBox();
            this.filterInfoAvrCHB = new System.Windows.Forms.CheckBox();
            this.filterInfoCourseDL = new System.Windows.Forms.ComboBox();
            this.filterInfoProfessionCHB = new System.Windows.Forms.CheckBox();
            this.filterInfoProfessionCB = new System.Windows.Forms.ComboBox();
            this.filterInfoCourseNUD = new System.Windows.Forms.NumericUpDown();
            this.filterInfoCourseCHB = new System.Windows.Forms.CheckBox();
            this.filterInfoApplyBTN = new System.Windows.Forms.Button();
            this.filterInfoAddressCHB = new System.Windows.Forms.CheckBox();
            this.filterInfoAddressTB = new System.Windows.Forms.TextBox();
            this.filterInfoNameTB = new System.Windows.Forms.TextBox();
            this.filterInfoNameCHB = new System.Windows.Forms.CheckBox();
            this.filterInfoGroupNameTB = new System.Windows.Forms.TextBox();
            this.filterInfoGroupNameCHB = new System.Windows.Forms.CheckBox();
            this.infoList = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодучащегосяDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодгруппыDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverageMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSkips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSkipsBad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учащиесяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.helpBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.группыTableAdapter = new Ocenki.dbDataSetTableAdapters.ГруппыTableAdapter();
            this.учащиесяTableAdapter = new Ocenki.dbDataSetTableAdapters.УчащиесяTableAdapter();
            this.оценкиTableAdapter = new Ocenki.dbDataSetTableAdapters.ОценкиTableAdapter();
            this.пропускиTableAdapter = new Ocenki.dbDataSetTableAdapters.ПропускиTableAdapter();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exporMarksBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMarksBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.infoMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportInfoBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.groupsPanel.SuspendLayout();
            this.groupsTabControl.SuspendLayout();
            this.groupsEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupECourseNUD)).BeginInit();
            this.groupsAddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupACourseNUD)).BeginInit();
            this.groupsFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterGroupCourseNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsList)).BeginInit();
            this.groupsMenu.SuspendLayout();
            this.studentsPanel.SuspendLayout();
            this.studentsTabControl.SuspendLayout();
            this.studentsEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.группыУчащиесяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource1)).BeginInit();
            this.studentsAddPanel.SuspendLayout();
            this.studentsFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGroupsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsList)).BeginInit();
            this.studentsMenu.SuspendLayout();
            this.marksPanel.SuspendLayout();
            this.marksTabControl.SuspendLayout();
            this.marksEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учащиесяОценкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыУчащиесяBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksEValueNUD)).BeginInit();
            this.marksAddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksAValueNUD)).BeginInit();
            this.marksFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterMarksValueNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksStudentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksList)).BeginInit();
            this.marksMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksGroupsList)).BeginInit();
            this.skipsPanel.SuspendLayout();
            this.skipsTabControl.SuspendLayout();
            this.skipsEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учащиесяПропускиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыУчащиесяBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource3)).BeginInit();
            this.skipsAddPanel.SuspendLayout();
            this.skipsFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skipsGroupsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipsStudentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipsList)).BeginInit();
            this.skipsMenu.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.infoFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterInfoAvrNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterInfoBSkipsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterInfoGSkipsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterInfoSkipsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterInfoCourseNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учащиесяBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.infoMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenu.Controls.Add(this.groupsPanel);
            this.mainMenu.Controls.Add(this.studentsPanel);
            this.mainMenu.Controls.Add(this.marksPanel);
            this.mainMenu.Controls.Add(this.skipsPanel);
            this.mainMenu.Controls.Add(this.infoPanel);
            this.mainMenu.HotTrack = true;
            this.mainMenu.Location = new System.Drawing.Point(0, 27);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.SelectedIndex = 0;
            this.mainMenu.Size = new System.Drawing.Size(1065, 743);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.SelectedIndexChanged += new System.EventHandler(this.mainMenu_SelectedIndexChanged);
            // 
            // groupsPanel
            // 
            this.groupsPanel.Controls.Add(this.groupsTabControl);
            this.groupsPanel.Controls.Add(this.groupsFilterPanel);
            this.groupsPanel.Controls.Add(this.groupsList);
            this.groupsPanel.Location = new System.Drawing.Point(4, 22);
            this.groupsPanel.Name = "groupsPanel";
            this.groupsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.groupsPanel.Size = new System.Drawing.Size(1057, 717);
            this.groupsPanel.TabIndex = 0;
            this.groupsPanel.Text = "Группы";
            this.groupsPanel.UseVisualStyleBackColor = true;
            // 
            // groupsTabControl
            // 
            this.groupsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupsTabControl.Controls.Add(this.groupsEditPanel);
            this.groupsTabControl.Controls.Add(this.groupsAddPanel);
            this.groupsTabControl.Location = new System.Drawing.Point(6, 493);
            this.groupsTabControl.Name = "groupsTabControl";
            this.groupsTabControl.SelectedIndex = 0;
            this.groupsTabControl.Size = new System.Drawing.Size(1045, 218);
            this.groupsTabControl.TabIndex = 2;
            // 
            // groupsEditPanel
            // 
            this.groupsEditPanel.Controls.Add(this.groupsSaveBTN);
            this.groupsEditPanel.Controls.Add(this.groupEProfessionCB);
            this.groupsEditPanel.Controls.Add(this.groupEProfessionLBL);
            this.groupsEditPanel.Controls.Add(this.groupEDateTP);
            this.groupsEditPanel.Controls.Add(this.groupEDateLBL);
            this.groupsEditPanel.Controls.Add(this.groupECourseNUD);
            this.groupsEditPanel.Controls.Add(this.groupECourseLBL);
            this.groupsEditPanel.Controls.Add(this.groupENameTB);
            this.groupsEditPanel.Controls.Add(this.groupENameLBL);
            this.groupsEditPanel.Location = new System.Drawing.Point(4, 22);
            this.groupsEditPanel.Name = "groupsEditPanel";
            this.groupsEditPanel.Padding = new System.Windows.Forms.Padding(3);
            this.groupsEditPanel.Size = new System.Drawing.Size(1037, 192);
            this.groupsEditPanel.TabIndex = 0;
            this.groupsEditPanel.Text = "Редактирование";
            this.groupsEditPanel.UseVisualStyleBackColor = true;
            // 
            // groupsSaveBTN
            // 
            this.groupsSaveBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupsSaveBTN.Location = new System.Drawing.Point(6, 163);
            this.groupsSaveBTN.Name = "groupsSaveBTN";
            this.groupsSaveBTN.Size = new System.Drawing.Size(1025, 23);
            this.groupsSaveBTN.TabIndex = 8;
            this.groupsSaveBTN.Text = "Сохранить изменения!";
            this.groupsSaveBTN.UseVisualStyleBackColor = true;
            this.groupsSaveBTN.Click += new System.EventHandler(this.groupsSaveBTN_Click);
            // 
            // groupEProfessionCB
            // 
            this.groupEProfessionCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEProfessionCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.groupEProfessionCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.groupEProfessionCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группыBindingSource, "Специальность", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.groupEProfessionCB.FormattingEnabled = true;
            this.groupEProfessionCB.Items.AddRange(new object[] {
            "Программное обеспечение информационных технологий",
            "Бухгалтерский учёт",
            "Коммерческая деятельность",
            "Правоведение",
            "Экономика и организация производства",
            "Банковское дело"});
            this.groupEProfessionCB.Location = new System.Drawing.Point(6, 136);
            this.groupEProfessionCB.Name = "groupEProfessionCB";
            this.groupEProfessionCB.Size = new System.Drawing.Size(1025, 21);
            this.groupEProfessionCB.TabIndex = 7;
            this.groupEProfessionCB.Text = "Программное обеспечение информационных технологий";
            // 
            // группыBindingSource
            // 
            this.группыBindingSource.DataMember = "Группы";
            this.группыBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupEProfessionLBL
            // 
            this.groupEProfessionLBL.AutoSize = true;
            this.groupEProfessionLBL.Location = new System.Drawing.Point(6, 120);
            this.groupEProfessionLBL.Name = "groupEProfessionLBL";
            this.groupEProfessionLBL.Size = new System.Drawing.Size(85, 13);
            this.groupEProfessionLBL.TabIndex = 6;
            this.groupEProfessionLBL.Text = "Специальность";
            // 
            // groupEDateTP
            // 
            this.groupEDateTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEDateTP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.группыBindingSource, "Дата_основания", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "D"));
            this.groupEDateTP.Location = new System.Drawing.Point(6, 97);
            this.groupEDateTP.Name = "groupEDateTP";
            this.groupEDateTP.Size = new System.Drawing.Size(1025, 20);
            this.groupEDateTP.TabIndex = 5;
            // 
            // groupEDateLBL
            // 
            this.groupEDateLBL.AutoSize = true;
            this.groupEDateLBL.Location = new System.Drawing.Point(6, 81);
            this.groupEDateLBL.Name = "groupEDateLBL";
            this.groupEDateLBL.Size = new System.Drawing.Size(90, 13);
            this.groupEDateLBL.TabIndex = 4;
            this.groupEDateLBL.Text = "Дата основания";
            // 
            // groupECourseNUD
            // 
            this.groupECourseNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupECourseNUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.группыBindingSource, "Курс", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "N0"));
            this.groupECourseNUD.Location = new System.Drawing.Point(6, 58);
            this.groupECourseNUD.Name = "groupECourseNUD";
            this.groupECourseNUD.Size = new System.Drawing.Size(1025, 20);
            this.groupECourseNUD.TabIndex = 3;
            // 
            // groupECourseLBL
            // 
            this.groupECourseLBL.AutoSize = true;
            this.groupECourseLBL.Location = new System.Drawing.Point(6, 42);
            this.groupECourseLBL.Name = "groupECourseLBL";
            this.groupECourseLBL.Size = new System.Drawing.Size(31, 13);
            this.groupECourseLBL.TabIndex = 2;
            this.groupECourseLBL.Text = "Курс";
            // 
            // groupENameTB
            // 
            this.groupENameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupENameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группыBindingSource, "Название_группы", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.groupENameTB.Location = new System.Drawing.Point(6, 19);
            this.groupENameTB.Name = "groupENameTB";
            this.groupENameTB.Size = new System.Drawing.Size(1025, 20);
            this.groupENameTB.TabIndex = 1;
            // 
            // groupENameLBL
            // 
            this.groupENameLBL.AutoSize = true;
            this.groupENameLBL.Location = new System.Drawing.Point(6, 3);
            this.groupENameLBL.Name = "groupENameLBL";
            this.groupENameLBL.Size = new System.Drawing.Size(96, 13);
            this.groupENameLBL.TabIndex = 0;
            this.groupENameLBL.Text = "Название группы";
            // 
            // groupsAddPanel
            // 
            this.groupsAddPanel.Controls.Add(this.groupsAddBTN);
            this.groupsAddPanel.Controls.Add(this.groupAProfessionCB);
            this.groupsAddPanel.Controls.Add(this.groupAProfessionLBL);
            this.groupsAddPanel.Controls.Add(this.groupADateTP);
            this.groupsAddPanel.Controls.Add(this.groupADateLBL);
            this.groupsAddPanel.Controls.Add(this.groupACourseNUD);
            this.groupsAddPanel.Controls.Add(this.groupACourseLBL);
            this.groupsAddPanel.Controls.Add(this.groupANameTB);
            this.groupsAddPanel.Controls.Add(this.groupANameLBL);
            this.groupsAddPanel.Location = new System.Drawing.Point(4, 22);
            this.groupsAddPanel.Name = "groupsAddPanel";
            this.groupsAddPanel.Padding = new System.Windows.Forms.Padding(3);
            this.groupsAddPanel.Size = new System.Drawing.Size(1037, 192);
            this.groupsAddPanel.TabIndex = 1;
            this.groupsAddPanel.Text = "Добавление";
            this.groupsAddPanel.UseVisualStyleBackColor = true;
            // 
            // groupsAddBTN
            // 
            this.groupsAddBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupsAddBTN.Location = new System.Drawing.Point(6, 163);
            this.groupsAddBTN.Name = "groupsAddBTN";
            this.groupsAddBTN.Size = new System.Drawing.Size(1025, 23);
            this.groupsAddBTN.TabIndex = 17;
            this.groupsAddBTN.Text = "Добавить новую группу!";
            this.groupsAddBTN.UseVisualStyleBackColor = true;
            this.groupsAddBTN.Click += new System.EventHandler(this.groupsAddBTN_Click);
            // 
            // groupAProfessionCB
            // 
            this.groupAProfessionCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAProfessionCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.groupAProfessionCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.groupAProfessionCB.FormattingEnabled = true;
            this.groupAProfessionCB.Items.AddRange(new object[] {
            "Программное обеспечение информационных технологий",
            "Бухгалтерский учёт",
            "Коммерческая деятельность",
            "Правоведение",
            "Экономика и организация производства",
            "Банковское дело"});
            this.groupAProfessionCB.Location = new System.Drawing.Point(6, 136);
            this.groupAProfessionCB.Name = "groupAProfessionCB";
            this.groupAProfessionCB.Size = new System.Drawing.Size(1025, 21);
            this.groupAProfessionCB.TabIndex = 16;
            this.groupAProfessionCB.Text = "Программное обеспечение информационных технологий";
            // 
            // groupAProfessionLBL
            // 
            this.groupAProfessionLBL.AutoSize = true;
            this.groupAProfessionLBL.Location = new System.Drawing.Point(6, 120);
            this.groupAProfessionLBL.Name = "groupAProfessionLBL";
            this.groupAProfessionLBL.Size = new System.Drawing.Size(85, 13);
            this.groupAProfessionLBL.TabIndex = 15;
            this.groupAProfessionLBL.Text = "Специальность";
            // 
            // groupADateTP
            // 
            this.groupADateTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupADateTP.Location = new System.Drawing.Point(6, 97);
            this.groupADateTP.Name = "groupADateTP";
            this.groupADateTP.Size = new System.Drawing.Size(1025, 20);
            this.groupADateTP.TabIndex = 14;
            // 
            // groupADateLBL
            // 
            this.groupADateLBL.AutoSize = true;
            this.groupADateLBL.Location = new System.Drawing.Point(6, 81);
            this.groupADateLBL.Name = "groupADateLBL";
            this.groupADateLBL.Size = new System.Drawing.Size(90, 13);
            this.groupADateLBL.TabIndex = 13;
            this.groupADateLBL.Text = "Дата основания";
            // 
            // groupACourseNUD
            // 
            this.groupACourseNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupACourseNUD.Location = new System.Drawing.Point(6, 58);
            this.groupACourseNUD.Name = "groupACourseNUD";
            this.groupACourseNUD.Size = new System.Drawing.Size(1025, 20);
            this.groupACourseNUD.TabIndex = 12;
            // 
            // groupACourseLBL
            // 
            this.groupACourseLBL.AutoSize = true;
            this.groupACourseLBL.Location = new System.Drawing.Point(6, 42);
            this.groupACourseLBL.Name = "groupACourseLBL";
            this.groupACourseLBL.Size = new System.Drawing.Size(31, 13);
            this.groupACourseLBL.TabIndex = 11;
            this.groupACourseLBL.Text = "Курс";
            // 
            // groupANameTB
            // 
            this.groupANameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupANameTB.Location = new System.Drawing.Point(6, 19);
            this.groupANameTB.Name = "groupANameTB";
            this.groupANameTB.Size = new System.Drawing.Size(1025, 20);
            this.groupANameTB.TabIndex = 10;
            // 
            // groupANameLBL
            // 
            this.groupANameLBL.AutoSize = true;
            this.groupANameLBL.Location = new System.Drawing.Point(6, 3);
            this.groupANameLBL.Name = "groupANameLBL";
            this.groupANameLBL.Size = new System.Drawing.Size(96, 13);
            this.groupANameLBL.TabIndex = 9;
            this.groupANameLBL.Text = "Название группы";
            // 
            // groupsFilterPanel
            // 
            this.groupsFilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupsFilterPanel.Controls.Add(this.filterGroupsApplyBTN);
            this.groupsFilterPanel.Controls.Add(this.filterGroupDateDL);
            this.groupsFilterPanel.Controls.Add(this.filterGroupCourseDL);
            this.groupsFilterPanel.Controls.Add(this.filterGroupDateCHB);
            this.groupsFilterPanel.Controls.Add(this.filterGroupDateTP);
            this.groupsFilterPanel.Controls.Add(this.filterGroupProfessionCHB);
            this.groupsFilterPanel.Controls.Add(this.filterGroupProfessionCB);
            this.groupsFilterPanel.Controls.Add(this.filterGroupCourseNUD);
            this.groupsFilterPanel.Controls.Add(this.filterGroupNameTB);
            this.groupsFilterPanel.Controls.Add(this.filterGroupNameCHB);
            this.groupsFilterPanel.Controls.Add(this.filterGroupCourseCHB);
            this.groupsFilterPanel.Location = new System.Drawing.Point(6, 6);
            this.groupsFilterPanel.Name = "groupsFilterPanel";
            this.groupsFilterPanel.Size = new System.Drawing.Size(1045, 245);
            this.groupsFilterPanel.TabIndex = 1;
            this.groupsFilterPanel.TabStop = false;
            this.groupsFilterPanel.Text = "Фильтр";
            // 
            // filterGroupsApplyBTN
            // 
            this.filterGroupsApplyBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGroupsApplyBTN.Location = new System.Drawing.Point(6, 216);
            this.filterGroupsApplyBTN.Name = "filterGroupsApplyBTN";
            this.filterGroupsApplyBTN.Size = new System.Drawing.Size(1033, 23);
            this.filterGroupsApplyBTN.TabIndex = 20;
            this.filterGroupsApplyBTN.Text = "Применить фильтр!";
            this.filterGroupsApplyBTN.UseVisualStyleBackColor = true;
            this.filterGroupsApplyBTN.Click += new System.EventHandler(this.filterGroupsApplyBTN_Click);
            // 
            // filterGroupDateDL
            // 
            this.filterGroupDateDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGroupDateDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterGroupDateDL.FormattingEnabled = true;
            this.filterGroupDateDL.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<",
            "<="});
            this.filterGroupDateDL.Location = new System.Drawing.Point(978, 139);
            this.filterGroupDateDL.Name = "filterGroupDateDL";
            this.filterGroupDateDL.Size = new System.Drawing.Size(61, 21);
            this.filterGroupDateDL.TabIndex = 19;
            // 
            // filterGroupCourseDL
            // 
            this.filterGroupCourseDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGroupCourseDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterGroupCourseDL.FormattingEnabled = true;
            this.filterGroupCourseDL.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<",
            "<="});
            this.filterGroupCourseDL.Location = new System.Drawing.Point(978, 90);
            this.filterGroupCourseDL.Name = "filterGroupCourseDL";
            this.filterGroupCourseDL.Size = new System.Drawing.Size(61, 21);
            this.filterGroupCourseDL.TabIndex = 18;
            // 
            // filterGroupDateCHB
            // 
            this.filterGroupDateCHB.AutoSize = true;
            this.filterGroupDateCHB.Location = new System.Drawing.Point(6, 117);
            this.filterGroupDateCHB.Name = "filterGroupDateCHB";
            this.filterGroupDateCHB.Size = new System.Drawing.Size(123, 17);
            this.filterGroupDateCHB.TabIndex = 17;
            this.filterGroupDateCHB.Text = "По дате основания";
            this.filterGroupDateCHB.UseVisualStyleBackColor = true;
            // 
            // filterGroupDateTP
            // 
            this.filterGroupDateTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGroupDateTP.Location = new System.Drawing.Point(6, 140);
            this.filterGroupDateTP.Name = "filterGroupDateTP";
            this.filterGroupDateTP.Size = new System.Drawing.Size(966, 20);
            this.filterGroupDateTP.TabIndex = 16;
            // 
            // filterGroupProfessionCHB
            // 
            this.filterGroupProfessionCHB.AutoSize = true;
            this.filterGroupProfessionCHB.Location = new System.Drawing.Point(6, 166);
            this.filterGroupProfessionCHB.Name = "filterGroupProfessionCHB";
            this.filterGroupProfessionCHB.Size = new System.Drawing.Size(120, 17);
            this.filterGroupProfessionCHB.TabIndex = 11;
            this.filterGroupProfessionCHB.Text = "По специальности";
            this.filterGroupProfessionCHB.UseVisualStyleBackColor = true;
            // 
            // filterGroupProfessionCB
            // 
            this.filterGroupProfessionCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGroupProfessionCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterGroupProfessionCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterGroupProfessionCB.FormattingEnabled = true;
            this.filterGroupProfessionCB.Items.AddRange(new object[] {
            "Программное обеспечение информационных технологий",
            "Бухгалтерский учёт",
            "Коммерческая деятельность",
            "Правоведение",
            "Экономика и организация производства",
            "Банковское дело"});
            this.filterGroupProfessionCB.Location = new System.Drawing.Point(6, 189);
            this.filterGroupProfessionCB.Name = "filterGroupProfessionCB";
            this.filterGroupProfessionCB.Size = new System.Drawing.Size(1033, 21);
            this.filterGroupProfessionCB.TabIndex = 8;
            // 
            // filterGroupCourseNUD
            // 
            this.filterGroupCourseNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGroupCourseNUD.Location = new System.Drawing.Point(6, 91);
            this.filterGroupCourseNUD.Name = "filterGroupCourseNUD";
            this.filterGroupCourseNUD.Size = new System.Drawing.Size(966, 20);
            this.filterGroupCourseNUD.TabIndex = 3;
            // 
            // filterGroupNameTB
            // 
            this.filterGroupNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterGroupNameTB.Location = new System.Drawing.Point(6, 42);
            this.filterGroupNameTB.Name = "filterGroupNameTB";
            this.filterGroupNameTB.Size = new System.Drawing.Size(1033, 20);
            this.filterGroupNameTB.TabIndex = 1;
            // 
            // filterGroupNameCHB
            // 
            this.filterGroupNameCHB.AutoSize = true;
            this.filterGroupNameCHB.Location = new System.Drawing.Point(6, 19);
            this.filterGroupNameCHB.Name = "filterGroupNameCHB";
            this.filterGroupNameCHB.Size = new System.Drawing.Size(132, 17);
            this.filterGroupNameCHB.TabIndex = 9;
            this.filterGroupNameCHB.Text = "По названию группы";
            this.filterGroupNameCHB.UseVisualStyleBackColor = true;
            // 
            // filterGroupCourseCHB
            // 
            this.filterGroupCourseCHB.AutoSize = true;
            this.filterGroupCourseCHB.Location = new System.Drawing.Point(6, 68);
            this.filterGroupCourseCHB.Name = "filterGroupCourseCHB";
            this.filterGroupCourseCHB.Size = new System.Drawing.Size(71, 17);
            this.filterGroupCourseCHB.TabIndex = 10;
            this.filterGroupCourseCHB.Text = "По курсу";
            this.filterGroupCourseCHB.UseVisualStyleBackColor = true;
            // 
            // groupsList
            // 
            this.groupsList.AllowUserToAddRows = false;
            this.groupsList.AllowUserToDeleteRows = false;
            this.groupsList.AllowUserToResizeColumns = false;
            this.groupsList.AllowUserToResizeRows = false;
            this.groupsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupsList.AutoGenerateColumns = false;
            this.groupsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.groupsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.groupsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиегруппыDataGridViewTextBoxColumn,
            this.кодгруппыDataGridViewTextBoxColumn,
            this.курсDataGridViewTextBoxColumn,
            this.датаоснованияDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn});
            this.groupsList.ContextMenuStrip = this.groupsMenu;
            this.groupsList.DataSource = this.группыBindingSource;
            this.groupsList.Location = new System.Drawing.Point(6, 257);
            this.groupsList.MultiSelect = false;
            this.groupsList.Name = "groupsList";
            this.groupsList.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.groupsList.RowHeadersVisible = false;
            this.groupsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.groupsList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.groupsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.groupsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.groupsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupsList.Size = new System.Drawing.Size(1045, 230);
            this.groupsList.TabIndex = 0;
            // 
            // названиегруппыDataGridViewTextBoxColumn
            // 
            this.названиегруппыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.названиегруппыDataGridViewTextBoxColumn.DataPropertyName = "Название_группы";
            this.названиегруппыDataGridViewTextBoxColumn.HeaderText = "Название группы";
            this.названиегруппыDataGridViewTextBoxColumn.Name = "названиегруппыDataGridViewTextBoxColumn";
            this.названиегруппыDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиегруппыDataGridViewTextBoxColumn.Width = 111;
            // 
            // кодгруппыDataGridViewTextBoxColumn
            // 
            this.кодгруппыDataGridViewTextBoxColumn.DataPropertyName = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn.HeaderText = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn.Name = "кодгруппыDataGridViewTextBoxColumn";
            this.кодгруппыDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодгруппыDataGridViewTextBoxColumn.Visible = false;
            // 
            // курсDataGridViewTextBoxColumn
            // 
            this.курсDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.курсDataGridViewTextBoxColumn.DataPropertyName = "Курс";
            this.курсDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.курсDataGridViewTextBoxColumn.Name = "курсDataGridViewTextBoxColumn";
            this.курсDataGridViewTextBoxColumn.ReadOnly = true;
            this.курсDataGridViewTextBoxColumn.Width = 56;
            // 
            // датаоснованияDataGridViewTextBoxColumn
            // 
            this.датаоснованияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.датаоснованияDataGridViewTextBoxColumn.DataPropertyName = "Дата_основания";
            this.датаоснованияDataGridViewTextBoxColumn.HeaderText = "Дата основания";
            this.датаоснованияDataGridViewTextBoxColumn.Name = "датаоснованияDataGridViewTextBoxColumn";
            this.датаоснованияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаоснованияDataGridViewTextBoxColumn.Width = 105;
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            this.специальностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupsMenu
            // 
            this.groupsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportGroupBTN,
            this.toolStripMenuItem2,
            this.deleteGroupBTN});
            this.groupsMenu.Name = "groupsMenu";
            this.groupsMenu.Size = new System.Drawing.Size(236, 54);
            // 
            // exportGroupBTN
            // 
            this.exportGroupBTN.Name = "exportGroupBTN";
            this.exportGroupBTN.Size = new System.Drawing.Size(235, 22);
            this.exportGroupBTN.Text = "Экспорт в Excel";
            this.exportGroupBTN.Click += new System.EventHandler(this.exportGroupBTN_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(232, 6);
            // 
            // deleteGroupBTN
            // 
            this.deleteGroupBTN.Name = "deleteGroupBTN";
            this.deleteGroupBTN.Size = new System.Drawing.Size(235, 22);
            this.deleteGroupBTN.Text = "Удалить выбранный элемент";
            this.deleteGroupBTN.Click += new System.EventHandler(this.deleteGroupBTN_Click);
            // 
            // studentsPanel
            // 
            this.studentsPanel.Controls.Add(this.studentsTabControl);
            this.studentsPanel.Controls.Add(this.studentsFilterPanel);
            this.studentsPanel.Controls.Add(this.studentsGroupsList);
            this.studentsPanel.Controls.Add(this.studentsList);
            this.studentsPanel.Location = new System.Drawing.Point(4, 22);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.studentsPanel.Size = new System.Drawing.Size(1057, 717);
            this.studentsPanel.TabIndex = 1;
            this.studentsPanel.Text = "Учащиеся";
            this.studentsPanel.UseVisualStyleBackColor = true;
            // 
            // studentsTabControl
            // 
            this.studentsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsTabControl.Controls.Add(this.studentsEditPanel);
            this.studentsTabControl.Controls.Add(this.studentsAddPanel);
            this.studentsTabControl.Location = new System.Drawing.Point(6, 573);
            this.studentsTabControl.Name = "studentsTabControl";
            this.studentsTabControl.SelectedIndex = 0;
            this.studentsTabControl.Size = new System.Drawing.Size(1045, 139);
            this.studentsTabControl.TabIndex = 5;
            // 
            // studentsEditPanel
            // 
            this.studentsEditPanel.Controls.Add(this.studentsEAddressTB);
            this.studentsEditPanel.Controls.Add(this.studentsEAddressLBL);
            this.studentsEditPanel.Controls.Add(this.studentsSaveBTN);
            this.studentsEditPanel.Controls.Add(this.studentsENameTB);
            this.studentsEditPanel.Controls.Add(this.studentsENameLBL);
            this.studentsEditPanel.Location = new System.Drawing.Point(4, 22);
            this.studentsEditPanel.Name = "studentsEditPanel";
            this.studentsEditPanel.Padding = new System.Windows.Forms.Padding(3);
            this.studentsEditPanel.Size = new System.Drawing.Size(1037, 113);
            this.studentsEditPanel.TabIndex = 0;
            this.studentsEditPanel.Text = "Редактирование";
            this.studentsEditPanel.UseVisualStyleBackColor = true;
            // 
            // studentsEAddressTB
            // 
            this.studentsEAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsEAddressTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группыУчащиесяBindingSource, "Адрес", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.studentsEAddressTB.Location = new System.Drawing.Point(6, 58);
            this.studentsEAddressTB.Name = "studentsEAddressTB";
            this.studentsEAddressTB.Size = new System.Drawing.Size(1025, 20);
            this.studentsEAddressTB.TabIndex = 10;
            // 
            // группыУчащиесяBindingSource
            // 
            this.группыУчащиесяBindingSource.DataMember = "ГруппыУчащиеся";
            this.группыУчащиесяBindingSource.DataSource = this.группыBindingSource1;
            // 
            // группыBindingSource1
            // 
            this.группыBindingSource1.DataMember = "Группы";
            this.группыBindingSource1.DataSource = this.dbDataSet;
            // 
            // studentsEAddressLBL
            // 
            this.studentsEAddressLBL.AutoSize = true;
            this.studentsEAddressLBL.Location = new System.Drawing.Point(6, 42);
            this.studentsEAddressLBL.Name = "studentsEAddressLBL";
            this.studentsEAddressLBL.Size = new System.Drawing.Size(38, 13);
            this.studentsEAddressLBL.TabIndex = 9;
            this.studentsEAddressLBL.Text = "Адрес";
            // 
            // studentsSaveBTN
            // 
            this.studentsSaveBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsSaveBTN.Location = new System.Drawing.Point(6, 84);
            this.studentsSaveBTN.Name = "studentsSaveBTN";
            this.studentsSaveBTN.Size = new System.Drawing.Size(1025, 23);
            this.studentsSaveBTN.TabIndex = 8;
            this.studentsSaveBTN.Text = "Сохранить изменения!";
            this.studentsSaveBTN.UseVisualStyleBackColor = true;
            this.studentsSaveBTN.Click += new System.EventHandler(this.studentsSaveBTN_Click);
            // 
            // studentsENameTB
            // 
            this.studentsENameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsENameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группыУчащиесяBindingSource, "ФИО", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.studentsENameTB.Location = new System.Drawing.Point(6, 19);
            this.studentsENameTB.Name = "studentsENameTB";
            this.studentsENameTB.Size = new System.Drawing.Size(1025, 20);
            this.studentsENameTB.TabIndex = 1;
            // 
            // studentsENameLBL
            // 
            this.studentsENameLBL.AutoSize = true;
            this.studentsENameLBL.Location = new System.Drawing.Point(6, 3);
            this.studentsENameLBL.Name = "studentsENameLBL";
            this.studentsENameLBL.Size = new System.Drawing.Size(34, 13);
            this.studentsENameLBL.TabIndex = 0;
            this.studentsENameLBL.Text = "ФИО";
            // 
            // studentsAddPanel
            // 
            this.studentsAddPanel.Controls.Add(this.studentsAAddressTB);
            this.studentsAddPanel.Controls.Add(this.studentsAAddressLBL);
            this.studentsAddPanel.Controls.Add(this.studentsAddBTN);
            this.studentsAddPanel.Controls.Add(this.studentsANameTB);
            this.studentsAddPanel.Controls.Add(this.studentsANameLBL);
            this.studentsAddPanel.Location = new System.Drawing.Point(4, 22);
            this.studentsAddPanel.Name = "studentsAddPanel";
            this.studentsAddPanel.Padding = new System.Windows.Forms.Padding(3);
            this.studentsAddPanel.Size = new System.Drawing.Size(1037, 113);
            this.studentsAddPanel.TabIndex = 1;
            this.studentsAddPanel.Text = "Добавление";
            this.studentsAddPanel.UseVisualStyleBackColor = true;
            // 
            // studentsAAddressTB
            // 
            this.studentsAAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsAAddressTB.Location = new System.Drawing.Point(6, 58);
            this.studentsAAddressTB.Name = "studentsAAddressTB";
            this.studentsAAddressTB.Size = new System.Drawing.Size(1025, 20);
            this.studentsAAddressTB.TabIndex = 15;
            // 
            // studentsAAddressLBL
            // 
            this.studentsAAddressLBL.AutoSize = true;
            this.studentsAAddressLBL.Location = new System.Drawing.Point(6, 42);
            this.studentsAAddressLBL.Name = "studentsAAddressLBL";
            this.studentsAAddressLBL.Size = new System.Drawing.Size(38, 13);
            this.studentsAAddressLBL.TabIndex = 14;
            this.studentsAAddressLBL.Text = "Адрес";
            // 
            // studentsAddBTN
            // 
            this.studentsAddBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsAddBTN.Location = new System.Drawing.Point(6, 84);
            this.studentsAddBTN.Name = "studentsAddBTN";
            this.studentsAddBTN.Size = new System.Drawing.Size(1025, 23);
            this.studentsAddBTN.TabIndex = 13;
            this.studentsAddBTN.Text = "Добавить учащегося!";
            this.studentsAddBTN.UseVisualStyleBackColor = true;
            this.studentsAddBTN.Click += new System.EventHandler(this.studentsAddBTN_Click);
            // 
            // studentsANameTB
            // 
            this.studentsANameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsANameTB.Location = new System.Drawing.Point(6, 19);
            this.studentsANameTB.Name = "studentsANameTB";
            this.studentsANameTB.Size = new System.Drawing.Size(1025, 20);
            this.studentsANameTB.TabIndex = 12;
            // 
            // studentsANameLBL
            // 
            this.studentsANameLBL.AutoSize = true;
            this.studentsANameLBL.Location = new System.Drawing.Point(6, 3);
            this.studentsANameLBL.Name = "studentsANameLBL";
            this.studentsANameLBL.Size = new System.Drawing.Size(34, 13);
            this.studentsANameLBL.TabIndex = 11;
            this.studentsANameLBL.Text = "ФИО";
            // 
            // studentsFilterPanel
            // 
            this.studentsFilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsFilterPanel.Controls.Add(this.filterStudentsApplyBTN);
            this.studentsFilterPanel.Controls.Add(this.filterStudentsAddressCHB);
            this.studentsFilterPanel.Controls.Add(this.filterStudentsAddressTB);
            this.studentsFilterPanel.Controls.Add(this.filterStudentsNameTB);
            this.studentsFilterPanel.Controls.Add(this.filterStudentsNameCHB);
            this.studentsFilterPanel.Location = new System.Drawing.Point(6, 6);
            this.studentsFilterPanel.Name = "studentsFilterPanel";
            this.studentsFilterPanel.Size = new System.Drawing.Size(1045, 146);
            this.studentsFilterPanel.TabIndex = 4;
            this.studentsFilterPanel.TabStop = false;
            this.studentsFilterPanel.Text = "Фильтр";
            // 
            // filterStudentsApplyBTN
            // 
            this.filterStudentsApplyBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterStudentsApplyBTN.Location = new System.Drawing.Point(6, 117);
            this.filterStudentsApplyBTN.Name = "filterStudentsApplyBTN";
            this.filterStudentsApplyBTN.Size = new System.Drawing.Size(1033, 23);
            this.filterStudentsApplyBTN.TabIndex = 17;
            this.filterStudentsApplyBTN.Text = "Применить фильтр!";
            this.filterStudentsApplyBTN.UseVisualStyleBackColor = true;
            this.filterStudentsApplyBTN.Click += new System.EventHandler(this.filterStudentsApplyBTN_Click);
            // 
            // filterStudentsAddressCHB
            // 
            this.filterStudentsAddressCHB.AutoSize = true;
            this.filterStudentsAddressCHB.Location = new System.Drawing.Point(6, 68);
            this.filterStudentsAddressCHB.Name = "filterStudentsAddressCHB";
            this.filterStudentsAddressCHB.Size = new System.Drawing.Size(78, 17);
            this.filterStudentsAddressCHB.TabIndex = 16;
            this.filterStudentsAddressCHB.Text = "По адресу";
            this.filterStudentsAddressCHB.UseVisualStyleBackColor = true;
            // 
            // filterStudentsAddressTB
            // 
            this.filterStudentsAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterStudentsAddressTB.Location = new System.Drawing.Point(6, 91);
            this.filterStudentsAddressTB.Name = "filterStudentsAddressTB";
            this.filterStudentsAddressTB.Size = new System.Drawing.Size(1033, 20);
            this.filterStudentsAddressTB.TabIndex = 14;
            // 
            // filterStudentsNameTB
            // 
            this.filterStudentsNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterStudentsNameTB.Location = new System.Drawing.Point(6, 42);
            this.filterStudentsNameTB.Name = "filterStudentsNameTB";
            this.filterStudentsNameTB.Size = new System.Drawing.Size(1033, 20);
            this.filterStudentsNameTB.TabIndex = 12;
            // 
            // filterStudentsNameCHB
            // 
            this.filterStudentsNameCHB.AutoSize = true;
            this.filterStudentsNameCHB.Location = new System.Drawing.Point(6, 19);
            this.filterStudentsNameCHB.Name = "filterStudentsNameCHB";
            this.filterStudentsNameCHB.Size = new System.Drawing.Size(70, 17);
            this.filterStudentsNameCHB.TabIndex = 15;
            this.filterStudentsNameCHB.Text = "По ФИО";
            this.filterStudentsNameCHB.UseVisualStyleBackColor = true;
            // 
            // studentsGroupsList
            // 
            this.studentsGroupsList.AllowUserToAddRows = false;
            this.studentsGroupsList.AllowUserToDeleteRows = false;
            this.studentsGroupsList.AllowUserToResizeColumns = false;
            this.studentsGroupsList.AllowUserToResizeRows = false;
            this.studentsGroupsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.studentsGroupsList.AutoGenerateColumns = false;
            this.studentsGroupsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.studentsGroupsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentsGroupsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGroupsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.studentsGroupsList.DataSource = this.группыBindingSource1;
            this.studentsGroupsList.Location = new System.Drawing.Point(6, 158);
            this.studentsGroupsList.MultiSelect = false;
            this.studentsGroupsList.Name = "studentsGroupsList";
            this.studentsGroupsList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsGroupsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studentsGroupsList.RowHeadersVisible = false;
            this.studentsGroupsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.studentsGroupsList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.studentsGroupsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.studentsGroupsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentsGroupsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.studentsGroupsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsGroupsList.Size = new System.Drawing.Size(135, 409);
            this.studentsGroupsList.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название_группы";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название группы";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_группы";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_группы";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Курс";
            this.dataGridViewTextBoxColumn3.HeaderText = "Курс";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_основания";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_основания";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Специальность";
            this.dataGridViewTextBoxColumn5.HeaderText = "Специальность";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // studentsList
            // 
            this.studentsList.AllowUserToAddRows = false;
            this.studentsList.AllowUserToDeleteRows = false;
            this.studentsList.AllowUserToResizeColumns = false;
            this.studentsList.AllowUserToResizeRows = false;
            this.studentsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsList.AutoGenerateColumns = false;
            this.studentsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.studentsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.кодучащегосяDataGridViewTextBoxColumn,
            this.кодгруппыDataGridViewTextBoxColumn1,
            this.адресDataGridViewTextBoxColumn});
            this.studentsList.ContextMenuStrip = this.studentsMenu;
            this.studentsList.DataSource = this.группыУчащиесяBindingSource;
            this.studentsList.Location = new System.Drawing.Point(147, 158);
            this.studentsList.MultiSelect = false;
            this.studentsList.Name = "studentsList";
            this.studentsList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.studentsList.RowHeadersVisible = false;
            this.studentsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.studentsList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.studentsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.studentsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.studentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsList.Size = new System.Drawing.Size(904, 409);
            this.studentsList.TabIndex = 6;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn.Width = 59;
            // 
            // кодучащегосяDataGridViewTextBoxColumn
            // 
            this.кодучащегосяDataGridViewTextBoxColumn.DataPropertyName = "Код_учащегося";
            this.кодучащегосяDataGridViewTextBoxColumn.HeaderText = "Код_учащегося";
            this.кодучащегосяDataGridViewTextBoxColumn.Name = "кодучащегосяDataGridViewTextBoxColumn";
            this.кодучащегосяDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодучащегосяDataGridViewTextBoxColumn.Visible = false;
            // 
            // кодгруппыDataGridViewTextBoxColumn1
            // 
            this.кодгруппыDataGridViewTextBoxColumn1.DataPropertyName = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn1.HeaderText = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn1.Name = "кодгруппыDataGridViewTextBoxColumn1";
            this.кодгруппыDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодгруппыDataGridViewTextBoxColumn1.Visible = false;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentsMenu
            // 
            this.studentsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportStudentBTN,
            this.toolStripMenuItem3,
            this.deleteStudentBTN});
            this.studentsMenu.Name = "groupsMenu";
            this.studentsMenu.Size = new System.Drawing.Size(236, 54);
            // 
            // exportStudentBTN
            // 
            this.exportStudentBTN.Name = "exportStudentBTN";
            this.exportStudentBTN.Size = new System.Drawing.Size(235, 22);
            this.exportStudentBTN.Text = "Экспорт в Excel";
            this.exportStudentBTN.Click += new System.EventHandler(this.exportStudentBTN_Click);
            // 
            // deleteStudentBTN
            // 
            this.deleteStudentBTN.Name = "deleteStudentBTN";
            this.deleteStudentBTN.Size = new System.Drawing.Size(235, 22);
            this.deleteStudentBTN.Text = "Удалить выбранный элемент";
            this.deleteStudentBTN.Click += new System.EventHandler(this.deleteStudentBTN_Click);
            // 
            // marksPanel
            // 
            this.marksPanel.Controls.Add(this.marksTabControl);
            this.marksPanel.Controls.Add(this.marksFilterPanel);
            this.marksPanel.Controls.Add(this.marksStudentsList);
            this.marksPanel.Controls.Add(this.marksList);
            this.marksPanel.Controls.Add(this.marksGroupsList);
            this.marksPanel.Location = new System.Drawing.Point(4, 22);
            this.marksPanel.Name = "marksPanel";
            this.marksPanel.Size = new System.Drawing.Size(1057, 717);
            this.marksPanel.TabIndex = 2;
            this.marksPanel.Text = "Оценки";
            this.marksPanel.UseVisualStyleBackColor = true;
            // 
            // marksTabControl
            // 
            this.marksTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksTabControl.Controls.Add(this.marksEditPanel);
            this.marksTabControl.Controls.Add(this.marksAddPanel);
            this.marksTabControl.Location = new System.Drawing.Point(6, 532);
            this.marksTabControl.Name = "marksTabControl";
            this.marksTabControl.SelectedIndex = 0;
            this.marksTabControl.Size = new System.Drawing.Size(1045, 179);
            this.marksTabControl.TabIndex = 11;
            // 
            // marksEditPanel
            // 
            this.marksEditPanel.Controls.Add(this.marksSaveBTN);
            this.marksEditPanel.Controls.Add(this.marksELessonCB);
            this.marksEditPanel.Controls.Add(this.marksELessonLBL);
            this.marksEditPanel.Controls.Add(this.marksEDateTP);
            this.marksEditPanel.Controls.Add(this.marksEDateLBL);
            this.marksEditPanel.Controls.Add(this.marksEValueNUD);
            this.marksEditPanel.Controls.Add(this.marksEValueLBL);
            this.marksEditPanel.Location = new System.Drawing.Point(4, 22);
            this.marksEditPanel.Name = "marksEditPanel";
            this.marksEditPanel.Padding = new System.Windows.Forms.Padding(3);
            this.marksEditPanel.Size = new System.Drawing.Size(1037, 153);
            this.marksEditPanel.TabIndex = 0;
            this.marksEditPanel.Text = "Редактирование";
            this.marksEditPanel.UseVisualStyleBackColor = true;
            // 
            // marksSaveBTN
            // 
            this.marksSaveBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksSaveBTN.Location = new System.Drawing.Point(6, 124);
            this.marksSaveBTN.Name = "marksSaveBTN";
            this.marksSaveBTN.Size = new System.Drawing.Size(1025, 23);
            this.marksSaveBTN.TabIndex = 8;
            this.marksSaveBTN.Text = "Сохранить изменения!";
            this.marksSaveBTN.UseVisualStyleBackColor = true;
            this.marksSaveBTN.Click += new System.EventHandler(this.marksSaveBTN_Click);
            // 
            // marksELessonCB
            // 
            this.marksELessonCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksELessonCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.marksELessonCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.marksELessonCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учащиесяОценкиBindingSource, "Предмет", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.marksELessonCB.FormattingEnabled = true;
            this.marksELessonCB.Items.AddRange(new object[] {
            "Трудовое обучение",
            "Астрономия",
            "Всемирная история. История Беларуси",
            "Русская литература",
            "Русский язык",
            "Обществоведение",
            "Математика",
            "Изобразительное искусство",
            "Иностранный язык",
            "Информатика",
            "Химия",
            "География",
            "Физическая культура и здоровье",
            "Физика",
            "Допризывная и медицинская подготовка",
            "Черчение",
            "Человек и мир",
            "Биология",
            "Беларуская мова",
            "Беларуская літаратура",
            "Литературное чтение",
            "Літаратурнае чытанне"});
            this.marksELessonCB.Location = new System.Drawing.Point(6, 97);
            this.marksELessonCB.Name = "marksELessonCB";
            this.marksELessonCB.Size = new System.Drawing.Size(1025, 21);
            this.marksELessonCB.TabIndex = 7;
            this.marksELessonCB.Text = "Трудовое обучение";
            // 
            // учащиесяОценкиBindingSource
            // 
            this.учащиесяОценкиBindingSource.DataMember = "УчащиесяОценки";
            this.учащиесяОценкиBindingSource.DataSource = this.группыУчащиесяBindingSource1;
            // 
            // группыУчащиесяBindingSource1
            // 
            this.группыУчащиесяBindingSource1.DataMember = "ГруппыУчащиеся";
            this.группыУчащиесяBindingSource1.DataSource = this.группыBindingSource2;
            // 
            // группыBindingSource2
            // 
            this.группыBindingSource2.DataMember = "Группы";
            this.группыBindingSource2.DataSource = this.dbDataSet;
            // 
            // marksELessonLBL
            // 
            this.marksELessonLBL.AutoSize = true;
            this.marksELessonLBL.Location = new System.Drawing.Point(6, 81);
            this.marksELessonLBL.Name = "marksELessonLBL";
            this.marksELessonLBL.Size = new System.Drawing.Size(52, 13);
            this.marksELessonLBL.TabIndex = 6;
            this.marksELessonLBL.Text = "Предмет";
            // 
            // marksEDateTP
            // 
            this.marksEDateTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksEDateTP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.учащиесяОценкиBindingSource, "Дата", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "D"));
            this.marksEDateTP.Location = new System.Drawing.Point(6, 58);
            this.marksEDateTP.Name = "marksEDateTP";
            this.marksEDateTP.Size = new System.Drawing.Size(1025, 20);
            this.marksEDateTP.TabIndex = 5;
            // 
            // marksEDateLBL
            // 
            this.marksEDateLBL.AutoSize = true;
            this.marksEDateLBL.Location = new System.Drawing.Point(6, 42);
            this.marksEDateLBL.Name = "marksEDateLBL";
            this.marksEDateLBL.Size = new System.Drawing.Size(103, 13);
            this.marksEDateLBL.TabIndex = 4;
            this.marksEDateLBL.Text = "Дата выставления";
            // 
            // marksEValueNUD
            // 
            this.marksEValueNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksEValueNUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.учащиесяОценкиBindingSource, "Оценка", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "N0"));
            this.marksEValueNUD.Location = new System.Drawing.Point(6, 19);
            this.marksEValueNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.marksEValueNUD.Name = "marksEValueNUD";
            this.marksEValueNUD.Size = new System.Drawing.Size(1025, 20);
            this.marksEValueNUD.TabIndex = 3;
            // 
            // marksEValueLBL
            // 
            this.marksEValueLBL.AutoSize = true;
            this.marksEValueLBL.Location = new System.Drawing.Point(6, 3);
            this.marksEValueLBL.Name = "marksEValueLBL";
            this.marksEValueLBL.Size = new System.Drawing.Size(45, 13);
            this.marksEValueLBL.TabIndex = 2;
            this.marksEValueLBL.Text = "Оценка";
            // 
            // marksAddPanel
            // 
            this.marksAddPanel.Controls.Add(this.marksAddBTN);
            this.marksAddPanel.Controls.Add(this.marksALessonCB);
            this.marksAddPanel.Controls.Add(this.marksALessonLBL);
            this.marksAddPanel.Controls.Add(this.marksADateTP);
            this.marksAddPanel.Controls.Add(this.marksADateLBL);
            this.marksAddPanel.Controls.Add(this.marksAValueNUD);
            this.marksAddPanel.Controls.Add(this.marksAValueLBL);
            this.marksAddPanel.Location = new System.Drawing.Point(4, 22);
            this.marksAddPanel.Name = "marksAddPanel";
            this.marksAddPanel.Padding = new System.Windows.Forms.Padding(3);
            this.marksAddPanel.Size = new System.Drawing.Size(1037, 153);
            this.marksAddPanel.TabIndex = 1;
            this.marksAddPanel.Text = "Добавление";
            this.marksAddPanel.UseVisualStyleBackColor = true;
            // 
            // marksAddBTN
            // 
            this.marksAddBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksAddBTN.Location = new System.Drawing.Point(6, 124);
            this.marksAddBTN.Name = "marksAddBTN";
            this.marksAddBTN.Size = new System.Drawing.Size(1025, 23);
            this.marksAddBTN.TabIndex = 15;
            this.marksAddBTN.Text = "Добавить оценку!";
            this.marksAddBTN.UseVisualStyleBackColor = true;
            this.marksAddBTN.Click += new System.EventHandler(this.marksAddBTN_Click);
            // 
            // marksALessonCB
            // 
            this.marksALessonCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksALessonCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.marksALessonCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.marksALessonCB.FormattingEnabled = true;
            this.marksALessonCB.Items.AddRange(new object[] {
            "Трудовое обучение",
            "Астрономия",
            "Всемирная история. История Беларуси",
            "Русская литература",
            "Русский язык",
            "Обществоведение",
            "Математика",
            "Изобразительное искусство",
            "Иностранный язык",
            "Информатика",
            "Химия",
            "География",
            "Физическая культура и здоровье",
            "Физика",
            "Допризывная и медицинская подготовка",
            "Черчение",
            "Человек и мир",
            "Биология",
            "Беларуская мова",
            "Беларуская літаратура",
            "Литературное чтение",
            "Літаратурнае чытанне"});
            this.marksALessonCB.Location = new System.Drawing.Point(6, 97);
            this.marksALessonCB.Name = "marksALessonCB";
            this.marksALessonCB.Size = new System.Drawing.Size(1025, 21);
            this.marksALessonCB.TabIndex = 14;
            this.marksALessonCB.Text = "Трудовое обучение";
            // 
            // marksALessonLBL
            // 
            this.marksALessonLBL.AutoSize = true;
            this.marksALessonLBL.Location = new System.Drawing.Point(6, 81);
            this.marksALessonLBL.Name = "marksALessonLBL";
            this.marksALessonLBL.Size = new System.Drawing.Size(52, 13);
            this.marksALessonLBL.TabIndex = 13;
            this.marksALessonLBL.Text = "Предмет";
            // 
            // marksADateTP
            // 
            this.marksADateTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksADateTP.Location = new System.Drawing.Point(6, 58);
            this.marksADateTP.Name = "marksADateTP";
            this.marksADateTP.Size = new System.Drawing.Size(1025, 20);
            this.marksADateTP.TabIndex = 12;
            // 
            // marksADateLBL
            // 
            this.marksADateLBL.AutoSize = true;
            this.marksADateLBL.Location = new System.Drawing.Point(6, 42);
            this.marksADateLBL.Name = "marksADateLBL";
            this.marksADateLBL.Size = new System.Drawing.Size(103, 13);
            this.marksADateLBL.TabIndex = 11;
            this.marksADateLBL.Text = "Дата выставления";
            // 
            // marksAValueNUD
            // 
            this.marksAValueNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksAValueNUD.Location = new System.Drawing.Point(6, 19);
            this.marksAValueNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.marksAValueNUD.Name = "marksAValueNUD";
            this.marksAValueNUD.Size = new System.Drawing.Size(1025, 20);
            this.marksAValueNUD.TabIndex = 10;
            // 
            // marksAValueLBL
            // 
            this.marksAValueLBL.AutoSize = true;
            this.marksAValueLBL.Location = new System.Drawing.Point(6, 3);
            this.marksAValueLBL.Name = "marksAValueLBL";
            this.marksAValueLBL.Size = new System.Drawing.Size(45, 13);
            this.marksAValueLBL.TabIndex = 9;
            this.marksAValueLBL.Text = "Оценка";
            // 
            // marksFilterPanel
            // 
            this.marksFilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksFilterPanel.Controls.Add(this.filterMarksApplyBTN);
            this.marksFilterPanel.Controls.Add(this.filterMarksDateDL);
            this.marksFilterPanel.Controls.Add(this.filterMarksValueDL);
            this.marksFilterPanel.Controls.Add(this.filterMarksDateCHB);
            this.marksFilterPanel.Controls.Add(this.filterMarksLessonCHB);
            this.marksFilterPanel.Controls.Add(this.filterMarksLessonTB);
            this.marksFilterPanel.Controls.Add(this.filterMarksValueNUD);
            this.marksFilterPanel.Controls.Add(this.filterMarksValueCHB);
            this.marksFilterPanel.Controls.Add(this.filterMarksDateTP);
            this.marksFilterPanel.Location = new System.Drawing.Point(6, 6);
            this.marksFilterPanel.Name = "marksFilterPanel";
            this.marksFilterPanel.Size = new System.Drawing.Size(1045, 196);
            this.marksFilterPanel.TabIndex = 8;
            this.marksFilterPanel.TabStop = false;
            this.marksFilterPanel.Text = "Фильтр";
            // 
            // filterMarksApplyBTN
            // 
            this.filterMarksApplyBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterMarksApplyBTN.Location = new System.Drawing.Point(6, 167);
            this.filterMarksApplyBTN.Name = "filterMarksApplyBTN";
            this.filterMarksApplyBTN.Size = new System.Drawing.Size(1033, 23);
            this.filterMarksApplyBTN.TabIndex = 21;
            this.filterMarksApplyBTN.Text = "Применить фильтр!";
            this.filterMarksApplyBTN.UseVisualStyleBackColor = true;
            this.filterMarksApplyBTN.Click += new System.EventHandler(this.filterMarksApplyBTN_Click);
            // 
            // filterMarksDateDL
            // 
            this.filterMarksDateDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterMarksDateDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterMarksDateDL.FormattingEnabled = true;
            this.filterMarksDateDL.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<",
            "<="});
            this.filterMarksDateDL.Location = new System.Drawing.Point(978, 90);
            this.filterMarksDateDL.Name = "filterMarksDateDL";
            this.filterMarksDateDL.Size = new System.Drawing.Size(61, 21);
            this.filterMarksDateDL.TabIndex = 20;
            // 
            // filterMarksValueDL
            // 
            this.filterMarksValueDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterMarksValueDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterMarksValueDL.FormattingEnabled = true;
            this.filterMarksValueDL.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<",
            "<="});
            this.filterMarksValueDL.Location = new System.Drawing.Point(978, 41);
            this.filterMarksValueDL.Name = "filterMarksValueDL";
            this.filterMarksValueDL.Size = new System.Drawing.Size(61, 21);
            this.filterMarksValueDL.TabIndex = 19;
            // 
            // filterMarksDateCHB
            // 
            this.filterMarksDateCHB.AutoSize = true;
            this.filterMarksDateCHB.Location = new System.Drawing.Point(6, 68);
            this.filterMarksDateCHB.Name = "filterMarksDateCHB";
            this.filterMarksDateCHB.Size = new System.Drawing.Size(136, 17);
            this.filterMarksDateCHB.TabIndex = 16;
            this.filterMarksDateCHB.Text = "По дате выставления";
            this.filterMarksDateCHB.UseVisualStyleBackColor = true;
            // 
            // filterMarksLessonCHB
            // 
            this.filterMarksLessonCHB.AutoSize = true;
            this.filterMarksLessonCHB.Location = new System.Drawing.Point(6, 117);
            this.filterMarksLessonCHB.Name = "filterMarksLessonCHB";
            this.filterMarksLessonCHB.Size = new System.Drawing.Size(91, 17);
            this.filterMarksLessonCHB.TabIndex = 13;
            this.filterMarksLessonCHB.Text = "По предмету";
            this.filterMarksLessonCHB.UseVisualStyleBackColor = true;
            // 
            // filterMarksLessonTB
            // 
            this.filterMarksLessonTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterMarksLessonTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterMarksLessonTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterMarksLessonTB.FormattingEnabled = true;
            this.filterMarksLessonTB.Items.AddRange(new object[] {
            "Трудовое обучение",
            "Астрономия",
            "Всемирная история. История Беларуси",
            "Русская литература",
            "Русский язык",
            "Обществоведение",
            "Математика",
            "Изобразительное искусство",
            "Иностранный язык",
            "Информатика",
            "Химия",
            "География",
            "Физическая культура и здоровье",
            "Физика",
            "Допризывная и медицинская подготовка",
            "Черчение",
            "Человек и мир",
            "Биология",
            "Беларуская мова",
            "Беларуская літаратура",
            "Литературное чтение",
            "Літаратурнае чытанне"});
            this.filterMarksLessonTB.Location = new System.Drawing.Point(6, 140);
            this.filterMarksLessonTB.Name = "filterMarksLessonTB";
            this.filterMarksLessonTB.Size = new System.Drawing.Size(1033, 21);
            this.filterMarksLessonTB.TabIndex = 11;
            // 
            // filterMarksValueNUD
            // 
            this.filterMarksValueNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterMarksValueNUD.Location = new System.Drawing.Point(6, 42);
            this.filterMarksValueNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.filterMarksValueNUD.Name = "filterMarksValueNUD";
            this.filterMarksValueNUD.Size = new System.Drawing.Size(966, 20);
            this.filterMarksValueNUD.TabIndex = 9;
            // 
            // filterMarksValueCHB
            // 
            this.filterMarksValueCHB.AutoSize = true;
            this.filterMarksValueCHB.Location = new System.Drawing.Point(6, 19);
            this.filterMarksValueCHB.Name = "filterMarksValueCHB";
            this.filterMarksValueCHB.Size = new System.Drawing.Size(79, 17);
            this.filterMarksValueCHB.TabIndex = 12;
            this.filterMarksValueCHB.Text = "По оценке";
            this.filterMarksValueCHB.UseVisualStyleBackColor = true;
            // 
            // filterMarksDateTP
            // 
            this.filterMarksDateTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterMarksDateTP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.группыBindingSource, "Дата_основания", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "D"));
            this.filterMarksDateTP.Location = new System.Drawing.Point(6, 91);
            this.filterMarksDateTP.Name = "filterMarksDateTP";
            this.filterMarksDateTP.Size = new System.Drawing.Size(966, 20);
            this.filterMarksDateTP.TabIndex = 15;
            // 
            // marksStudentsList
            // 
            this.marksStudentsList.AllowUserToAddRows = false;
            this.marksStudentsList.AllowUserToDeleteRows = false;
            this.marksStudentsList.AllowUserToResizeColumns = false;
            this.marksStudentsList.AllowUserToResizeRows = false;
            this.marksStudentsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.marksStudentsList.AutoGenerateColumns = false;
            this.marksStudentsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.marksStudentsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.marksStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksStudentsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn1,
            this.кодучащегосяDataGridViewTextBoxColumn1,
            this.кодгруппыDataGridViewTextBoxColumn2,
            this.адресDataGridViewTextBoxColumn1});
            this.marksStudentsList.DataSource = this.группыУчащиесяBindingSource1;
            this.marksStudentsList.Location = new System.Drawing.Point(149, 208);
            this.marksStudentsList.MultiSelect = false;
            this.marksStudentsList.Name = "marksStudentsList";
            this.marksStudentsList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marksStudentsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.marksStudentsList.RowHeadersVisible = false;
            this.marksStudentsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.marksStudentsList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.marksStudentsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.marksStudentsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.marksStudentsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.marksStudentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marksStudentsList.Size = new System.Drawing.Size(188, 318);
            this.marksStudentsList.TabIndex = 7;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // кодучащегосяDataGridViewTextBoxColumn1
            // 
            this.кодучащегосяDataGridViewTextBoxColumn1.DataPropertyName = "Код_учащегося";
            this.кодучащегосяDataGridViewTextBoxColumn1.HeaderText = "Код_учащегося";
            this.кодучащегосяDataGridViewTextBoxColumn1.Name = "кодучащегосяDataGridViewTextBoxColumn1";
            this.кодучащегосяDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодучащегосяDataGridViewTextBoxColumn1.Visible = false;
            // 
            // кодгруппыDataGridViewTextBoxColumn2
            // 
            this.кодгруппыDataGridViewTextBoxColumn2.DataPropertyName = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn2.HeaderText = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn2.Name = "кодгруппыDataGridViewTextBoxColumn2";
            this.кодгруппыDataGridViewTextBoxColumn2.ReadOnly = true;
            this.кодгруппыDataGridViewTextBoxColumn2.Visible = false;
            // 
            // адресDataGridViewTextBoxColumn1
            // 
            this.адресDataGridViewTextBoxColumn1.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn1.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn1.Name = "адресDataGridViewTextBoxColumn1";
            this.адресDataGridViewTextBoxColumn1.ReadOnly = true;
            this.адресDataGridViewTextBoxColumn1.Visible = false;
            // 
            // marksList
            // 
            this.marksList.AllowUserToAddRows = false;
            this.marksList.AllowUserToDeleteRows = false;
            this.marksList.AllowUserToResizeColumns = false;
            this.marksList.AllowUserToResizeRows = false;
            this.marksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksList.AutoGenerateColumns = false;
            this.marksList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.marksList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.marksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.оценкаDataGridViewTextBoxColumn,
            this.кодоценкиDataGridViewTextBoxColumn,
            this.кодучащегосяDataGridViewTextBoxColumn2,
            this.предметDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.marksList.ContextMenuStrip = this.marksMenu;
            this.marksList.DataSource = this.учащиесяОценкиBindingSource;
            this.marksList.Location = new System.Drawing.Point(343, 208);
            this.marksList.MultiSelect = false;
            this.marksList.Name = "marksList";
            this.marksList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marksList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.marksList.RowHeadersVisible = false;
            this.marksList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.marksList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.marksList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.marksList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.marksList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.marksList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marksList.Size = new System.Drawing.Size(708, 318);
            this.marksList.TabIndex = 10;
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            this.оценкаDataGridViewTextBoxColumn.ReadOnly = true;
            this.оценкаDataGridViewTextBoxColumn.Width = 70;
            // 
            // кодоценкиDataGridViewTextBoxColumn
            // 
            this.кодоценкиDataGridViewTextBoxColumn.DataPropertyName = "Код_оценки";
            this.кодоценкиDataGridViewTextBoxColumn.HeaderText = "Код_оценки";
            this.кодоценкиDataGridViewTextBoxColumn.Name = "кодоценкиDataGridViewTextBoxColumn";
            this.кодоценкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодоценкиDataGridViewTextBoxColumn.Visible = false;
            // 
            // кодучащегосяDataGridViewTextBoxColumn2
            // 
            this.кодучащегосяDataGridViewTextBoxColumn2.DataPropertyName = "Код_учащегося";
            this.кодучащегосяDataGridViewTextBoxColumn2.HeaderText = "Код_учащегося";
            this.кодучащегосяDataGridViewTextBoxColumn2.Name = "кодучащегосяDataGridViewTextBoxColumn2";
            this.кодучащегосяDataGridViewTextBoxColumn2.ReadOnly = true;
            this.кодучащегосяDataGridViewTextBoxColumn2.Visible = false;
            // 
            // предметDataGridViewTextBoxColumn
            // 
            this.предметDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.предметDataGridViewTextBoxColumn.DataPropertyName = "Предмет";
            this.предметDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.предметDataGridViewTextBoxColumn.Name = "предметDataGridViewTextBoxColumn";
            this.предметDataGridViewTextBoxColumn.ReadOnly = true;
            this.предметDataGridViewTextBoxColumn.Width = 77;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marksMenu
            // 
            this.marksMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marksAvgBTN,
            this.exporMarksBTN,
            this.toolStripMenuItem1,
            this.deleteMarkBTN});
            this.marksMenu.Name = "groupsMenu";
            this.marksMenu.Size = new System.Drawing.Size(237, 76);
            // 
            // marksAvgBTN
            // 
            this.marksAvgBTN.Name = "marksAvgBTN";
            this.marksAvgBTN.Size = new System.Drawing.Size(236, 22);
            this.marksAvgBTN.Text = "Вычислить среднее значение";
            this.marksAvgBTN.Click += new System.EventHandler(this.marksAvgBTN_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(233, 6);
            // 
            // deleteMarkBTN
            // 
            this.deleteMarkBTN.Name = "deleteMarkBTN";
            this.deleteMarkBTN.Size = new System.Drawing.Size(236, 22);
            this.deleteMarkBTN.Text = "Удалить выбранный элемент";
            this.deleteMarkBTN.Click += new System.EventHandler(this.deleteMarkBTN_Click);
            // 
            // marksGroupsList
            // 
            this.marksGroupsList.AllowUserToAddRows = false;
            this.marksGroupsList.AllowUserToDeleteRows = false;
            this.marksGroupsList.AllowUserToResizeColumns = false;
            this.marksGroupsList.AllowUserToResizeRows = false;
            this.marksGroupsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.marksGroupsList.AutoGenerateColumns = false;
            this.marksGroupsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.marksGroupsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.marksGroupsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksGroupsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.marksGroupsList.DataSource = this.группыBindingSource2;
            this.marksGroupsList.Location = new System.Drawing.Point(8, 208);
            this.marksGroupsList.MultiSelect = false;
            this.marksGroupsList.Name = "marksGroupsList";
            this.marksGroupsList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marksGroupsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.marksGroupsList.RowHeadersVisible = false;
            this.marksGroupsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.marksGroupsList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.marksGroupsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.marksGroupsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.marksGroupsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.marksGroupsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marksGroupsList.Size = new System.Drawing.Size(135, 318);
            this.marksGroupsList.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Название_группы";
            this.dataGridViewTextBoxColumn6.HeaderText = "Название группы";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Код_группы";
            this.dataGridViewTextBoxColumn7.HeaderText = "Код_группы";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Курс";
            this.dataGridViewTextBoxColumn8.HeaderText = "Курс";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Дата_основания";
            this.dataGridViewTextBoxColumn9.HeaderText = "Дата_основания";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Специальность";
            this.dataGridViewTextBoxColumn10.HeaderText = "Специальность";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // skipsPanel
            // 
            this.skipsPanel.Controls.Add(this.skipsTabControl);
            this.skipsPanel.Controls.Add(this.skipsFilterPanel);
            this.skipsPanel.Controls.Add(this.skipsGroupsList);
            this.skipsPanel.Controls.Add(this.skipsStudentsList);
            this.skipsPanel.Controls.Add(this.skipsList);
            this.skipsPanel.Location = new System.Drawing.Point(4, 22);
            this.skipsPanel.Name = "skipsPanel";
            this.skipsPanel.Size = new System.Drawing.Size(1057, 717);
            this.skipsPanel.TabIndex = 3;
            this.skipsPanel.Text = "Пропуски";
            this.skipsPanel.UseVisualStyleBackColor = true;
            // 
            // skipsTabControl
            // 
            this.skipsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipsTabControl.Controls.Add(this.skipsEditPanel);
            this.skipsTabControl.Controls.Add(this.skipsAddPanel);
            this.skipsTabControl.Location = new System.Drawing.Point(6, 548);
            this.skipsTabControl.Name = "skipsTabControl";
            this.skipsTabControl.SelectedIndex = 0;
            this.skipsTabControl.Size = new System.Drawing.Size(1045, 163);
            this.skipsTabControl.TabIndex = 15;
            // 
            // skipsEditPanel
            // 
            this.skipsEditPanel.Controls.Add(this.skipsEReasonCHB);
            this.skipsEditPanel.Controls.Add(this.skipsSaveBTN);
            this.skipsEditPanel.Controls.Add(this.skipsELessonCB);
            this.skipsEditPanel.Controls.Add(this.skipsELessonLBL);
            this.skipsEditPanel.Controls.Add(this.skipsEDateTP);
            this.skipsEditPanel.Controls.Add(this.skipsEDateLBL);
            this.skipsEditPanel.Location = new System.Drawing.Point(4, 22);
            this.skipsEditPanel.Name = "skipsEditPanel";
            this.skipsEditPanel.Padding = new System.Windows.Forms.Padding(3);
            this.skipsEditPanel.Size = new System.Drawing.Size(1037, 137);
            this.skipsEditPanel.TabIndex = 0;
            this.skipsEditPanel.Text = "Редактирование";
            this.skipsEditPanel.UseVisualStyleBackColor = true;
            // 
            // skipsEReasonCHB
            // 
            this.skipsEReasonCHB.AutoSize = true;
            this.skipsEReasonCHB.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.учащиесяПропускиBindingSource, "По_уважительной", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.skipsEReasonCHB.Location = new System.Drawing.Point(6, 6);
            this.skipsEReasonCHB.Name = "skipsEReasonCHB";
            this.skipsEReasonCHB.Size = new System.Drawing.Size(115, 17);
            this.skipsEReasonCHB.TabIndex = 9;
            this.skipsEReasonCHB.Text = "По уважительной";
            this.skipsEReasonCHB.UseVisualStyleBackColor = true;
            // 
            // учащиесяПропускиBindingSource
            // 
            this.учащиесяПропускиBindingSource.DataMember = "УчащиесяПропуски";
            this.учащиесяПропускиBindingSource.DataSource = this.группыУчащиесяBindingSource2;
            // 
            // группыУчащиесяBindingSource2
            // 
            this.группыУчащиесяBindingSource2.DataMember = "ГруппыУчащиеся";
            this.группыУчащиесяBindingSource2.DataSource = this.группыBindingSource3;
            // 
            // группыBindingSource3
            // 
            this.группыBindingSource3.DataMember = "Группы";
            this.группыBindingSource3.DataSource = this.dbDataSet;
            // 
            // skipsSaveBTN
            // 
            this.skipsSaveBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipsSaveBTN.Location = new System.Drawing.Point(6, 108);
            this.skipsSaveBTN.Name = "skipsSaveBTN";
            this.skipsSaveBTN.Size = new System.Drawing.Size(1025, 23);
            this.skipsSaveBTN.TabIndex = 8;
            this.skipsSaveBTN.Text = "Сохранить изменения!";
            this.skipsSaveBTN.UseVisualStyleBackColor = true;
            this.skipsSaveBTN.Click += new System.EventHandler(this.skipsSaveBTN_Click);
            // 
            // skipsELessonCB
            // 
            this.skipsELessonCB.AllowDrop = true;
            this.skipsELessonCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipsELessonCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.skipsELessonCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.skipsELessonCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учащиесяПропускиBindingSource, "Предмет", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.skipsELessonCB.FormattingEnabled = true;
            this.skipsELessonCB.Items.AddRange(new object[] {
            "Трудовое обучение",
            "Астрономия",
            "Всемирная история. История Беларуси",
            "Русская литература",
            "Русский язык",
            "Обществоведение",
            "Математика",
            "Изобразительное искусство",
            "Иностранный язык",
            "Информатика",
            "Химия",
            "География",
            "Физическая культура и здоровье",
            "Физика",
            "Допризывная и медицинская подготовка",
            "Черчение",
            "Человек и мир",
            "Биология",
            "Беларуская мова",
            "Беларуская літаратура",
            "Литературное чтение",
            "Літаратурнае чытанне"});
            this.skipsELessonCB.Location = new System.Drawing.Point(6, 81);
            this.skipsELessonCB.Name = "skipsELessonCB";
            this.skipsELessonCB.Size = new System.Drawing.Size(1025, 21);
            this.skipsELessonCB.TabIndex = 7;
            this.skipsELessonCB.Text = "Трудовое обучение";
            // 
            // skipsELessonLBL
            // 
            this.skipsELessonLBL.AutoSize = true;
            this.skipsELessonLBL.Location = new System.Drawing.Point(6, 65);
            this.skipsELessonLBL.Name = "skipsELessonLBL";
            this.skipsELessonLBL.Size = new System.Drawing.Size(52, 13);
            this.skipsELessonLBL.TabIndex = 6;
            this.skipsELessonLBL.Text = "Предмет";
            // 
            // skipsEDateTP
            // 
            this.skipsEDateTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipsEDateTP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.учащиесяПропускиBindingSource, "Дата", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.skipsEDateTP.Location = new System.Drawing.Point(6, 42);
            this.skipsEDateTP.Name = "skipsEDateTP";
            this.skipsEDateTP.Size = new System.Drawing.Size(1025, 20);
            this.skipsEDateTP.TabIndex = 5;
            // 
            // skipsEDateLBL
            // 
            this.skipsEDateLBL.AutoSize = true;
            this.skipsEDateLBL.Location = new System.Drawing.Point(6, 26);
            this.skipsEDateLBL.Name = "skipsEDateLBL";
            this.skipsEDateLBL.Size = new System.Drawing.Size(83, 13);
            this.skipsEDateLBL.TabIndex = 4;
            this.skipsEDateLBL.Text = "Дата пропуска";
            // 
            // skipsAddPanel
            // 
            this.skipsAddPanel.Controls.Add(this.skipsAReasonCHB);
            this.skipsAddPanel.Controls.Add(this.skipsAddBTN);
            this.skipsAddPanel.Controls.Add(this.skipsALessonCB);
            this.skipsAddPanel.Controls.Add(this.skipsALessonLBL);
            this.skipsAddPanel.Controls.Add(this.skipsADateTP);
            this.skipsAddPanel.Controls.Add(this.skipsADateLBL);
            this.skipsAddPanel.Location = new System.Drawing.Point(4, 22);
            this.skipsAddPanel.Name = "skipsAddPanel";
            this.skipsAddPanel.Padding = new System.Windows.Forms.Padding(3);
            this.skipsAddPanel.Size = new System.Drawing.Size(1037, 137);
            this.skipsAddPanel.TabIndex = 1;
            this.skipsAddPanel.Text = "Добавление";
            this.skipsAddPanel.UseVisualStyleBackColor = true;
            // 
            // skipsAReasonCHB
            // 
            this.skipsAReasonCHB.AutoSize = true;
            this.skipsAReasonCHB.Location = new System.Drawing.Point(6, 6);
            this.skipsAReasonCHB.Name = "skipsAReasonCHB";
            this.skipsAReasonCHB.Size = new System.Drawing.Size(115, 17);
            this.skipsAReasonCHB.TabIndex = 15;
            this.skipsAReasonCHB.Text = "По уважительной";
            this.skipsAReasonCHB.UseVisualStyleBackColor = true;
            // 
            // skipsAddBTN
            // 
            this.skipsAddBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipsAddBTN.Location = new System.Drawing.Point(6, 108);
            this.skipsAddBTN.Name = "skipsAddBTN";
            this.skipsAddBTN.Size = new System.Drawing.Size(1025, 23);
            this.skipsAddBTN.TabIndex = 14;
            this.skipsAddBTN.Text = "Добавить пропуск!";
            this.skipsAddBTN.UseVisualStyleBackColor = true;
            this.skipsAddBTN.Click += new System.EventHandler(this.skipsAddBTN_Click);
            // 
            // skipsALessonCB
            // 
            this.skipsALessonCB.AllowDrop = true;
            this.skipsALessonCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipsALessonCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.skipsALessonCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.skipsALessonCB.FormattingEnabled = true;
            this.skipsALessonCB.Items.AddRange(new object[] {
            "Трудовое обучение",
            "Астрономия",
            "Всемирная история. История Беларуси",
            "Русская литература",
            "Русский язык",
            "Обществоведение",
            "Математика",
            "Изобразительное искусство",
            "Иностранный язык",
            "Информатика",
            "Химия",
            "География",
            "Физическая культура и здоровье",
            "Физика",
            "Допризывная и медицинская подготовка",
            "Черчение",
            "Человек и мир",
            "Биология",
            "Беларуская мова",
            "Беларуская літаратура",
            "Литературное чтение",
            "Літаратурнае чытанне"});
            this.skipsALessonCB.Location = new System.Drawing.Point(6, 81);
            this.skipsALessonCB.Name = "skipsALessonCB";
            this.skipsALessonCB.Size = new System.Drawing.Size(1025, 21);
            this.skipsALessonCB.TabIndex = 13;
            this.skipsALessonCB.Text = "Трудовое обучение";
            // 
            // skipsALessonLBL
            // 
            this.skipsALessonLBL.AutoSize = true;
            this.skipsALessonLBL.Location = new System.Drawing.Point(6, 65);
            this.skipsALessonLBL.Name = "skipsALessonLBL";
            this.skipsALessonLBL.Size = new System.Drawing.Size(52, 13);
            this.skipsALessonLBL.TabIndex = 12;
            this.skipsALessonLBL.Text = "Предмет";
            // 
            // skipsADateTP
            // 
            this.skipsADateTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipsADateTP.Location = new System.Drawing.Point(6, 42);
            this.skipsADateTP.Name = "skipsADateTP";
            this.skipsADateTP.Size = new System.Drawing.Size(1025, 20);
            this.skipsADateTP.TabIndex = 11;
            // 
            // skipsADateLBL
            // 
            this.skipsADateLBL.AutoSize = true;
            this.skipsADateLBL.Location = new System.Drawing.Point(6, 26);
            this.skipsADateLBL.Name = "skipsADateLBL";
            this.skipsADateLBL.Size = new System.Drawing.Size(83, 13);
            this.skipsADateLBL.TabIndex = 10;
            this.skipsADateLBL.Text = "Дата пропуска";
            // 
            // skipsFilterPanel
            // 
            this.skipsFilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipsFilterPanel.Controls.Add(this.filterSkipsApplyBTN);
            this.skipsFilterPanel.Controls.Add(this.filterSkipsDateDL);
            this.skipsFilterPanel.Controls.Add(this.filterSkipsLessonCHB);
            this.skipsFilterPanel.Controls.Add(this.filterSkipsDateCHB);
            this.skipsFilterPanel.Controls.Add(this.filterSkipsDateTP);
            this.skipsFilterPanel.Controls.Add(this.filterSkipsLessonCB);
            this.skipsFilterPanel.Location = new System.Drawing.Point(6, 6);
            this.skipsFilterPanel.Name = "skipsFilterPanel";
            this.skipsFilterPanel.Size = new System.Drawing.Size(1045, 147);
            this.skipsFilterPanel.TabIndex = 13;
            this.skipsFilterPanel.TabStop = false;
            this.skipsFilterPanel.Text = "Фильтр";
            // 
            // filterSkipsApplyBTN
            // 
            this.filterSkipsApplyBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterSkipsApplyBTN.Location = new System.Drawing.Point(6, 118);
            this.filterSkipsApplyBTN.Name = "filterSkipsApplyBTN";
            this.filterSkipsApplyBTN.Size = new System.Drawing.Size(1033, 23);
            this.filterSkipsApplyBTN.TabIndex = 22;
            this.filterSkipsApplyBTN.Text = "Применить фильтр!";
            this.filterSkipsApplyBTN.UseVisualStyleBackColor = true;
            this.filterSkipsApplyBTN.Click += new System.EventHandler(this.filterSkipsApplyBTN_Click);
            // 
            // filterSkipsDateDL
            // 
            this.filterSkipsDateDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterSkipsDateDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterSkipsDateDL.FormattingEnabled = true;
            this.filterSkipsDateDL.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<",
            "<="});
            this.filterSkipsDateDL.Location = new System.Drawing.Point(978, 41);
            this.filterSkipsDateDL.Name = "filterSkipsDateDL";
            this.filterSkipsDateDL.Size = new System.Drawing.Size(61, 21);
            this.filterSkipsDateDL.TabIndex = 21;
            // 
            // filterSkipsLessonCHB
            // 
            this.filterSkipsLessonCHB.AutoSize = true;
            this.filterSkipsLessonCHB.Location = new System.Drawing.Point(6, 68);
            this.filterSkipsLessonCHB.Name = "filterSkipsLessonCHB";
            this.filterSkipsLessonCHB.Size = new System.Drawing.Size(91, 17);
            this.filterSkipsLessonCHB.TabIndex = 19;
            this.filterSkipsLessonCHB.Text = "По предмету";
            this.filterSkipsLessonCHB.UseVisualStyleBackColor = true;
            // 
            // filterSkipsDateCHB
            // 
            this.filterSkipsDateCHB.AutoSize = true;
            this.filterSkipsDateCHB.Location = new System.Drawing.Point(6, 19);
            this.filterSkipsDateCHB.Name = "filterSkipsDateCHB";
            this.filterSkipsDateCHB.Size = new System.Drawing.Size(116, 17);
            this.filterSkipsDateCHB.TabIndex = 18;
            this.filterSkipsDateCHB.Text = "По дате пропуска";
            this.filterSkipsDateCHB.UseVisualStyleBackColor = true;
            // 
            // filterSkipsDateTP
            // 
            this.filterSkipsDateTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterSkipsDateTP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.группыBindingSource, "Дата_основания", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "D"));
            this.filterSkipsDateTP.Location = new System.Drawing.Point(6, 42);
            this.filterSkipsDateTP.Name = "filterSkipsDateTP";
            this.filterSkipsDateTP.Size = new System.Drawing.Size(966, 20);
            this.filterSkipsDateTP.TabIndex = 17;
            // 
            // filterSkipsLessonCB
            // 
            this.filterSkipsLessonCB.AllowDrop = true;
            this.filterSkipsLessonCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterSkipsLessonCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterSkipsLessonCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterSkipsLessonCB.FormattingEnabled = true;
            this.filterSkipsLessonCB.Items.AddRange(new object[] {
            "Трудовое обучение",
            "Астрономия",
            "Всемирная история. История Беларуси",
            "Русская литература",
            "Русский язык",
            "Обществоведение",
            "Математика",
            "Изобразительное искусство",
            "Иностранный язык",
            "Информатика",
            "Химия",
            "География",
            "Физическая культура и здоровье",
            "Физика",
            "Допризывная и медицинская подготовка",
            "Черчение",
            "Человек и мир",
            "Биология",
            "Беларуская мова",
            "Беларуская літаратура",
            "Литературное чтение",
            "Літаратурнае чытанне"});
            this.filterSkipsLessonCB.Location = new System.Drawing.Point(6, 91);
            this.filterSkipsLessonCB.Name = "filterSkipsLessonCB";
            this.filterSkipsLessonCB.Size = new System.Drawing.Size(1033, 21);
            this.filterSkipsLessonCB.TabIndex = 9;
            // 
            // skipsGroupsList
            // 
            this.skipsGroupsList.AllowUserToAddRows = false;
            this.skipsGroupsList.AllowUserToDeleteRows = false;
            this.skipsGroupsList.AllowUserToResizeColumns = false;
            this.skipsGroupsList.AllowUserToResizeRows = false;
            this.skipsGroupsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.skipsGroupsList.AutoGenerateColumns = false;
            this.skipsGroupsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skipsGroupsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.skipsGroupsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skipsGroupsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.skipsGroupsList.DataSource = this.группыBindingSource3;
            this.skipsGroupsList.Location = new System.Drawing.Point(6, 159);
            this.skipsGroupsList.MultiSelect = false;
            this.skipsGroupsList.Name = "skipsGroupsList";
            this.skipsGroupsList.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skipsGroupsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.skipsGroupsList.RowHeadersVisible = false;
            this.skipsGroupsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.skipsGroupsList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.skipsGroupsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.skipsGroupsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skipsGroupsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.skipsGroupsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skipsGroupsList.Size = new System.Drawing.Size(135, 381);
            this.skipsGroupsList.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Название_группы";
            this.dataGridViewTextBoxColumn11.HeaderText = "Название группы";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Код_группы";
            this.dataGridViewTextBoxColumn12.HeaderText = "Код_группы";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Курс";
            this.dataGridViewTextBoxColumn13.HeaderText = "Курс";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Дата_основания";
            this.dataGridViewTextBoxColumn14.HeaderText = "Дата_основания";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Специальность";
            this.dataGridViewTextBoxColumn15.HeaderText = "Специальность";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // skipsStudentsList
            // 
            this.skipsStudentsList.AllowUserToAddRows = false;
            this.skipsStudentsList.AllowUserToDeleteRows = false;
            this.skipsStudentsList.AllowUserToResizeColumns = false;
            this.skipsStudentsList.AllowUserToResizeRows = false;
            this.skipsStudentsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.skipsStudentsList.AutoGenerateColumns = false;
            this.skipsStudentsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skipsStudentsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.skipsStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skipsStudentsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.skipsStudentsList.DataSource = this.группыУчащиесяBindingSource2;
            this.skipsStudentsList.Location = new System.Drawing.Point(147, 159);
            this.skipsStudentsList.MultiSelect = false;
            this.skipsStudentsList.Name = "skipsStudentsList";
            this.skipsStudentsList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skipsStudentsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.skipsStudentsList.RowHeadersVisible = false;
            this.skipsStudentsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.skipsStudentsList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.skipsStudentsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.skipsStudentsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skipsStudentsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.skipsStudentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skipsStudentsList.Size = new System.Drawing.Size(188, 381);
            this.skipsStudentsList.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn17.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Код_учащегося";
            this.dataGridViewTextBoxColumn16.HeaderText = "Код_учащегося";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Код_группы";
            this.dataGridViewTextBoxColumn18.HeaderText = "Код_группы";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn19.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // skipsList
            // 
            this.skipsList.AllowUserToAddRows = false;
            this.skipsList.AllowUserToDeleteRows = false;
            this.skipsList.AllowUserToResizeColumns = false;
            this.skipsList.AllowUserToResizeRows = false;
            this.skipsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipsList.AutoGenerateColumns = false;
            this.skipsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skipsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.skipsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skipsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.поуважительнойDataGridViewCheckBoxColumn,
            this.кодпропускаDataGridViewTextBoxColumn,
            this.предметDataGridViewTextBoxColumn1,
            this.датаDataGridViewTextBoxColumn1,
            this.кодучащегосяDataGridViewTextBoxColumn3});
            this.skipsList.ContextMenuStrip = this.skipsMenu;
            this.skipsList.DataSource = this.учащиесяПропускиBindingSource;
            this.skipsList.Location = new System.Drawing.Point(341, 159);
            this.skipsList.MultiSelect = false;
            this.skipsList.Name = "skipsList";
            this.skipsList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skipsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.skipsList.RowHeadersVisible = false;
            this.skipsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.skipsList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.skipsList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.skipsList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skipsList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.skipsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skipsList.Size = new System.Drawing.Size(708, 381);
            this.skipsList.TabIndex = 17;
            // 
            // поуважительнойDataGridViewCheckBoxColumn
            // 
            this.поуважительнойDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.поуважительнойDataGridViewCheckBoxColumn.DataPropertyName = "По_уважительной";
            this.поуважительнойDataGridViewCheckBoxColumn.HeaderText = "По уважительной";
            this.поуважительнойDataGridViewCheckBoxColumn.Name = "поуважительнойDataGridViewCheckBoxColumn";
            this.поуважительнойDataGridViewCheckBoxColumn.ReadOnly = true;
            this.поуважительнойDataGridViewCheckBoxColumn.Width = 92;
            // 
            // кодпропускаDataGridViewTextBoxColumn
            // 
            this.кодпропускаDataGridViewTextBoxColumn.DataPropertyName = "Код_пропуска";
            this.кодпропускаDataGridViewTextBoxColumn.HeaderText = "Код_пропуска";
            this.кодпропускаDataGridViewTextBoxColumn.Name = "кодпропускаDataGridViewTextBoxColumn";
            this.кодпропускаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодпропускаDataGridViewTextBoxColumn.Visible = false;
            // 
            // предметDataGridViewTextBoxColumn1
            // 
            this.предметDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.предметDataGridViewTextBoxColumn1.DataPropertyName = "Предмет";
            this.предметDataGridViewTextBoxColumn1.HeaderText = "Предмет";
            this.предметDataGridViewTextBoxColumn1.Name = "предметDataGridViewTextBoxColumn1";
            this.предметDataGridViewTextBoxColumn1.ReadOnly = true;
            this.предметDataGridViewTextBoxColumn1.Width = 77;
            // 
            // датаDataGridViewTextBoxColumn1
            // 
            this.датаDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаDataGridViewTextBoxColumn1.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn1.Name = "датаDataGridViewTextBoxColumn1";
            this.датаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // кодучащегосяDataGridViewTextBoxColumn3
            // 
            this.кодучащегосяDataGridViewTextBoxColumn3.DataPropertyName = "Код_учащегося";
            this.кодучащегосяDataGridViewTextBoxColumn3.HeaderText = "Код_учащегося";
            this.кодучащегосяDataGridViewTextBoxColumn3.Name = "кодучащегосяDataGridViewTextBoxColumn3";
            this.кодучащегосяDataGridViewTextBoxColumn3.ReadOnly = true;
            this.кодучащегосяDataGridViewTextBoxColumn3.Visible = false;
            // 
            // skipsMenu
            // 
            this.skipsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportMarksBTN,
            this.toolStripSeparator1,
            this.deleteSkipBTN});
            this.skipsMenu.Name = "groupsMenu";
            this.skipsMenu.Size = new System.Drawing.Size(236, 54);
            // 
            // deleteSkipBTN
            // 
            this.deleteSkipBTN.Name = "deleteSkipBTN";
            this.deleteSkipBTN.Size = new System.Drawing.Size(235, 22);
            this.deleteSkipBTN.Text = "Удалить выбранный элемент";
            this.deleteSkipBTN.Click += new System.EventHandler(this.deleteSkipBTN_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.infoFilterPanel);
            this.infoPanel.Controls.Add(this.infoList);
            this.infoPanel.Location = new System.Drawing.Point(4, 22);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1057, 717);
            this.infoPanel.TabIndex = 4;
            this.infoPanel.Text = "Статистика успеваемости";
            this.infoPanel.UseVisualStyleBackColor = true;
            // 
            // infoFilterPanel
            // 
            this.infoFilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoFilterPanel.Controls.Add(this.filterInfoAvrDL);
            this.infoFilterPanel.Controls.Add(this.filterInfoAvrNUD);
            this.infoFilterPanel.Controls.Add(this.filterInfoBSkipsDL);
            this.infoFilterPanel.Controls.Add(this.filterInfoBSkipsNUD);
            this.infoFilterPanel.Controls.Add(this.filterInfoBSkipsCHB);
            this.infoFilterPanel.Controls.Add(this.filterInfoGSkipsDL);
            this.infoFilterPanel.Controls.Add(this.filterInfoGSkipsNUD);
            this.infoFilterPanel.Controls.Add(this.filterInfoGSkipsCHB);
            this.infoFilterPanel.Controls.Add(this.filterInfoSkipsDL);
            this.infoFilterPanel.Controls.Add(this.filterInfoSkipsNUD);
            this.infoFilterPanel.Controls.Add(this.filterInfoSkipsCHB);
            this.infoFilterPanel.Controls.Add(this.filterInfoAvrCHB);
            this.infoFilterPanel.Controls.Add(this.filterInfoCourseDL);
            this.infoFilterPanel.Controls.Add(this.filterInfoProfessionCHB);
            this.infoFilterPanel.Controls.Add(this.filterInfoProfessionCB);
            this.infoFilterPanel.Controls.Add(this.filterInfoCourseNUD);
            this.infoFilterPanel.Controls.Add(this.filterInfoCourseCHB);
            this.infoFilterPanel.Controls.Add(this.filterInfoApplyBTN);
            this.infoFilterPanel.Controls.Add(this.filterInfoAddressCHB);
            this.infoFilterPanel.Controls.Add(this.filterInfoAddressTB);
            this.infoFilterPanel.Controls.Add(this.filterInfoNameTB);
            this.infoFilterPanel.Controls.Add(this.filterInfoNameCHB);
            this.infoFilterPanel.Controls.Add(this.filterInfoGroupNameTB);
            this.infoFilterPanel.Controls.Add(this.filterInfoGroupNameCHB);
            this.infoFilterPanel.Location = new System.Drawing.Point(6, 6);
            this.infoFilterPanel.Name = "infoFilterPanel";
            this.infoFilterPanel.Size = new System.Drawing.Size(1045, 293);
            this.infoFilterPanel.TabIndex = 8;
            this.infoFilterPanel.TabStop = false;
            this.infoFilterPanel.Text = "Фильтр";
            // 
            // filterInfoAvrDL
            // 
            this.filterInfoAvrDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterInfoAvrDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterInfoAvrDL.FormattingEnabled = true;
            this.filterInfoAvrDL.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<",
            "<="});
            this.filterInfoAvrDL.Location = new System.Drawing.Point(978, 41);
            this.filterInfoAvrDL.Name = "filterInfoAvrDL";
            this.filterInfoAvrDL.Size = new System.Drawing.Size(61, 21);
            this.filterInfoAvrDL.TabIndex = 46;
            // 
            // filterInfoAvrNUD
            // 
            this.filterInfoAvrNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterInfoAvrNUD.DecimalPlaces = 2;
            this.filterInfoAvrNUD.Location = new System.Drawing.Point(449, 42);
            this.filterInfoAvrNUD.Name = "filterInfoAvrNUD";
            this.filterInfoAvrNUD.Size = new System.Drawing.Size(523, 20);
            this.filterInfoAvrNUD.TabIndex = 45;
            // 
            // filterInfoBSkipsDL
            // 
            this.filterInfoBSkipsDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterInfoBSkipsDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterInfoBSkipsDL.FormattingEnabled = true;
            this.filterInfoBSkipsDL.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<",
            "<="});
            this.filterInfoBSkipsDL.Location = new System.Drawing.Point(978, 189);
            this.filterInfoBSkipsDL.Name = "filterInfoBSkipsDL";
            this.filterInfoBSkipsDL.Size = new System.Drawing.Size(61, 21);
            this.filterInfoBSkipsDL.TabIndex = 44;
            // 
            // filterInfoBSkipsNUD
            // 
            this.filterInfoBSkipsNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterInfoBSkipsNUD.Location = new System.Drawing.Point(449, 189);
            this.filterInfoBSkipsNUD.Name = "filterInfoBSkipsNUD";
            this.filterInfoBSkipsNUD.Size = new System.Drawing.Size(523, 20);
            this.filterInfoBSkipsNUD.TabIndex = 42;
            // 
            // filterInfoBSkipsCHB
            // 
            this.filterInfoBSkipsCHB.AutoSize = true;
            this.filterInfoBSkipsCHB.Location = new System.Drawing.Point(449, 166);
            this.filterInfoBSkipsCHB.Name = "filterInfoBSkipsCHB";
            this.filterInfoBSkipsCHB.Size = new System.Drawing.Size(252, 17);
            this.filterInfoBSkipsCHB.TabIndex = 43;
            this.filterInfoBSkipsCHB.Text = "По количеству пропусков без уважительной";
            this.filterInfoBSkipsCHB.UseVisualStyleBackColor = true;
            // 
            // filterInfoGSkipsDL
            // 
            this.filterInfoGSkipsDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterInfoGSkipsDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterInfoGSkipsDL.FormattingEnabled = true;
            this.filterInfoGSkipsDL.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<",
            "<="});
            this.filterInfoGSkipsDL.Location = new System.Drawing.Point(978, 140);
            this.filterInfoGSkipsDL.Name = "filterInfoGSkipsDL";
            this.filterInfoGSkipsDL.Size = new System.Drawing.Size(61, 21);
            this.filterInfoGSkipsDL.TabIndex = 41;
            // 
            // filterInfoGSkipsNUD
            // 
            this.filterInfoGSkipsNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterInfoGSkipsNUD.Location = new System.Drawing.Point(449, 140);
            this.filterInfoGSkipsNUD.Name = "filterInfoGSkipsNUD";
            this.filterInfoGSkipsNUD.Size = new System.Drawing.Size(523, 20);
            this.filterInfoGSkipsNUD.TabIndex = 39;
            // 
            // filterInfoGSkipsCHB
            // 
            this.filterInfoGSkipsCHB.AutoSize = true;
            this.filterInfoGSkipsCHB.Location = new System.Drawing.Point(449, 117);
            this.filterInfoGSkipsCHB.Name = "filterInfoGSkipsCHB";
            this.filterInfoGSkipsCHB.Size = new System.Drawing.Size(246, 17);
            this.filterInfoGSkipsCHB.TabIndex = 40;
            this.filterInfoGSkipsCHB.Text = "По количеству пропусков по уважительной";
            this.filterInfoGSkipsCHB.UseVisualStyleBackColor = true;
            // 
            // filterInfoSkipsDL
            // 
            this.filterInfoSkipsDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterInfoSkipsDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterInfoSkipsDL.FormattingEnabled = true;
            this.filterInfoSkipsDL.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<",
            "<="});
            this.filterInfoSkipsDL.Location = new System.Drawing.Point(978, 91);
            this.filterInfoSkipsDL.Name = "filterInfoSkipsDL";
            this.filterInfoSkipsDL.Size = new System.Drawing.Size(61, 21);
            this.filterInfoSkipsDL.TabIndex = 36;
            // 
            // filterInfoSkipsNUD
            // 
            this.filterInfoSkipsNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterInfoSkipsNUD.Location = new System.Drawing.Point(449, 91);
            this.filterInfoSkipsNUD.Name = "filterInfoSkipsNUD";
            this.filterInfoSkipsNUD.Size = new System.Drawing.Size(523, 20);
            this.filterInfoSkipsNUD.TabIndex = 32;
            // 
            // filterInfoSkipsCHB
            // 
            this.filterInfoSkipsCHB.AutoSize = true;
            this.filterInfoSkipsCHB.Location = new System.Drawing.Point(449, 68);
            this.filterInfoSkipsCHB.Name = "filterInfoSkipsCHB";
            this.filterInfoSkipsCHB.Size = new System.Drawing.Size(156, 17);
            this.filterInfoSkipsCHB.TabIndex = 33;
            this.filterInfoSkipsCHB.Text = "По количеству пропусков";
            this.filterInfoSkipsCHB.UseVisualStyleBackColor = true;
            // 
            // filterInfoAvrCHB
            // 
            this.filterInfoAvrCHB.AutoSize = true;
            this.filterInfoAvrCHB.Location = new System.Drawing.Point(449, 18);
            this.filterInfoAvrCHB.Name = "filterInfoAvrCHB";
            this.filterInfoAvrCHB.Size = new System.Drawing.Size(124, 17);
            this.filterInfoAvrCHB.TabIndex = 30;
            this.filterInfoAvrCHB.Text = "По среднему баллу";
            this.filterInfoAvrCHB.UseVisualStyleBackColor = true;
            // 
            // filterInfoCourseDL
            // 
            this.filterInfoCourseDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterInfoCourseDL.FormattingEnabled = true;
            this.filterInfoCourseDL.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<",
            "<="});
            this.filterInfoCourseDL.Location = new System.Drawing.Point(377, 187);
            this.filterInfoCourseDL.Name = "filterInfoCourseDL";
            this.filterInfoCourseDL.Size = new System.Drawing.Size(61, 21);
            this.filterInfoCourseDL.TabIndex = 27;
            // 
            // filterInfoProfessionCHB
            // 
            this.filterInfoProfessionCHB.AutoSize = true;
            this.filterInfoProfessionCHB.Location = new System.Drawing.Point(6, 214);
            this.filterInfoProfessionCHB.Name = "filterInfoProfessionCHB";
            this.filterInfoProfessionCHB.Size = new System.Drawing.Size(120, 17);
            this.filterInfoProfessionCHB.TabIndex = 26;
            this.filterInfoProfessionCHB.Text = "По специальности";
            this.filterInfoProfessionCHB.UseVisualStyleBackColor = true;
            // 
            // filterInfoProfessionCB
            // 
            this.filterInfoProfessionCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterInfoProfessionCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filterInfoProfessionCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterInfoProfessionCB.FormattingEnabled = true;
            this.filterInfoProfessionCB.Items.AddRange(new object[] {
            "Программное обеспечение информационных технологий",
            "Бухгалтерский учёт",
            "Коммерческая деятельность",
            "Правоведение",
            "Экономика и организация производства",
            "Банковское дело"});
            this.filterInfoProfessionCB.Location = new System.Drawing.Point(6, 237);
            this.filterInfoProfessionCB.Name = "filterInfoProfessionCB";
            this.filterInfoProfessionCB.Size = new System.Drawing.Size(1033, 21);
            this.filterInfoProfessionCB.TabIndex = 25;
            // 
            // filterInfoCourseNUD
            // 
            this.filterInfoCourseNUD.Location = new System.Drawing.Point(6, 188);
            this.filterInfoCourseNUD.Name = "filterInfoCourseNUD";
            this.filterInfoCourseNUD.Size = new System.Drawing.Size(365, 20);
            this.filterInfoCourseNUD.TabIndex = 23;
            // 
            // filterInfoCourseCHB
            // 
            this.filterInfoCourseCHB.AutoSize = true;
            this.filterInfoCourseCHB.Location = new System.Drawing.Point(6, 165);
            this.filterInfoCourseCHB.Name = "filterInfoCourseCHB";
            this.filterInfoCourseCHB.Size = new System.Drawing.Size(71, 17);
            this.filterInfoCourseCHB.TabIndex = 24;
            this.filterInfoCourseCHB.Text = "По курсу";
            this.filterInfoCourseCHB.UseVisualStyleBackColor = true;
            // 
            // filterInfoApplyBTN
            // 
            this.filterInfoApplyBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterInfoApplyBTN.Location = new System.Drawing.Point(6, 264);
            this.filterInfoApplyBTN.Name = "filterInfoApplyBTN";
            this.filterInfoApplyBTN.Size = new System.Drawing.Size(1033, 23);
            this.filterInfoApplyBTN.TabIndex = 22;
            this.filterInfoApplyBTN.Text = "Применить фильтр!";
            this.filterInfoApplyBTN.UseVisualStyleBackColor = true;
            this.filterInfoApplyBTN.Click += new System.EventHandler(this.filterInfoApplyBTN_Click);
            // 
            // filterInfoAddressCHB
            // 
            this.filterInfoAddressCHB.AutoSize = true;
            this.filterInfoAddressCHB.Location = new System.Drawing.Point(6, 68);
            this.filterInfoAddressCHB.Name = "filterInfoAddressCHB";
            this.filterInfoAddressCHB.Size = new System.Drawing.Size(78, 17);
            this.filterInfoAddressCHB.TabIndex = 21;
            this.filterInfoAddressCHB.Text = "По адресу";
            this.filterInfoAddressCHB.UseVisualStyleBackColor = true;
            // 
            // filterInfoAddressTB
            // 
            this.filterInfoAddressTB.Location = new System.Drawing.Point(6, 91);
            this.filterInfoAddressTB.Name = "filterInfoAddressTB";
            this.filterInfoAddressTB.Size = new System.Drawing.Size(432, 20);
            this.filterInfoAddressTB.TabIndex = 19;
            // 
            // filterInfoNameTB
            // 
            this.filterInfoNameTB.Location = new System.Drawing.Point(6, 42);
            this.filterInfoNameTB.Name = "filterInfoNameTB";
            this.filterInfoNameTB.Size = new System.Drawing.Size(432, 20);
            this.filterInfoNameTB.TabIndex = 18;
            // 
            // filterInfoNameCHB
            // 
            this.filterInfoNameCHB.AutoSize = true;
            this.filterInfoNameCHB.Location = new System.Drawing.Point(6, 19);
            this.filterInfoNameCHB.Name = "filterInfoNameCHB";
            this.filterInfoNameCHB.Size = new System.Drawing.Size(70, 17);
            this.filterInfoNameCHB.TabIndex = 20;
            this.filterInfoNameCHB.Text = "По ФИО";
            this.filterInfoNameCHB.UseVisualStyleBackColor = true;
            // 
            // filterInfoGroupNameTB
            // 
            this.filterInfoGroupNameTB.Location = new System.Drawing.Point(6, 139);
            this.filterInfoGroupNameTB.Name = "filterInfoGroupNameTB";
            this.filterInfoGroupNameTB.Size = new System.Drawing.Size(432, 20);
            this.filterInfoGroupNameTB.TabIndex = 37;
            // 
            // filterInfoGroupNameCHB
            // 
            this.filterInfoGroupNameCHB.AutoSize = true;
            this.filterInfoGroupNameCHB.Location = new System.Drawing.Point(6, 116);
            this.filterInfoGroupNameCHB.Name = "filterInfoGroupNameCHB";
            this.filterInfoGroupNameCHB.Size = new System.Drawing.Size(132, 17);
            this.filterInfoGroupNameCHB.TabIndex = 38;
            this.filterInfoGroupNameCHB.Text = "По названию группы";
            this.filterInfoGroupNameCHB.UseVisualStyleBackColor = true;
            // 
            // infoList
            // 
            this.infoList.AllowUserToAddRows = false;
            this.infoList.AllowUserToDeleteRows = false;
            this.infoList.AllowUserToResizeRows = false;
            this.infoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoList.AutoGenerateColumns = false;
            this.infoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.infoList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.infoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn2,
            this.адресDataGridViewTextBoxColumn2,
            this.кодучащегосяDataGridViewTextBoxColumn4,
            this.кодгруппыDataGridViewTextBoxColumn3,
            this.colGroupName,
            this.colCours,
            this.colProfession,
            this.colAverageMark,
            this.colSkips,
            this.colSkipsBad});
            this.infoList.ContextMenuStrip = this.infoMenu;
            this.infoList.DataSource = this.учащиесяBindingSource;
            this.infoList.Location = new System.Drawing.Point(6, 305);
            this.infoList.MultiSelect = false;
            this.infoList.Name = "infoList";
            this.infoList.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.infoList.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.infoList.RowHeadersVisible = false;
            this.infoList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.infoList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.infoList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.infoList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.infoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.infoList.Size = new System.Drawing.Size(1045, 404);
            this.infoList.TabIndex = 7;
            // 
            // фИОDataGridViewTextBoxColumn2
            // 
            this.фИОDataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn2.Name = "фИОDataGridViewTextBoxColumn2";
            this.фИОDataGridViewTextBoxColumn2.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // адресDataGridViewTextBoxColumn2
            // 
            this.адресDataGridViewTextBoxColumn2.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn2.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn2.Name = "адресDataGridViewTextBoxColumn2";
            this.адресDataGridViewTextBoxColumn2.ReadOnly = true;
            this.адресDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // кодучащегосяDataGridViewTextBoxColumn4
            // 
            this.кодучащегосяDataGridViewTextBoxColumn4.DataPropertyName = "Код_учащегося";
            this.кодучащегосяDataGridViewTextBoxColumn4.HeaderText = "Код_учащегося";
            this.кодучащегосяDataGridViewTextBoxColumn4.Name = "кодучащегосяDataGridViewTextBoxColumn4";
            this.кодучащегосяDataGridViewTextBoxColumn4.ReadOnly = true;
            this.кодучащегосяDataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.кодучащегосяDataGridViewTextBoxColumn4.Visible = false;
            // 
            // кодгруппыDataGridViewTextBoxColumn3
            // 
            this.кодгруппыDataGridViewTextBoxColumn3.DataPropertyName = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn3.HeaderText = "Код_группы";
            this.кодгруппыDataGridViewTextBoxColumn3.Name = "кодгруппыDataGridViewTextBoxColumn3";
            this.кодгруппыDataGridViewTextBoxColumn3.ReadOnly = true;
            this.кодгруппыDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.кодгруппыDataGridViewTextBoxColumn3.Visible = false;
            // 
            // colGroupName
            // 
            this.colGroupName.HeaderText = "Название группы";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.ReadOnly = true;
            this.colGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCours
            // 
            this.colCours.HeaderText = "Курс";
            this.colCours.Name = "colCours";
            this.colCours.ReadOnly = true;
            this.colCours.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colProfession
            // 
            this.colProfession.HeaderText = "Специальность";
            this.colProfession.Name = "colProfession";
            this.colProfession.ReadOnly = true;
            this.colProfession.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAverageMark
            // 
            this.colAverageMark.HeaderText = "Средний балл";
            this.colAverageMark.Name = "colAverageMark";
            this.colAverageMark.ReadOnly = true;
            this.colAverageMark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSkips
            // 
            this.colSkips.HeaderText = "Пропусков по уважительной";
            this.colSkips.Name = "colSkips";
            this.colSkips.ReadOnly = true;
            this.colSkips.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSkipsBad
            // 
            this.colSkipsBad.HeaderText = "Пропусков без уважительной";
            this.colSkipsBad.Name = "colSkipsBad";
            this.colSkipsBad.ReadOnly = true;
            this.colSkipsBad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // учащиесяBindingSource
            // 
            this.учащиесяBindingSource.DataMember = "Учащиеся";
            this.учащиесяBindingSource.DataSource = this.dbDataSet;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsBTN,
            this.helpBTN});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // settingsBTN
            // 
            this.settingsBTN.Name = "settingsBTN";
            this.settingsBTN.Size = new System.Drawing.Size(79, 20);
            this.settingsBTN.Text = "Настройки";
            this.settingsBTN.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // helpBTN
            // 
            this.helpBTN.Name = "helpBTN";
            this.helpBTN.Size = new System.Drawing.Size(65, 20);
            this.helpBTN.Text = "Справка";
            this.helpBTN.Click += new System.EventHandler(this.helpBTN_Click);
            // 
            // группыTableAdapter
            // 
            this.группыTableAdapter.ClearBeforeFill = true;
            // 
            // учащиесяTableAdapter
            // 
            this.учащиесяTableAdapter.ClearBeforeFill = true;
            // 
            // оценкиTableAdapter
            // 
            this.оценкиTableAdapter.ClearBeforeFill = true;
            // 
            // пропускиTableAdapter
            // 
            this.пропускиTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(232, 6);
            // 
            // exporMarksBTN
            // 
            this.exporMarksBTN.Name = "exporMarksBTN";
            this.exporMarksBTN.Size = new System.Drawing.Size(236, 22);
            this.exporMarksBTN.Text = "Экспорт в Excel";
            this.exporMarksBTN.Click += new System.EventHandler(this.exporMarksBTN_Click);
            // 
            // exportMarksBTN
            // 
            this.exportMarksBTN.Name = "exportMarksBTN";
            this.exportMarksBTN.Size = new System.Drawing.Size(235, 22);
            this.exportMarksBTN.Text = "Экспорт в Excel";
            this.exportMarksBTN.Click += new System.EventHandler(this.exportMarksBTN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // infoMenu
            // 
            this.infoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportInfoBTN});
            this.infoMenu.Name = "groupsMenu";
            this.infoMenu.Size = new System.Drawing.Size(158, 48);
            // 
            // exportInfoBTN
            // 
            this.exportInfoBTN.Name = "exportInfoBTN";
            this.exportInfoBTN.Size = new System.Drawing.Size(157, 22);
            this.exportInfoBTN.Text = "Экспорт в Excel";
            this.exportInfoBTN.Click += new System.EventHandler(this.exportInfoBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 770);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для ведения статистического  учета успеваемости учащихся";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.groupsPanel.ResumeLayout(false);
            this.groupsTabControl.ResumeLayout(false);
            this.groupsEditPanel.ResumeLayout(false);
            this.groupsEditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupECourseNUD)).EndInit();
            this.groupsAddPanel.ResumeLayout(false);
            this.groupsAddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupACourseNUD)).EndInit();
            this.groupsFilterPanel.ResumeLayout(false);
            this.groupsFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterGroupCourseNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsList)).EndInit();
            this.groupsMenu.ResumeLayout(false);
            this.studentsPanel.ResumeLayout(false);
            this.studentsTabControl.ResumeLayout(false);
            this.studentsEditPanel.ResumeLayout(false);
            this.studentsEditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.группыУчащиесяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource1)).EndInit();
            this.studentsAddPanel.ResumeLayout(false);
            this.studentsAddPanel.PerformLayout();
            this.studentsFilterPanel.ResumeLayout(false);
            this.studentsFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGroupsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsList)).EndInit();
            this.studentsMenu.ResumeLayout(false);
            this.marksPanel.ResumeLayout(false);
            this.marksTabControl.ResumeLayout(false);
            this.marksEditPanel.ResumeLayout(false);
            this.marksEditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учащиесяОценкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыУчащиесяBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksEValueNUD)).EndInit();
            this.marksAddPanel.ResumeLayout(false);
            this.marksAddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksAValueNUD)).EndInit();
            this.marksFilterPanel.ResumeLayout(false);
            this.marksFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterMarksValueNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksStudentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksList)).EndInit();
            this.marksMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marksGroupsList)).EndInit();
            this.skipsPanel.ResumeLayout(false);
            this.skipsTabControl.ResumeLayout(false);
            this.skipsEditPanel.ResumeLayout(false);
            this.skipsEditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учащиесяПропускиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыУчащиесяBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource3)).EndInit();
            this.skipsAddPanel.ResumeLayout(false);
            this.skipsAddPanel.PerformLayout();
            this.skipsFilterPanel.ResumeLayout(false);
            this.skipsFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skipsGroupsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipsStudentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipsList)).EndInit();
            this.skipsMenu.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoFilterPanel.ResumeLayout(false);
            this.infoFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterInfoAvrNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterInfoBSkipsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterInfoGSkipsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterInfoSkipsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterInfoCourseNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учащиесяBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.infoMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainMenu;
        private System.Windows.Forms.TabPage groupsPanel;
        private System.Windows.Forms.TabPage studentsPanel;
        private System.Windows.Forms.TabPage marksPanel;
        private System.Windows.Forms.TabPage skipsPanel;
        private System.Windows.Forms.DataGridView groupsList;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource группыBindingSource;
        private dbDataSetTableAdapters.ГруппыTableAdapter группыTableAdapter;
        private System.Windows.Forms.GroupBox groupsFilterPanel;
        private System.Windows.Forms.TabControl groupsTabControl;
        private System.Windows.Forms.TabPage groupsEditPanel;
        private System.Windows.Forms.TabPage groupsAddPanel;
        private System.Windows.Forms.Button groupsSaveBTN;
        private System.Windows.Forms.ComboBox groupEProfessionCB;
        private System.Windows.Forms.Label groupEProfessionLBL;
        private System.Windows.Forms.DateTimePicker groupEDateTP;
        private System.Windows.Forms.Label groupEDateLBL;
        private System.Windows.Forms.NumericUpDown groupECourseNUD;
        private System.Windows.Forms.Label groupECourseLBL;
        private System.Windows.Forms.TextBox groupENameTB;
        private System.Windows.Forms.Label groupENameLBL;
        private System.Windows.Forms.Button groupsAddBTN;
        private System.Windows.Forms.ComboBox groupAProfessionCB;
        private System.Windows.Forms.Label groupAProfessionLBL;
        private System.Windows.Forms.DateTimePicker groupADateTP;
        private System.Windows.Forms.Label groupADateLBL;
        private System.Windows.Forms.NumericUpDown groupACourseNUD;
        private System.Windows.Forms.Label groupACourseLBL;
        private System.Windows.Forms.TextBox groupANameTB;
        private System.Windows.Forms.Label groupANameLBL;
        private System.Windows.Forms.DataGridView studentsList;
        private System.Windows.Forms.BindingSource группыBindingSource1;
        private System.Windows.Forms.TabControl studentsTabControl;
        private System.Windows.Forms.TabPage studentsEditPanel;
        private System.Windows.Forms.Button studentsSaveBTN;
        private System.Windows.Forms.TextBox studentsENameTB;
        private System.Windows.Forms.Label studentsENameLBL;
        private System.Windows.Forms.TabPage studentsAddPanel;
        private System.Windows.Forms.GroupBox studentsFilterPanel;
        private System.Windows.Forms.BindingSource группыУчащиесяBindingSource;
        private dbDataSetTableAdapters.УчащиесяTableAdapter учащиесяTableAdapter;
        private System.Windows.Forms.TextBox studentsEAddressTB;
        private System.Windows.Forms.Label studentsEAddressLBL;
        private System.Windows.Forms.TextBox studentsAAddressTB;
        private System.Windows.Forms.Label studentsAAddressLBL;
        private System.Windows.Forms.Button studentsAddBTN;
        private System.Windows.Forms.TextBox studentsANameTB;
        private System.Windows.Forms.Label studentsANameLBL;
        private System.Windows.Forms.DataGridView marksList;
        private System.Windows.Forms.GroupBox marksFilterPanel;
        private System.Windows.Forms.DataGridView marksStudentsList;
        private System.Windows.Forms.TabControl marksTabControl;
        private System.Windows.Forms.TabPage marksEditPanel;
        private System.Windows.Forms.Button marksSaveBTN;
        private System.Windows.Forms.ComboBox marksELessonCB;
        private System.Windows.Forms.Label marksELessonLBL;
        private System.Windows.Forms.DateTimePicker marksEDateTP;
        private System.Windows.Forms.Label marksEDateLBL;
        private System.Windows.Forms.NumericUpDown marksEValueNUD;
        private System.Windows.Forms.Label marksEValueLBL;
        private System.Windows.Forms.TabPage marksAddPanel;
        private System.Windows.Forms.Button marksAddBTN;
        private System.Windows.Forms.ComboBox marksALessonCB;
        private System.Windows.Forms.Label marksALessonLBL;
        private System.Windows.Forms.DateTimePicker marksADateTP;
        private System.Windows.Forms.Label marksADateLBL;
        private System.Windows.Forms.NumericUpDown marksAValueNUD;
        private System.Windows.Forms.Label marksAValueLBL;
        private System.Windows.Forms.TabControl skipsTabControl;
        private System.Windows.Forms.TabPage skipsEditPanel;
        private System.Windows.Forms.Button skipsSaveBTN;
        private System.Windows.Forms.ComboBox skipsELessonCB;
        private System.Windows.Forms.Label skipsELessonLBL;
        private System.Windows.Forms.DateTimePicker skipsEDateTP;
        private System.Windows.Forms.Label skipsEDateLBL;
        private System.Windows.Forms.TabPage skipsAddPanel;
        private System.Windows.Forms.GroupBox skipsFilterPanel;
        private System.Windows.Forms.CheckBox skipsEReasonCHB;
        private System.Windows.Forms.CheckBox skipsAReasonCHB;
        private System.Windows.Forms.Button skipsAddBTN;
        private System.Windows.Forms.ComboBox skipsALessonCB;
        private System.Windows.Forms.Label skipsALessonLBL;
        private System.Windows.Forms.DateTimePicker skipsADateTP;
        private System.Windows.Forms.Label skipsADateLBL;
        private System.Windows.Forms.ComboBox filterGroupProfessionCB;
        private System.Windows.Forms.NumericUpDown filterGroupCourseNUD;
        private System.Windows.Forms.TextBox filterGroupNameTB;
        private System.Windows.Forms.TextBox filterStudentsAddressTB;
        private System.Windows.Forms.TextBox filterStudentsNameTB;
        private System.Windows.Forms.ComboBox filterMarksLessonTB;
        private System.Windows.Forms.NumericUpDown filterMarksValueNUD;
        private System.Windows.Forms.ComboBox filterSkipsLessonCB;
        private System.Windows.Forms.CheckBox filterGroupDateCHB;
        private System.Windows.Forms.DateTimePicker filterGroupDateTP;
        private System.Windows.Forms.CheckBox filterGroupProfessionCHB;
        private System.Windows.Forms.CheckBox filterGroupNameCHB;
        private System.Windows.Forms.CheckBox filterGroupCourseCHB;
        private System.Windows.Forms.CheckBox filterStudentsAddressCHB;
        private System.Windows.Forms.CheckBox filterStudentsNameCHB;
        private System.Windows.Forms.CheckBox filterMarksDateCHB;
        private System.Windows.Forms.CheckBox filterMarksLessonCHB;
        private System.Windows.Forms.CheckBox filterMarksValueCHB;
        private System.Windows.Forms.DateTimePicker filterMarksDateTP;
        private System.Windows.Forms.CheckBox filterSkipsLessonCHB;
        private System.Windows.Forms.CheckBox filterSkipsDateCHB;
        private System.Windows.Forms.DateTimePicker filterSkipsDateTP;
        private System.Windows.Forms.ComboBox filterGroupDateDL;
        private System.Windows.Forms.ComboBox filterGroupCourseDL;
        private System.Windows.Forms.ComboBox filterMarksValueDL;
        private System.Windows.Forms.ComboBox filterMarksDateDL;
        private System.Windows.Forms.ComboBox filterSkipsDateDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиегруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодгруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn курсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаоснованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView studentsGroupsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView marksGroupsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource группыBindingSource2;
        private System.Windows.Forms.BindingSource группыУчащиесяBindingSource1;
        private System.Windows.Forms.BindingSource учащиесяОценкиBindingSource;
        private dbDataSetTableAdapters.ОценкиTableAdapter оценкиTableAdapter;
        private System.Windows.Forms.DataGridView skipsGroupsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.BindingSource группыBindingSource3;
        private System.Windows.Forms.DataGridView skipsStudentsList;
        private System.Windows.Forms.BindingSource группыУчащиесяBindingSource2;
        private System.Windows.Forms.DataGridView skipsList;
        private System.Windows.Forms.BindingSource учащиесяПропускиBindingSource;
        private dbDataSetTableAdapters.ПропускиTableAdapter пропускиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодучащегосяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодгруппыDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодучащегосяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодгруппыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодоценкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодучащегосяDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn предметDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewCheckBoxColumn поуважительнойDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпропускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предметDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодучащегосяDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button filterGroupsApplyBTN;
        private System.Windows.Forms.Button filterStudentsApplyBTN;
        private System.Windows.Forms.Button filterMarksApplyBTN;
        private System.Windows.Forms.Button filterSkipsApplyBTN;
        private System.Windows.Forms.ContextMenuStrip groupsMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupBTN;
        private System.Windows.Forms.ContextMenuStrip studentsMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentBTN;
        private System.Windows.Forms.ContextMenuStrip marksMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMarkBTN;
        private System.Windows.Forms.ContextMenuStrip skipsMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteSkipBTN;
        private System.Windows.Forms.ToolStripMenuItem marksAvgBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TabPage infoPanel;
        private System.Windows.Forms.DataGridView infoList;
        private System.Windows.Forms.BindingSource учащиесяBindingSource;
        private System.Windows.Forms.GroupBox infoFilterPanel;
        private System.Windows.Forms.ComboBox filterInfoAvrDL;
        private System.Windows.Forms.NumericUpDown filterInfoAvrNUD;
        private System.Windows.Forms.ComboBox filterInfoBSkipsDL;
        private System.Windows.Forms.NumericUpDown filterInfoBSkipsNUD;
        private System.Windows.Forms.CheckBox filterInfoBSkipsCHB;
        private System.Windows.Forms.ComboBox filterInfoGSkipsDL;
        private System.Windows.Forms.NumericUpDown filterInfoGSkipsNUD;
        private System.Windows.Forms.CheckBox filterInfoGSkipsCHB;
        private System.Windows.Forms.ComboBox filterInfoSkipsDL;
        private System.Windows.Forms.NumericUpDown filterInfoSkipsNUD;
        private System.Windows.Forms.CheckBox filterInfoSkipsCHB;
        private System.Windows.Forms.CheckBox filterInfoAvrCHB;
        private System.Windows.Forms.ComboBox filterInfoCourseDL;
        private System.Windows.Forms.CheckBox filterInfoProfessionCHB;
        private System.Windows.Forms.ComboBox filterInfoProfessionCB;
        private System.Windows.Forms.NumericUpDown filterInfoCourseNUD;
        private System.Windows.Forms.CheckBox filterInfoCourseCHB;
        private System.Windows.Forms.Button filterInfoApplyBTN;
        private System.Windows.Forms.CheckBox filterInfoAddressCHB;
        private System.Windows.Forms.TextBox filterInfoAddressTB;
        private System.Windows.Forms.TextBox filterInfoNameTB;
        private System.Windows.Forms.CheckBox filterInfoNameCHB;
        private System.Windows.Forms.TextBox filterInfoGroupNameTB;
        private System.Windows.Forms.CheckBox filterInfoGroupNameCHB;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодучащегосяDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодгруппыDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCours;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfession;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverageMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSkips;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSkipsBad;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsBTN;
        private System.Windows.Forms.ToolStripMenuItem helpBTN;
        private System.Windows.Forms.ToolStripMenuItem exportGroupBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportStudentBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exporMarksBTN;
        private System.Windows.Forms.ToolStripMenuItem exportMarksBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip infoMenu;
        private System.Windows.Forms.ToolStripMenuItem exportInfoBTN;

    }
}