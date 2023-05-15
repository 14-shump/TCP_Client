using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{
    public partial class Form1 : Form
    {
        public IPEndPoint ServerIPEndPoint { get; set; }
        private Socket Socket { get; set; }
        public const int BufferSize = 1024;
        public byte[] Buffer { get; } = new byte[BufferSize];

        /// <summary>
        /// STX
        /// </summary>
        private const char _stx = '\x02';

        /// <summary>
        /// ETX
        /// </summary>
        private const char _etx = '\x03';

        /// <summary>
        /// 受信メッセージ
        /// </summary>
        private string _receiveMsg = null;

        public Form1()
        {
            InitializeComponent();
        }

        // ソケット通信の接続
        public void Connect()
        {
            this.Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.Socket.Connect(this.ServerIPEndPoint);

            // 非同期で受信を待機
            this.Socket.BeginReceive(this.Buffer, 0, BufferSize, SocketFlags.None, new AsyncCallback(ReceiveCallback), this.Socket);
        }

        // ソケット通信接続の切断
        public void DisConnect()
        {
            this.Socket?.Disconnect(false);
            this.Socket?.Dispose();
        }

        // 非同期受信のコールバックメソッド(別スレッドで実行される)
        private void ReceiveCallback(IAsyncResult asyncResult)
        {
            var socket = asyncResult.AsyncState as Socket;

            var byteSize = -1;
            try
            {
                // 受信を待機
                byteSize = socket.EndReceive(asyncResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            // 受信したデータがある場合、その内容を表示する
            // 再度非同期での受信を開始する
            if (byteSize > 0)
            {
                byte[] buff = new byte[byteSize];
                buff = Encoding.GetEncoding("ASCII").GetBytes(Encoding.ASCII.GetString(this.Buffer, 0, byteSize));

                // 初期化
                bool isStx = false;
                bool isEtx = false;
                int posStart = 0;
                int posEnd = byteSize - 1;

                for (int i = 0; i < buff.Length; i++)
                {
                    if (!isStx && buff[i] == _stx)
                    {
                        // STXがあればその次の位置を開始インデックスにする
                        if (isEtx) isEtx = false;
                        posStart = i + 1;
                        isStx = true;
                    }
                    if (!isEtx && buff[i] == _etx)
                    {
                        // ETXがあればその前の位置を終了インデックスにする
                        posEnd = i - 1;
                        isEtx = true;
                    }
                }

                // STXがあれば溜めていた受信メッセージをクリアする
                if (isStx) _receiveMsg = string.Empty;

                // ETXがなければ終了インデックスを末尾にする
                if (!isEtx) posEnd = byteSize - 1;

                if (posStart < byteSize || posEnd >= 0)
                {
                    // 開始・終了インデックスが範囲内の場合
                    byte[] tmpBuff = new byte[posEnd - posStart + 1];

                    // 開始から終了インデックスの範囲のデータを文字列変換用のバッファにコピーする
                    Array.Copy(buff, posStart, tmpBuff, 0, tmpBuff.Length);

                    // ASCII文字列としてエンコードして溜めていた受信メッセージに連結する(送信する内容に合わせて下さい)
                    _receiveMsg += Encoding.ASCII.GetString(tmpBuff);
                }

                if (isEtx)
                {
                    this.Invoke((Action)(() => { this.txt_Receive.Text = _receiveMsg; }));
                }

                socket.BeginReceive(this.Buffer, 0, this.Buffer.Length, SocketFlags.None, ReceiveCallback, socket);
            }
        }


        /// <summary>
        /// FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DisConnect();
        }

        /// <summary>
        /// 接続ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            this.ServerIPEndPoint = new IPEndPoint(IPAddress.Parse(this.txt_IP.Text), Int32.Parse(this.txt_Port.Text));
            this.Connect();
        }

        /// <summary>
        /// 送信ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Send_Click(object sender, EventArgs e)
        {
            var sendBytes = new UTF8Encoding().GetBytes(this.txt_Cmd.Text);
            this.Socket.Send(sendBytes);
        }
    }
}
