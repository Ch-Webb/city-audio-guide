﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView : ContentView
    {
        public PopupView()
        {
            InitializeComponent();
        }
    }
}