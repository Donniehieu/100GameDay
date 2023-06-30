using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pathfinding.Poly2Tri
{
	public abstract class TriangulationContext
	{
		public readonly List<DelaunayTriangle> Triangles;

		public readonly List<TriangulationPoint> Points;

		public TriangulationDebugContext DebugContext
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public TriangulationMode TriangulationMode
		{
			[CompilerGenerated]
			get
			{
				return default(TriangulationMode);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Triangulatable Triangulatable
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

		public int StepCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public abstract TriangulationAlgorithm Algorithm { get; }

		public virtual bool IsDebugEnabled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public DTSweepDebugContext DTDebugContext => null;

		public void Done()
		{
		}

		public virtual void PrepareTriangulation(Triangulatable t)
		{
		}

		public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b);

		public void Update(string message)
		{
		}

		public virtual void Clear()
		{
		}
	}
}
