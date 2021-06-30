using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Demo_CoCaro
{
    public partial class Form1 : Form
    {
        CaroChess _CR;
        Graphics _gp;
        LANNetwork LAN;
        Socket _Socket;
        BoardChess _BC;
        int scoreX = 0, scoreO = 0, myPiece = 1; //1 = cờ X, 2 = cờ O
        int gameMode = 0; //1: computer, 2: LAN
        string myIPAdress = "127.0.0.1";
        

        public Form1()
        {
            InitializeComponent();
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btnSearch, "Quét tìm IP Server");
            tt.SetToolTip(txtIPAddress, "Bỏ trống để tạo Server");

            
            
            
            pgbcooldown.Step = cons.COOL_DOWN_STEP;
            pgbcooldown.Maximum = cons.COOL_DOWN_TIME;
            pgbcooldown.Value = 0;
            timercooldown.Interval = cons.COOL_DOWN_INTERVAL;
            
        }

        private void _BC_PlayerMarked1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _BC_EndedGame(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _BC_PlayerMarked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _CR = new CaroChess();
            _gp = panelBoard.CreateGraphics();
            LAN = new LANNetwork();
            myIPAdress = getMyIPv4();
        }

        private void panelBoard_Paint(object sender, PaintEventArgs e)
        {
            _CR._drawBoardChess(_gp);
            
        }

        private void panelBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (_CR._playChess(e.Y, e.X, _gp, myPiece))
            {
                _CR.readyPlay = false;
                string[] data = { "played", e.Y.ToString(), e.X.ToString(), myPiece.ToString() };
                LAN.sentData(_Socket, data);
                checkWinner();

                //máy đánh
                if (gameMode == 1)
                {
                    _CR._Computer(_gp, 2);
                    if (checkWinner())
                        _CR._Computer(_gp, 2);
                }
            }
        }
        
        void EndGame()
        {
            timercooldown.Stop();
            pgbcooldown.Enabled = false;
            MessageBox.Show("Kết thúc");
        }

        private void btnNetwork_Click(object sender, EventArgs e)
        {
            grbGameMode.Enabled = false;
            if (string.IsNullOrEmpty(txtIPAddress.Text))
            {
                Socket skServer = LAN.createServer((int)numPort.Value);
                if (skServer == null)
                {
                    addChatBox("System", "Tạo Server thất bại !");
                    grbGameMode.Enabled = true;
                }
                else
                {
                    addChatBox("System", "Đã tạo Server, đang chờ kết nối ...");
                    txtIPAddress.Text = myIPAdress;
                    timerServer.Enabled = true;
                    txtScoreX.ForeColor = Color.Red;
                    waitConnect(skServer);
                }
            }
            else
            {
                _Socket = LAN.connectServer(txtIPAddress.Text, (int)numPort.Value);
                if (_Socket == null)
                {
                    addChatBox("System", "Kết nối thất bại !");
                    grbGameMode.Enabled = true;
                }
                else
                {
                    myPiece = 2;
                    txtScoreO.ForeColor = Color.Red;
                    receiveData(_Socket);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            addChatBox("System", "Đang tìm Server ...");
            string ipServer = LAN.findServer((int)numPort.Value);
            if (string.IsNullOrEmpty(ipServer))
            {
                addChatBox("System", "Không tìm thấy Server !");
            }
            else
            {
                addChatBox("System", "Tìm thấy 01 Server !");
                txtIPAddress.Text = ipServer;
                //btnNetwork_Click(null, null);
            }
        }

        //chơi với máy
        private void btnComputer_Click(object sender, EventArgs e)
        {
            eventNewGame(false);
            gameMode = 1;
            _CR._Computer(_gp, 2);
            
        }


        //sự kiện nhấn Enter nhập chatbox
        private void txtChatInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                addChatBox("You", txtChatInput.Text);
                string[] data = { "message", txtChatInput.Text };
                LAN.sentData(_Socket, data);
                txtChatInput.Clear();
            }
        }

        //timer gửi IP Server tới các máy khác trong mạng LAN
        private void timerServer_Tick(object sender, EventArgs e)
        {
            bool send = LAN.sendIPServer(myIPAdress, (int)numPort.Value);
            if (!send)
                timerServer.Enabled = false;
        }

        //Server chờ client kết nối
        private void waitConnect(Socket socket)
        {
            Thread waitThread = new Thread(() =>
            {
                socket.Listen(1);
                _Socket = socket.Accept();
                receiveData(_Socket);

                socket.Close();
                timerServer.Enabled = false;
                timercooldown.Start();
                pgbcooldown.Value = 0;
            });
            waitThread.IsBackground = true;
            waitThread.Start();
        }

        //nhận dữ liệu gửi qua socket
        private void receiveData(Socket socket)
        {
            Thread receiveThread = new Thread(() =>
            {
                try
                {
                    addChatBox("System", "Đã kết nối, chiến thôi nào !");
                    gameMode = 2;
                    eventNewGame(false);
                    _CR.readyPlay = true;
                    //vòng lặp để lắng nghe và nhận dữ liệu socket
                    while (true)
                    {
                        byte[] data = new byte[2048];
                        socket.Receive(data);
                        analysisData(LAN.byte2Obj(data));
                    }
                }
                catch
                {
                    Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show(this, "Đối phương đã thoát. Trò chơi kết thúc.", "Endgame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    });
                }
            });
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        //sự kiện game mới
        private void eventNewGame(bool keepScore)
        {
            
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    eventNewGame(keepScore);
                });
                return;
            }
            _CR._newGames();
            panelBoard.Refresh();
            if (!keepScore)
            {
                scoreX = 0; scoreO = 0;
                txtScoreX.Text = scoreX.ToString();
                txtScoreO.Text = scoreO.ToString();
            }
        }

        //lấy địa chỉ IP của máy
        private string getMyIPv4()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        //cập nhật list chatbox
        private void addChatBox(string from, string content)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    addChatBox(from, content);
                });
                return;
            }
            ListViewItem item = new ListViewItem(from);
            item.SubItems.Add(content);
            listView1.Items.Add(item);
            listView1.Items[listView1.Items.Count - 1].EnsureVisible();
        }

        //phân tích dữ liệu nhận được
        private void analysisData(object data)
        {
            string[] str = data as string[];
            switch (str[0])
            {
                case "message":
                    addChatBox("Enemy", str[1]);
                    break;
                case "played":
                    _CR.readyPlay = true;
                    int row = int.Parse(str[1]), column = int.Parse(str[2]), piece = int.Parse(str[3]);
                    _CR._playChess(row, column, _gp, piece);
                    checkWinner();
                    break;
                case "ready":
                    _CR.readyPlay = true;
                    break;
                case "undo":
                    eventUndo();
                    _CR.readyPlay = false;
                    break;
                case "new game":
                    eventNewGame(true);
                    break;

            }
        }

        //xác định player chiến thắng
        private bool checkWinner()
        {
            int check = _CR._checkWins();
            if (check != -1)
            {
                endGames(check);
                string[] data = { "ready" };
                LAN.sentData(_Socket, data);
                eventNewGame(true);
                _CR.readyPlay = false;
                return true;
            }
            else
                return false;
        }

        private void lnkUndo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (gameMode == 1)
            {
                _CR._undoPlay();
                if (_CR._undoPlay())
                    panelBoard.Refresh();
            }
            if (gameMode == 2)
            {
                if (_CR.readyPlay)
                    return;
                if (eventUndo())
                {
                    _CR.readyPlay = true;
                    string[] data = { "undo" };
                    LAN.sentData(_Socket, data);
                }
            }
        }

        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hai bên lần lượt đánh vào các ô cờ. Bên nào có đủ 5 quân cờ liên tiếp theo 1 hàng (ngang, chéo hoặc dọc) " +
                "mà không bị quân cờ đối phương chặn cả 2 đầu là thắng.", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void endGames(int win)
        {
            timercooldown.Stop();

            if (InvokeRequired)
            {
                  Invoke((MethodInvoker)delegate
                  {
                       endGames(win);
                  });
                  return ;
                    
            }
            
            switch (win)
            {
                case 0:
                    MessageBox.Show(this, "Hòa cờ !", "Endgame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    txtScoreX.Text = (scoreX += 1).ToString();
                    MessageBox.Show(this, "Player X thắng !", "Endgame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    txtScoreO.Text = (scoreO += 1).ToString();
                    MessageBox.Show(this, "Player O thắng !", "Endgame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e, bool keepScore)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameMode == 1)
            {
                _CR._undoPlay();
                if (_CR._undoPlay())
                    panelBoard.Refresh();
            }
            if (gameMode == 2)
            {
                if (_CR.readyPlay)
                    return;
                if (eventUndo())
                {
                    _CR.readyPlay = true;
                    string[] data = { "undo" };
                    LAN.sentData(_Socket, data);
                }
            }
        }

        private void pgbcooldown_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventNewGame(true);
            string[] data = { "new game" };
            LAN.sentData(_Socket, data);

        }

        private void timercooldown_Tick(object sender, EventArgs e)
        {
            pgbcooldown.PerformStep();
            if (pgbcooldown.Value >= pgbcooldown.Maximum )
            {
                
                endGames(1);
            }
        }
       



        //sự kiện đánh lại (khi đi nhầm nước ^^)
        private bool eventUndo()
        {
            bool undo = _CR._undoPlay();
            if (undo)
            {
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate
                    {
                        panelBoard.Refresh();
                    });
                else
                    panelBoard.Refresh();
            }
            return undo;
        }
        
       
    }
}
