using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using DatePickerCustomization;
using DatePickerCustomization.Droid;
using Android.Content;

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]

namespace DatePickerCustomization.Droid
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        public CustomDatePickerRenderer(Context context) : base(context) {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            var picker = e.NewElement;

            // Control is Android.Widget.EditText
            if (Control != null)
            {
                Control.Typeface = Android.Graphics.Typeface.SansSerif;
                Control.TextSize = 30;
                var pickerStyle = new Style(typeof(DatePicker))
                {
                    Setters = {
                     new Setter {Property = DatePicker.FontFamilyProperty, Value = "architectsdaughter.ttf"},
                     new Setter { Property = DatePicker.TextColorProperty, Value="#bfff00"}
                }
                };
                picker.Style = pickerStyle;
            }
            //picker.FontFamily = "font/architectsdaughter.ttf";
        }
    }
}
