using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Classes;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageDataGrid.xaml
    /// </summary>
    public partial class PageDataGrid : Page
    {
        public PageDataGrid()
        {
            InitializeComponent();
            ClassHelper.listStudents.Clear();
            ClassStudent student1 = new ClassStudent()
            {
                Id = 1,
                Name = "Ivan",
                LastName = "Chromov",
                Age = 18,
                Phone = "3442342353",
                Scholarship = 0.00,
            };
            ClassHelper.listStudents.Add(student1);
            ClassStudent student2 = new ClassStudent()
            {
                Id = 2,
                Name = "Ivan",
                LastName = "Ivanov",
                Age = 18,
                Phone = "35343423",
                Scholarship = 520.30,
            };
            ClassHelper.listStudents.Add(student2);
            ClassStudent student3 = new ClassStudent()
            {
                Id = 3,
                Name = "Andrey",
                LastName = "Molotov",
                Age = 17,
                Phone = "3543412343",
                Scholarship = 620.20,
            };
            ClassHelper.listStudents.Add(student3);
            ClassStudent student4 = new ClassStudent()
            {
                Id = 4,
                Name = "Aleksey",
                LastName = "Lopatin",
                Age = 18,
                Phone = "3442342353",
                Scholarship = 0.00,
            };
            ClassHelper.listStudents.Add(student4);
            ClassStudent student5 = new ClassStudent()
            {
                Id = 5,
                Name = "Ivan",
                LastName = "Volkov",
                Age = 18,
                Phone = "23423542",
                Scholarship = 2560.30,
            };
            ClassHelper.listStudents.Add(student5);
            //источник данных для DataGrid
            DtgStudents.ItemsSource = ClassHelper.listStudents;
        }

        private void txtSearchLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = txtSearchLastName.Text;
            if (search.Length > 0)
            {
                //поиск по начальным символам в любом регистре
                DtgStudents.ItemsSource = ClassHelper.listStudents.
                Where(x => x.LastName.ToLower().StartsWith(search.ToLower())).ToList();
            }
            else
            {
                DtgStudents.ItemsSource = ClassHelper.listStudents;
            }
        }

        private void cmbFiltrAge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = cmbFiltrAge.SelectedIndex;
            if (index == 0)
            {
                DtgStudents.ItemsSource = ClassHelper.listStudents;
            }
            else if(index == 1)
            {
                DtgStudents.ItemsSource = ClassHelper.listStudents.
                    Where(x => x.Age < 18);
            }
            else
            {
                DtgStudents.ItemsSource = ClassHelper.listStudents.
                    Where(x => x.Age >= 18);
            }
        }
    }
}
