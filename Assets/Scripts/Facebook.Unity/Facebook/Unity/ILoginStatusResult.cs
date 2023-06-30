namespace Facebook.Unity
{
	public interface ILoginStatusResult : ILoginResult, IResult
	{
		bool Failed { get; }
	}
}
