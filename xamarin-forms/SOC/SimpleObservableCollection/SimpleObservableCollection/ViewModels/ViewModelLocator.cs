using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleObservableCollection.ViewModels
{
    // Reference: https://github.com/suchithm/SampleAutoFacDI/blob/62ab6062d9a843050775d500bf962b025e0f06ff/SampleAutoFacDI/ViewModels/ViewModelLocator.cs

    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            AutofacContainer.Initialize();
        }

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();
    }
}
