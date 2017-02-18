namespace Demo.Core.ViewModels
{
    public class RasterViewModel : BaseViewModel
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
