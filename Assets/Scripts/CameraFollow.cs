using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    private Vector3 offsetTop = new Vector3(0, 7, -10);
    private Vector3 rotationOffsetTop = new Vector3(13, 0, 0);

    private Vector3 offsetFPV = new Vector3(0, 2.0f, 2f);
    private Vector3 rotationFPV = new Vector3(0, 0, 0);

    private bool isFPV = false;

    void Start()
    {
        SetTopDownView();
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            isFPV = !isFPV;
            if (isFPV)
                SetFPV();
            else
                SetTopDownView();
        }

        if (isFPV)
            transform.position = player.transform.position + offsetFPV;
        else
            transform.position = player.transform.position + offsetTop;
    }

    private void SetTopDownView()
    {
        transform.position = player.transform.position + offsetTop;
        transform.rotation = Quaternion.Euler(rotationOffsetTop);
    }

    private void SetFPV()
    {
        transform.position = player.transform.position + offsetFPV;
    }
}
