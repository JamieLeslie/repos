namespace Migration_Toolkit
{
    public partial class Migration_Toolkit_Main : Form
    {
        public Migration_Toolkit_Main()
        {
            InitializeComponent();
        }

        private void sftpTools_Click_1(object sender, EventArgs e)
        {
            SFTPTools SFTPForm = new SFTPTools();
            SFTPForm.Show();
        }

        private void shortcutTools_Click(object sender, EventArgs e)
        {
            ShortcutTools ShortcutForm = new ShortcutTools();
            ShortcutForm.Show();
        }
    }
}