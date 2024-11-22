using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

[RequireComponent(typeof(TextMeshProUGUI))]
public class SimpleTextMeshPro : MonoBehaviour
{
   private TextMeshProUGUI text;
   public SimpleIntData dataObject;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        Update();
    }

    // Update is called once per frame
    public void Update()
    {
        text.text = dataObject.value.ToString(CultureInfo.InvariantCulture);
    }
}
