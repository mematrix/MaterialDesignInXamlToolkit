﻿using System.Windows;
using MaterialDesignColors.WpfExample.Domain;

namespace MaterialDesignColors.WpfExample
{
    public partial class Trees
    {
        public Trees() => InitializeComponent();

        public TreesViewModel ViewModel => DataContext as TreesViewModel;

        /// <summary>
        /// TreesView's SelectedItem is read-only. Hence we can't bind it. There is a way to obtain a selected item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (ViewModel == null)
                return;

            ViewModel.SelectedItem = e.NewValue;
        }
    }
}
