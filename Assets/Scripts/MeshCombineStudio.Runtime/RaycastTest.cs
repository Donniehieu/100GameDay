using UnityEngine;

[ExecuteInEditMode]
public class RaycastTest : MonoBehaviour
{
	public MeshRenderer mr;

	public Collider collider;

	public LayerMask layerMask;

	public bool createTriangle;

	public int triangleIndex;

	private RaycastHit hitInfo;

	public bool step2;

	public bool drawTriangle;

	private void Update()
	{
	}

	private void CreateTriangle()
	{
	}

	private void Swap<T>(ref T v1, ref T v2)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
