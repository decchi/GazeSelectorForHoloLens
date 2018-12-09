using UnityEngine;
using UnityEngine.Events;
using HoloToolkit.Unity.InputModule;

namespace HoloToolkitExtension.Input
{

    public class GazeSelectorTarget : MonoBehaviour, IFocusable
    {

        public UnityEvent OnSelectionCompleted = new UnityEvent();

        public void OnFocusEnter()
        {
            SelectionRadial.Instance.OnSelectionComplete += OnSelectionComplete;
            SelectionRadial.Instance.Show();
            SelectionRadial.Instance.HandleDown();
        }

        public void OnFocusExit()
        {
            SelectionRadial.Instance.OnSelectionComplete -= OnSelectionComplete;
            SelectionRadial.Instance.HandleUp();
            SelectionRadial.Instance.Hide();

        }

        private void OnSelectionComplete()
        {
            SelectionRadial.Instance.OnSelectionComplete -= OnSelectionComplete;
            OnSelectionCompleted.Invoke();
        }
    }

}