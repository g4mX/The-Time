using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    public GameObject time;
    public int hour;
    public int minutes;
    public int seconds;

    private void Update() {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        seconds = System.DateTime.Now.Second;
        time.GetComponent<Text>().text = "" + hour + ":" + minutes + ":" + seconds;
    }
}
