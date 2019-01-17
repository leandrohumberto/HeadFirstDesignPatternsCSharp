using System.ComponentModel;
using System.Windows.Controls;

namespace VSMDecoratorPattern.Components
{
    public interface ITextBoxComponent : INotifyPropertyChanged
    {
        string Text { get; set; }
    }
}
