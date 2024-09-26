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

        // Asignamos el método PlaySound al evento OnClick del botón
        button.onClick.AddListener(PlaySound);
    }

    // Método que se llama cuando se oprime el botón
    void PlaySound()
    {
        // Reproduce el sonido asignado al AudioSource
        audioSource.Play();
    }
}
