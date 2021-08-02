using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(Rigidbody2D))]
public class Rigidbody2DEditor : Editor
{
	void OnSceneGUI()
	{
		Rigidbody2D rb = target as Rigidbody2D;
		Handles.color = Color.red;
		Handles.SphereCap(1, rb.transform.TransformPoint(rb.centerOfMass), rb.rotation, 1f);
	}
	public override void OnInspectorGUI()
	{
		GUI.skin = EditorGUIUtility.GetBuiltinSkin(UnityEditor.EditorSkin.Inspector);
		DrawDefaultInspector();
	}
}