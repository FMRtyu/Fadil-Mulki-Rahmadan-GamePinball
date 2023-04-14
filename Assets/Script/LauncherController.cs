using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;
    public float maxTimeHold;
    public float maxForce;
    public Material onMaterial;
    public Material offMaterial;

    private bool isHold = false;
    private Renderer render;

    private void Start()
    {
        render = GetComponent<Renderer>();
        render.material = offMaterial;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider == bola)
        {
            ReadInput(bola);
        }
    }
    private void ReadInput(Collider colider)
    {
        if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(colider));
        }
    }
    private IEnumerator StartHold(Collider colider)
    {
        isHold = true;
        render.material = onMaterial;
        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);
            //kalkulasi force
            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        colider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
        render.material = offMaterial;
    }
}
