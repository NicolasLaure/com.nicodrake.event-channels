using UnityEngine;
using UnityEngine.Events;

namespace Events
{
    [CreateAssetMenu(fileName = "FloatEventChannel", menuName = "Events/Float", order = 0)]
    public class FloatChannelEvent : ScriptableObject
    {
        public event UnityAction<float> onFloatEvent;

        public void RaiseEvent(float value)
        {
            onFloatEvent?.Invoke(value);
        }
    }
}
