using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceUI_M1 : MonoBehaviour
{
    public GameObject Ref;
    public GameObject Target;
    public GameObject DistanceUI_Marker;

    Vector3 myPos = new Vector3(0f,0f,0f);

    private void Start()
    {
        transform.position = myPos;
    }

    void Update()
    {
        // 
        transform.position = Ref.transform.position;


        // 
        Vector3 targetDir = Target.transform.position - Ref.transform.position;
        Quaternion rotation = Quaternion.LookRotation(targetDir, Vector3.up);
        transform.rotation = rotation;

        // 
        float distance = Vector3.Distance(Ref.transform.position, Target.transform.position);
        transform.localScale = new Vector3(1f, 1f, 100f*distance);
    }

}
