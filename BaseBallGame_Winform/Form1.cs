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
        int countGame; // 게임카운트
        public Form1() // 기본생성자
        {
            InitializeComponent();
            countGame = 0; // 0회차 부터 (게임 시작시 1부터 ++해서 카운트 할거임
        }

        private void clickNumber(object sender, EventArgs e) // 버튼클릭했을때 이벤트
        {
            var number = sender as Button; // object sender를 Button으로 형변환 후 number에 담음
            
            if (number == null)
                return;

            // MessageBox.Show("버튼을 클릭했구만! : " + number.Text); 
            
             inputNumber.Text += number.Text;// 형변환해서 넣은 값 text로 추출
        }

        private void Form1_Load(object sender, EventArgs e) // 폼로드
        {

        }
    }
}
