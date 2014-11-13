using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamlDemoCommon.Annotations;

namespace XamlDemoCommon.ViewModels
{
    public class VmBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
