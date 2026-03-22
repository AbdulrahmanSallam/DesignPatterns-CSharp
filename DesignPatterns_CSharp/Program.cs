using DesignPatterns_CSharp.Behavioral.Memento;

//memento

var editor = new Editor();
var history = new History();

editor.Content = "a";
history.Push(editor.CreateState()); // state a

editor.Content = "b";
history.Push(editor.CreateState()); // state b

editor.Content = "c";

editor.RestoreState(history.Pop()); // restore b 
editor.RestoreState(history.Pop()); // restore a 

Console.WriteLine(editor.Content);
