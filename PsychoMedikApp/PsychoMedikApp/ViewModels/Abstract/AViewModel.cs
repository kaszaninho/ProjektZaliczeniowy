﻿using Xamarin.Forms;

namespace PsychoMedikApp.ViewModels.Abstract
{
    public class AViewModel<T> where T : class
    {
        public T DataStore => DependencyService.Get<T>();
    }
}