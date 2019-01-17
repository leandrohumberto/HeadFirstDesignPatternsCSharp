using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;

namespace VSMDecoratorPattern.Components
{
    public class TextBoxComponent : ITextBoxComponent
    {
        protected readonly TextBox TextBox;

        private string _text = "";
        public string Text
        {
            get { return _text; }

            set
            {
                if (!EqualityComparer<string>.Default.Equals(_text, value))
                {
                    _text = value;
                    OnPropertyChanged("Text");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public TextBoxComponent(TextBox textBox)
        {
            TextBox = textBox;
            TextBox.TextChanged += TextBoxTextChanged;
        }

        private void TextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            Text = TextBox.Text;
        }
    }
}
