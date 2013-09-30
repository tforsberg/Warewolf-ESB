using System.Activities.Presentation.Model;
using System.Collections.Generic;
using System.Windows;
using Dev2.Activities.Designers2.Core;
using Dev2.Common;
using Dev2.Converters.DateAndTime;

namespace Dev2.Activities.Designers2.DateTime
{
    public class DateTimeDesignerViewModel : ActivityDesignerViewModel
    {
        public DateTimeDesignerViewModel(ModelItem modelItem)
            : base(modelItem)
        {
            AddTitleBarHelpToggle();
            TimeModifierTypes = new List<string>(DateTimeFormatter.TimeModifierTypes);
        }

        public List<string> TimeModifierTypes { get; private set; }

        public string Dev2DefaultDateTime { get { return GlobalConstants.Dev2CustomDefaultDateTimeFormat; } }

        public string SelectedTimeModifierType
        {
            get { return (string)GetValue(SelectedTimeModifierTypeProperty); }
            set { SetValue(SelectedTimeModifierTypeProperty, value); }
        }

        public static readonly DependencyProperty SelectedTimeModifierTypeProperty =
            DependencyProperty.Register("SelectedTimeModifierType", typeof(string), typeof(DateTimeDesignerViewModel), new PropertyMetadata(null, OnSelectedTimeModifierTypeChanged));

        static void OnSelectedTimeModifierTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var viewModel = (DateTimeDesignerViewModel)d;
            var value = e.NewValue as string;

            if(string.IsNullOrWhiteSpace(value))
            {
                viewModel.TimeModifierAmountDisplay = value;
            }
            viewModel.TimeModifierType = value;
        }

        public string DateTime { get { return GetProperty<string>(); } set { SetProperty(value); } }
        public string InputFormat { get { return GetProperty<string>(); } set { SetProperty(value); } }
        public string TimeModifierType { get { return GetProperty<string>(); } set { SetProperty(value); } }
        public string TimeModifierAmountDisplay { get { return GetProperty<string>(); } set { SetProperty(value); } }
        public string OutputFormat { get { return GetProperty<string>(); } set { SetProperty(value); } }
        public string Result { get { return GetProperty<string>(); } set { SetProperty(value); } }

        public override void Validate()
        {
        }
    }
}