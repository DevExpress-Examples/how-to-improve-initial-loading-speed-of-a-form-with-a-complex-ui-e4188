<!-- default file list -->
*Files to look at*:

* [EditForm.cs](./CS/EditForm.cs) (VB: [EditForm.vb](./VB/EditForm.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to improve initial loading speed of a form with a complex UI


<p><strong>Problem</strong><strong>:</strong></p><p>My editing form contains many UI elements. It take too much time on initial loading. All subsequent loads are fast enough. How can I improve initial loading of the form?</p><p><strong>Solution</strong><strong>:</strong></p><p>This problem is related to the specifics of <a href="http://en.wikipedia.org/wiki/Just-in-time_compilation"><u>Just-in-time compilation</u></a>. The code is not compiled until it is actually needed. The simplest solution is to force jitter to pre-compile a code in a background thread. This allows CLR to cache compiled code for future use (this will improve performance). Moreover, the UI will not be blocked because we launch compilation in a background thread. It is implemented as follows:</p>

```cs
        static void Main() {
            Thread thread = new Thread(delegate() {
                EditForm editForm = new EditForm();
                //MessageBox.Show("EditForm has been initialized.");
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Priority = ThreadPriority.Highest;
            thread.IsBackground = true;
            thread.Start();
            ...
        }
```

<p> </p><p>Alternatively, you can use the approach from the <a href="https://www.devexpress.com/Support/Center/p/A2670">Why does my code take longer to execute the first time it's run?</a> knowledge base article.</p>

<br/>


