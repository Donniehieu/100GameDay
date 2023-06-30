namespace Facebook.Unity.Windows
{
	internal interface IWindowsFacebookImplementation : IWindowsFacebook, IPayFacebook, IFacebook, IFacebookWindows, IWindowsFacebookResultHandler, IFacebookResultHandler
	{
		void Tick();

		void Deinit();
	}
}
