using System.IO;
using System.Runtime.CompilerServices;

namespace Pathfinding.Ionic.BZip2
{
	internal class WorkItem
	{
		public int index;

		public MemoryStream ms;

		public int ordinal;

		public BitWriter bw;

		public BZip2Compressor Compressor
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public WorkItem(int ix, int blockSize)
		{
		}
	}
}
