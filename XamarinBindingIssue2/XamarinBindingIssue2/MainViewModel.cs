using System;
using System.Waf.Foundation;

namespace XamarinBindingIssue2
{
    public class MainViewModel : Model
    {
        private TimeSpan? time = TimeSpan.FromSeconds(42);

        public TimeSpan? Time
        {
            get => time;
            set => SetProperty(ref time, value);
        }
    }
}
