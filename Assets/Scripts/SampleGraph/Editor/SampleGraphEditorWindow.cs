using UnityEditor;

public class SampleGraphEditorWindow : EditorWindow
{
	[MenuItem("Window/Open SampleGraphView")]
	public static void Open()
	{
		GetWindow<SampleGraphEditorWindow>("SampleGraphView");
	}

	void OnEnable()
	{
		var graphView = new SampleGraphView()
		{
			style = { flexGrow = 1 }
		};
		rootVisualElement.Add(graphView);
	}
}
