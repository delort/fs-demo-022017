using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using Demo.Core.ViewModels;

namespace Demo.Android.Views
{
    [MvxFragment(typeof(MainContainerViewModel), Resource.Id.content_frame)]
    [Register(nameof(HomeFragment))]
    public class HomeFragment : BaseFragment<HomeViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.layout_fragment_home;
        protected override string ToolbarText => Resources.GetString(Resource.String.toolbar_home);

        Button _vectorButton, _rasterButton;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);
            
            _vectorButton = view.FindViewById<Button>(Resource.Id.button_vector);
            _rasterButton = view.FindViewById<Button>(Resource.Id.button_raster);

            Bind();

            return view;
        }

        void Bind()
        {
            var bindingSet = this.CreateBindingSet<HomeFragment, HomeViewModel>();
            
            bindingSet.Bind(_vectorButton).To(vm => vm.VectorCommand);
            bindingSet.Bind(_rasterButton).To(vm => vm.RasterCommand);

            bindingSet.Apply();
        }
    }
}
