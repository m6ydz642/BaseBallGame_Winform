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

        private void clickNumber(object sender, EventArgs e) // 버튼클릭했을때 이벤트 (임의로 만듦)
        {
            var number = sender as Button; // object sender를 Button으로 형변환 후 number에 담음
            
            if (number == null)
                return;

            // MessageBox.Show("버튼을 클릭했구만! : " + number.Text); 
            int lengthNumber = inputNumber.Text.Length;
            if (lengthNumber < 3)
            {
                inputNumber.Text += number.Text;// 형변환해서 넣은 값 text로 꺼낸 후 inputNumber에 텍스트로 담음
            }
            else{
                MessageBox.Show("더 이상 수를 입력할 수 없습니다 3자리까지만 허용됩니다");
            }

        }

        private void Form1_Load(object sender, EventArgs e) // 폼로드
        {

        }

        private void buttonClean_Click(object sender, EventArgs e) // 키패드 내용 전체삭제
        {
            inputNumber.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e) // backspace
        {
            int numberLength = inputNumber.Text.Length;

            try
            {
                if (numberLength >= 1)
                {
                    inputNumber.Text = inputNumber.Text.Remove(numberLength - 1);
                }
                else if (numberLength <= 0)
                {
                    MessageBox.Show("더 이상 지울 수 있는 수가 없습니다");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("숫자 Back 예외오류 뜸 : " + ex);
                MessageBox.Show("숫자 back 알 수 없는 오류가 발생하였습니다 ");
            }

        }
    }
}
