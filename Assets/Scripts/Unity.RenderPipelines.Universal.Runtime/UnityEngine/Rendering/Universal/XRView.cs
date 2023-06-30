using UnityEngine.XR;

namespace UnityEngine.Rendering.Universal
{
	internal struct XRView
	{
		internal readonly Matrix4x4 projMatrix;

		internal readonly Matrix4x4 viewMatrix;

		internal readonly Rect viewport;

		internal readonly Mesh occlusionMesh;

		internal readonly int textureArraySlice;

		internal XRView(Matrix4x4 proj, Matrix4x4 view, Rect vp, int dstSlice)
		{
		}

		internal XRView(XRDisplaySubsystem.XRRenderPass renderPass, XRDisplaySubsystem.XRRenderParameter renderParameter)
		{
		}
	}
}
