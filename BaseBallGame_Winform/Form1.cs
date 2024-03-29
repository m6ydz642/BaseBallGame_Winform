﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            DataSet dataSet = connectDB();
            dataGridView1.DataSource = dataSet.Tables[0]; // DataGrid에 DB호출
        }


       
       

        private void Form1_Load(object sender, EventArgs e) // 폼로드
        {
            setRandomNumber();
        }

        #region 버튼클릭 이벤트
        /*******************************************************************************************/
        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e) // 메뉴 -> 저장
        {
            SaveFileDialog savePanel = new SaveFileDialog();
            savePanel.FileName = "";
            savePanel.Filter = "txt(*.txt)|*.txt | All files (*.*)|(*.*)";

            if (savePanel.ShowDialog() == DialogResult.OK)
            {
                // string content = listViewGameStart.;

                MessageBox.Show("저장 되었습니다");
            }



        }
        private void clickNumber(object sender, EventArgs e) // 버튼클릭했을때 이벤트 (임의로 만듦)
        {
            var number = sender as Button; // object sender를 Button으로 형변환 후 number에 담음

            if (number == null)
                return;

            if (_statusCheckGame)
            {
                int lengthNumber = inputNumber.Text.Length;
                if (lengthNumber < 3)
                {
                    inputNumber.Text += number.Text;// 형변환해서 넣은 값 text로 꺼낸 후 inputNumber에 텍스트로 담음
                }
                else
                {
                    MessageBox.Show("더 이상 수를 입력할 수 없습니다 3자리까지만 허용됩니다");
                }

            } // 게임상태 체크 if문 + else
            else
            {
                MessageBox.Show("게임이 이미 끝났습니다");

            }
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
            MessageBox.Show("게임을 처음부터 다시 시작합니다");
            inputNumber.Text = "";
            _statusCheckGame = true;
            _countGame = 0;
            textRandomNumber.Text = "";
            setRandomNumber();
        }

        private void buttonStart_Click(object sender, EventArgs e) // 게임시작 버튼
        {
            bool checkInputCountNumber = checkNumberLength(); // 입력받은 번호 개수 체크함수

            if (checkInputCountNumber && _countGame < 9 && _statusCheckGame) 
                // 입력된 자릿수가 맞고 게임이 시작중, 회차가 9회미만이라면
            {

                _countGame++; // 게임 회차 카운트
                if (_countGame <= 1) // 1회차에만 문구 나오게
                    listViewGameStart.Items.Add("게임을 시작합니다");

               char[] inputNumberString = inputNumber.Text.ToCharArray(); // string input box내용  char로 변환
                // 각 자리수로 비교하기 위해서 char로 변환
                // 근데 그냥 string inputNumberString = inputNumber.text 한 후 비교할때는 (input)inputNumberString
                // 해서 형변환 후 사용해도 상관은 없는데 getter, setter에 담을 형태가 int라 이렇게 변환해서 씀
                // int 배열에 안담고 바로 사용하려면 그냥 형변환해서 쓰면 됨

                string test = inputNumber.Text;
                Console.WriteLine("test : " + test[0]); // 이렇게 써도 됨 string에서 array 로 변환 됨


                // test변수가 string인데 inputNumber.Text가 배열 반환이라 가능 
                // 디자인 영역에 속성쪽에 보면 string[] array로 설정 되어있음

                _inputNumberSave = new int[3]; // new 연산자로 영역 생성안하니까 null뜨면서 안들어가짐 


                char[] a = new char[3];
                a[0] = 'A';
                int[] b = new int[3];
                b[0] = a[0]; // 이렇게 그냥 별도의 형변환없이 가능
                Console.WriteLine("b값 int : " + b[0]);


                _inputNumberSave[0] = inputNumberString[0]-48;  // char[] 타입을 int [] 타입으로
                // 이거 어이없는게 0번(48) 아스키코드를 빼면 현재 숫자가 나옴
                // 아스키코드로 49는 1인데 이걸 변환하려면 -48을 하면 1이나옴

                                                    
                _inputNumberSave[1] = inputNumberString[1]-48;
                _inputNumberSave[2] = inputNumberString[2]-48;

                bool CheckInputDuplicateNumber = CheckInputNumberDuplicate(_inputNumberSave); // 입력 값 중복 체크
                if (CheckInputDuplicateNumber)
                {

                    listViewGameStart.Items.Add(_countGame + "회차 " + inputNumber.Text + "\r\n");

                    compareRandnumber_inputNumber(); // 랜덤값, 입력값 비교

                    inputNumber.Text = ""; // 키패드 값 삭제
                }
          

            }

            if (_countGame >= 9 || _statusCheckGame == false)
            // 9회차이상이고 게임 _statusCheckGame false처리하면 아래 조건문 조건에 안맞아서 안들어감
            {
                MessageBox.Show("게임이 끝났습니다");
                _statusCheckGame = false;
            }


        }

        private void buttonDBConnect_Click(object sender, EventArgs e) // DB버튼 클릭했을시
        {
            DataSet dataSet = connectDB();
            dataGridView1.DataSource = dataSet.Tables[0];


        }

        private void button1_Click(object sender, EventArgs e) // DB값 입력
        {
            insertDB();
        }

        #endregion

        #region 동작관련 함수
        /*******************************************************************************************/

        public int[] setRandomNumber() // 컴퓨터가 생성하는 랜덤함수
        {
            Random random = new Random();
            int[] setRandomNumber = new int[3];
            for (int i = 0; i < 3; i++)
            {
                setRandomNumber[i] = random.Next(1, 10); // 랜덤난수 배열에 삽입 

                for (int j = 0; j < i; j++)
                {
                    if (setRandomNumber[j] == setRandomNumber[i]) i--; // 비교후 동일하면 다시 반복문
                    // 중복이 발견되어 --처리하면 텍스트 출력은 중복 으로 뜨지만 실제 배열에는
                    // 중복이 안들어가있음
                }
                _saveRandomNumber = setRandomNumber; // setter에 저장
                textRandomNumber.Text += setRandomNumber[i]; // 메인화면에 랜덤함수 생성된거 보여줌
                                                             // 왜 그냥 textRanDomNumber.Text = setRandomNumber[i]는 안되냐.....




            }
            return setRandomNumber;
        }


        private void compareRandnumber_inputNumber() // 랜덤값, 입력값 비교함수 (점수 환산용)
        {

            int strike = 0; // 점수
            int ball = 0;


            // 랜덤값과 입력값 비교

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_saveRandomNumber[i] == _inputNumberSave[j])
                    {
                        // 자리수, 번호 까지 같으면 strike

                        if (i == j) strike++;

                        else
                        {
                            ball++;
                        }

                    }

                }

            }

        
          // out 생략, 0스트라이크 0볼로 처리하면 됨
            if (strike == 3)
            {
                listViewGameStart.Items.Add(strike +"스트라이크" + ball + "볼" + " ");
                listViewGameStart.Items.Add("사용자 승리!!!!!!!!!!!!!! ");
                _statusCheckGame = false;
                MessageBox.Show("사용자가 승리하여 게임이 종료되었습니다");
               
            }
            else
            {
                listViewGameStart.Items.Add(strike + "스트라이크" + ball + "볼" + " ");

            }

        }
        /*******************************************************************************************/
        #endregion         

        #region 입력 값 체크
        /*******************************************************************************************/
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

        private bool CheckInputNumberDuplicate(int [] InputNumber) // 자리수 입력값 중복체크
        {
            bool checkStatus = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (InputNumber[j] == InputNumber[i])
                    {
                        checkStatus = false;
                        i = 3;
                        break;
                    }
                    else checkStatus = true;

                }
            }

            if (checkStatus == false)
            {
         
             MessageBox.Show("입력숫자가 중복입니다");
           
            }
            return checkStatus;
        }
        /*******************************************************************************************/
        #endregion

        #region DB접속 관련
        /*******************************************************************************************/
        private void insertDB()
        {
            string result = "";

            for (int i = 0; i < listViewGameStart.Items.Count; i++) // 반복문으로 리스트 뷰  가져옴
            {

                ListViewItem item = listViewGameStart.Items[i];
                Console.WriteLine(item.Text.ToString());
                result += item.Text.ToString();

            }


            String database = "Data Source=DESKTOP-Develop;Initial Catalog=BaseBallGameWinform_DB;Integrated Security=SSPI";
            // Initial Catalog는 DB이름이고
            // Data Source=해서 들어가는 이름은 DB의 서버이름임
            // ㅅㅂ 윈도우인증 sql인증 몰라서 접속 계속 못함

            SqlConnection connection = new SqlConnection(database);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT ScoreTable VALUES( '" + result + "')";
            cmd.ExecuteNonQuery();


            Console.WriteLine("result : " + result);


        }

        private DataSet connectDB()
        {
            String database = "Data Source=DESKTOP-Develop ;Initial Catalog=BaseBallGameWinform_DB;Integrated Security=SSPI";
            // Initial Catalog는 DB이름이고
            // Data Source=해서 들어가는 이름은 DB의 서버이름

            SqlConnection connection = new SqlConnection(database);
            connection.Open();
            Console.WriteLine("DB연결객체 : " + connection);


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
               "SELECT * from ScoreTable", connection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            return dataSet;
        }
        /*******************************************************************************************/
        #endregion

     
    }
}
