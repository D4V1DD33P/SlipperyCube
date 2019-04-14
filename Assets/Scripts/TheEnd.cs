using UnityEngine;
using UnityEngine.SceneManagement; 

public class TheEnd : MonoBehaviour
{
    // Start is called before the first frame update
	public void Quit() {
		SceneManager.LoadScene(0); 
		//Application.Quit(); 
	}
}
