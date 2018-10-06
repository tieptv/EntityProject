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
using System.Windows.Shapes;

namespace Sales.Account
{
    /// <summary>
    /// Interaction logic for AccountList.xaml
    /// </summary>
    public partial class AccountList : Window
    {
        public AccountList()
        {
            InitializeComponent();
            lvaccount.SizeChanged += LV_SizeChanged;
            account_tranObj.SizeChanged += LV_SizeChanged1;
            AccountVM vm = new AccountVM();
            this.DataContext = vm;
        }

        private void lvaccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvaccount.ScrollIntoView(lvaccount.SelectedItem);
        }
        void LV_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var newWidth = lvaccount.ActualWidth / GridView1.Columns.Count;
            foreach (var column in GridView1.Columns)
            {
                column.Width = newWidth;
            }
        }
        void LV_SizeChanged1(object sender, SizeChangedEventArgs e)
        {
            var newWidth = account_tranObj.ActualWidth / GridView2.Columns.Count;
            foreach (var column in GridView2.Columns)
            {
                column.Width = newWidth;
            }
        }
    }
}
