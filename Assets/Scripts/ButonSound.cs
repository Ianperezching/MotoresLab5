using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    
    public AudioSource audioSource;


    public Button button;

    void Start()
    {
        // Obtenemos el componente AudioSource del GameObject
        audioSource = GetComponent<AudioSource>();

        // Asignamos el m�todo PlaySound al evento OnClick del bot�n
        button.onClick.AddListener(PlaySound);
    }

    // M�todo que se llama cuando se oprime el bot�n
    void PlaySound()
    {
        // Reproduce el sonido asignado al AudioSource
        audioSource.Play();
    }
}
