using UnityEngine;

// class for the object seen by camera
public class CameraPreview : MonoBehaviour
{
    public GameObject obj;
    public Camera cam;
  
    void Update()
    {
        if (obj.GetComponent<MeshRenderer>().IsVisibleFrom(cam)){
            print("Visible");
        }
        else {
            print("Not Visible");
        }       
    }   
}
 
public static class RendererExtensions
{
	public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
	{
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
		return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
	}
}
