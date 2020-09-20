using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CodeCapture
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutUs : ContentPage
    {
        public string description;
        public AboutUs()
        {
            InitializeComponent();

            description = "CodeCapture is a cross-platform app that aims to assist remote learning experiences in Computer Science for students without computers by taking code from paper to mobile. CodeCapture has the functionality to extract code (C++, Java, JavaScript, or Python) from images of handwritten text and then allow the user to edit, compile, and share the result via email/SMS. We also have various lessons on C++ (more languages coming soon) to assist with students' Computer Science education especially in times like these, where the lockdown and pandemic have kept students away from school.";
            aboutUs.Text = description;
        }

        private async void returnButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}