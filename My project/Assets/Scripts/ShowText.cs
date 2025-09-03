using System.Collections;
using TMPro;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textMesh;

    [SerializeField] private float textTimer = 4.0f;

    private void Start()
    {
        textMesh.text = "";
    }

    public void SetMessage(string message)
    {
        textMesh.text = message;
        StartCoroutine(MessageTimer());
    }

    private IEnumerator MessageTimer()
    {
        yield return new WaitForSeconds(textTimer);
        textMesh.text = "";
    }
}
