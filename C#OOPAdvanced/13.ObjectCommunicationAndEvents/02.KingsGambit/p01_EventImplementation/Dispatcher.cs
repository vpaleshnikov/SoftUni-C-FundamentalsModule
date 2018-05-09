// Delegates are out of class (in namespace)
public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs e);

public class Dispatcher
{
    private string name;
    public event NameChangeEventHandler NameChange;

    public string Name
    {
        get { return this.name; }
        set
        {
            this.name = value;
            OnNameChange(new NameChangeEventArgs(value));
        }
    }

    private void OnNameChange(NameChangeEventArgs e)
    {
        this.NameChange?.Invoke(this, e);

        // This is the same!:
        //if (this.NameChange != null)
        //{
        //    this.NameChange(this, e);
        //}
    }
}
