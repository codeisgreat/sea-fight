using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeaFight
{
    
    public partial class CreateForm : Form
    {
        public event Action<string,string> GameJoinHandler;
        public event Action<string> GameCreateHandler;

        public CreateForm(Action<string,string> joinHandler,Action<string> createHandler)
        {
            Contract.Assert(joinHandler != null && createHandler != null);

            GameJoinHandler += joinHandler;
            GameCreateHandler += createHandler;

            InitializeComponent();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            if (IPBox.Text.Length == 0 || NicknameBox.Text.Length == 0)
            {
                MessageBox.Show("Please input your nickname and enemy IP");
                return;
            }

            GameJoinHandler(IPBox.Text,NicknameBox.Text);
            Close();

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (NicknameBox.Text.Length == 0 || Utils.IsNum(NicknameBox.Text))
            {
                MessageBox.Show("Please input your nickname");
                return;
            }
                GameCreateHandler(NicknameBox.Text);
                Close();

        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
