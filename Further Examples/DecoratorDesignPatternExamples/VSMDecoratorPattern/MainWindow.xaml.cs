using System.Windows;

namespace VSMDecoratorPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var textBoxComponent = new Components.TextBoxComponent(InputField);
            var pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
            var validationTextBox =
              new Decorators.ValidateTextBoxDecorator(textBoxComponent, pattern);
            InputPanel.DataContext = validationTextBox;
        }
    }
}
