using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using Demo.Android.Helpers;
using Demo.Core.ViewModels;

namespace Demo.Android.Views
{
    [MvxFragment(typeof(MainContainerViewModel), Resource.Id.content_frame, true)]
    [Register(nameof(RasterFragment))]
    public class RasterFragment : BaseFragment<RasterViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.layout_fragment_raster;
        protected override string ToolbarText => Resources.GetString(Resource.String.toolbar_raster);

        ImageView _rasterImage;
        SeekBar _sizeSeekBar;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            _rasterImage = view.FindViewById<ImageView>(Resource.Id.raster_image_view);
            _sizeSeekBar = view.FindViewById<SeekBar>(Resource.Id.size_seek_bar);

            var screenWidth = Resources.DisplayMetrics.WidthPixels;
            _sizeSeekBar.Max = screenWidth - (int)(Resources.GetDimension(Resource.Dimension.side_padding) * 2);

            Bind();

            return view;
        }

        void Bind()
        {
            var bindingSet = this.CreateBindingSet<RasterFragment, RasterViewModel>();

            bindingSet.Bind(_rasterImage).For(AndroidConstants.SIZE_TARGET_BINDING_KEY).To(vm => vm.Size);
            bindingSet.Bind(_sizeSeekBar).To(vm => vm.Size);

            bindingSet.Apply();
        }
    }
}
