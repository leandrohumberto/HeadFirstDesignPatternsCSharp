using System.Collections.Generic;
using System.ComponentModel;
using VSMDecoratorPattern.Components;

namespace VSMDecoratorPattern.Decorators
{
    public abstract class TextBoxDecorator : ITextBoxComponent
    {
        protected readonly ITextBoxComponent _component;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Text
        {
            get { return _component.Text; }

            set
            {
                if (!EqualityComparer<string>.Default.Equals(_component.Text, value))
                {
                    _component.Text = value;
                    OnPropertyChanged("Text");
                }
            }
        }

        public TextBoxDecorator(ITextBoxComponent component)
        {
            _component = component;
        }

        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
