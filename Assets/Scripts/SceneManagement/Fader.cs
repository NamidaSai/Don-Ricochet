using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.SceneManagement
{
    public class Fader : MonoBehaviour
    {
        CanvasGroup canvasGroup;

        // Start is called before the first frame update
        void Start()
        {
            canvasGroup = GetComponent<CanvasGroup>();

            StartCoroutine(FadeOut(3f));
        }

        IEnumerator FadeOut()
        {
            while (false) // while alpha is not 1
            {
                // move alpha towards 1
                yield return null;
            }
        }
    }
}
