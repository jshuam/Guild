using UnityEngine;

namespace Guild.Core
{
    [CreateAssetMenu(fileName = "New Activity Type", menuName = "Activity Type")]
    public class ActivityType : ScriptableObject
    {
        [SerializeField] private string _type = "";

        public string Type { get => _type; }
    }
}