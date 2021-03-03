using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseBallGame_Winform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBallGame_Winform.Tests
{
    [TestClass()]
    public class Form1Tests : Form1
    {
       
        public void Form1Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void setRandomNumberTest() // 컴퓨터가 생성하는 랜덤함수 (야구게임 함수랑 동일한 테스트 함수 생성)
        {
            Assert.IsNotNull(setRandomNumber()); // int []형식의 함수 호출 null이 아니면 됨
        }

        [TestMethod()]
        public void compareRandnumber_inputNumber()
        {

            Form1 target = new Form1();
            PrivateObject obj = new PrivateObject(target); // 함수가 private일경우 지금처럼 연결해서 사용
            var retVal = obj.Invoke("compareRandnumber_inputNumber");
            Assert.IsNotNull(retVal);
        }
        // compareRandnumber_inputNumber

    }
}