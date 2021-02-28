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
        int _countGame; // 게임카운트
         bool _statusCheckGame; // 게임 상태 활성화 여부

        int[] _inputNumberSave // 사용자로부터 입력받은 점수 저장용 (비교할때 꺼내쓸 용도)
        {
            get;
            set;
        }

        int[] _saveRandomNumber // 랜덤함수 저장용 (나중에 꺼내서 비교할때 쓸거)
        { 
            get;
            set;
        }

        
        public Form1() // 기본생성자
        {
          InitializeComponent();
          _countGame = 0; // 0회차 부터 (게임 시작시 1부터 ++해서 카운트 할거임
           _statusCheckGame = true;

            listViewGameStart.Items.Clear();
            //            textRandomNumber.Text = setRandomNumber().ToString(); // 컴퓨터가 만드는 랜덤함수 생성 호출 
            setRandomNumber();
            Console.WriteLine("생성자 초기화 값 _countGame : " + _countGame);
            Console.WriteLine("생성자 초기화 값 _statusCheckGame : " + _statusCheckGame);
        }

   /*     public Form1(int _countGame, bool _statusCheckGame) //인자있는 기본생성자
        {
          //  InitializeComponent();
            MessageBox.Show("인자있는 기본생성자");
            this._countGame = _countGame; // 0회차 부터 (게임 시작시 1부터 ++해서 카운트 할거임
            this._statusCheckGame = _statusCheckGame;
            Console.WriteLine("생성자 초기화 값 _countGame : " + _countGame);
            Console.WriteLine("생성자 초기화 값 _statusCheckGame : " + _statusCheckGame); 
             listViewGameStart.Items.Clear();
            //            textRandomNumber.Text = setRandomNumber().ToString(); // 컴퓨터가 만드는 랜덤함수 생성 호출 
            setRandomNumber();

        }
*/



        public int[] setRandomNumber() // 컴퓨터가 생성하는 랜덤함수
        {
            Random random = new Random();
            int[] setRandomNumber = new int [3];
            for (int i = 0; i < 3; i++)

            {

                setRandomNumber[i] = random.Next(1,10); // 랜덤난수 배열에 삽입 
                
                for (int j = 0; j < i; j++)

                {

                    if (setRandomNumber[j] == setRandomNumber[i]) i--; // 비교후 동일하면 다시 반복문
                    // 중복이 발견되어 --처리하면 출력은 충복 으로 뜨지만 실제 배열에는
                    // 중복이 안들어가있음
                }
                _saveRandomNumber = setRandomNumber; // setter에 저장
                textRandomNumber.Text += setRandomNumber[i]; // 메인화면에 랜덤함수 생성된거 보여줌
                                                             // 왜 그냥 textRanDomNumber.Text = setRandomNumber[i]는 안되냐.....

           


            }

   /*         Console.WriteLine("test = " + setRandomNumber[0]);
            Console.WriteLine("test = " + setRandomNumber[1]);
            Console.WriteLine("test = " + setRandomNumber[2]);*/
            return setRandomNumber;
        }

        private void clickNumber(object sender, EventArgs e) // 버튼클릭했을때 이벤트 (임의로 만듦)
        {
            var number = sender as Button; // object sender를 Button으로 형변환 후 number에 담음
            
            if (number == null)
                return;

            if(_statusCheckGame)
            {
               

            int lengthNumber = inputNumber.Text.Length;
            if (lengthNumber < 3)
            {
              //  _statusCheckGame = false; // 이새키가 여기 왜있냐 ㅡㅡ;
                inputNumber.Text += number.Text;// 형변환해서 넣은 값 text로 꺼낸 후 inputNumber에 텍스트로 담음
            }
            else{
                MessageBox.Show("더 이상 수를 입력할 수 없습니다 3자리까지만 허용됩니다");
            }

            } // 게임상태 체크 if문 + else
            else
            {
                MessageBox.Show("게임이 이미 끝났습니다");

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
            int numberLength = inputNumber.Text.Length; // 입력된 숫자 사이즈

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
                MessageBox.Show("숫자 back 예외가 발생하였습니다 ");
            }

        }

        private void buttonRetry_Click(object sender, EventArgs e) // 게임 재시작
        {

  
            listViewGameStart.Items.Clear();
            listViewGameStart.Items.Add("게임을 다시 시작합니다");
            MessageBox.Show("게임을 처음부터 다시 시작합니다");
            inputNumber.Text = "";
            _statusCheckGame = true;
            _countGame = 0;
            textRandomNumber.Text = "";
            setRandomNumber();


        }

        private void buttonStart_Click(object sender, EventArgs e) // 게임시작 버튼
        {
      
            if (checkNumberLength()  && _countGame < 9 && _statusCheckGame) 
                // 자릿수가 맞고 게임이 시작중이고 회차가 9회미만이라면
            {

                _countGame++; // 게임 회차 카운트
                if (_countGame <= 1) // 1회차에만 문구 나오게
                    listViewGameStart.Items.Add("게임을 시작합니다");

                listViewGameStart.Items.Add(_countGame + "회차 " + inputNumber.Text);
               // inputNumber.Text = ""; // 키패드 값 삭제

            }

            if (_countGame >= 9)
            // 9회차이상이고 게임 _statusCheckGame false처리하면 아래 조건문 조건에 안맞아서 안들어감
            {
                MessageBox.Show("게임이 끝났습니다");

                // 여기에 점수 계산 결과 기록하면 됨

                _statusCheckGame = false;
            }


        }

        private bool checkNumberLength() // 자리수 체크 함수
        {
            bool checkNumber = false;
            if (_statusCheckGame) // 게임상태가 활성화 일때만
            {
                if (inputNumber.Text.Length >= 3)// 3자리이면서 게임이 끝이 아니면
                {
                    checkNumber = true;

                }
                else
                {
                    MessageBox.Show("3자리를 입력해주세요");

                }
            }

            return checkNumber;
        }
    }
}
