using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public TextMeshProUGUI LoadingText;
    public Image loadingCircle, InnerCircle;
    public float CircleSpeed = 0.05f;
    private float _fillAmount = 0;
    private void Start() {
        LoadingText.text = "Loading";
        Invoke("ChangeText", CircleSpeed * 10);
    }
    private void ChangeText() {
        LoadingText.text += ".";
        if(LoadingText.text == "Loading...."){
            LoadingText.text = "Loading";
        }
        Invoke("ChangeText", CircleSpeed * 10);
    }
}
