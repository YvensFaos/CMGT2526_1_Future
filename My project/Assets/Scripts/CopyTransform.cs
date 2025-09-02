using UnityEngine;

public class CopyTransform : MonoBehaviour
{
    [SerializeField]
    private Camera target;
    [SerializeField]
    private Camera selfCamera;

    private void LateUpdate()
    {
        if (target == null || selfCamera == null) return;
        transform.position = target.transform.position;
        transform.rotation = target.transform.rotation;
        selfCamera.fieldOfView = target.fieldOfView;
    }
}
