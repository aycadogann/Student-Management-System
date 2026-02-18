using StundentManagement.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_FirstName.Text) || string.IsNullOrEmpty(txt_LastName.Text))
                {
                    throw new Exception("İsim alanları boş bırakılamaz!");
                }
                if (num_MidTerm.Value == 0 && num_Final.Value == 0)
                {
                    throw new Exception("Lütfen notları girdiğinizden emin olun!");

                }

                Student student = new Student();
                student.FirstName = txt_FirstName.Text;
                student.LastName = txt_LastName.Text;
                student.MidTermGrade = Convert.ToDouble(num_MidTerm.Value);
                student.FinalGrade = Convert.ToDouble(num_Final.Value);
                double average = GradeCalculator.OrtalamaHesapla(student.MidTermGrade, student.FinalGrade);
                string letterGrade = GradeCalculator.HarfNotuGetir(average);
                bool status = GradeCalculator.GectiMi(average);
               
                lbl_Average.Text = average.ToString();
                lbl_LetterGrade.Text = letterGrade.ToString();
                if (status)
                {
                    lbl_Status.Text = "Geçti";
                    lbl_Status.ForeColor = Color.Green;
                }
                else
                {
                    lbl_Status.Text = "Kaldı";
                    lbl_Status.ForeColor = Color.Red;
                }
                dgw_List.Rows.Add(student.FirstName, student.LastName, average, letterGrade);

                txt_FirstName.Clear();
                txt_LastName.Clear();
                num_MidTerm.Value = 0;
                num_Final.Value = 0;
                txt_FirstName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}
