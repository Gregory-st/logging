using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseWorker.Context;
using DataBaseWorker.Repositores;
using DataBaseWorker.Entites.Models;
using DataBaseWorker.Entites;

namespace Учебная_часть
{
    public partial class Lich_delo_studenta : Form
    {
        private readonly OleDataBaseContext context;
        private readonly RepositoryPersonalFileActive repository;
        private readonly RepositoryPerson repositoryPerson;
        private readonly RepositoryGroup repositoryGroup;
        private readonly RepositoryBaseAdmission repositoryBaseAdmission;
        public Lich_delo_studenta()
        {
            InitializeComponent();
        }
        public Lich_delo_studenta(OleDataBaseContext context)
        {
            InitializeComponent();
            this.context = context;
            repository = new RepositoryPersonalFileActive(context);
            repositoryPerson = new RepositoryPerson(context);
            repositoryGroup = new RepositoryGroup(context);
            repositoryBaseAdmission = new RepositoryBaseAdmission(context);

            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 1;

            DataGridViewCheckBoxColumn box = new DataGridViewCheckBoxColumn();
            box.ReadOnly = true;
            dataGridView1.Columns.Add(box);
            dataGridView1.Rows[0].Cells[1].Value = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Glavn a = new Glavn();
            a.Show();
            this.Hide();
        }

        private void SetView()
        {
            ModelPersonalFileActive[] actives = repository.Get();
            DataGridViewCheckBoxColumn box = new DataGridViewCheckBoxColumn();
            box.ReadOnly = true;
            box.Name = "Перевод";
            dataGridView1.Rows.Clear();

            dataGridView1.RowCount = actives.Length;
            dataGridView1.ColumnCount = 8;

            dataGridView1.Columns[0].Name = "ФИО";
            dataGridView1.Columns[1].Name = "Дата рождения";
            dataGridView1.Columns[2].Name = "Курс";
            dataGridView1.Columns[3].Name = "Класс";
            dataGridView1.Columns[4].Name = "Дата поступления";
            dataGridView1.Columns[5].Name = "Специальность";
            dataGridView1.Columns[6].Name = "База поступления";
            dataGridView1.Columns[7].Name = "Группа";

            dataGridView1.Columns.Add(box);

            ModelPerson person;
            EntityBaseAdmission admission;
            ModelGroup group;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                person = repositoryPerson.GetByID(actives[i].IdPerson);
                admission = repositoryBaseAdmission.GetById(actives[i].IdBaseAdmission);
                group = repositoryGroup.GetById(actives[i].IdGroup);

                dataGridView1.Rows[i].Cells[0].Value = person.GetFullName();
                dataGridView1.Rows[i].Cells[1].Value = person.GetDateOfBorn();
                dataGridView1.Rows[i].Cells[2].Value = actives[i].Course;
                dataGridView1.Rows[i].Cells[3].Value = actives[i].BaseClass;
                dataGridView1.Rows[i].Cells[4].Value = actives[i].GetDate();
                dataGridView1.Rows[i].Cells[5].Value = actives[i].Speciality;
                dataGridView1.Rows[i].Cells[6].Value = admission.Name;
                dataGridView1.Rows[i].Cells[7].Value = group.GetTitle();
                dataGridView1.Rows[i].Cells[8].Value = actives[i].IdTransfer != -1;            
            }


        }
    }
}
