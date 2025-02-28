using UnityEngine;
using System.Collections;

public class MainMenuCamera : MonoBehaviour
{
    public float moveDistance = 200f;  // Distance to move on the Z-axis
    public float speed = 40f;  // Adjust for slower movement
    private Vector3 startPos;
    private Vector3 targetPos;
    private bool movingForward = true;

    void Start()
    {
        startPos = transform.position;
        targetPos = startPos + new Vector3(0, 0, moveDistance);
        StartCoroutine(MoveCamera());
    }

    IEnumerator MoveCamera()
    {
        while (true)
        {
            float elapsedTime = 0f;
            Vector3 from = movingForward ? startPos : targetPos;
            Vector3 to = movingForward ? targetPos : startPos;

            while (elapsedTime < speed)
            {
                transform.position = Vector3.Lerp(from, to, elapsedTime / speed);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            transform.position = to;
            movingForward = !movingForward;
        }
    }
}
