using MvvmCross.Core.ViewModels;

namespace Demo.Core.ViewModels
{
    public class VectorViewModel : MvxViewModel
    {
        #region Bindable Properties

        int _size = 300;
        public int Size
        {
            get { return _size; }
            set { SetProperty(ref _size, value); }
        }

        #endregion
    }
}
