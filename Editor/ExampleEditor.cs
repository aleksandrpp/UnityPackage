using UnityEngine;
using UnityEditor;

namespace UnityPackage {
    
    [CustomEditor(typeof(Example))]
    public class ExampleEditor : Editor {
        public override void OnInspectorGUI() {
            base.OnInspectorGUI();
            
        }
    }
}