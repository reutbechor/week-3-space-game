using UnityEngine;

public class BackgroundColorPulse : MonoBehaviour
{
    // רכיב של הרקע – עליו נשנה צבע
    SpriteRenderer sr;

    // שני צבעים בין הרקע יעבור בהדרגה
    [SerializeField] Color colorA = new Color(0.1f, 0.1f, 0.3f);  // צבע 1
    [SerializeField] Color colorB = new Color(0.2f, 0.2f, 0.6f);  // צבע 2

    // כמה מהר הרקע יחליף צבע
    [SerializeField] float speed = 1f;

    void Start()
    {
        // שמירת ה- SpriteRenderer כדי שנוכל לשנות את צבע הרקע
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // חישוב ערך t בין 0 ל-1 באמצעות פונקציית סינוס – נותן שינוי חלק וחוזר
        float t = (Mathf.Sin(Time.time * speed) + 1f) / 2f;

        // מעבר חלק בין שני הצבעים לפי הערך t
        sr.color = Color.Lerp(colorA, colorB, t);
    }
}
