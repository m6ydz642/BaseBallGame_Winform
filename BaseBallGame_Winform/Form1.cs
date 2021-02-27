using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseBallGame_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickNumber(object sender, EventArgs e) // 버튼클릭했을때 이벤트
        {
            MessageBox.Show("버튼을 클릭했구만! : " + sender);
        }

        private void Form1_Load(object sender, EventArgs e) // 폼로드
        {

        }
    }
}
