using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	private int coinsColledted = 0;

	public void ResetScene() 
	{
        // Reset the scene when the user clicks the sign post
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
	}

	public void addCoin(){
		++coinsColledted;
		GetComponent<UnityEngine.UI.Text> ().text = string.Format ("YOU WIN\n{0} coins", coinsColledted);		
	}
}