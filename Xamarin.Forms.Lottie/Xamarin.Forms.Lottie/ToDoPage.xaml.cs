using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Lottie.ViewModels;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Lottie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoPage : ContentPage
    {
        public ToDoPage()
        {
            InitializeComponent();
            BindingContext = new ToDoViewModel();
        }
    }
}