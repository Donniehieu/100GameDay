using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pathfinding.Poly2Tri
{
	public class ConstrainedPointSet : PointSet
	{
		public int[] EdgeIndex
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

		public override TriangulationMode TriangulationMode => default(TriangulationMode);

		public ConstrainedPointSet(List<TriangulationPoint> points, int[] index)
			: base(null)
		{
		}

		public override void Prepare(TriangulationContext tcx)
		{
		}
	}
}
