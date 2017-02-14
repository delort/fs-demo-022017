using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using Demo.Android.Helpers;
using Demo.Core.ViewModels;

namespace Demo.Android.Views.Fragments
{
    [MvxFragment(typeof(MainContainerViewModel), Resource.Id.content_frame, true)]
    [Register(nameof(MemoryDemoFragment))]
    public class MemoryDemoFragment : BaseFragment<MemoryDemoViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.layout_fragment_memory;
        LinearLayout _linearLayout1, _linearLayout2, _linearLayout3, _linearLayout4, _linearLayout5, _linearLayout6, _linearLayout7, _linearLayout8, _linearLayout9;
        ImageView _vectorImage1, _vectorImage2, _vectorImage3, _vectorImage4, _vectorImage5, _vectorImage6, _vectorImage7, _vectorImage8, _vectorImage9;
        TextView _textviewMemoryUsage;
        SeekBar _sizeSeekBar;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            _linearLayout1 = view.FindViewById<LinearLayout>(Resource.Id.linear_layout_1);
            _linearLayout2 = view.FindViewById<LinearLayout>(Resource.Id.linear_layout_2);
            _linearLayout3 = view.FindViewById<LinearLayout>(Resource.Id.linear_layout_3);
            _linearLayout4 = view.FindViewById<LinearLayout>(Resource.Id.linear_layout_4);
            _linearLayout5 = view.FindViewById<LinearLayout>(Resource.Id.linear_layout_5);
            _linearLayout6 = view.FindViewById<LinearLayout>(Resource.Id.linear_layout_6);
            _linearLayout7 = view.FindViewById<LinearLayout>(Resource.Id.linear_layout_7);
            _linearLayout8 = view.FindViewById<LinearLayout>(Resource.Id.linear_layout_8);
            _linearLayout9 = view.FindViewById<LinearLayout>(Resource.Id.linear_layout_9);

            _vectorImage1 = view.FindViewById<ImageView>(Resource.Id.vector_image_view_1);
            _vectorImage2 = view.FindViewById<ImageView>(Resource.Id.vector_image_view_2);
            _vectorImage3 = view.FindViewById<ImageView>(Resource.Id.vector_image_view_3);
            _vectorImage4 = view.FindViewById<ImageView>(Resource.Id.vector_image_view_4);
            _vectorImage5 = view.FindViewById<ImageView>(Resource.Id.vector_image_view_5);
            _vectorImage6 = view.FindViewById<ImageView>(Resource.Id.vector_image_view_6);
            _vectorImage7 = view.FindViewById<ImageView>(Resource.Id.vector_image_view_7);
            _vectorImage8 = view.FindViewById<ImageView>(Resource.Id.vector_image_view_8);
            _vectorImage9 = view.FindViewById<ImageView>(Resource.Id.vector_image_view_9);
            _sizeSeekBar = view.FindViewById<SeekBar>(Resource.Id.size_seek_bar);
            _textviewMemoryUsage = view.FindViewById<TextView>(Resource.Id.textview_memory_usage);

            _sizeSeekBar.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) =>
            {
                if (e.FromUser)
                    UpdateMemoryUsage();
            };

            Bind();

            return view;
        }

        void Bind()
        {
            var bindingSet = this.CreateBindingSet<MemoryDemoFragment, MemoryDemoViewModel>();

            bindingSet.Bind(_linearLayout1).For(AndroidConstants.SIZE_TARGET_BINDING_KEY).To(vm => vm.Size);
            bindingSet.Bind(_vectorImage2).For(AndroidConstants.SIZE_TARGET_BINDING_KEY).To(vm => vm.Size);
            bindingSet.Bind(_vectorImage3).For(AndroidConstants.SIZE_TARGET_BINDING_KEY).To(vm => vm.Size);
            bindingSet.Bind(_vectorImage4).For(AndroidConstants.SIZE_TARGET_BINDING_KEY).To(vm => vm.Size);
            bindingSet.Bind(_vectorImage5).For(AndroidConstants.SIZE_TARGET_BINDING_KEY).To(vm => vm.Size);
            bindingSet.Bind(_vectorImage6).For(AndroidConstants.SIZE_TARGET_BINDING_KEY).To(vm => vm.Size);
            bindingSet.Bind(_vectorImage7).For(AndroidConstants.SIZE_TARGET_BINDING_KEY).To(vm => vm.Size);
            bindingSet.Bind(_vectorImage8).For(AndroidConstants.SIZE_TARGET_BINDING_KEY).To(vm => vm.Size);
            bindingSet.Bind(_vectorImage9).For(AndroidConstants.SIZE_TARGET_BINDING_KEY).To(vm => vm.Size);
            bindingSet.Bind(_sizeSeekBar).To(vm => vm.Size);

            bindingSet.Apply();
        }

        public override void OnResume()
        {
            base.OnResume();

            UpdateMemoryUsage();
        }

        void UpdateMemoryUsage()
        {
            var runtime = Runtime.GetRuntime();

            var usedMemory = (runtime.TotalMemory() - runtime.FreeMemory()) / 1024f / 1024f;

            _textviewMemoryUsage.Text = $"Used Memory: {usedMemory}MB";
        }
    }
}
