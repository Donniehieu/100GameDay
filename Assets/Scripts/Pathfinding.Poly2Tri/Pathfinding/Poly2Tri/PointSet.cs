using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pathfinding.Poly2Tri
{
	public class PointSet : Triangulatable
	{
		public IList<TriangulationPoint> Points
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

		public IList<DelaunayTriangle> Triangles
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

		public virtual TriangulationMode TriangulationMode => default(TriangulationMode);

		public PointSet(List<TriangulationPoint> points)
		{
		}

		public void AddTriangle(DelaunayTriangle t)
		{
		}

		public void AddTriangles(IEnumerable<DelaunayTriangle> list)
		{
		}

		public void ClearTriangles()
		{
		}

		public virtual void Prepare(TriangulationContext tcx)
		{
		}
	}
}
