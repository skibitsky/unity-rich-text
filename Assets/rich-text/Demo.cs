using UnityEngine;
using RichText;

public class Demo : MonoBehaviour
{
	private const float Pi = 3.14f;
	private const string Quote = "\"Hank, this is great.\"";

	private void Start()
	{
		// Without RichText
		Debug.Log($"<color=purple><size=17><b><i>{Quote}</i></b></size></color> \nPi: <color=blue><i>{Pi}</i></color>");
		
		// Using RichText
		Debug.Log($"{Quote.Size(17).Bold().Italic().Purple()} \nPi: {Pi.Blue().Italic()}");
	}
}