using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pathfinding.Poly2Tri
{
	public class TriangulationPoint
	{
		public double X;

		public double Y;

		public List<DTSweepConstraint> Edges
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

		public float Xf
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Yf
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool HasEdges => false;

		public TriangulationPoint(double x, double y)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public void AddEdge(DTSweepConstraint e)
		{
		}
	}
}
