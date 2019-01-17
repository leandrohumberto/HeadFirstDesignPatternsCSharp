using System.Collections.Generic;
using System.Text.RegularExpressions;
using VSMDecoratorPattern.Components;

namespace VSMDecoratorPattern.Decorators
{
    class ValidateTextBoxDecorator : TextBoxDecorator
    {
        private string _errorMesage;

        public string ErrorMessage
        {
            get { return _errorMesage; }
            set
            {
                if (!EqualityComparer<string>.Default.Equals(_errorMesage, value))
                {
                    _errorMesage = value;
                    OnPropertyChanged("ErrorMessage");
                }
            }
        }

        private string _regExPattern;

        public ValidateTextBoxDecorator(ITextBoxComponent component, string pattern) : base(component)
        {
            _regExPattern = pattern;
            component.PropertyChanged += ComponentOnPropertyChanged;
        }

        private void ComponentOnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Text))
            {
                Validate();
            }
        }

        private bool Validate()
        {
            if (!Regex.IsMatch(Text, _regExPattern))
            {
                ErrorMessage = "Validation failed.";
                return false;
            }

            ErrorMessage = string.Empty;
            return true;
        }
    }
}
