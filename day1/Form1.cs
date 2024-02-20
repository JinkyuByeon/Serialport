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
                comboBox_port.Enabled = false; // COM포트 설정 콤보박스 비활성화
            }
            else // 시리얼 포트가 열려 있다면
            {
                label_status.Text = "포트가 이미 열려 있습니다.";
            }
        }
        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리
        {
            int ReceiveData = serialPort1.ReadByte();  //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
            richTextBox_received.Text = richTextBox_received.Text + string.Format("{0:X2}", ReceiveData);  //int 형식을 string형식으로 변환하여 출력
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox_send.Text);
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();

                label_status.Text = "포트가 닫혔습니다.";
                comboBox_port.Enabled = true; // COM포트 설정 비활성화
            }
            else
            {
                label_status.Text = "포트가 이미 닫혀 있습니다.";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived)); // 메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 invoke 사용. MySerialReceived로 이동 추가 실행.
        }
    }
    
    
}
