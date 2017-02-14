using MvvmCross.Core.ViewModels;

namespace Demo.Core.ViewModels
{
    public class MemoryDemoViewModel : MvxViewModel
    {
        #region Bindable Properties

        int _size = 100;
        public int Size
        {
            get { return _size; }
            set { SetProperty(ref _size, value); }
        }

        #endregion
    }
}
