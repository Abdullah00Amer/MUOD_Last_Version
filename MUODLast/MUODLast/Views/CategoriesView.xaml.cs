﻿using MUODLast.Models;
using MUODLast.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MUODLast.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesView : ContentPage
    {
        public CategoriesView()
        {
            InitializeComponent();
        }

        async void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var category = e.CurrentSelection.FirstOrDefault() as Category;
            if(category == null)
                return;

            await Navigation.PushAsync(new CategoryDrinksView(category));

            ((CollectionView)sender).SelectedItem = null;

        }
    }
}