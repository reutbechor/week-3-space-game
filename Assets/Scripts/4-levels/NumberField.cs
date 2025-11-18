using TMPro;
using UnityEngine;

/**
 * רכיב שמוצמד לאובייקט שיש עליו TextMeshPro.
 * מאפשר לעדכן מספר ולהציג אותו על גבי הטקסט.
 */
[RequireComponent(typeof(TextMeshPro))]
public class NumberField : MonoBehaviour
{
    private int number;

    // כאן נחזיק את טקסט ה-UI שנמצא בתוך ה-Canvas על המסך.
    [SerializeField] private TextMeshProUGUI scoreTextUI;

    public int GetNumber()
    {
        return this.number;
    }

    public void SetNumber(int newNumber)
    {
        // שמירת המספר החדש
        this.number = newNumber;

        // עדכון הטקסט הישן
        // זה משאיר תאימות לקוד המקורי ללא שינוי.
        GetComponent<TextMeshPro>().text = newNumber.ToString();

        // עדכון הטקסט החדש על המסך 
        if (scoreTextUI != null)
            scoreTextUI.text = newNumber.ToString();
    }

    public void AddNumber(int toAdd)
    {
        // פשוט מוסיף מספר ומשתמש ב-SetNumber כדי לעדכן את התצוגה
        SetNumber(this.number + toAdd);
    }
}
