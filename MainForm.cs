using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Ocenki
{
    public partial class MainForm : Form
    {
        AuthForm authForm;
        bool rw;
        public MainForm(AuthForm authForm, bool rw = false)
        {
            InitializeComponent();
            this.authForm = authForm;
            this.rw = rw;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.пропускиTableAdapter.Fill(this.dbDataSet.Пропуски);
            this.оценкиTableAdapter.Fill(this.dbDataSet.Оценки);
            this.учащиесяTableAdapter.Fill(this.dbDataSet.Учащиеся);
            this.группыTableAdapter.Fill(this.dbDataSet.Группы);

            filterGroupCourseDL.SelectedIndex = 0;
            filterGroupDateDL.SelectedIndex = 0;
            filterMarksValueDL.SelectedIndex = 0;
            filterMarksDateDL.SelectedIndex = 0;
            filterSkipsDateDL.SelectedIndex = 0;
            filterInfoCourseDL.SelectedIndex = 0;
            filterInfoAvrDL.SelectedIndex = 0;
            filterInfoSkipsDL.SelectedIndex = 0;
            filterInfoGSkipsDL.SelectedIndex = 0;
            filterInfoBSkipsDL.SelectedIndex = 0;

            if (!rw)
            {
                groupsTabControl.Enabled = false;
                deleteGroupBTN.Enabled = false;
                groupsAddBTN.Enabled = false;
                groupsSaveBTN.Enabled = false;

                studentsTabControl.Enabled = false;
                deleteStudentBTN.Enabled = false;
                studentsSaveBTN.Enabled = false;
                studentsAddBTN.Enabled = false;

                marksTabControl.Enabled = false;
                deleteMarkBTN.Enabled = false;
                marksAddBTN.Enabled = false;
                marksSaveBTN.Enabled = false;

                skipsTabControl.Enabled = false;
                deleteSkipBTN.Enabled = false;
                skipsAddBTN.Enabled = false;
                skipsSaveBTN.Enabled = false;

                settingsBTN.Enabled = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            authForm.Show();
        }

        private void saveGroupsChanges()
        {
            группыBindingSource.EndEdit();
            группыTableAdapter.Update(dbDataSet);
            dbDataSet.AcceptChanges();
            группыTableAdapter.Fill(dbDataSet.Группы);
        }

        private void saveStudentsChanges()
        {
            группыУчащиесяBindingSource.EndEdit();
            учащиесяTableAdapter.Update(dbDataSet);
            dbDataSet.AcceptChanges();
            учащиесяTableAdapter.Fill(dbDataSet.Учащиеся);
        }

        private void saveMarksChanges()
        {
            учащиесяОценкиBindingSource.EndEdit();
            оценкиTableAdapter.Update(dbDataSet);
            dbDataSet.AcceptChanges();
            оценкиTableAdapter.Fill(dbDataSet.Оценки);
        }

        private void saveSkipsChanges()
        {
            учащиесяПропускиBindingSource.EndEdit();
            пропускиTableAdapter.Update(dbDataSet);
            dbDataSet.AcceptChanges();
            пропускиTableAdapter.Fill(dbDataSet.Пропуски);
        }

        private void groupsAddBTN_Click(object sender, EventArgs e)
        {
            dbDataSet.Группы.AddГруппыRow(groupANameTB.Text, Convert.ToInt32(groupACourseNUD.Value), groupADateTP.Value.Date, groupAProfessionCB.Text);
            saveGroupsChanges();
        }

        private void groupsSaveBTN_Click(object sender, EventArgs e)
        {
            if (groupsList.SelectedRows.Count > 0)
            {
                foreach (Control c in groupsEditPanel.Controls)
                {
                    foreach (Binding b in c.DataBindings)
                    {
                        b.WriteValue();
                    }
                }
                saveGroupsChanges();
            }
        }

        private void studentsAddBTN_Click(object sender, EventArgs e)
        {
            if (studentsGroupsList.SelectedRows.Count > 0)
            {
                dbDataSet.Учащиеся.AddУчащиесяRow(studentsANameTB.Text, dbDataSet.Группы.FindByКод_группы(int.Parse(studentsGroupsList.SelectedRows[0].Cells[1].Value.ToString())), studentsAAddressTB.Text);
                saveStudentsChanges();
            }
        }

        private void studentsSaveBTN_Click(object sender, EventArgs e)
        {
            if (studentsList.SelectedRows.Count > 0)
            {
                foreach (Control c in studentsEditPanel.Controls)
                {
                    foreach (Binding b in c.DataBindings)
                    {
                        b.WriteValue();
                    }
                }
                saveStudentsChanges();
            }
        }

        private void marksAddBTN_Click(object sender, EventArgs e)
        {
            if (marksList.SelectedRows.Count > 0)
            {
                for (int i = 0; i < marksList.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(marksList[4, i].Value.ToString()).Date == marksADateTP.Value.Date && marksList[3, i].Value.ToString() == marksALessonCB.Text)
                    {
                        MessageBox.Show("Оценка в такой день и по такому предмету уже стоит, увы!");
                        return;
                    }

                }
            }
            if (marksStudentsList.SelectedRows.Count > 0)
            {
                dbDataSet.Оценки.AddОценкиRow(dbDataSet.Учащиеся.FindByКод_учащегося(int.Parse(marksStudentsList.SelectedRows[0].Cells[1].Value.ToString())), Convert.ToInt32(marksAValueNUD.Value), marksALessonCB.Text, marksADateTP.Value.Date);
                saveMarksChanges();
            }
        }

        private void marksSaveBTN_Click(object sender, EventArgs e)
        {
            if (marksList.SelectedRows.Count > 0)
            {
                for (int i = 0; i < marksList.Rows.Count; i++)
                {
                    if (marksList[1, i].Value.ToString() != marksList.SelectedRows[0].Cells[1].Value.ToString())
                    {
                        if (Convert.ToDateTime(marksList[4, i].Value.ToString()).Date == marksEDateTP.Value.Date && marksList[3, i].Value.ToString() == marksELessonCB.Text)
                        {
                            MessageBox.Show("Оценка в такой день и по такому предмету уже стоит, увы!");
                            return;

                        }
                    }

                }
                foreach (Control c in marksEditPanel.Controls)
                {
                    foreach (Binding b in c.DataBindings)
                    {
                        b.WriteValue();
                    }
                }
                saveMarksChanges();
            }
        }

        private void skipsAddBTN_Click(object sender, EventArgs e)
        {

            if (skipsList.SelectedRows.Count > 0)
            {
                for (int i = 0; i < skipsList.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(skipsList[3, i].Value.ToString()).Date == skipsADateTP.Value.Date && skipsList[2, i].Value.ToString() == skipsALessonCB.Text)
                    {
                        MessageBox.Show("Пропуск в такой день и по такому предмету уже стоит, увы!");
                        return;
                    }
                }
            }
            if (skipsStudentsList.SelectedRows.Count > 0)
            {
                dbDataSet.Пропуски.AddПропускиRow(skipsADateTP.Value.Date, skipsALessonCB.Text, skipsAReasonCHB.Checked, dbDataSet.Учащиеся.FindByКод_учащегося(int.Parse(skipsStudentsList.SelectedRows[0].Cells[1].Value.ToString())));
                saveSkipsChanges();
            }
        }

        private void skipsSaveBTN_Click(object sender, EventArgs e)
        {
            if (skipsList.SelectedRows.Count > 0)
            {
                for (int i = 0; i < skipsList.Rows.Count; i++)
                {
                    if (skipsList[1, i].Value.ToString() != skipsList.SelectedRows[0].Cells[1].Value.ToString())
                    {
                        if (Convert.ToDateTime(skipsList[3, i].Value.ToString()).Date == skipsADateTP.Value.Date && skipsList[2, i].Value.ToString() == skipsALessonCB.Text)
                        {
                            MessageBox.Show("Пропуск в такой день и по такому предмету уже стоит, увы!");
                            return;

                        }
                    }

                }
                foreach (Control c in skipsEditPanel.Controls)
                {
                    foreach (Binding b in c.DataBindings)
                    {
                        b.WriteValue();
                    }
                }
                saveSkipsChanges();
            }
        }

        private bool cmpStr<T>(string s, T c1, T c2) where T : IComparable<T>
        {
            int res = c1.CompareTo(c2);

            switch (s)
            {
                case ">":
                    return res > 0;
                case ">=":
                    return res >= 0;
                case "=":
                    return res == 0;
                case "<=":
                    return res <= 0;
                case "<":
                    return res < 0;
                default:
                    throw new ArgumentException();
            }
        }

        private void filterGroupsApplyBTN_Click(object sender, EventArgs e)
        {
            группыBindingSource.SuspendBinding();
            for (int i = 0; i < groupsList.Rows.Count; i++)
            {
                groupsList.Rows[i].Visible = true;
                if (filterGroupNameCHB.Checked && groupsList[0, i].Value.ToString().IndexOf(filterGroupNameTB.Text) < 0)
                {
                    groupsList.Rows[i].Visible = false;
                    continue;
                }
                if (filterGroupCourseCHB.Checked && !cmpStr<int>(filterGroupCourseDL.Text, Convert.ToInt32(groupsList[2, i].Value.ToString()), Convert.ToInt32(filterGroupCourseNUD.Value)))
                {
                    groupsList.Rows[i].Visible = false;
                    continue;
                }
                if (filterGroupDateCHB.Checked && !cmpStr<DateTime>(filterGroupDateDL.Text, Convert.ToDateTime(groupsList[3, i].Value.ToString()).Date, Convert.ToDateTime(filterGroupDateTP.Value).Date))
                {
                    groupsList.Rows[i].Visible = false;
                    continue;
                }
                if (filterGroupProfessionCHB.Checked && groupsList[4, i].Value.ToString().IndexOf(filterGroupProfessionCB.Text) < 0)
                {
                    groupsList.Rows[i].Visible = false;
                    continue;
                }
            }
            группыBindingSource.ResumeBinding();
        }

        private void filterStudentsApplyBTN_Click(object sender, EventArgs e)
        {

            группыУчащиесяBindingSource.SuspendBinding();
            for (int i = 0; i < studentsList.Rows.Count; i++)
            {
                studentsList.Rows[i].Visible = true;
                if (filterStudentsNameCHB.Checked && studentsList[0, i].Value.ToString().IndexOf(filterStudentsNameTB.Text) < 0)
                {
                    studentsList.Rows[i].Visible = false;
                    continue;
                }
                if (filterStudentsAddressCHB.Checked && studentsList[3, i].Value.ToString().IndexOf(filterStudentsAddressTB.Text) < 0)
                {
                    studentsList.Rows[i].Visible = false;
                    continue;
                }
            }
            группыУчащиесяBindingSource.ResumeBinding();
        }

        private void filterMarksApplyBTN_Click(object sender, EventArgs e)
        {
            учащиесяОценкиBindingSource.SuspendBinding();
            for (int i = 0; i < marksList.Rows.Count; i++)
            {
                marksList.Rows[i].Visible = true;
                if (filterMarksValueCHB.Checked && !cmpStr<int>(filterMarksValueDL.Text, Convert.ToInt32(marksList[0, i].Value.ToString()), Convert.ToInt32(filterMarksValueNUD.Value)))
                {
                    marksList.Rows[i].Visible = false;
                    continue;
                }
                if (filterMarksDateCHB.Checked && !cmpStr<DateTime>(filterMarksDateDL.Text, Convert.ToDateTime(marksList[4, i].Value.ToString()).Date, Convert.ToDateTime(filterMarksDateTP.Value).Date))
                {
                    marksList.Rows[i].Visible = false;
                    continue;
                }
                if (filterMarksLessonCHB.Checked && marksList[3, i].Value.ToString().IndexOf(filterMarksLessonTB.Text) < 0)
                {
                    marksList.Rows[i].Visible = false;
                    continue;
                }
            }
            учащиесяОценкиBindingSource.ResumeBinding();
        }

        private void filterSkipsApplyBTN_Click(object sender, EventArgs e)
        {
            учащиесяПропускиBindingSource.SuspendBinding();
            for (int i = 0; i < skipsList.Rows.Count; i++)
            {
                skipsList.Rows[i].Visible = true;
                if (filterSkipsDateCHB.Checked && !cmpStr<DateTime>(filterSkipsDateDL.Text, Convert.ToDateTime(skipsList[3, i].Value.ToString()).Date, Convert.ToDateTime(filterSkipsDateTP.Value).Date))
                {
                    skipsList.Rows[i].Visible = false;
                    continue;
                }
                if (filterSkipsLessonCHB.Checked && skipsList[2, i].Value.ToString().IndexOf(filterSkipsLessonCB.Text) < 0)
                {
                    skipsList.Rows[i].Visible = false;
                    continue;
                }
            }
            учащиесяПропускиBindingSource.ResumeBinding();
        }

        private void deleteGroupBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?\nЭто действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in groupsList.SelectedRows)
                {
                    группыBindingSource.RemoveAt(item.Index);
                }
                saveGroupsChanges();
            }
        }

        private void deleteStudentBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?\nЭто действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in studentsList.SelectedRows)
                {
                    группыУчащиесяBindingSource.RemoveAt(item.Index);
                }
                saveStudentsChanges();
            }
        }

        private void deleteMarkBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?\nЭто действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in marksList.SelectedRows)
                {
                    учащиесяОценкиBindingSource.RemoveAt(item.Index);
                }
                saveMarksChanges();
            }
        }

        private void deleteSkipBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент?\nЭто действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in skipsList.SelectedRows)
                {
                    учащиесяПропускиBindingSource.RemoveAt(item.Index);
                }
                saveSkipsChanges();
            }
        }

        private void marksAvgBTN_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int sum = 0;
            for (int i = 0; i < marksList.Rows.Count; i++)
            {
                if (marksList.Rows[i].Visible)
                {
                    counter++;
                    sum += int.Parse(marksList[0, i].Value.ToString());
                }
            }
            MessageBox.Show("Всего значений: " + counter.ToString() + "\nСумма: " + sum.ToString() + "\nСреднее значение: " + (Convert.ToDouble(sum) / Convert.ToDouble(counter)).ToString("N"));
        }

        private void refreshInfo()
        {
            for (int i = 0; i < infoList.Rows.Count; i++)
            {
                infoList.Rows[i].Visible = true;
                dbDataSet.ГруппыRow groupInfo = dbDataSet.Группы.FindByКод_группы(Convert.ToInt32(infoList[3, i].Value.ToString()));
                infoList[4, i].Value = groupInfo.Название_группы;
                infoList[5, i].Value = groupInfo.Курс.ToString();
                infoList[6, i].Value = groupInfo.Специальность;
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.dbConnectionString);
                conn.Open();
                OleDbCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = "SELECT * FROM Оценки WHERE Код_учащегося = " + infoList[2, i].Value.ToString();
                var dataReader = myCommand.ExecuteReader();
                int sum = 0, cnt = 0;
                while (dataReader.Read())
                {
                    cnt++;
                    sum += int.Parse(dataReader["Оценка"].ToString());
                }
                dataReader.Close();

                myCommand.CommandText = "SELECT count(*) FROM Пропуски WHERE По_уважительной = true AND Код_учащегося = " + infoList[2, i].Value.ToString();
                int gcnt = int.Parse(myCommand.ExecuteScalar().ToString());
                myCommand.CommandText = "SELECT count(*) FROM Пропуски WHERE По_уважительной = false AND Код_учащегося = " + infoList[2, i].Value.ToString();
                int bcnt = int.Parse(myCommand.ExecuteScalar().ToString());
                dataReader.Close();
                conn.Close();
                infoList[7, i].Value = (Convert.ToDouble(sum) / Convert.ToDouble(cnt)).ToString("N");
                infoList[8, i].Value = gcnt.ToString();
                infoList[9, i].Value = bcnt.ToString();
            }
        }

        private void mainMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainMenu.SelectedTab == mainMenu.TabPages[4])
            {
                refreshInfo();
            }
        }

        private void filterInfoApplyBTN_Click(object sender, EventArgs e)
        {
            учащиесяBindingSource.SuspendBinding();
            for (int i = 0; i < infoList.Rows.Count; i++)
            {
                infoList.Rows[i].Visible = true;
                if (filterInfoNameCHB.Checked && infoList[0, i].Value.ToString().IndexOf(filterInfoNameTB.Text) < 0)
                {
                    infoList.Rows[i].Visible = false;
                    continue;
                }
                if (filterInfoAddressCHB.Checked && infoList[1, i].Value.ToString().IndexOf(filterInfoAddressTB.Text) < 0)
                {
                    studentsList.Rows[i].Visible = false;
                    continue;
                }
                if (filterInfoGroupNameCHB.Checked && infoList[4, i].Value.ToString().IndexOf(filterGroupNameTB.Text) < 0)
                {
                    infoList.Rows[i].Visible = false;
                    continue;
                }
                if (filterInfoCourseCHB.Checked && !cmpStr<int>(filterInfoCourseDL.Text, Convert.ToInt32(infoList[5, i].Value.ToString()), Convert.ToInt32(filterInfoCourseNUD.Value)))
                {
                    infoList.Rows[i].Visible = false;
                    continue;
                }
                if (filterInfoProfessionCHB.Checked && infoList[6, i].Value.ToString().IndexOf(filterInfoProfessionCB.Text) < 0)
                {
                    infoList.Rows[i].Visible = false;
                    continue;
                }
                if (filterInfoAvrCHB.Checked && !cmpStr<double>(filterInfoAvrDL.Text, Convert.ToDouble(infoList[7, i].Value.ToString()), Convert.ToDouble(filterInfoAvrNUD.Value)))
                {
                    infoList.Rows[i].Visible = false;
                    continue;
                }
                if (filterInfoSkipsCHB.Checked && !cmpStr<int>(filterInfoSkipsDL.Text, (Convert.ToInt32(infoList[8, i].Value.ToString()) + Convert.ToInt32(infoList[9, i].Value.ToString())), Convert.ToInt32(filterInfoSkipsNUD.Value)))
                {
                    infoList.Rows[i].Visible = false;
                    continue;
                }
                if (filterInfoGSkipsCHB.Checked && !cmpStr<int>(filterInfoGSkipsDL.Text, Convert.ToInt32(infoList[8, i].Value.ToString()), Convert.ToInt32(filterInfoGSkipsNUD.Value)))
                {
                    infoList.Rows[i].Visible = false;
                    continue;
                }
                if (filterInfoBSkipsCHB.Checked && !cmpStr<int>(filterInfoBSkipsDL.Text, Convert.ToInt32(infoList[9, i].Value.ToString()), Convert.ToInt32(filterInfoBSkipsNUD.Value)))
                {
                    infoList.Rows[i].Visible = false;
                    continue;
                }
            }
            учащиесяBindingSource.ResumeBinding();
        }

        private void helpBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Справка.pdf");
            }
            catch
            {
                MessageBox.Show("Файл справки не найден!");
            }
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show();
            this.Hide();
        }

        private void exportToExcel(DataGridView dgv)
        {
            var dia = new System.Windows.Forms.SaveFileDialog();
            dia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dia.Filter = "Excel Worksheets (*.xlsx)|*.xlsx|xls file (*.xls)|*.xls|All files (*.*)|*.*";
            if (dia.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                Excel.Application excelapp = new Excel.Application();
                Excel.Workbook workbook = excelapp.Workbooks.Add();
                Excel.Worksheet worksheet = (Worksheet)workbook.ActiveSheet;

                int currentCol = 0;
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv.Columns[j].Visible)
                    {
                        worksheet.Rows[1].Columns[currentCol + 1] = dgv.Columns[j].HeaderText;
                    }
                    else
                    {
                        currentCol -= 1;
                    }
                    currentCol++;
                }

                int currentRow = 0;
                for (int i = 1; i < dgv.RowCount + 1; i++)
                {
                    currentRow++;
                    currentCol = 0;
                    for (int j = 1; j < dgv.ColumnCount + 1; j++)
                    {
                        currentCol++;
                        if (dgv.Rows[i - 1].Visible)
                        {
                            if (dgv.Columns[j - 1].Visible)
                            {
                                worksheet.Rows[currentRow + 1].Columns[currentCol] = dgv.Rows[i - 1].Cells[j - 1].Value;
                            }
                            else
                            {
                                currentCol -= 1;
                            }
                        }
                        else
                        {
                            currentRow -= 1;
                        }
                    }
                }

                excelapp.AlertBeforeOverwriting = false;
                workbook.SaveAs(dia.FileName);
                excelapp.Quit();
                MessageBox.Show("Экспорт прошёл успешно!");
            }
        }

        private void exportGroupBTN_Click(object sender, EventArgs e)
        {
            exportToExcel(groupsList);
        }

        private void exportStudentBTN_Click(object sender, EventArgs e)
        {
            exportToExcel(studentsList);
        }

        private void exporMarksBTN_Click(object sender, EventArgs e)
        {
            exportToExcel(marksList);
        }

        private void exportMarksBTN_Click(object sender, EventArgs e)
        {
            exportToExcel(marksList);
        }

        private void exportInfoBTN_Click(object sender, EventArgs e)
        {
            exportToExcel(infoList);
        }
    }
}
