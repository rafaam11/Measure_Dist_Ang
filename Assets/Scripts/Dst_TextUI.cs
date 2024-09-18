using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dst_TextUI : MonoBehaviour
{
    public GameObject Ref;
    public GameObject Target;
    public TextMeshPro TMP_Text;

    string uiText = "";

    void Update()
    {
        transform.position = Ref.transform.position + 0.5f * (Target.transform.position - Ref.transform.position);
        float distance = Vector3.Distance(Ref.transform.position, Target.transform.position);
        float walid = distance * 100;
        uiText = walid.ToString();
        TMP_Text.text = uiText + "CM";

    }
}
