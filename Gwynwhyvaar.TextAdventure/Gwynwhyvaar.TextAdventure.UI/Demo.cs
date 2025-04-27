namespace Gwynwhyvaar.TextAdventure.UI;

public partial class Demo : Form
{
    public Demo()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var playerForm = new CreatePlayerForm();
        if (playerForm.ShowDialog() == DialogResult.OK)
        {
            playerForm.Close();
        }
    }
}