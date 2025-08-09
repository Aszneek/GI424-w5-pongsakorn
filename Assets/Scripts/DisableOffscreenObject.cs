using UnityEngine;

public class DisableOffscreenObject : MonoBehaviour
{
    private Renderer objRenderer;
    private Camera mainCam;



    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        mainCam = Camera.main;
    }

    void Update()
    {
        if (objRenderer == null || mainCam == null) return;
        
        bool isVisible = GeometryUtility.TestPlanesAABB(
            GeometryUtility.CalculateFrustumPlanes(mainCam),
            objRenderer.bounds
        );
        gameObject.SetActive(isVisible);
    }
}