namespace Facebook.Unity
{
	internal class PayResult : ResultBase, IPayResult, IResult
	{
		internal const long CancelPaymentFlowCode = 1383010L;

		public long ErrorCode => 0L;

		internal PayResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
