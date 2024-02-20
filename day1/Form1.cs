using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // 포트 필수 코드

namespace day1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            comboBox_port.DataSource = SerialPort.GetPortNames(); // 연결 가능한 시리얼 포트 이름을 콤보 박스에 가져온다.
        }

        private void Button_connect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) // 시리얼 포트가 열려 있지 않다면
            {
                serialPort1.PortName = comboBox_port.Text; // 콤보 박스의 선택된 COM포트명을 시리얼포트명으로 지정
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); // 필수 코드

                serialPort1.Open(); // 시리얼 포트 열기

                label_status.Text = "포트가 열렸습니다.";
                comboBox_port.ENabled = false; // COM포트 설정 콤보박스 비활성화
            }
            else // 시리얼 포트가 열려 있다면
            {
                label_status.Text = "포트가 이미 열려 있습니다.";
            }
        }
        private void serialPort1_DataReceived(object sender, SerialErrorReceivedEventArgs e) // 수신 이벤트가 발생하면 이 부분이 실행
        {
            this.Invoke(new EventHandler(MySerialReceived)); // 메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 invoke 사용. MySerialReceived로 이동 추가 실행.
        }
        private void MySerialReceived(object s, EventArgs e) // 수신데이타 용도에 따라 처리
        {
            int ReceiveData = serialPort1.Rea
        }

    }
    
    
}
