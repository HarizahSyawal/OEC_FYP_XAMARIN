using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.CommunityToolkit;

namespace AIO.IDOS3.Client.Mobile.Views.Universities
{
    public partial class StudyProgram : ContentPage
    {
        public StudyProgram()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public ObservableCollection<Faculty> Faculties { get => GetFaculties(); }

        private ObservableCollection<Faculty> GetFaculties()
        {
            return new ObservableCollection<Faculty>
            {
                new Faculty { Name = "All Things Xamarin", Duration = "07:30 UTC - 11:30 UTC", Color = "#B96CBD", Date = new DateTime(2020, 3, 23),
                    Speakers = new ObservableCollection<FacultyDetails>{ new FacultyDetails { Name = "Maddy Leger", Time = "07:30" }, new FacultyDetails { Name = "David Ortinau", Time = "08:30" }, new FacultyDetails { Name = "Gerald Versluis", Time = "10:30" } } },

                new Faculty { Name = "Visualize Your Data", Duration = "07:30 UTC - 11:30 UTC", Color = "#49A24D", Date = new DateTime(2020, 3, 24),
                    Speakers = new ObservableCollection<FacultyDetails>{ new FacultyDetails { Name = "Maddy Leger", Time = "07:30" }, new FacultyDetails { Name = "David Ortinau", Time = "08:30" }, new FacultyDetails { Name = "Gerald Versluis", Time = "10:30" } } },

                new Faculty { Name = "Testing Your Xamarin Apps", Duration = "07:30 UTC - 11:30 UTC", Color = "#FDA838", Date = new DateTime(2020, 3, 25),
                    Speakers = new ObservableCollection<FacultyDetails>{ new FacultyDetails { Name = "Maddy Leger", Time = "07:30" }, new FacultyDetails { Name = "David Ortinau", Time = "08:30" }, new FacultyDetails { Name = "Gerald Versluis", Time = "10:30" } } },

                new Faculty { Name = "Xamarin Productivity to the Max", Duration = "07:30 UTC - 11:30 UTC", Color = "#F75355", Date = new DateTime(2020, 3, 26),
                    Speakers = new ObservableCollection<FacultyDetails>{ new FacultyDetails { Name = "Maddy Leger", Time = "07:30" }, new FacultyDetails { Name = "David Ortinau", Time = "08:30" }, new FacultyDetails { Name = "Gerald Versluis", Time = "10:30" } } },

                new Faculty { Name = "All Things Xamarin.Forms Shell", Duration = "07:30 UTC - 11:30 UTC", Color = "#00C6AE", Date = new DateTime(2020, 3, 27),
                    Speakers = new ObservableCollection<FacultyDetails>{ new FacultyDetails { Name = "Maddy Leger", Time = "07:30" }, new FacultyDetails { Name = "David Ortinau", Time = "08:30" }, new FacultyDetails { Name = "Gerald Versluis", Time = "10:30" } } },

                new Faculty { Name = "Building Beautiful Apps", Duration = "07:30 UTC - 11:30 UTC", Color = "#455399", Date = new DateTime(2020, 3, 28),
                    Speakers = new ObservableCollection<FacultyDetails>{ new FacultyDetails { Name = "Maddy Leger", Time = "07:30" }, new FacultyDetails { Name = "David Ortinau", Time = "08:30" }, new FacultyDetails { Name = "Gerald Versluis", Time = "10:30" } } }
            };
        }
    }


    public class Faculty
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public DateTime Date { get; set; }
        public ObservableCollection<FacultyDetails> Speakers { get; set; }
        public string Color { get; set; }
    }

    public class FacultyDetails
    {
        public string Name { get; set; }
        public string Time { get; set; }
    }
}