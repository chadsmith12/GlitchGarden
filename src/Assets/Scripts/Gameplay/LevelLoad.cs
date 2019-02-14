using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Gameplay
{
    public class LevelLoad : MonoBehaviour
    {
        private int _currentSceneIndex;
        [SerializeField] private int _timeToWait = 3;

        /// <summary>
        /// gives you if the current scene is the splash screen.
        /// </summary>
        private bool IsSplashScreen
        {
            get
            {
                return _currentSceneIndex == 0;
            }
        }

        // Use this for initialization
        void Start()
        {
            _currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            if(IsSplashScreen)
            {
                StartCoroutine(WaitForSplash());
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// Loads the very next scene by moving to the next scene in the build settings.
        /// </summary>
        public void LoadNextScene()
        {
            SceneManager.LoadScene(_currentSceneIndex + 1);
        }

        private IEnumerator WaitForSplash()
        {
            yield return new WaitForSeconds(_timeToWait);

            LoadNextScene();
        }
    }
}

