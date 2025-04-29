using System;
using System.Windows.Forms;

namespace MyDotNetFormApp
{
    public class MyForm : Form
    {
        private Button myButton;
        private TextBox myInput;
        private ComboBox myComboBox;
        private MenuStrip myMenuStrip;

        public MyForm()
        {
            // ウィンドウのタイトルを設定
            this.Text = "My .NET Form";
            // 入力テキストボックス作成
            myInput = new TextBox();
            myInput.Location = new System.Drawing.Point(50, 50);
            // ボタン作成
            myButton = new Button();
            myButton.Text = "Click Me";
            myButton.Location = new System.Drawing.Point(50, 50);
            myButton.Click += new EventHandler(Button_Click);
            // 出力ラベル作成
            outputLabel = new Label();
            outputLabel.Location = new System.Drawing.Point(50, 150);

            // テキストボックス作成
            myInput = new TextBox();
            myInput.Location = new System.Drawing.Point(50, 100);

            // コンボボックス作成
            myComboBox = new ComboBox();
            myComboBox.Items.Add("Item 1");
            myComboBox.Items.Add("Item 2");
            myComboBox.Location = new System.Drawing.Point(50, 150);

            // メニューストリップ作成
            myMenuStrip = new MenuStrip();
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem helpMenu = new ToolStripMenuItem("Help");
            myMenuStrip.Items.Add(fileMenu);
            myMenuStrip.Items.Add(helpMenu);

            // コントロールをフォームに追加
            this.Controls.Add(myButton);
            this.Controls.Add(myInput);
            this.Controls.Add(myComboBox);
            this.Controls.Add(myMenuStrip);
            this.Controls.Add(outputLabel);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string inputText = myInput.Text;
            outputLabel.Text = "You posted: " + inputText;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm());
        }
    }
}
