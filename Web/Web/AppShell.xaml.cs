﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Web
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }
    }
}