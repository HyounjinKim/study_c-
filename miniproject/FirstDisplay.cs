
namespace miniproject
{
    public partial class FirstDisplay : Form
    {
        public FirstDisplay()
        {
            InitializeComponent();
        }

        // ���� ȭ������ ���� ��ư
        private void btn_gomain_Click(object sender, EventArgs e)
        {
            MainDisplay mainDisplay = new MainDisplay();
            Hide();
            mainDisplay.ShowDialog();
            Show();
        }

        // ��ư �̹��� �ٲ�� ��������
    }
}
