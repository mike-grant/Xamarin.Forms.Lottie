using Lottie.Forms;
using System;

namespace Xamarin.Forms.Lottie.Controls
{
    public class AnimatedCheckbox : AnimationView, IDisposable
    {
        public AnimatedCheckbox()
        {
            Animation = "tickbox.json";
            OnClick += Checkbox_OnClick;
        }

        public static BindableProperty IsCheckedProperty = BindableProperty.Create(
            nameof(IsChecked), typeof(bool), typeof(AnimatedCheckbox), defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: IsCheckedChanged);

        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        public void Dispose()
        {
            OnClick -= Checkbox_OnClick;
        }

        private static void IsCheckedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is AnimatedCheckbox cb))
                return;

            if ((bool) newValue)
            {
                cb.Play();
            }
            else
            {
                cb.PlayFrameSegment(0, 1);
                cb.IsPlaying = false;
                //cb.Reset();
            }
        }

        private void Reset()
        {
            Animation = null;
            Animation = "tickbox.json";
        }

        private void Checkbox_OnClick(object sender, EventArgs e)
        {
            IsChecked = !IsChecked;
        }
    }
}
